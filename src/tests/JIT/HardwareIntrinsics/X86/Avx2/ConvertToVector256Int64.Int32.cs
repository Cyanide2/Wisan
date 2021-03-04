// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\X86\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        private static void ConvertToVector256Int64Int32()
        {
            var test = new SimpleUnaryOpTest__ConvertToVector256Int64Int32();

            if (test.IsSupported)
            {
                // Validates basic functionality works, using Unsafe.Read
                test.RunBasicScenario_UnsafeRead();

                // Validates basic functionality works, using the pointer overload
                test.RunBasicScenario_Ptr();

                if (Avx.IsSupported)
                {
                    // Validates basic functionality works, using Load
                    test.RunBasicScenario_Load();

                    // Validates basic functionality works, using LoadAligned
                    test.RunBasicScenario_LoadAligned();
                }

                // Validates calling via reflection works, using Unsafe.Read
                test.RunReflectionScenario_UnsafeRead();

                // Validates calling via reflection works, using the pointer overload
                test.RunReflectionScenario_Ptr();

                if (Avx.IsSupported)
                {
                    // Validates calling via reflection works, using Load
                    test.RunReflectionScenario_Load();

                    // Validates calling via reflection works, using LoadAligned
                    test.RunReflectionScenario_LoadAligned();
                }

                // Validates passing a static member works
                test.RunClsVarScenario();

                // Validates passing a local works, using Unsafe.Read
                test.RunLclVarScenario_UnsafeRead();

                if (Avx.IsSupported)
                {
                    // Validates passing a local works, using Load
                    test.RunLclVarScenario_Load();

                    // Validates passing a local works, using LoadAligned
                    test.RunLclVarScenario_LoadAligned();
                }

                // Validates passing the field of a local works
                test.RunLclFldScenario();

                // Validates passing an instance member works
                test.RunFldScenario();
            }
            else
            {
                // Validates we throw on unsupported hardware
                test.RunUnsupportedScenario();
            }

            if (!test.Succeeded)
            {
                throw new Exception("One or more scenarios did not complete as expected.");
            }
        }
    }

    public sealed unsafe class SimpleUnaryOpTest__ConvertToVector256Int64Int32
    {
        private const int VectorSize = 32;

        private const int Op1ElementCount = 16 / sizeof(Int32);
        private const int RetElementCount = VectorSize / sizeof(Int64);

        private static Int32[] _data = new Int32[Op1ElementCount];

        private static Vector128<Int32> _clsVar;

        private Vector128<Int32> _fld;

        private SimpleUnaryOpTest__DataTable<Int64, Int32> _dataTable;

        static SimpleUnaryOpTest__ConvertToVector256Int64Int32()
        {
            var random = new Random();

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (int)(random.Next(int.MinValue, int.MaxValue)); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector128<Int32>, byte>(ref _clsVar), ref Unsafe.As<Int32, byte>(ref _data[0]), 16);
        }

        public SimpleUnaryOpTest__ConvertToVector256Int64Int32()
        {
            Succeeded = true;

            var random = new Random();

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (int)(random.Next(int.MinValue, int.MaxValue)); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector128<Int32>, byte>(ref _fld), ref Unsafe.As<Int32, byte>(ref _data[0]), 16);

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (int)(random.Next(int.MinValue, int.MaxValue)); }
            _dataTable = new SimpleUnaryOpTest__DataTable<Int64, Int32>(_data, new Int64[RetElementCount], VectorSize);
        }

        public bool IsSupported => Avx2.IsSupported;

        public bool Succeeded { get; set; }

        public void RunBasicScenario_UnsafeRead()
        {
            var result = Avx2.ConvertToVector256Int64(
                Unsafe.Read<Vector128<Int32>>(_dataTable.inArrayPtr)
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_Ptr()
        {
            var result = Avx2.ConvertToVector256Int64(
                (Int32*)(_dataTable.inArrayPtr)
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_Load()
        {
            var result = Avx2.ConvertToVector256Int64(
                Sse2.LoadVector128((Int32*)(_dataTable.inArrayPtr))
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_LoadAligned()
        {
            var result = Avx2.ConvertToVector256Int64(
                Sse2.LoadAlignedVector128((Int32*)(_dataTable.inArrayPtr))
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_UnsafeRead()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ConvertToVector256Int64), new Type[] { typeof(Vector128<Int32>) })
                                     .Invoke(null, new object[] {
                                        Unsafe.Read<Vector128<Int32>>(_dataTable.inArrayPtr)
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Int64>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_Ptr()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ConvertToVector256Int64), new Type[] { typeof(Int32*) })
                                     .Invoke(null, new object[] {
                                        Pointer.Box(_dataTable.inArrayPtr, typeof(Int32*))
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Int64>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_Load()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ConvertToVector256Int64), new Type[] { typeof(Vector128<Int32>) })
                                     .Invoke(null, new object[] {
                                        Sse2.LoadVector128((Int32*)(_dataTable.inArrayPtr))
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Int64>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_LoadAligned()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ConvertToVector256Int64), new Type[] { typeof(Vector128<Int32>) })
                                     .Invoke(null, new object[] {
                                        Sse2.LoadAlignedVector128((Int32*)(_dataTable.inArrayPtr))
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<Int64>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunClsVarScenario()
        {
            var result = Avx2.ConvertToVector256Int64(
                _clsVar
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_clsVar, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_UnsafeRead()
        {
            var firstOp = Unsafe.Read<Vector128<Int32>>(_dataTable.inArrayPtr);
            var result = Avx2.ConvertToVector256Int64(firstOp);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_Load()
        {
            var firstOp = Sse2.LoadVector128((Int32*)(_dataTable.inArrayPtr));
            var result = Avx2.ConvertToVector256Int64(firstOp);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_LoadAligned()
        {
            var firstOp = Sse2.LoadAlignedVector128((Int32*)(_dataTable.inArrayPtr));
            var result = Avx2.ConvertToVector256Int64(firstOp);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclFldScenario()
        {
            var test = new SimpleUnaryOpTest__ConvertToVector256Int64Int32();
            var result = Avx2.ConvertToVector256Int64(test._fld);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(test._fld, _dataTable.outArrayPtr);
        }

        public void RunFldScenario()
        {
            var result = Avx2.ConvertToVector256Int64(_fld);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_fld, _dataTable.outArrayPtr);
        }

        public void RunUnsupportedScenario()
        {
            Succeeded = false;

            try
            {
                RunBasicScenario_UnsafeRead();
            }
            catch (PlatformNotSupportedException)
            {
                Succeeded = true;
            }
        }

        private void ValidateResult(Vector128<Int32> firstOp, void* result, [CallerMemberName] string method = "")
        {
            Int32[] inArray = new Int32[Op1ElementCount];
            Int64[] outArray = new Int64[RetElementCount];

            Unsafe.WriteUnaligned(ref Unsafe.As<Int32, byte>(ref inArray[0]), firstOp);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Int64, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), VectorSize);

            ValidateResult(inArray, outArray, method);
        }

        private void ValidateResult(void* firstOp, void* result, [CallerMemberName] string method = "")
        {
            Int32[] inArray = new Int32[Op1ElementCount];
            Int64[] outArray = new Int64[RetElementCount];

            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Int32, byte>(ref inArray[0]), ref Unsafe.AsRef<byte>(firstOp), 16);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Int64, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), VectorSize);

            ValidateResult(inArray, outArray, method);
        }

        private void ValidateResult(Int32[] firstOp, Int64[] result, [CallerMemberName] string method = "")
        {
            if (result[0] != firstOp[0])
            {
                Succeeded = false;
            }
            else
            {
                for (var i = 1; i < RetElementCount; i++)
                {
                    if (result[i] != firstOp[i])
                    {
                        Succeeded = false;
                        break;
                    }
                }
            }

            if (!Succeeded)
            {
                Console.WriteLine($"{nameof(Avx2)}.{nameof(Avx2.ConvertToVector256Int64)}<Int64>(Vector128<Int32>): {method} failed:");
                Console.WriteLine($"  firstOp: ({string.Join(", ", firstOp)})");
                Console.WriteLine($"   result: ({string.Join(", ", result)})");
                Console.WriteLine();
            }
        }
    }
}
