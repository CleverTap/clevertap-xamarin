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
namespace CleverTapSDK {
	[Protocol (Name = "CTInAppNotification", WrapperType = typeof (CTInAppNotificationWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareWithCompletionHandler", Selector = "prepareWithCompletionHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Id", Selector = "Id", PropertyType = typeof (string), GetterSelector = "Id", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CampaignId", Selector = "campaignId", PropertyType = typeof (string), GetterSelector = "campaignId", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (string), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "InAppType", Selector = "inAppType", PropertyType = typeof (CleverTapSDK.CTInAppType), GetterSelector = "inAppType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Html", Selector = "html", PropertyType = typeof (string), GetterSelector = "html", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Url", Selector = "url", PropertyType = typeof (string), GetterSelector = "url", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ExcludeFromCaps", Selector = "excludeFromCaps", PropertyType = typeof (bool), GetterSelector = "excludeFromCaps", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ShowClose", Selector = "showClose", PropertyType = typeof (bool), GetterSelector = "showClose", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DarkenScreen", Selector = "darkenScreen", PropertyType = typeof (bool), GetterSelector = "darkenScreen", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxPerSession", Selector = "maxPerSession", PropertyType = typeof (int), GetterSelector = "maxPerSession", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TotalLifetimeCount", Selector = "totalLifetimeCount", PropertyType = typeof (int), GetterSelector = "totalLifetimeCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TotalDailyCount", Selector = "totalDailyCount", PropertyType = typeof (int), GetterSelector = "totalDailyCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TimeToLive", Selector = "timeToLive", PropertyType = typeof (IntPtr), GetterSelector = "timeToLive", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Position", Selector = "position", PropertyType = typeof (sbyte), GetterSelector = "position", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Height", Selector = "height", PropertyType = typeof (float), GetterSelector = "height", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HeightPercent", Selector = "heightPercent", PropertyType = typeof (float), GetterSelector = "heightPercent", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof (float), GetterSelector = "width", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WidthPercent", Selector = "widthPercent", PropertyType = typeof (float), GetterSelector = "widthPercent", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof (NSData), GetterSelector = "image", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageLandscape", Selector = "imageLandscape", PropertyType = typeof (NSData), GetterSelector = "imageLandscape", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentType", Selector = "contentType", PropertyType = typeof (string), GetterSelector = "contentType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaUrl", Selector = "mediaUrl", PropertyType = typeof (string), GetterSelector = "mediaUrl", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaIsVideo", Selector = "mediaIsVideo", PropertyType = typeof (bool), GetterSelector = "mediaIsVideo", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaIsAudio", Selector = "mediaIsAudio", PropertyType = typeof (bool), GetterSelector = "mediaIsAudio", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaIsImage", Selector = "mediaIsImage", PropertyType = typeof (bool), GetterSelector = "mediaIsImage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaIsGif", Selector = "mediaIsGif", PropertyType = typeof (bool), GetterSelector = "mediaIsGif", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TitleColor", Selector = "titleColor", PropertyType = typeof (string), GetterSelector = "titleColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof (string), GetterSelector = "message", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MessageColor", Selector = "messageColor", PropertyType = typeof (string), GetterSelector = "messageColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BackgroundColor", Selector = "backgroundColor", PropertyType = typeof (string), GetterSelector = "backgroundColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ShowCloseButton", Selector = "showCloseButton", PropertyType = typeof (bool), GetterSelector = "showCloseButton", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Tablet", Selector = "tablet", PropertyType = typeof (bool), GetterSelector = "tablet", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasLandscape", Selector = "hasLandscape", PropertyType = typeof (bool), GetterSelector = "hasLandscape", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasPortrait", Selector = "hasPortrait", PropertyType = typeof (bool), GetterSelector = "hasPortrait", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Buttons", Selector = "buttons", PropertyType = typeof (CleverTapSDK.CTNotificationButton[]), GetterSelector = "buttons", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "JsonDescription", Selector = "jsonDescription", PropertyType = typeof (NSDictionary), GetterSelector = "jsonDescription", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Error", Selector = "error", PropertyType = typeof (string), GetterSelector = "error", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CustomExtras", Selector = "customExtras", PropertyType = typeof (NSDictionary), GetterSelector = "customExtras", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ActionExtras", Selector = "actionExtras", PropertyType = typeof (NSDictionary), GetterSelector = "actionExtras", SetterSelector = "setActionExtras:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface ICTInAppNotification : INativeObject, IDisposable
	{
	}
	public unsafe static partial class CTInAppNotification_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareWithCompletionHandler (this ICTInAppNotification This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetId (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("Id")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCampaignId (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("campaignId")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetType (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("type")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTInAppType GetInAppType (this ICTInAppNotification This)
		{
			CTInAppType ret;
			ret = (CleverTapSDK.CTInAppType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inAppType"));
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetHtml (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("html")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetUrl (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("url")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetExcludeFromCaps (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("excludeFromCaps"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetShowClose (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showClose"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDarkenScreen (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("darkenScreen"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetMaxPerSession (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("maxPerSession"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetTotalLifetimeCount (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("totalLifetimeCount"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetTotalDailyCount (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("totalDailyCount"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetTimeToLive (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("timeToLive"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static sbyte GetPosition (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.SByte_objc_msgSend (This.Handle, Selector.GetHandle ("position"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetHeight (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("height"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetHeightPercent (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("heightPercent"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetWidth (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("width"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetWidthPercent (this ICTInAppNotification This)
		{
			return global::ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("widthPercent"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetImage (this ICTInAppNotification This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("image")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetImageLandscape (this ICTInAppNotification This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageLandscape")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetContentType (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentType")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetMediaUrl (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("mediaUrl")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMediaIsVideo (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("mediaIsVideo"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMediaIsAudio (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("mediaIsAudio"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMediaIsImage (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("mediaIsImage"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMediaIsGif (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("mediaIsGif"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTitle (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("title")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTitleColor (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("titleColor")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetMessage (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("message")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetMessageColor (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("messageColor")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetBackgroundColor (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("backgroundColor")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetShowCloseButton (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showCloseButton"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetTablet (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("tablet"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasLandscape (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasLandscape"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHasPortrait (this ICTInAppNotification This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasPortrait"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTNotificationButton[] GetButtons (this ICTInAppNotification This)
		{
			return CFArray.ArrayFromHandle<CTNotificationButton>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("buttons")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetJsonDescription (this ICTInAppNotification This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("jsonDescription")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetError (this ICTInAppNotification This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("error")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetCustomExtras (this ICTInAppNotification This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("customExtras")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetActionExtras (this ICTInAppNotification This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("actionExtras")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetActionExtras (this ICTInAppNotification This, NSDictionary value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setActionExtras:"), value__handle__);
		}
	}
	internal unsafe sealed class CTInAppNotificationWrapper : BaseWrapper, ICTInAppNotification {
		[Preserve (Conditional = true)]
		public CTInAppNotificationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTInAppNotification", true)]
	public unsafe partial class CTInAppNotification : NSObject, ICTInAppNotification {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTInAppNotification");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTInAppNotification (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTInAppNotification (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithJSON:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTInAppNotification (NSDictionary json)
			: base (NSObjectFlag.Empty)
		{
			var json__handle__ = json!.GetNonNullHandle (nameof (json));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithJSON:"), json__handle__), "initWithJSON:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithJSON:"), json__handle__), "initWithJSON:");
			}
		}
		[Export ("prepareWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PrepareWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("prepareWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ActionExtras {
			[Export ("actionExtras", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("actionExtras")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionExtras")))!;
				}
				return ret!;
			}
			[Export ("setActionExtras:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setActionExtras:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setActionExtras:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BackgroundColor {
			[Export ("backgroundColor")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColor")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CTNotificationButton[] Buttons {
			[Export ("buttons")]
			get {
				CTNotificationButton[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CTNotificationButton>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buttons")))!;
				} else {
					ret = CFArray.ArrayFromHandle<CTNotificationButton>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttons")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CampaignId {
			[Export ("campaignId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("campaignId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("campaignId")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ContentType {
			[Export ("contentType")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentType")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentType")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary CustomExtras {
			[Export ("customExtras", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customExtras")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customExtras")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DarkenScreen {
			[Export ("darkenScreen")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("darkenScreen"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("darkenScreen"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Error {
			[Export ("error")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("error")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExcludeFromCaps {
			[Export ("excludeFromCaps")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("excludeFromCaps"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("excludeFromCaps"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasLandscape {
			[Export ("hasLandscape")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasLandscape"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasLandscape"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPortrait {
			[Export ("hasPortrait")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasPortrait"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasPortrait"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Height {
			[Export ("height")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("height"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float HeightPercent {
			[Export ("heightPercent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("heightPercent"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heightPercent"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Html {
			[Export ("html")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("html")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("html")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Id {
			[Export ("Id")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("Id")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("Id")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData Image {
			[Export ("image")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")))!;
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData ImageLandscape {
			[Export ("imageLandscape")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageLandscape")))!;
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageLandscape")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CTInAppType InAppType {
			[Export ("inAppType")]
			get {
				CTInAppType ret;
				if (IsDirectBinding) {
					ret = (CleverTapSDK.CTInAppType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inAppType"));
				} else {
					ret = (CleverTapSDK.CTInAppType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inAppType"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary JsonDescription {
			[Export ("jsonDescription", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("jsonDescription")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("jsonDescription")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int MaxPerSession {
			[Export ("maxPerSession")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("maxPerSession"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxPerSession"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MediaIsAudio {
			[Export ("mediaIsAudio")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mediaIsAudio"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaIsAudio"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MediaIsGif {
			[Export ("mediaIsGif")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mediaIsGif"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaIsGif"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MediaIsImage {
			[Export ("mediaIsImage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mediaIsImage"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaIsImage"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MediaIsVideo {
			[Export ("mediaIsVideo")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mediaIsVideo"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaIsVideo"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MediaUrl {
			[Export ("mediaUrl")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediaUrl")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaUrl")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Message {
			[Export ("message")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("message")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("message")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MessageColor {
			[Export ("messageColor")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("messageColor")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageColor")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual sbyte Position {
			[Export ("position")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.SByte_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				} else {
					return global::ApiDefinition.Messaging.SByte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("position"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowClose {
			[Export ("showClose")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showClose"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showClose"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowCloseButton {
			[Export ("showCloseButton")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showCloseButton"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showCloseButton"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Tablet {
			[Export ("tablet")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("tablet"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tablet"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint TimeToLive {
			[Export ("timeToLive")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timeToLive"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timeToLive"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TitleColor {
			[Export ("titleColor")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("titleColor")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleColor")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int TotalDailyCount {
			[Export ("totalDailyCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("totalDailyCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalDailyCount"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int TotalLifetimeCount {
			[Export ("totalLifetimeCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("totalLifetimeCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalLifetimeCount"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("type")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Url {
			[Export ("url")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("url")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("url")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Width {
			[Export ("width")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("width"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float WidthPercent {
			[Export ("widthPercent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("widthPercent"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("widthPercent"));
				}
			}
		}
	} /* class CTInAppNotification */
}
