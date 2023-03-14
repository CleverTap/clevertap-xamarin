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
namespace CleverTapSDK {
	public unsafe static partial class CleverTap_Inbox  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTap");
		[Export ("getAllInboxMessages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage[] AllInboxMessages (this CleverTap This)
		{
			return CFArray.ArrayFromHandle<CleverTapInboxMessage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAllInboxMessages")))!;
		}
		[Export ("deleteInboxMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteInboxMessage (this CleverTap This, CleverTapInboxMessage message)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteInboxMessage:"), message__handle__);
		}
		[Export ("deleteInboxMessageForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteInboxMessageForID (this CleverTap This, string messageId)
		{
			if (messageId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageId));
			var nsmessageId = CFString.CreateNative (messageId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteInboxMessageForID:"), nsmessageId);
			CFString.ReleaseNative (nsmessageId);
		}
		[Export ("deleteInboxMessagesForIDs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteInboxMessagesForIDs (this CleverTap This, string[] messageIds)
		{
			if (messageIds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageIds));
			var nsa_messageIds = NSArray.FromStrings (messageIds);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteInboxMessagesForIDs:"), nsa_messageIds.Handle);
			nsa_messageIds.Dispose ();
		}
		[Export ("getInboxMessageForId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage? GetInboxMessageForId (this CleverTap This, string messageId)
		{
			if (messageId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageId));
			var nsmessageId = CFString.CreateNative (messageId);
			CleverTapInboxMessage? ret;
			ret =  Runtime.GetNSObject<CleverTapInboxMessage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getInboxMessageForId:"), nsmessageId))!;
			CFString.ReleaseNative (nsmessageId);
			return ret!;
		}
		[Export ("getInboxMessageCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint InboxMessageCount (this CleverTap This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInboxMessageCount"));
		}
		[Export ("getInboxMessageUnreadCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint InboxMessageUnreadCount (this CleverTap This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInboxMessageUnreadCount"));
		}
		[Export ("initializeInboxWithCallback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitializeInboxWithCallback (this CleverTap This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCleverTapInboxSuccessBlock))]CleverTapInboxSuccessBlock callback)
		{
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
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
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("markReadInboxMessage:"), message__handle__);
		}
		[Export ("markReadInboxMessageForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MarkReadInboxMessageForID (this CleverTap This, string messageId)
		{
			if (messageId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageId));
			var nsmessageId = CFString.CreateNative (messageId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("markReadInboxMessageForID:"), nsmessageId);
			CFString.ReleaseNative (nsmessageId);
		}
		[Export ("newInboxViewControllerWithConfig:andDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxViewController? NewInboxViewControllerWithConfig (this CleverTap This, CleverTapInboxStyleConfig? config, CleverTapInboxViewControllerDelegate? @delegate)
		{
			var config__handle__ = config.GetHandle ();
			var @delegate__handle__ = @delegate.GetHandle ();
			return  Runtime.GetNSObject<CleverTapInboxViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("newInboxViewControllerWithConfig:andDelegate:"), config__handle__, @delegate__handle__))!;
		}
		[Export ("recordInboxNotificationClickedEventForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordInboxNotificationClickedEventForID (this CleverTap This, string messageId)
		{
			if (messageId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageId));
			var nsmessageId = CFString.CreateNative (messageId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordInboxNotificationClickedEventForID:"), nsmessageId);
			CFString.ReleaseNative (nsmessageId);
		}
		[Export ("recordInboxNotificationViewedEventForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordInboxNotificationViewedEventForID (this CleverTap This, string messageId)
		{
			if (messageId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageId));
			var nsmessageId = CFString.CreateNative (messageId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordInboxNotificationViewedEventForID:"), nsmessageId);
			CFString.ReleaseNative (nsmessageId);
		}
		[Export ("registerInboxUpdatedBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterInboxUpdatedBlock (this CleverTap This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCleverTapInboxUpdatedBlock))]CleverTapInboxUpdatedBlock block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDCleverTapInboxUpdatedBlock.Handler, block);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerInboxUpdatedBlock:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
		}
		[Export ("getUnreadInboxMessages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInboxMessage[] UnreadInboxMessages (this CleverTap This)
		{
			return CFArray.ArrayFromHandle<CleverTapInboxMessage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getUnreadInboxMessages")))!;
		}
	} /* class CleverTap_Inbox */
}
