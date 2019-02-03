﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterHunterDecoTracker {
    class FileFormat {
        public const string fileContent =   "BlastcoatJewel3;BlastFunctionality;1;1\n" +
                                            "BraceJewel3;FlinchFree;3;16\n" +
                                            "DragonsealJewel3;EldersealBoost;1;1\n" +
                                            "EarplugJewel3;Earplugs;5;13\n" +
                                            "ForceshotJewel3;NormalShots;1;0\n" +
                                            "HandicraftJewel3;Handicraft;5;0\n" +
                                            "ParacoatJewel3;ParalysisFunctionality;1;0\n" +
                                            "PierceJewel3;PiercingShots;1;0\n" +
                                            "PoisoncoatJewel3;PoisonFunctionality;1;12\n" +
                                            "ReleaseJewel3;FreeElem/AmmoUp;3;0\n" +
                                            "SleepcoatJewel3;SleepFunctionality;1;3\n" +
                                            "SpreadJewel3;Spread/PowerShots;1;0\n" +
                                            "ChallengerJewel2;Agitator;5;1\n" +
                                            "ChargerJewel2;Focus;3;1\n" +
                                            "CriticalJewel2;CriticalBoost;3;0\n" +
                                            "DestroyerJewel2;Partbreaker;3;4\n" +
                                            "DrawJewel2;CriticalDraw;3;1\n" +
                                            "ElementlessJewel2;Non-ElementalBoost;1;12\n" +
                                            "EnhancerJewel2;PowerProlonger;3;2\n" +
                                            "EvasionJewel2;EvadeWindow;5;2\n" +
                                            "FlawlessJewel2;PeakPerformance;3;2\n" +
                                            "FlightJewel2;Airborne;1;8\n" +
                                            "FootingJewel2;TremorResistance;3;12\n" +
                                            "FurorJewel2;Resentment;5;0\n" +
                                            "JumpingJewel2;EvadeExtender;3;5\n" +
                                            "KOJewel2;Slugger;3;4\n" +
                                            "MagazineJewel2;CapacityBoost;1;0\n" +
                                            "MightyJewel2;MaximumMight;3;1\n" +
                                            "MightyBowJewel2;BowChargePlus;1;0\n" +
                                            "Mind'sEyeJewel2;MindEye/Ballistic;1;0\n" +
                                            "PhysiqueJewel2;Constitution;5;7\n" +
                                            "PotentialJewel2;Heroics;5;1\n" +
                                            "RefreshJewel2;StaminaSurge;3;0\n" +
                                            "SharpJewel2;ProtectivePolish;1;3\n" +
                                            "ShieldJewel2;GuardUp;1;1\n" +
                                            "SliderJewel2;AffinitySliding;1;8\n" +
                                            "SprinterJewel2;MarathonRunner;3;0\n" +
                                            "TenderizerJewel2;WeaknessExploit;3;1\n" +
                                            "ThrottleJewel2;LatentPower;5;5\n" +
                                            "WindResistJewel2;Windproof;5;8\n" +
                                            "AntiblastJewel1;BlastResistance;3;10\n" +
                                            "AntidoteJewel1;PoisonResistance;3;17\n" +
                                            "AntiparaJewel1;ParalysisResistance;3;15\n" +
                                            "ArtilleryJewel1;Artillery;3;0\n" +
                                            "AttackJewel1;AttackBoost;7;2\n" +
                                            "BlastJewel1;BlastAttack;3;0\n" +
                                            "BlazeJewel1;FireAttack;5;10\n" +
                                            "BoltJewel1;ThunderAttack;5;8\n" +
                                            "BomberJewel1;Bombardier;3;6\n" +
                                            "BotanyJewel1;Botanist;4;17\n" +
                                            "CrisisJewel1;Resuscitate;1;21\n" +
                                            "DefLockJewel1;IronSkin;3;16\n" +
                                            "DefenseJewel1;DefenseBoost;7;6\n" +
                                            "DragonJewel1;DragonAttack;5;6\n" +
                                            "DragonResJewel1;DragonResistance;3;13\n" +
                                            "DrainJewel1;StaminaThief;3;9\n" +
                                            "EnduringJewel1;ItemProlonger;3;9\n" +
                                            "ExpertJewel1;CriticalEye;7;4\n" +
                                            "FireResJewel1;FireResistance;3;14\n" +
                                            "FortitudeJewel1;Fortify;1;11\n" +
                                            "FriendshipJewel1;Wide-Range;5;10\n" +
                                            "FrostJewel1;IceAttack;5;11\n" +
                                            "FungiformJewel1;Mushroomancer;3;2\n" +
                                            "GeologyJewel1;Geologist;3;13\n" +
                                            "GobblerJewel1;SpeedEating;3;15\n" +
                                            "GrinderJewel1;SpeedSharpening;3;11\n" +
                                            "HeavyArtilleryJewel1;HeavyArtillery;2;17\n" +
                                            "HungerlessJewel1;HungerResistance;3;7\n" +
                                            "IceResJewel1;IceResistance;3;7\n" +
                                            "IntimidatorJewel1;Intimidator;3;3\n" +
                                            "IronwallJewel1;Guard;5;1\n" +
                                            "MaintenanceJewel1;ToolSpecialist;3;1\n" +
                                            "MedicineJewel1;RecoveryUp;3;11\n" +
                                            "MeowsterJewel1;PalicoRally;5;20\n" +
                                            "MiasmaJewel1;EffluviaResistance;3;16\n" +
                                            "MirewalkerJewel1;AquaticExpert;3;1\n" +
                                            "ParalyzerJewel1;ParalysisAttack;3;2\n" +
                                            "PepJewel1;SleepResistance;3;6\n" +
                                            "ProtectionJewel1;DivineBlessing;3;4\n" +
                                            "RecoveryJewel1;RecoverySpeed;3;3\n" +
                                            "ResistorJewel1;BlightResistance;3;15\n" +
                                            "SatiatedJewel1;FreeMeal;1;5\n" +
                                            "ScentJewel1;Scenthound;1;7\n" +
                                            "SheathJewel1;QuickSheath;3;3\n" +
                                            "SleepJewel1;SleepAttack;3;2\n" +
                                            "SmokeJewel1;SporepuffExpert;3;7\n" +
                                            "SonorousJewel1;HornMaestro;1;4\n" +
                                            "SpecimenJewel1;Entomologist;3;8\n" +
                                            "SteadfastJewel1;StunResistance;3;17\n" +
                                            "StonethrowerJewel1;SlingerCapacity;3;10\n" +
                                            "StreamJewel1;WaterAttack;5;13\n" +
                                            "SutureJewel1;BleedingResistance;3;9\n" +
                                            "ThunderResJewel1;ThunderResistance;3;14\n" +
                                            "TipToeJewel1;Stealth;3;19\n" +
                                            "TrueshotJewel1;SpecialAmmoBoost;2;0\n" +
                                            "VenomJewel1;PoisonAttack;3;9\n" +
                                            "VitalityJewel1;HealthBoost;3;14\n" +
                                            "WaterResJewel1;WaterResistance;3;13\n";
    }
}