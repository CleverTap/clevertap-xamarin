//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::CleverTapSDK.CleverTapInboxSuccessBlock))]
		unsafe internal delegate void DCleverTapInboxSuccessBlock (IntPtr block, byte arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCleverTapInboxSuccessBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, byte arg0) {
				var del = BlockLiteral.GetTarget<global::CleverTapSDK.CleverTapInboxSuccessBlock> (block);
				if (del is not null) {
					del (arg0 != 0);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::CleverTapSDK.CleverTapInboxSuccessBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::CleverTapSDK.CleverTapInboxSuccessBlock callback)
			{
				delegate* unmanaged<IntPtr, byte, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDCleverTapInboxSuccessBlock), nameof (Invoke));
			}
		} /* class SDCleverTapInboxSuccessBlock */
		internal sealed class NIDCleverTapInboxSuccessBlock : TrampolineBlockBase {
			DCleverTapInboxSuccessBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDCleverTapInboxSuccessBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DCleverTapInboxSuccessBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::CleverTapSDK.CleverTapInboxSuccessBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::CleverTapSDK.CleverTapInboxSuccessBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDCleverTapInboxSuccessBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0)
			{
				invoker (BlockPointer, arg0 ? (byte) 1 : (byte) 0);
			}
		} /* class NIDCleverTapInboxSuccessBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::CleverTapSDK.CleverTapInboxUpdatedBlock))]
		unsafe internal delegate void DCleverTapInboxUpdatedBlock (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCleverTapInboxUpdatedBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block) {
				var del = BlockLiteral.GetTarget<global::CleverTapSDK.CleverTapInboxUpdatedBlock> (block);
				if (del is not null) {
					del ();
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::CleverTapSDK.CleverTapInboxUpdatedBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::CleverTapSDK.CleverTapInboxUpdatedBlock callback)
			{
				delegate* unmanaged<IntPtr, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDCleverTapInboxUpdatedBlock), nameof (Invoke));
			}
		} /* class SDCleverTapInboxUpdatedBlock */
		internal sealed class NIDCleverTapInboxUpdatedBlock : TrampolineBlockBase {
			DCleverTapInboxUpdatedBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDCleverTapInboxUpdatedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DCleverTapInboxUpdatedBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::CleverTapSDK.CleverTapInboxUpdatedBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::CleverTapSDK.CleverTapInboxUpdatedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDCleverTapInboxUpdatedBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDCleverTapInboxUpdatedBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		unsafe internal delegate void DAction (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block) {
				var del = BlockLiteral.GetTarget<global::System.Action> (block);
				if (del is not null) {
					del ();
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action callback)
			{
				delegate* unmanaged<IntPtr, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDAction), nameof (Invoke));
			}
		} /* class SDAction */
		internal sealed class NIDAction : TrampolineBlockBase {
			DAction invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action) GetExistingManagedDelegate (block);
				return del ?? new NIDAction ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDAction */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>))]
		unsafe internal delegate void DActionArity1V0 (IntPtr block, global::CoreLocation.CLLocationCoordinate2D obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, global::CoreLocation.CLLocationCoordinate2D obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<global::CoreLocation.CLLocationCoordinate2D>> (block);
				if (del is not null) {
					del (obj);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::CoreLocation.CLLocationCoordinate2D> callback)
			{
				delegate* unmanaged<IntPtr, global::CoreLocation.CLLocationCoordinate2D, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V0), nameof (Invoke));
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::CoreLocation.CLLocationCoordinate2D>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::CoreLocation.CLLocationCoordinate2D obj)
			{
				invoker (BlockPointer, obj);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString>))]
		unsafe internal delegate void DActionArity1V1 (IntPtr block, NativeHandle obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSString>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSString> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSString>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSString> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity1V1), nameof (Invoke));
			}
		} /* class SDActionArity1V1 */
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V1 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		unsafe internal delegate void DActionArity2V0 (IntPtr block, NativeHandle arg1, NativeHandle arg2);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSDictionary> (arg1)!,  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg2)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity2V0), nameof (Invoke));
			}
		} /* class SDActionArity2V0 */
		internal sealed class NIDActionArity2V0 : TrampolineBlockBase {
			DActionArity2V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSArray<global::CleverTapSDK.CTValidationResult> arg2)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__);
			}
		} /* class NIDActionArity2V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		unsafe internal delegate void DActionArity3V1 (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V1 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSDictionary> (arg1)!,  Runtime.GetNSObject<NSArray> (arg2)!,  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg3)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity3V1), nameof (Invoke));
			}
		} /* class SDActionArity3V1 */
		internal sealed class NIDActionArity3V1 : TrampolineBlockBase {
			DActionArity3V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity3V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity3V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSArray arg2, NSArray<global::CleverTapSDK.CTValidationResult> arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var arg3__handle__ = arg3.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3__handle__);
			}
		} /* class NIDActionArity3V1 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		unsafe internal delegate void DActionArity3V0 (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSDictionary> (arg1)!,  Runtime.GetNSObject<NSDictionary> (arg2)!,  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg3)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity3V0), nameof (Invoke));
			}
		} /* class SDActionArity3V0 */
		internal sealed class NIDActionArity3V0 : TrampolineBlockBase {
			DActionArity3V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSDictionary arg2, NSArray<global::CleverTapSDK.CTValidationResult> arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var arg3__handle__ = arg3.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3__handle__);
			}
		} /* class NIDActionArity3V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		unsafe internal delegate void DActionArity3V2 (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V2 {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3) {
				var del = BlockLiteral.GetTarget<global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>>> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSDictionary> (arg1)!,  Runtime.GetNSObject<NSNumber> (arg2)!,  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg3)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>> callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDActionArity3V2), nameof (Invoke));
			}
		} /* class SDActionArity3V2 */
		internal sealed class NIDActionArity3V2 : TrampolineBlockBase {
			DActionArity3V2 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity3V2 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity3V2> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSNumber, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V2 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSNumber arg2, NSArray<global::CleverTapSDK.CTValidationResult> arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var arg3__handle__ = arg3.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3__handle__);
			}
		} /* class NIDActionArity3V2 */
	}
}
