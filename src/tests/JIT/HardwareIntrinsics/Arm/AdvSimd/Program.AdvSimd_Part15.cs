// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["StoreSelectedScalar.Vector128.Int64.1"] = StoreSelectedScalar_Vector128_Int64_1,
                ["StoreSelectedScalar.Vector128.SByte.15"] = StoreSelectedScalar_Vector128_SByte_15,
                ["StoreSelectedScalar.Vector128.Single.3"] = StoreSelectedScalar_Vector128_Single_3,
                ["StoreSelectedScalar.Vector128.UInt16.7"] = StoreSelectedScalar_Vector128_UInt16_7,
                ["StoreSelectedScalar.Vector128.UInt32.3"] = StoreSelectedScalar_Vector128_UInt32_3,
                ["StoreSelectedScalar.Vector128.UInt64.1"] = StoreSelectedScalar_Vector128_UInt64_1,
                ["Subtract.Vector64.Byte"] = Subtract_Vector64_Byte,
                ["Subtract.Vector64.Int16"] = Subtract_Vector64_Int16,
                ["Subtract.Vector64.Int32"] = Subtract_Vector64_Int32,
                ["Subtract.Vector64.SByte"] = Subtract_Vector64_SByte,
                ["Subtract.Vector64.Single"] = Subtract_Vector64_Single,
                ["Subtract.Vector64.UInt16"] = Subtract_Vector64_UInt16,
                ["Subtract.Vector64.UInt32"] = Subtract_Vector64_UInt32,
                ["Subtract.Vector128.Byte"] = Subtract_Vector128_Byte,
                ["Subtract.Vector128.Int16"] = Subtract_Vector128_Int16,
                ["Subtract.Vector128.Int32"] = Subtract_Vector128_Int32,
                ["Subtract.Vector128.Int64"] = Subtract_Vector128_Int64,
                ["Subtract.Vector128.SByte"] = Subtract_Vector128_SByte,
                ["Subtract.Vector128.Single"] = Subtract_Vector128_Single,
                ["Subtract.Vector128.UInt16"] = Subtract_Vector128_UInt16,
                ["Subtract.Vector128.UInt32"] = Subtract_Vector128_UInt32,
                ["Subtract.Vector128.UInt64"] = Subtract_Vector128_UInt64,
                ["SubtractHighNarrowingLower.Vector64.Byte"] = SubtractHighNarrowingLower_Vector64_Byte,
                ["SubtractHighNarrowingLower.Vector64.Int16"] = SubtractHighNarrowingLower_Vector64_Int16,
                ["SubtractHighNarrowingLower.Vector64.Int32"] = SubtractHighNarrowingLower_Vector64_Int32,
                ["SubtractHighNarrowingLower.Vector64.SByte"] = SubtractHighNarrowingLower_Vector64_SByte,
                ["SubtractHighNarrowingLower.Vector64.UInt16"] = SubtractHighNarrowingLower_Vector64_UInt16,
                ["SubtractHighNarrowingLower.Vector64.UInt32"] = SubtractHighNarrowingLower_Vector64_UInt32,
                ["SubtractHighNarrowingUpper.Vector128.Byte"] = SubtractHighNarrowingUpper_Vector128_Byte,
                ["SubtractHighNarrowingUpper.Vector128.Int16"] = SubtractHighNarrowingUpper_Vector128_Int16,
                ["SubtractHighNarrowingUpper.Vector128.Int32"] = SubtractHighNarrowingUpper_Vector128_Int32,
                ["SubtractHighNarrowingUpper.Vector128.SByte"] = SubtractHighNarrowingUpper_Vector128_SByte,
                ["SubtractHighNarrowingUpper.Vector128.UInt16"] = SubtractHighNarrowingUpper_Vector128_UInt16,
                ["SubtractHighNarrowingUpper.Vector128.UInt32"] = SubtractHighNarrowingUpper_Vector128_UInt32,
                ["SubtractRoundedHighNarrowingLower.Vector64.Byte"] = SubtractRoundedHighNarrowingLower_Vector64_Byte,
                ["SubtractRoundedHighNarrowingLower.Vector64.Int16"] = SubtractRoundedHighNarrowingLower_Vector64_Int16,
                ["SubtractRoundedHighNarrowingLower.Vector64.Int32"] = SubtractRoundedHighNarrowingLower_Vector64_Int32,
                ["SubtractRoundedHighNarrowingLower.Vector64.SByte"] = SubtractRoundedHighNarrowingLower_Vector64_SByte,
                ["SubtractRoundedHighNarrowingLower.Vector64.UInt16"] = SubtractRoundedHighNarrowingLower_Vector64_UInt16,
                ["SubtractRoundedHighNarrowingLower.Vector64.UInt32"] = SubtractRoundedHighNarrowingLower_Vector64_UInt32,
                ["SubtractRoundedHighNarrowingUpper.Vector128.Byte"] = SubtractRoundedHighNarrowingUpper_Vector128_Byte,
                ["SubtractRoundedHighNarrowingUpper.Vector128.Int16"] = SubtractRoundedHighNarrowingUpper_Vector128_Int16,
                ["SubtractRoundedHighNarrowingUpper.Vector128.Int32"] = SubtractRoundedHighNarrowingUpper_Vector128_Int32,
                ["SubtractRoundedHighNarrowingUpper.Vector128.SByte"] = SubtractRoundedHighNarrowingUpper_Vector128_SByte,
                ["SubtractRoundedHighNarrowingUpper.Vector128.UInt16"] = SubtractRoundedHighNarrowingUpper_Vector128_UInt16,
                ["SubtractRoundedHighNarrowingUpper.Vector128.UInt32"] = SubtractRoundedHighNarrowingUpper_Vector128_UInt32,
                ["SubtractSaturate.Vector64.Byte"] = SubtractSaturate_Vector64_Byte,
                ["SubtractSaturate.Vector64.Int16"] = SubtractSaturate_Vector64_Int16,
                ["SubtractSaturate.Vector64.Int32"] = SubtractSaturate_Vector64_Int32,
                ["SubtractSaturate.Vector64.SByte"] = SubtractSaturate_Vector64_SByte,
                ["SubtractSaturate.Vector64.UInt16"] = SubtractSaturate_Vector64_UInt16,
                ["SubtractSaturate.Vector64.UInt32"] = SubtractSaturate_Vector64_UInt32,
                ["SubtractSaturate.Vector128.Byte"] = SubtractSaturate_Vector128_Byte,
                ["SubtractSaturate.Vector128.Int16"] = SubtractSaturate_Vector128_Int16,
                ["SubtractSaturate.Vector128.Int32"] = SubtractSaturate_Vector128_Int32,
                ["SubtractSaturate.Vector128.Int64"] = SubtractSaturate_Vector128_Int64,
                ["SubtractSaturate.Vector128.SByte"] = SubtractSaturate_Vector128_SByte,
                ["SubtractSaturate.Vector128.UInt16"] = SubtractSaturate_Vector128_UInt16,
                ["SubtractSaturate.Vector128.UInt32"] = SubtractSaturate_Vector128_UInt32,
                ["SubtractSaturate.Vector128.UInt64"] = SubtractSaturate_Vector128_UInt64,
                ["SubtractSaturateScalar.Vector64.Int64"] = SubtractSaturateScalar_Vector64_Int64,
                ["SubtractSaturateScalar.Vector64.UInt64"] = SubtractSaturateScalar_Vector64_UInt64,
                ["SubtractScalar.Vector64.Double"] = SubtractScalar_Vector64_Double,
                ["SubtractScalar.Vector64.Int64"] = SubtractScalar_Vector64_Int64,
                ["SubtractScalar.Vector64.Single"] = SubtractScalar_Vector64_Single,
                ["SubtractScalar.Vector64.UInt64"] = SubtractScalar_Vector64_UInt64,
                ["SubtractWideningLower.Vector64.Byte"] = SubtractWideningLower_Vector64_Byte,
                ["SubtractWideningLower.Vector64.Int16"] = SubtractWideningLower_Vector64_Int16,
                ["SubtractWideningLower.Vector64.Int32"] = SubtractWideningLower_Vector64_Int32,
                ["SubtractWideningLower.Vector64.SByte"] = SubtractWideningLower_Vector64_SByte,
                ["SubtractWideningLower.Vector64.UInt16"] = SubtractWideningLower_Vector64_UInt16,
                ["SubtractWideningLower.Vector64.UInt32"] = SubtractWideningLower_Vector64_UInt32,
                ["SubtractWideningLower.Vector128.Int16"] = SubtractWideningLower_Vector128_Int16,
                ["SubtractWideningLower.Vector128.Int32"] = SubtractWideningLower_Vector128_Int32,
                ["SubtractWideningLower.Vector128.Int64"] = SubtractWideningLower_Vector128_Int64,
                ["SubtractWideningLower.Vector128.UInt16"] = SubtractWideningLower_Vector128_UInt16,
                ["SubtractWideningLower.Vector128.UInt32"] = SubtractWideningLower_Vector128_UInt32,
                ["SubtractWideningLower.Vector128.UInt64"] = SubtractWideningLower_Vector128_UInt64,
                ["SubtractWideningUpper.Vector128.Byte.Vector128.Byte"] = SubtractWideningUpper_Vector128_Byte_Vector128_Byte,
                ["SubtractWideningUpper.Vector128.Int16.Vector128.Int16"] = SubtractWideningUpper_Vector128_Int16_Vector128_Int16,
                ["SubtractWideningUpper.Vector128.Int16.Vector128.SByte"] = SubtractWideningUpper_Vector128_Int16_Vector128_SByte,
                ["SubtractWideningUpper.Vector128.Int32.Vector128.Int16"] = SubtractWideningUpper_Vector128_Int32_Vector128_Int16,
                ["SubtractWideningUpper.Vector128.Int32.Vector128.Int32"] = SubtractWideningUpper_Vector128_Int32_Vector128_Int32,
                ["SubtractWideningUpper.Vector128.Int64.Vector128.Int32"] = SubtractWideningUpper_Vector128_Int64_Vector128_Int32,
                ["SubtractWideningUpper.Vector128.SByte.Vector128.SByte"] = SubtractWideningUpper_Vector128_SByte_Vector128_SByte,
                ["SubtractWideningUpper.Vector128.UInt16.Vector128.Byte"] = SubtractWideningUpper_Vector128_UInt16_Vector128_Byte,
                ["SubtractWideningUpper.Vector128.UInt16.Vector128.UInt16"] = SubtractWideningUpper_Vector128_UInt16_Vector128_UInt16,
                ["SubtractWideningUpper.Vector128.UInt32.Vector128.UInt16"] = SubtractWideningUpper_Vector128_UInt32_Vector128_UInt16,
                ["SubtractWideningUpper.Vector128.UInt32.Vector128.UInt32"] = SubtractWideningUpper_Vector128_UInt32_Vector128_UInt32,
                ["SubtractWideningUpper.Vector128.UInt64.Vector128.UInt32"] = SubtractWideningUpper_Vector128_UInt64_Vector128_UInt32,
                ["VectorTableLookup.Vector64.Byte"] = VectorTableLookup_Vector64_Byte,
                ["VectorTableLookup.Vector64.SByte"] = VectorTableLookup_Vector64_SByte,
                ["VectorTableLookupExtension.Vector64.Byte"] = VectorTableLookupExtension_Vector64_Byte,
                ["VectorTableLookupExtension.Vector64.SByte"] = VectorTableLookupExtension_Vector64_SByte,
                ["Xor.Vector64.Byte"] = Xor_Vector64_Byte,
                ["Xor.Vector64.Double"] = Xor_Vector64_Double,
                ["Xor.Vector64.Int16"] = Xor_Vector64_Int16,
                ["Xor.Vector64.Int32"] = Xor_Vector64_Int32,
                ["Xor.Vector64.Int64"] = Xor_Vector64_Int64,
                ["Xor.Vector64.SByte"] = Xor_Vector64_SByte,
            };
        }
    }
}
