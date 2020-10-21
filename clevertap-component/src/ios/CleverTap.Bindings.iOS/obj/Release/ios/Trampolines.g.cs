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
using System.Runtime.InteropServices;
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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::CleverTapSDK.CleverTapExperimentsUpdatedBlock))]
		internal delegate void DCleverTapExperimentsUpdatedBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCleverTapExperimentsUpdatedBlock {
			static internal readonly DCleverTapExperimentsUpdatedBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCleverTapExperimentsUpdatedBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::CleverTapSDK.CleverTapExperimentsUpdatedBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDCleverTapExperimentsUpdatedBlock */
		
		internal sealed class NIDCleverTapExperimentsUpdatedBlock : TrampolineBlockBase {
			DCleverTapExperimentsUpdatedBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDCleverTapExperimentsUpdatedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DCleverTapExperimentsUpdatedBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::CleverTapSDK.CleverTapExperimentsUpdatedBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::CleverTapSDK.CleverTapExperimentsUpdatedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDCleverTapExperimentsUpdatedBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDCleverTapExperimentsUpdatedBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::CleverTapSDK.CleverTapInboxSuccessBlock))]
		internal delegate void DCleverTapInboxSuccessBlock (IntPtr block, bool arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCleverTapInboxSuccessBlock {
			static internal readonly DCleverTapInboxSuccessBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCleverTapInboxSuccessBlock))]
			static unsafe void Invoke (IntPtr block, bool arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::CleverTapSDK.CleverTapInboxSuccessBlock) (descriptor->Target);
				if (del != null)
					del (arg0);
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
			public unsafe static global::CleverTapSDK.CleverTapInboxSuccessBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::CleverTapSDK.CleverTapInboxSuccessBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDCleverTapInboxSuccessBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0)
			{
				invoker (BlockPointer, arg0);
			}
		} /* class NIDCleverTapInboxSuccessBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::CleverTapSDK.CleverTapInboxUpdatedBlock))]
		internal delegate void DCleverTapInboxUpdatedBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCleverTapInboxUpdatedBlock {
			static internal readonly DCleverTapInboxUpdatedBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCleverTapInboxUpdatedBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::CleverTapSDK.CleverTapInboxUpdatedBlock) (descriptor->Target);
				if (del != null)
					del ();
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
			public unsafe static global::CleverTapSDK.CleverTapInboxUpdatedBlock Create (IntPtr block)
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
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
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
			public unsafe static global::System.Action Create (IntPtr block)
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
		internal delegate void DActionArity1V0 (IntPtr block, global::CoreLocation.CLLocationCoordinate2D obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, global::CoreLocation.CLLocationCoordinate2D obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>) (descriptor->Target);
				if (del != null)
					del (obj);
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
			public unsafe static global::System.Action<global::CoreLocation.CLLocationCoordinate2D> Create (IntPtr block)
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
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (obj));
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
			public unsafe static global::System.Action<NSString> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString obj)
			{
				invoker (BlockPointer, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg1),  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg2));
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
			public unsafe static global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSArray<global::CleverTapSDK.CTValidationResult> arg2)
			{
				invoker (BlockPointer, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		internal delegate void DActionArity3V1 (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V1 {
			static internal readonly DActionArity3V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg1),  Runtime.GetNSObject<NSArray> (arg2),  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg3));
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
			public unsafe static global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V1 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSArray arg2, NSArray<global::CleverTapSDK.CTValidationResult> arg3)
			{
				invoker (BlockPointer, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDActionArity3V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>))]
		internal delegate void DActionArity3V0 (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg1),  Runtime.GetNSObject<NSDictionary> (arg2),  Runtime.GetNSObject<global::Foundation.NSArray<global::CleverTapSDK.CTValidationResult>> (arg3));
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
			public unsafe static global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSDictionary arg1, NSDictionary arg2, NSArray<global::CleverTapSDK.CTValidationResult> arg3)
			{
				invoker (BlockPointer, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDActionArity3V0 */
	}
}
