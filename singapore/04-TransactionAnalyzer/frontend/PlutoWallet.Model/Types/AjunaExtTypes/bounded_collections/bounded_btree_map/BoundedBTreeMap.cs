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


namespace Substrate.NetApi.Generated.Model.bounded_collections.bounded_btree_map
{
    
    
    /// <summary>
    /// >> 353 - Composite[bounded_collections.bounded_btree_map.BoundedBTreeMap]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedBTreeMap : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Generated.Types.Base.BTreeMapT3 _value;
        
        public Substrate.NetApi.Generated.Types.Base.BTreeMapT3 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedBTreeMap";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.NetApi.Generated.Types.Base.BTreeMapT3();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}