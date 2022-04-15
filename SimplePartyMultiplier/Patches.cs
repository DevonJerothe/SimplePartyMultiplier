using System;
using HarmonyLib;
using JetBrains.Annotations;
using MCM.Abstractions.Settings.Base.Global;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Party;

namespace SimplePartyMultiplier
{
    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "GetPartyMemberSizeLimit")]
    public static class PartyPatches
    {
        [UsedImplicitly]
        [HarmonyPostfix]
        public static void GetPartyMemberSizeLimit(
            ref PartyBase party,
            ref bool includeDescriptions,
            ref ExplainedNumber __result
            )
        {
            if (!party.IsMobile)
            {
                return;
            }
            
            var currentSettings = GlobalSettings<Settings>.Instance;
            if (currentSettings == null) return;
           
            var increaseBy = party.MobileParty.IsGarrison 
                ? CalculateNewGarrisonPartySize(party.MobileParty, currentSettings)
                : CalculateNewPartySize(party.MobileParty, currentSettings);
            __result.AddFactor(increaseBy - 1f, null);
        }
        
        private static float CalculateNewPartySize(MobileParty party, Settings settings)
        {
            var player = Hero.MainHero;
            
            if (party.Owner is {IsHumanPlayerCharacter: true})
            {
                return settings.PlayerPartyMultiplier;
            }

            if (party.ActualClan != null)
            {
                if (party.ActualClan == player.Clan)
                {
                    return settings.PlayerClanMultiplier;
                }
            }

            if (party.ActualClan?.Kingdom?.IsMapFaction ?? false)
            {
                foreach (PartyHelper.Kingdoms kingdomOf in Enum.GetValues(typeof(PartyHelper.Kingdoms)))
                {
                    if (PartyHelper.isKingdomOf(party.ActualClan.Kingdom, kingdomOf))
                    {
                        return PartyHelper.getFloatFor(kingdomOf, settings);
                    }
                }
            }
            
            if (party.IsBandit)
            {
                return PartyHelper.IsLooter(party.StringId) 
                    ? settings.LooterMultiplier 
                    : settings.BanditMultiplier;
            }

            if (PartyHelper.IsMerc(party.StringId))
            {
                return settings.MercFactionMultiplier;
            }
            return PartyHelper.IsOutlaw(party.StringId) ? settings.OutLawFactionMultiplier : 1f;
        }

        private static float CalculateNewGarrisonPartySize(MobileParty party, Settings settings)
        {
            return 1f;
        }
    }
}