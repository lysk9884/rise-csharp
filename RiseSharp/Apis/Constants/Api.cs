using System;
namespace RiseSharp.Apis.Constants
{
    public static class Api
    {
        #region NEW

        public const string Enable = "enable";
        public const string Disable = "disable";

        public const string PostGeneratePublicKey = "/api/accounts/generatePublicKey";
        public const string GetDappsCategories = "api/dapps/categories";
        public const string ToggleForging = "/api/delegates/forging/{0}"; //disable | enable
        public const string GetForgingStatus = "/api/delegates/forging/status";
        public const string GetNextForgers = "api/delegates/getNextForgers";
        public const string GetTransactionsCount = "/api/transactions/count";

        #endregion

        public const string GetPeers = "/api/peers";
		public const string GetPeer = "/api/peers/get";
		public const string Version = "/api/peers/version";

		public const string GetDelegates = "/api/delegates";
		public const string GetDelegate = "/api/delegates/get";
		public const string GetDelegateVoters = "/api/delegates/voters";
		public const string GetDelegateFee = "/api/delegates/fee";
		public const string GetDelegateForgeAccount = "/api/delegates/forging/getForgedByAccount";
		public const string PutDelegateAdd = "/api/delegates";

		public const string GetBlocks = "/api/blocks";
		public const string GetBlocksBlock = "/api/blocks/get";
		public const string GetBlocksHeight = "/api/blocks/getHeight";
		public const string GetBlocksFee = "/api/blocks/getFee";
		public const string GetFeeSchedule = "/api/blocks/getFees";
		public const string GetBlocksNethash = "/api/blocks/getNethash";
		public const string GetBlocksMilestone = "/api/blocks/getMilestone";
		public const string GetBlocksReward = "/api/blocks/getReward";
		public const string GetBlocksSupply = "/api/blocks/getSupply";
		public const string GetBlocksStatus = "/api/blocks/getStatus";

		public const string GetAccount = "/api/accounts";
		public const string GetAccountDelegates = "/api/accounts/delegates";
		public const string GetAccountDelegatesFee = "/api/accounts/delegates/fee";
		public const string GetAccountPublickey = "/api/accounts/getPublicKey";
		public const string GetAccountBalance = "/api/accounts/getBalance";
		public const string PostAccountOpen = "/api/accounts/open";
		public const string PutAccountDelegateAdd = "/api/accounts/delegates";

		public const string GetSignatureFee = "/api/signatures/fee";
		public const string PutSignatureAdd = "/api/signatures";

		public const string GetTransactions = "/api/transactions";
		public const string GetTransaction = "/api/transactions/get";
		public const string GetUnconfirmedTransaction = "/api/transactions/unconfirmed/get";
		public const string GetUnconfirmedTransactions = "/api/transactions/unconfirmed";
		public const string PutAddTransaction = "/api/transactions";

		public const string GetLoaderStatus = "/api/loader/status";
		public const string GetLoaderSyncStatus = "/api/loader/status/sync";

		public const string GetMultiSignaturesPending = "/api/multisignatures/pending";
		public const string GetMultiSignaturesAccounts = "/api/multisignatures/accounts";
		public const string PostMultiSignaturesSign = "/api/multisignatures/sign";
		public const string PutMultiSignaturesAdd = "/api/multisignatures/";

		public const string PeerGetList = "/peer/list";
		public const string PeerGetBlocks = "/peer/blocks";
		public const string PeerGetBlocksCommon = "/peer/blocks/common";
		public const string PeerPostTransactions = "/peer/transactions";
		public const string PeerGetSignatures = "/peer/signatures";
		public const string PeerGetHeight = "/peer/height";
		public const string PeerGetDappMessage = "/peer/dapp/message";
		public const string PeerGetDappRequest = "/peer/dapp/request";
    }
}
