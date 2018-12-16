using RaiBlocks.Actions;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaiBlocks
{
    /// <summary>
    /// .NET wrapper for RaiBlocks RPC Protocol.
    /// <see cref="https://github.com/clemahieu/raiblocks/wiki/RPC-protocol"/>
    /// </summary>
    public class RaiBlocksRpc
    {
        private readonly Uri _node;

        /// <param name="node">The URI of your node. http://localhost:7076/ by default.</param>
        public RaiBlocksRpc(Uri node)
        {
            _node = node ?? throw new ArgumentNullException(nameof(node));
        }

        /// <param name="url">The URI of your node. http://localhost:7076/ by default.</param>
        public RaiBlocksRpc(string url) : this(new Uri(url))
        { }

        #region Actions

        /// <summary>
        /// Returns how many RAW is owned and how many have not yet been received by account.
        /// </summary>
        /// <param name="acc">The account to get balance for.</param>
        /// <returns>Balance of <paramref name="acc"/> in RAW.</returns>
        public async Task<BalanceResult> GetBalanceAsync(RaiAddress acc) 
            => await Handle<GetBalance, BalanceResult>(new GetBalance(acc));

        public async Task<BalancesResult> GetBalancesAsync(IEnumerable<RaiAddress> acc) 
            => await Handle<GetBalances, BalancesResult>(new GetBalances(acc));

        /// <summary>
        /// Get number of blocks for a specific account
        /// </summary>
        /// <param name="acc">The account to get block count for.</param>
        /// <returns>Number of blocks on account.</returns>
        public async Task<AccountBlockCountResult> GetAccountBlockCountAsync(RaiAddress acc) 
            => await Handle<GetAccountBlockCount, AccountBlockCountResult>(new GetAccountBlockCount(acc));

        /// <summary>
        /// Get information about account
        /// </summary>
        /// <returns>
        ///     Returns frontier, open block, change representative block, balance, 
        ///     last modified timestamp from local database and block count for account
        /// </summary></returns>
        public async Task<AccountInformationResult> GetAccountInformationAsync(RaiAddress acc) 
            => await Handle<GetAccountInformation, AccountInformationResult>(new GetAccountInformation(acc));

        /// <summary>
        /// Return block by hash.
        /// </summary>
        /// <param name="hash">Block hash.</param>
        /// <returns>Block info.</returns>
        public async Task<RetrieveBlockResult> GetRetrieveBlockAsync(string hash) 
            => await Handle<RetrieveBlock, RetrieveBlockResult>(new RetrieveBlock(hash));

        /// <summary>
        /// Get blocks info
        /// </summary>
        /// <param name="hashes">Blocks hashes.</param>
        /// <param name="pending">Include panding info</param>
        /// <param name="source">Include source info</param>
        /// <param name="balance">Include balance info</param>
        /// <returns>Block info.</returns>
        public async Task<RetrieveBlocksInfoResult> GetRetrieveBlocksInfoAsync(List<string> hashes, 
                                                                               bool pending = false,
                                                                               bool source = false, 
                                                                               bool balance = false)
        {
            var action = new RetrieveBlocksInfo
            {
                Hashes = hashes,
                Balance = balance,
                Pending = pending,
                Source = source
            };

            return await Handle<RetrieveBlocksInfo, RetrieveBlocksInfoResult>(action);
        }

        /// <summary>
        /// enable_control required
        /// Creates a new account, insert next deterministic key in wallet
        /// </summary>
        public async Task<CreateAccountResult> CreateAccountAsync(string wallet) 
            => await Handle<CreateAccount, CreateAccountResult>(new CreateAccount(wallet));

        /// <summary>
        /// Get account number for the public key
        /// </summary>>
        public async Task<GetAccountByPublicKeyResult> GetAccountByPublicKeyAsync(string key) 
            => await Handle<GetAccountByPublicKey, GetAccountByPublicKeyResult>(new GetAccountByPublicKey(key));

        /// <summary>
        /// Reports send/receive information for a account
        /// </summary>>
        public async Task<AccountHistoryResult> GetAccountHistoryAsync(RaiAddress acc, int count = 1) 
            => await Handle<GetAccountHistory, AccountHistoryResult>(new GetAccountHistory(acc, count));

        /// <summary>
        /// enable_control required
        /// Send amount from source in wallet to destination
        /// </summary>
        /// <param name="wallet">Wallet</param>
        /// <param name="source">Source</param>create
        /// <param name="destination">Destination</param>
        /// <param name="amount">Amount in RAW.</param>
        /// <returns></returns>
        public async Task<SendResult> SendAsync(string wallet,
                                                RaiAddress source,
                                                RaiAddress destination,
                                                RaiUnits.RaiRaw amount) 
            => await Handle<Send, SendResult>(new Send(wallet, source, destination, amount));

        public async Task<ValidateAccountResult> ValidateAccountAsync(RaiAddress acc) 
            => await Handle<ValidateAccount, ValidateAccountResult>(new ValidateAccount(acc));

        public async Task<ProcessBlockResult> ProcessBlockAsync(string block) 
            => await Handle<ProcessBlock, ProcessBlockResult>(new ProcessBlock(block));

        public async Task<WorkGenerateResult> GetWorkAsync(string hash) 
            => await Handle<WorkGenerate, WorkGenerateResult>(new WorkGenerate(hash));

        public async Task<AccountKeyResult> GetAccountKeyAsync(RaiAddress account) 
            => await Handle<AccountKey, AccountKeyResult>(new AccountKey(account));

        public async Task<BlockCreateResult> BlockCreateSendAsync(string wallet, 
                                                                  RaiAddress account,
                                                                  RaiAddress destination,
                                                                  RaiUnits.RaiRaw balance,
                                                                  RaiUnits.RaiRaw amount,
                                                                  string previous)
        {
            var action = new BlockCreate()
            {
                Type = BlockType.Send,
                Wallet = wallet,
                AccountNumber = account,
                Destination = destination,
                Balance = balance,
                Amount = amount,
                Previous = previous
            };

            return await Handle<BlockCreate, BlockCreateResult>(action);
        }

        public async Task<BlockCreateResult> BlockCreateSendAsync(BlockCreate createBlockAction)
            => await Handle<BlockCreate, BlockCreateResult>(createBlockAction);

        public async Task<GetChainResult> GetChainAsync(string block, long count)
            => await Handle<GetChain, GetChainResult>(new GetChain(block, count));

        private async Task<TResult> Handle<TAction, TResult>(IAction<TResult> action)
            where TAction : class, IAction<TResult>
            where TResult : class, IActionResult
        {
            var handler = new ActionHandler<TAction, TResult>(_node);
            return await handler.Handle(action);
        }

        #endregion
    }
}