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

namespace CleverTapSDK {
	public unsafe static partial class CleverTap_Inbox  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTap");
		
		[Export ("deleteInboxMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteInboxMessage (this CleverTap This, CleverTapInboxMessage message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteInboxMessage:"), message.Handle);
		}
		
		[Export ("getInboxMessageForId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage GetInboxMessageForId (this CleverTap This, string messageId)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			var nsmessageId = NSString.CreateNative (messageId);
			
			CleverTapInboxMessage ret;
			ret =  Runtime.GetNSObject<CleverTapInboxMessage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getInboxMessageForId:"), nsmessageId));
			NSString.ReleaseNative (nsmessageId);
			
			return ret;
		}
		
		[Export ("initializeInboxWithCallback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitializeInboxWithCallback (this CleverTap This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCleverTapInboxSuccessBlock))]CleverTapInboxSuccessBlock callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlockUnsafe (Trampolines.SDCleverTapInboxSuccessBlock.Handler, callback);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("initializeInboxWithCallback:"), (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("markReadInboxMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MarkReadInboxMessage (this CleverTap This, CleverTapInboxMessage message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("markReadInboxMessage:"), message.Handle);
		}
		
		[Export ("newInboxViewControllerWithConfig:andDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxViewController NewInboxViewControllerWithConfig (this CleverTap This, CleverTapInboxStyleConfig config, CleverTapInboxViewControllerDelegate @delegate)
		{
			return  Runtime.GetNSObject<CleverTapInboxViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("newInboxViewControllerWithConfig:andDelegate:"), config == null ? IntPtr.Zero : config.Handle, @delegate == null ? IntPtr.Zero : @delegate.Handle));
		}
		
		[Export ("registerInboxUpdatedBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterInboxUpdatedBlock (this CleverTap This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCleverTapInboxUpdatedBlock))]CleverTapInboxUpdatedBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDCleverTapInboxUpdatedBlock.Handler, block);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerInboxUpdatedBlock:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage[] AllInboxMessages {
			[Export ("getAllInboxMessages")]
			get {
				CleverTapInboxMessage[] ret;
				ret = NSArray.ArrayFromHandle<CleverTapInboxMessage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getAllInboxMessages")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint InboxMessageCount {
			[Export ("getInboxMessageCount")]
			get {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (class_ptr, Selector.GetHandle ("getInboxMessageCount"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint InboxMessageUnreadCount {
			[Export ("getInboxMessageUnreadCount")]
			get {
				return global::ApiDefinition.Messaging.nuint_objc_msgSend (class_ptr, Selector.GetHandle ("getInboxMessageUnreadCount"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage[] UnreadInboxMessages {
			[Export ("getUnreadInboxMessages")]
			get {
				CleverTapInboxMessage[] ret;
				ret = NSArray.ArrayFromHandle<CleverTapInboxMessage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getUnreadInboxMessages")));
				return ret;
			}
			
		}
		
	} /* class CleverTap_Inbox */
}
