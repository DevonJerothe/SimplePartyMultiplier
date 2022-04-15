using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace SimplePartyMultiplier
{
    public class SubModule : MBSubModuleBase
    {
        private static bool _patched; 
        
        public override void OnInitialState(){}

        public override void OnGameInitializationFinished(Game game)
        {
            base.OnGameInitializationFinished(game);
            if (game.GameType is not Campaign || _patched)
            {
                return;
            }

            try
            {
                new Harmony("SimplePartyMultiplier").PatchAll();
                _patched = true;
            }
            catch (Exception)
            {
                InformationManager.ShowInquiry(new InquiryData("SPM Failed",
                        "Failed to load Simple Party Multiplier",
                        true,
                        false,
                        "OK",
                        null, null, null)
                );
            }
        }
    }
}