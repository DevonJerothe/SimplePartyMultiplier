using TaleWorlds.CampaignSystem;

namespace SimplePartyMultiplier
{

    public static class PartyHelper
    {
        public enum Kingdoms
        {
            Battania,
            Vlandia,
            Khuzait,
            Strugia,
            Aserai,
            NorthernEmpire,
            SouthernEmpire,
            WesternEmpire,
            PlayerKingdom
        }
        
        // Static helpers
        public static bool IsLooter(string stringId)
        {
            return stringId.ToLower().Contains("looter");
        }

        public static bool IsMerc(string stringId)
        {
            return stringId.ToLower().Contains("mercenary");
        }

        public static bool IsOutlaw(string stringId)
        {
            return stringId.ToLower().Contains("outlaw");
        }

        public static bool isKingdomOf(Kingdom kingdom, Kingdoms kingdomOf)
        {
            var result = false;
            switch (kingdomOf)
            {
                case Kingdoms.Battania:
                {
                    result = kingdom.StringId.ToLower().Contains("battania");
                    break;
                }
                case Kingdoms.Vlandia:
                {
                    result = kingdom.StringId.ToLower().Contains("vlandia");
                    break;
                }
                case Kingdoms.Aserai:
                {
                    result = kingdom.StringId.ToLower().Contains("aserai");
                    break;
                }
                case Kingdoms.Khuzait:
                {
                    result = kingdom.StringId.ToLower().Contains("khuzait");
                    break;
                }
                case Kingdoms.Strugia:
                {
                    result = kingdom.StringId.ToLower().Contains("strugia");
                    break;
                }
                case Kingdoms.NorthernEmpire:
                {
                    if (kingdom.StringId.ToLower().Contains("empire"))
                    {
                        result = kingdom.InformalName.ToString().ToLower().Contains("northern");
                    }
                    break;
                }
                case Kingdoms.WesternEmpire:
                {
                    if (kingdom.StringId.ToLower().Contains("empire"))
                    {
                        result = kingdom.InformalName.ToString().ToLower().Contains("western");
                    }
                    break;
                }
                case Kingdoms.SouthernEmpire:
                {
                    if (kingdom.StringId.ToLower().Contains("empire"))
                    {
                        result = kingdom.InformalName.ToString().ToLower().Contains("southern");
                    }
                    break;
                }
                case Kingdoms.PlayerKingdom:
                {
                    result = kingdom.Leader == Hero.MainHero;
                    break;
                }
            }
            return result;
        }
        
        public static float getFloatFor(Kingdoms kingdom, Settings settings)
        {
            var result = 1f;
            switch (kingdom)
            {
                case Kingdoms.Battania:
                {
                    result = settings.BattaniaKingdomMultiplier;
                    break;
                }
                case Kingdoms.Vlandia:
                {
                    result = settings.VlandiaKingdomMultiplier;
                    break;
                }
                case Kingdoms.Aserai:
                {
                    result = settings.AseraiKingdomMultiplier;
                    break;
                }
                case Kingdoms.Khuzait:
                {
                    result = settings.KhuzaitKingdomMultiplier;
                    break;
                }
                case Kingdoms.Strugia:
                {
                    result = settings.SturgiaKingdomMultiplier;
                    break;
                }
                case Kingdoms.NorthernEmpire:
                {
                    result = settings.NorthernKingdomMultiplier;
                    break;
                }
                case Kingdoms.WesternEmpire:
                {
                    result = settings.WesternKingdomMultiplier;
                    break;
                }
                case Kingdoms.SouthernEmpire:
                {
                    result = settings.SouthernKingdomMultiplier;
                    break;
                }
                case Kingdoms.PlayerKingdom:
                {
                    result = settings.PlayerKingdomMultiplier;
                    break;
                }
            }
            return result;
        }
    }

}