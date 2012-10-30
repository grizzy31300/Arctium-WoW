﻿/*
 * Copyright (C) 2012 Arctium <http://>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace Framework.Constants
{
    [Flags]
    public enum JAMCCMessage : uint
    {
        AuthChallenge                            = 0x523,
        SuspendComms                             = 0xAE8,
        ResumeComms                              = 0xAE2,
        DropNewConnection                        = 0xCEA,
        ConnectTo                                = 0x8EA,
        Pong                                     = 0xAE0,
        ResetCompressionContext                  = 0xCE0,
        FloodDetected                            = 0xEE0,
    }

    [Flags]
    public enum JAMCMessage : uint
    {
        AuthResponse                             = 0xE20,
        WaitQueueUpdate                          = 0xAC8,
        WaitQueueFinish                          = 0xF17,
        AllAchievementData                       = 0xB64,
        AllAccountCriteria                       = 0xE27,
        RespondInspectAchievements               = 0xE4C,
        AllGuildAchievements                     = 0xF23,
        SetupCurrency                            = 0xAE5,
        SetCurrency                              = 0xE55,
        ResetWeeklyCurrency                      = 0xEBB,
        GuildSendGuildXP                         = 0xE7D,
        GuildSendMaxDailyXP                      = 0xAAF,
        MessageBox                               = 0xB2F,
        WardenData                               = 0xEA8,
        PhaseShiftChange                         = 0xA93,
        InitialSetup                             = 0xA9F,
        DailyQuestsReset                         = 0xF9E,
        SetQuestCompletedBit                     = 0xF73,
        ClearQuestCompletedBit                   = 0xBF7,
        ClearQuestCompletedBits                  = 0xFE7,
        AuraPointsDepleted                       = 0xFAF,
        GuildSendRankChange                      = 0xE04,
        ReforgeResult                            = 0xBA6,
        TradeUpdated                             = 0xAFB,
        TradeStatus                              = 0xF85,
        EnumCharactersResult                     = 0xE28,
        GenerateRandomCharacterNameResult        = 0xA9B,
        GuildCommandResult                       = 0xA59,
        GuildRoster                              = 0xBEA,
        GuildRosterUpdate                        = 0xBE4,
        CurrencyLootRemoved                      = 0xE01,
        GuildMemberRecipes                       = 0xBFF,
        GuildKnownRecipes                        = 0xB7E,
        GuildMembersWithRecipe                   = 0xA04,
        SetupResearchHistory                     = 0xBF1,
        ResearchComplete                         = 0xBF3,
        PetSlotUpdated                           = 0xA1B,
        DifferentInstanceFromParty               = 0xE26,
        UpdateServerPlayerPosition               = 0xE1B,
        CategoryCooldown                         = 0xF25,
        RoleChangedInform                        = 0xA7B,
        GuildRewardList                          = 0xF00,
        RolePollInform                           = 0xE1C,
        SummonRaidMemberValidateFailed           = 0xA4E,
        BattlefieldStatus_NeedConfirmation       = 0xAE3,
        BattlefieldStatus_Active                 = 0xA33,
        BattlefieldStatus_Queued                 = 0xB88,
        BattlefieldStatus_None                   = 0xF39,
        BattlefieldStatus_Failed                 = 0xE88,
        BattlefieldList                          = 0xFE5,
        BattlegroundPlayerPositions              = 0xFA8,
        BattlegroundPlayerJoined                 = 0xAB5,
        BattlegroundPlayerLeft                   = 0xAD3,
        BattlefieldPortDenied                    = 0xE42,
        BFMgrEntryInvite                         = 0xB44,
        BFMgrEntering                            = 0xA0A,
        BFMgrQueueRequestResponse                = 0xE15,
        BFMgrEjectPending                        = 0xB36,
        BFMgrEjected                             = 0xA89,
        BFMgrQueueInvite                         = 0xE6D,
        BFMgrExitRequest                         = 0xE33,
        BFMgrStateChanged                        = 0xEE3,
        BattlegroundInfoThrottled                = 0xBEC,
        QuestCompletionNPCResponse               = 0xA2E,
        RequestCemeteryListResponse              = 0xEE6,
        SetForgeMaster                           = 0xF8F,
        CheckWargameEntry                        = 0xBE6,
        ShowRatings                              = 0xB99,
        DBReply                                  = 0xB8B,
        HotfixNotify                             = 0xEE0,
        HotfixNotifyBlob                         = 0xF86,
        BattlefieldStatus_WaitForGroups          = 0xADA,
        GuildNews                                = 0xBE7,
        GuildNewsDeleted                         = 0xA03,
        RatedBattlefieldInfo                     = 0xA84,
        AverageItemLevelInform                   = 0xEF9,
        GuildCriteriaUpdate                      = 0xA81,
        GuildAchievementEarned                   = 0xA8E,
        GuildAchievementDeleted                  = 0xB46,
        GuildCriteriaDeleted                     = 0xF6B,
        GuildAchievementMembers                  = 0xA62,
        ArenaTeamCommandResult                   = 0xEE2,
        PetAdded                                 = 0xA7F,
        GuildRanks                               = 0xF5D,
        GuildXPEarned                            = 0xEF8,
        NewWorld                                 = 0xF21,
        AbortNewWorld                            = 0xEA0,
        GuildMemberUpdateNote                    = 0xF6C,
        GuildInvite                              = 0xF69,
        NotifyMoney                              = 0xB33,
        QuestGiverQuestComplete                  = 0xB98,
        ItemPurchaseRefundResult                 = 0xB43,
        SetItemPurchaseData                      = 0xE80,
        ItemExpirePurchaseRefund                 = 0xFC6,
        InspectHonorStats                        = 0xFD4,
        GuildPartyState                          = 0xB75,
        PVPLogData                               = 0xB3F,
        RatedBGStats                             = 0xB21,
        WargameRequestSuccessfullySentToOpponent = 0xF48,
        DisplayGameError                         = 0xA63,
        PVPOptionsEnabled                        = 0xA09,
        RatedBattlegroundRating                  = 0xA4B,
        SetMaxWeeklyQuantity                     = 0xAEA,
        GuildReputationWeeklyCap                 = 0xF29,
        GuildReputationReactionChanged           = 0xBDD,
        PetitionAlreadySigned                    = 0xAA8,
        RaidMarkersChanged                       = 0xBAA,
        CommentatorPartyInfo                     = 0xB06,
        StreamingMovies                          = 0xB4C,
        TimeSyncRequest                          = 0xAA9,
        TimeAdjustment                           = 0xF3A,
        StartTimer                               = 0xEBA,
        DisenchantCredit                         = 0xE2D,
        SuspendToken                             = 0xB4F,
        ResumeToken                              = 0xA25,
        CancelSpellVisual                        = 0xF3D,
        PlaySpellVisual                          = 0xAE4,
        CancelOrphanSpellVisual                  = 0xF15,
        PlayOrphanSpellVisual                    = 0xEFF,
        LFGuildPost                              = 0xE5A,
        LFGuildBrowse                            = 0xE9F,
        LFGuildRecruits                          = 0xB1D,
        LFGuildCommandResult                     = 0xEC3,
        LFGuildApplications                      = 0xAF7,
        CancelSpellVisualKit                     = 0xF82,
        PlaySpellVisualKit                       = 0xBFD,
        AddItemPassive                           = 0xF6A,
        RemoveItemPassive                        = 0xA19,
        SendItemPassives                         = 0xF80,
        WorldServerInfo                          = 0xA6D,
        WeeklySpellUsage                         = 0xB6D,
        UpdateWeeklySpellUsage                   = 0xE92,
        LastWeeklyReset                          = 0xB2D,
        GuildChallengeUpdate                     = 0xEDC,
        GuildChallengeCompleted                  = 0xA96,
        LFGuildApplicantListChanged              = 0xE67,
        LFGuildApplicationsListChanged           = 0xA1F,
        InspectRatedBGStats                      = 0xB42,
        MoveSetActiveMover                       = 0xA67,
        RuneRegenDebug                           = 0xE2E,
        MoveUpdateRunSpeed                       = 0xE18,
        MoveUpdateRunBackSpeed                   = 0xF4F,
        MoveUpdateWalkSpeed                      = 0xB28,
        MoveUpdateSwimSpeed                      = 0xAAE,
        MoveUpdateSwimBackSpeed                  = 0xB24,
        MoveUpdateFlightSpeed                    = 0xED4,
        MoveUpdateFlightBackSpeed                = 0xB2A,
        MoveUpdateTurnRate                       = 0xF96,
        MoveUpdatePitchRate                      = 0xE6C,
        MoveUpdateCollisionHeight                = 0xE3E,
        MoveUpdate                               = 0xA6F,
        MoveUpdateTeleport                       = 0xA80,
        MoveUpdateKnockBack                      = 0xAF1,
        MoveUpdateApplyMovementForce             = 0xA88,
        MoveUpdateRemoveMovementForce            = 0xF34,
        MoveSplineSetRunSpeed                    = 0xA9C,
        MoveSplineSetRunBackSpeed                = 0xA10,
        MoveSplineSetSwimSpeed                   = 0xFAD,
        MoveSplineSetSwimBackSpeed               = 0xFC3,
        MoveSplineSetFlightSpeed                 = 0xE5D,
        MoveSplineSetFlightBackSpeed             = 0xE8E,
        MoveSplineSetWalkBackSpeed               = 0xB8F,
        MoveSplineSetTurnRate                    = 0xA44,
        MoveSplineSetPitchRate                   = 0xE82,
        MoveSetRunSpeed                          = 0xE09,
        MoveSetRunBackSpeed                      = 0xA24,
        MoveSetSwimSpeed                         = 0xE46,
        MoveSetSwimBackSpeed                     = 0xE64,
        MoveSetFlightSpeed                       = 0xA66,
        MoveSetFlightBackSpeed                   = 0xFDD,
        MoveSetWalkSpeed                         = 0xA23,
        MoveSetTurnRate                          = 0xE44,
        MoveSetPitchRate                         = 0xF65,
        MoveRoot                                 = 0xF61,
        MoveUnroot                               = 0xB11,
        MoveSetWaterWalk                         = 0xE66,
        MoveSetLandWalk                          = 0xB1C,
        MoveSetFeatherFall                       = 0xAFC,
        MoveSetNormalFall                        = 0xF42,
        MoveSetHovering                          = 0xE0E,
        MoveUnsetHovering                        = 0xF75,
        MoveKnockBack                            = 0xA79,
        MoveTeleport                             = 0xA95,
        MoveSetCanFly                            = 0xB90,
        MoveUnsetCanFly                          = 0xBC9,
        MoveSetCanTurnWhileFalling               = 0xA31,
        MoveUnsetCanTurnWhileFalling             = 0xAED,
        MoveEnableTransitionBetweenSwimAndFly    = 0xBA7,
        MoveDisableTransitionBetweenSwimAndFly   = 0xA28,
        MoveDisableGravity                       = 0xE21,
        MoveEnableGravity                        = 0xBF2,
        MoveDisableCollision                     = 0xA16,
        MoveEnableCollision                      = 0xF22,
        MoveSetCollisionHeight                   = 0xE40,
        MoveSetVehicleRecID                      = 0xAA7,
        MoveApplyMovementForce                   = 0xB92,
        MoveRemoveMovementForce                  = 0xA48,
        MoveSetCompoundState                     = 0xA98,
        MoveSkipTime                             = 0xA52,
        MoveSplineRoot                           = 0xFAA,
        MoveSplineUnroot                         = 0xAAC,
        MoveSplineDisableGravity                 = 0xE2B,
        MoveSplineEnableGravity                  = 0xA56,
        MoveSplineDisableCollision               = 0xE81,
        MoveSplineEnableCollision                = 0xE12,
        MoveSplineSetFeatherFall                 = 0xBD5,
        MoveSplineSetNormalFall                  = 0xE45,
        MoveSplineSetHover                       = 0xA90,
        MoveSplineUnsetHover                     = 0xBC0,
        MoveSplineSetWaterWalk                   = 0xB69,
        MoveSplineSetLandWalk                    = 0xA49,
        MoveSplineStartSwim                      = 0xEEE,
        MoveSplineStopSwim                       = 0xE0B,
        MoveSplineSetRunMode                     = 0xA9A,
        MoveSplineSetWalkMode                    = 0xA2C,
        MoveSplineSetFlying                      = 0xE95,
        MoveSplineUnsetFlying                    = 0xEB1,
        VendorInventory                          = 0xFDE,
        RestrictedAccountWarning                 = 0xB66,
        GuildReset                               = 0xE53,
        SetPlayHoverAnim                         = 0xE84,
        GuildMoveStarting                        = 0xA76,
        GuildMoved                               = 0xB40,
        ClearBossEmotes                          = 0xB87,
        LoadCUFProfiles                          = 0xFC9,
        SuppressNPCGreetings                     = 0xA2A,
        PartyInvite                              = 0xF68,
        DumpRideTicketsResponse                  = 0xBF9,
        FeatureSystemStatus                      = 0xB5B,
        GuildNameChanged                         = 0xED1,
        RequestPVPRewardsResponse                = 0xE30,
        SpellInterruptLog                        = 0xF8A,
        GameObjectActivateAnimKit                = 0xAB7,
        MapObjEvents                             = 0xBF6,
        MissileCancel                            = 0xFD1,
        VoidStorageFailed                        = 0xF40,
        VoidStorageContents                      = 0xE85,
        VoidStorageTransferChanges               = 0xBD9,
        VoidTransferResult                       = 0xE02,
        VoidItemSwapResponse                     = 0xFB1,
        XPGainAborted                            = 0xB76,
        GuildFlaggedForRename                    = 0xACD,
        GuildChangeNameResult                    = 0xF07,
        PrintNotification                        = 0xE0F,
        ClearCooldowns                           = 0xEB2,
        FailedPlayerCondition                    = 0xA46,
        CustomLoadScreen                         = 0xA5B,
        TransferPending                          = 0xF79,
        GuildBankQueryResults                    = 0xF2C,
        GuildBankLogQueryResults                 = 0xF7F,
        GuildBankRemainingWithdrawMoney          = 0xE78,
        GuildPermissionsQueryResults             = 0xFE4,
        GuildEventLogQueryResults                = 0xEB6,
        GuildBankTextQueryResult                 = 0xF1C,
        GuildMemberDailyReset                    = 0xA0C,
        GameEventDebugLog                        = 0xBDC,
        ServerPerf                               = 0xE8D,
        AreaTriggerMovementUpdate                = 0xFB8,
        AdjustSplineDuration                     = 0xF0A,
        LearnTalentFailed                        = 0xA77,
        LFGJoinResult                            = 0xEA1,
        LFGQueueStatus                           = 0xE36,
        LFGRoleCheckUpdate                       = 0xF4E,
        LFGUpdateStatusNone                      = 0xFA0,
        LFGUpdateStatus                          = 0xEEB,
        LFGProposalUpdate                        = 0xAEE,
        LFGSearchResults                         = 0xF92,
        ServerInfoResponse                       = 0xA5C,
        LootContents                             = 0xBFC,
        ShowNeutralPlayerFactionSelectUI         = 0xAC0,
        NeutralPlayerFactionSelectResult         = 0xF06,
        ChatIgnoredAccountMuted                  = 0xF02,
        SORStartExperienceIncomplete             = 0xAB4,
        AccountInfoResponse                      = 0xF05,
        SetDFFastLaunchResult                    = 0xE54,
        SupercededSpells                         = 0xA6B,
        LearnedSpells                            = 0xBF8,
        UnlearnedSpells                          = 0xBB0,
        PetLearnedSpells                         = 0xE63,
        PetUnlearnedSpells                       = 0xEBE,
        UpdateActionButtons                      = 0xE34,
        DontAutoPushSpellsToActionBar            = 0xBD1,
        LFGSlotInvalid                           = 0xA40,
        UpdateDungeonEncounterForLoot            = 0xA53,
        SceneObjectEvent                         = 0xB97,
        SendAllItemDurability                    = 0xE76,
        BattlePetUpdates                         = 0xF1E,
        BattlePetTrapLevel                       = 0xAE1,
        PetBattleSlotUpdates                     = 0xF16,
        BattlePetJournalLockAcquired             = 0xE1E,
        BattlePetJournalLockDenied               = 0xFE6,
        BattlePetJournal                         = 0xB2E,
        BattlePetDeleted                         = 0xF49,
        BattlePetsHealed                         = 0xADC,
        BattlePetLicenseChanged                  = 0xFC4,
        PartyUpdate                              = 0xB3E,
        ReadyCheckStarted                        = 0xF28,
        ReadyCheckResponse                       = 0xBDE,
        ReadyCheckCompleted                      = 0xA13,
        PetBattleRequestFailed                   = 0xB04,
        PetBattlePVPChallenge                    = 0xE65,
        PetBattleFinalizeLocation                = 0xB81,
        PetBattleFullUpdate                      = 0xB08,
        PetBattleFirstRound                      = 0xF31,
        PetBattleRoundResult                     = 0xB0A,
        PetBattleReplacementsMade                = 0xE89,
        PetBattleFinalRound                      = 0xFA9,
        PetBattleFinished                        = 0xBC8,
        PetBattleChatRestricted                  = 0xB68,
        PetBattleMaxGameLengthWarning            = 0xB13,
        StartElapsedTimer                        = 0xBA1,
        StopElapsedTimer                         = 0xA91,
        StartElapsedTimers                       = 0xFA2,
        ChallengeModeComplete                    = 0xA3E,
        ChallegeModeRewards                      = 0xEBC,
        IncreaseCastTimeForSpell                 = 0xA87,
        ClearAllSpellCharges                     = 0xAE7,
        ChallengeModeAllMapStats                 = 0xB01,
        ChallengeModeMapStatsUpdate              = 0xA06,
        ChallengeModeRequestLeadersResult        = 0xFA6,
        ChallengeModeNewPlayerRecord             = 0xF7B,
        RespecWipeConfirm                        = 0xE83,
        IsQuestCompleteResponse                  = 0xE62,
        GMCharacterRestoreResponse               = 0xAE2,
        LootResponse                             = 0xA75,
        LootRemoved                              = 0xE6A,
        LootUpdated                              = 0xBF0,
        CoinRemoved                              = 0xBB1,
        AELootTargets                            = 0xF59,
        AELootTargetAck                          = 0xEDA,
        LootReleaseAll                           = 0xB35,
        LootRelease                              = 0xB8A,
        LootMoneyNotify                          = 0xF18,
        StartLootRoll                            = 0xEF4,
        LootRoll                                 = 0xB59,
        MasterLootCandidateList                  = 0xA5A,
        LootItemList                             = 0xA08,
        LootRollsComplete                        = 0xF09,
        LootAllPassed                            = 0xE49,
        LootRollWon                              = 0xF32,
        SetItemChallengeModeData                 = 0xEA9,
        ClearItemChallengeModeData               = 0xAE9,
        ItemPushResult                           = 0xF64,
        DisplayToast                             = 0xAAD,
        AreaTriggerDebugSweep                    = 0xA7D,
        AreaTriggerDebugPlayerInside             = 0xFC0,
        ResetAreaTrigger                         = 0xB9B,
        SetPetSpecialization                     = 0xE17,
        BlackMarketOpenResult                    = 0xAB1,
        BlackMarketRequestItemsResult            = 0xB50,
        BlackMarketBidOnItemResult               = 0xB6A,
        BlackMarketOutbid                        = 0xB14,
        BlackMarketWon                           = 0xE2F,
        ScenarioState                            = 0xB70,
        ScenarioProgressUpdate                   = 0xF9A,
        GroupNewLeader                           = 0xA1A,
        SendRaidTargetUpdateAll                  = 0xB9E,
        SendRaidTargetUpdateSingle               = 0xF13,
        RandomRoll                               = 0xEDB,
        InspectResult                            = 0xE3D,
        ScenarioPOIs                             = 0xE1D,
        InstanceInfo                             = 0xF3B,
        ConsoleWrite                             = 0xA4A,
        AccountCriteriaUpdate                    = 0xE9C,
        PlayScene                                = 0xE38,
        CancelScene                              = 0xE08,
        BattlePetError                           = 0xBA0,
        PetBattleQueueProposeMatch               = 0xE58,
        PetBattleQueueStatus                     = 0xB51,
        MailCommandResult                        = 0xA4F,
        AddBattlenetFriendResponse               = 0xFCA,
        ItemUpgradeResult                        = 0xAC2,
        MoveCharacterCheatSuccess                = 0xAA1,
        MoveCharacterCheatFailure                = 0xE14,
        AchievementEarned                        = 0xAF4,
        AreaShareInfoResponse                    = 0xEC5,
        LFGTeleportDenied                        = 0xE24,
        AreaShareMappingsResponse                = 0xAFE,
        BonusRollEmpty                           = 0xE32,
        UpdateExpansionLevel                     = 0xF14,
        ControlUpdate                            = 0xEFB,
        ArenaPrepOpponentSpecializations         = 0xE4B,
        GMTicketGetTicketResponse                = 0xBBD,
        NukeAllObjectsDueToRealmBundlePort       = 0xB84,
        GMNotifyAreaChange                       = 0xA60,
        ForceObjectRelink                        = 0xEDE,
        DisplayPromotion                         = 0xEB4,
        ClearedPromotion                         = 0xA0E,
        ServerFirstAchievements                  = 0xB58,
        CorpseLocation                           = 0xAA2,
        CanDuelResult                            = 0xBB7,
        ImmigrantHostSearchLog                   = 0xFCC,
        SendKnownSpells                          = 0xEA3,
        SendSpellHistory                         = 0xF55,
        SendSpellCharges                         = 0xAE8,
        SendUnlearnSpells                        = 0xFD7,
        RefreshComponent                         = 0xAD0
    }

    [Flags]
    public enum LegacyMessage : uint
    {
        SetAddonInfoRequest                      = 0x9C6,
        UpdateClientCacheVersion                 = 0x956,
        RealmSplitStateResponse                  = 0xCCD,
        ResponseCharacterCreate                  = 0xC15,
        ResponseCharacterDelete                  = 0x936,
        MessageOfTheDay                          = 0x952,
        AccountDataInitialized                   = 0xC4B,
        UpdateObject                             = 0x8F7,
        TutorialFlags                            = 0x8AE,
        UITime                                   = 0,
        SendKnownSpells                          = 0xEA3,
        LogoutComplete                           = 0x8DA,
        MessageChat                              = 0xC9F,
        NameCache                                = 0xCF9,
        RealmCache                               = 0xC26,
    }

    [Flags]
    public enum ClientMessage : int
    {
        #region Authentication
        TransferInitiate                         = 0x4F57,
        AuthSession                              = 0x08A,
        #endregion

        #region CharacterList
        ReadyForAccountDataTimes                 = 0x9A2,
        EnumCharacters                           = 0x576,
        RequestCharCreate                        = 0x332,
        RequestCharDelete                        = 0x944,
        RequestRandomCharacterName               = 0x044,
        SetRealmSplitState                       = 0x820,
        #endregion

        #region WorldEnter
        PlayerLogin                              = 0x203,
        #endregion

        #region Logout
        Logout                                   = 0xCE0,
        #endregion

        #region Disconnect
        LogDisconnect                            = 0x48F,
        #endregion

        #region Permanent
        Ping                                     = 0x4EB,
        #endregion

        #region Uncategorized
        SuspendCommsAck                          = -1,
        AuthContinuedSession                     = -1,
        EnableNagle                              = -1,
        SuspendTokenResponse                     = -1,
        RequestUITime                            = -1,
        ChatMessageSay                           = 0x61A,
        NameCache                                = 0x884,
        RealmCache                               = 0x81B,
        #endregion
    }

    [Flags]
    public enum Message : uint
    {
        TransferInitiate                         = 0x4F57,
    }
}
