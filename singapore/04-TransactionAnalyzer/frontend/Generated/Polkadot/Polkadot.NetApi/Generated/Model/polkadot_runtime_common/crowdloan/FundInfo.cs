//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_common.crowdloan
{
    
    
    /// <summary>
    /// >> 822 - Composite[polkadot_runtime_common.crowdloan.FundInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FundInfo : BaseType
    {
        
        /// <summary>
        /// >> depositor
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32 Depositor { get; set; }
        /// <summary>
        /// >> verifier
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.sp_runtime.EnumMultiSigner> Verifier { get; set; }
        /// <summary>
        /// >> deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit { get; set; }
        /// <summary>
        /// >> raised
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Raised { get; set; }
        /// <summary>
        /// >> end
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 End { get; set; }
        /// <summary>
        /// >> cap
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Cap { get; set; }
        /// <summary>
        /// >> last_contribution
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_runtime_common.crowdloan.EnumLastContribution LastContribution { get; set; }
        /// <summary>
        /// >> first_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 FirstPeriod { get; set; }
        /// <summary>
        /// >> last_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastPeriod { get; set; }
        /// <summary>
        /// >> fund_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 FundIndex { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "FundInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Depositor.Encode());
            result.AddRange(Verifier.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Raised.Encode());
            result.AddRange(End.Encode());
            result.AddRange(Cap.Encode());
            result.AddRange(LastContribution.Encode());
            result.AddRange(FirstPeriod.Encode());
            result.AddRange(LastPeriod.Encode());
            result.AddRange(FundIndex.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Depositor = new Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Depositor.Decode(byteArray, ref p);
            Verifier = new Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.sp_runtime.EnumMultiSigner>();
            Verifier.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Raised = new Substrate.NetApi.Model.Types.Primitive.U128();
            Raised.Decode(byteArray, ref p);
            End = new Substrate.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            Cap = new Substrate.NetApi.Model.Types.Primitive.U128();
            Cap.Decode(byteArray, ref p);
            LastContribution = new Polkadot.NetApi.Generated.Model.polkadot_runtime_common.crowdloan.EnumLastContribution();
            LastContribution.Decode(byteArray, ref p);
            FirstPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            FirstPeriod.Decode(byteArray, ref p);
            LastPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastPeriod.Decode(byteArray, ref p);
            FundIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            FundIndex.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}