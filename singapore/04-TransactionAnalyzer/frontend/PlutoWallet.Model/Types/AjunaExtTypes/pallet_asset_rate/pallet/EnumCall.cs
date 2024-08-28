//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.pallet_asset_rate.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> create
        /// See [`Pallet::create`].
        /// </summary>
        create = 0,
        
        /// <summary>
        /// >> update
        /// See [`Pallet::update`].
        /// </summary>
        update = 1,
        
        /// <summary>
        /// >> remove
        /// See [`Pallet::remove`].
        /// </summary>
        remove = 2,
    }
    
    /// <summary>
    /// >> 466 - Variant[pallet_asset_rate.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset, Substrate.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Substrate.NetApi.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset, Substrate.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, Substrate.NetApi.Generated.Model.polkadot_runtime_common.impls.EnumVersionedLocatableAsset>
    {
    }
}