using System.Configuration;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v1;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Settings.Base.Global;

namespace SimplePartyMultiplier
{
    public class Settings : AttributeGlobalSettings<Settings>
    {
        public override string Id => "SimplePartyMultiplier";
        public override string FolderName => "PartyMultipliers";
        public override string DisplayName => "Party Multipliers";
        public override string FormatType => "json";
        
        [SettingProperty("Player Party Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "Multiplier for player party", Order = 1)]
        [SettingPropertyGroup("Player Multipliers", GroupOrder = 1)]
        public float PlayerPartyMultiplier { get; set; } = 1f;
        
        [SettingProperty("Player Clan Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "Multiplier for all player clan members", Order = 2)]
        [SettingPropertyGroup("Player Multipliers", GroupOrder = 1)]
        public float PlayerClanMultiplier { get; set; } = 1f;

        [SettingProperty("Player Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clan parties in the player created kingdom", Order = 1)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float PlayerKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Battania Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the kingdom of Battania", Order = 2)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float BattaniaKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Vlandia Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the kingdom of Vlandia", Order = 3)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float VlandiaKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Sturgia Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the kingdom of Sturgia", Order = 4)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float SturgiaKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Aserai Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the kingdom of Aserai", Order = 5)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float AseraiKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Khuzait Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the kingdom of Khuzait", Order = 6)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float KhuzaitKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Northern Empire Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the Northern Empire", Order = 7)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float NorthernKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Western Empire Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the Eastern Empire", Order = 8)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float WesternKingdomMultiplier { get; set; } = 1f;
        
        [SettingProperty("Southern Empire Kingdom Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All clans from the Southern Empire", Order = 9)]
        [SettingPropertyGroup("Kingdom Multipliers", GroupOrder = 2)]
        public float SouthernKingdomMultiplier { get; set; } = 1f;

        [SettingProperty("Mercenary Clan Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All mercenary clan parties will be multiplied by this amount", Order = 1)]
        [SettingPropertyGroup("Minor Faction Multipliers", GroupOrder = 3)]
        public float MercFactionMultiplier { get; set; } = 1f;
        
        [SettingProperty("OutLaw Clan Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All outlaw clan parties will be multiplied by this amount", Order = 2)]
        [SettingPropertyGroup("Minor Faction Multipliers", GroupOrder = 3)]
        public float OutLawFactionMultiplier { get; set; } = 1f;
        
        [SettingProperty("Looters Party Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All looter parties will be multiplied by this amount", Order = 1)]
        [SettingPropertyGroup("Bandit Multipliers", GroupOrder = 4)]
        public float LooterMultiplier { get; set; } = 1f;
        
        [SettingProperty("All Other Bandit Party Multiplier", 1f, 100f, RequireRestart = false,
            HintText = "All bandit parties will be multiplied by this amount", Order = 1)]
        [SettingPropertyGroup("Bandit Multipliers", GroupOrder = 4)]
        public float BanditMultiplier { get; set; } = 1f;
    }
}


