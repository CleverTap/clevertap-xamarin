#define DEBUG 1
#include <xamarin/xamarin.h>
#include "registrar.h"
extern "C" {
static id native_to_managed_trampoline_1 (id self, SEL _cmd, MonoMethod **managed_method_ptr, bool* call_super, uint32_t token_ref)
{
	MonoClass *declaring_type = NULL;
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	bool has_nsobject = xamarin_has_nsobject (self, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	if (has_nsobject) {
		*call_super = true;
		goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	declaring_type = mono_method_get_class (managed_method);
	mthis = xamarin_new_nsobject (self, declaring_type, &exception_gchandle);
	xamarin_mono_object_release (&declaring_type);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

exception_handling:
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return self;
}


static id native_to_managed_trampoline_2 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	MonoObject *retval = NULL;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	id res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_waypoint ();
		[retobj retain];
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:
	xamarin_mono_object_release (&retval);
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return res;
}


static void native_to_managed_trampoline_3 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoClass *paramclass0 = NULL;
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype0, 0, true);
			goto exception_handling;
		}
		paramclass0 = mono_class_from_mono_type (paramtype0);
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, paramclass0, managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

exception_handling:
	xamarin_mono_object_release (&paramtype0);
	xamarin_mono_object_release (&mobj0);
	xamarin_mono_object_release (&paramclass0);
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return;
}


static BOOL native_to_managed_trampoline_4 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, id p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoClass *paramclass0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoClass *paramclass1 = NULL;
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	MonoObject *retval = NULL;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype0, 0, true);
			goto exception_handling;
		}
		paramclass0 = mono_class_from_mono_type (paramtype0);
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, paramclass0, managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype1, 1, true);
			goto exception_handling;
		}
		paramclass1 = mono_class_from_mono_type (paramtype1);
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, paramclass1, managed_method);
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:
	xamarin_mono_object_release (&paramtype0);
	xamarin_mono_object_release (&mobj0);
	xamarin_mono_object_release (&paramclass0);
	xamarin_mono_object_release (&paramtype1);
	xamarin_mono_object_release (&mobj1);
	xamarin_mono_object_release (&paramclass1);
	xamarin_mono_object_release (&retval);
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return res;
}


static void native_to_managed_trampoline_5 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, id p1, id p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoClass *paramclass0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoClass *paramclass1 = NULL;
	NSObject *nsobj2 = NULL;
	MonoObject *mobj2 = NULL;
	int32_t created2 = false;
	MonoType *paramtype2 = NULL;
	MonoClass *paramclass2 = NULL;
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype0, 0, true);
			goto exception_handling;
		}
		paramclass0 = mono_class_from_mono_type (paramtype0);
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, paramclass0, managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype1, 1, true);
			goto exception_handling;
		}
		paramclass1 = mono_class_from_mono_type (paramtype1);
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, paramclass1, managed_method);
	}
	arg_ptrs [1] = mobj1;
	nsobj2 = (NSObject *) p2;
	if (nsobj2) {
		paramtype2 = xamarin_get_parameter_type (managed_method, 2);
		mobj2 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj2, false, paramtype2, &created2, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype2, 2, true);
			goto exception_handling;
		}
		paramclass2 = mono_class_from_mono_type (paramtype2);
		xamarin_verify_parameter (mobj2, _cmd, self, nsobj2, 2, paramclass2, managed_method);
	}
	arg_ptrs [2] = mobj2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

exception_handling:
	xamarin_mono_object_release (&paramtype0);
	xamarin_mono_object_release (&mobj0);
	xamarin_mono_object_release (&paramclass0);
	xamarin_mono_object_release (&paramtype1);
	xamarin_mono_object_release (&mobj1);
	xamarin_mono_object_release (&paramclass1);
	xamarin_mono_object_release (&paramtype2);
	xamarin_mono_object_release (&mobj2);
	xamarin_mono_object_release (&paramclass2);
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return;
}


static void native_to_managed_trampoline_6 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	}
	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

exception_handling:
	xamarin_mono_object_release (&mthis);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return;
}


static void native_to_managed_trampoline_7 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoClass *paramclass0 = NULL;
	MonoObject *exception = NULL;
	MonoObject **exception_ptr = xamarin_is_managed_exception_marshaling_disabled () ? NULL : &exception;
	GCHandle exception_gchandle = INVALID_GCHANDLE;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MonoReflectionMethod *reflection_method = NULL;
	MONO_ASSERT_GC_SAFE_OR_DETACHED;
	MONO_THREAD_ATTACH;

	if (!managed_method) {
		GCHandle reflection_method_handle = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		reflection_method = (MonoReflectionMethod *) xamarin_gchandle_unwrap (reflection_method_handle);
		if (exception_gchandle != INVALID_GCHANDLE) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
		xamarin_mono_object_release_at_process_exit (managed_method);
	}
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != INVALID_GCHANDLE) {
			exception_gchandle = xamarin_get_exception_for_parameter (8029, exception_gchandle, "Unable to marshal the parameter", _cmd, managed_method, paramtype0, 0, true);
			goto exception_handling;
		}
		paramclass0 = mono_class_from_mono_type (paramtype0);
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, paramclass0, managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, NULL, arg_ptrs, exception_ptr);
	if (exception != NULL) goto exception_handling;

exception_handling:
	xamarin_mono_object_release (&paramtype0);
	xamarin_mono_object_release (&mobj0);
	xamarin_mono_object_release (&paramclass0);
	xamarin_mono_object_release (&reflection_method);

	MONO_THREAD_DETACH;
	if (exception_gchandle != INVALID_GCHANDLE)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	xamarin_process_managed_exception (exception);
	return;
}




#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation Microsoft_iOS__UIKit_UIApplicationDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x3330C);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop

@implementation AppDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(GCHandle) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(bool) xamarinSetGCHandle: (GCHandle) gc_handle flags: (enum XamarinGCHandleFlags) flags
	{
		if (((flags & XamarinGCHandleFlags_InitialSet) == XamarinGCHandleFlags_InitialSet) && __monoObjectGCHandle.gc_handle != INVALID_GCHANDLE) {
			return false;
		}
		flags = (enum XamarinGCHandleFlags) (flags & ~XamarinGCHandleFlags_InitialSet);
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.flags = flags;
		__monoObjectGCHandle.native_object = self;
		return true;
	}

	-(enum XamarinGCHandleFlags) xamarinGetFlags
	{
		return __monoObjectGCHandle.flags;
	}

	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags
	{
		__monoObjectGCHandle.flags = flags;
	}


	-(UIWindow *) window
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, 0x302);
	}

	-(void) setWindow:(UIWindow *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0x402);
	}

	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_4 (self, _cmd, &managed_method, p0, p1, 0x502);
	}
	-(BOOL) conformsToProtocol: (void *) protocol
	{
		GCHandle exception_gchandle;
		BOOL rv = xamarin_invoke_conforms_to_protocol (self, (Protocol *) protocol, &exception_gchandle);
		xamarin_process_managed_exception_gchandle (exception_gchandle);
		return rv;
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x702);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation SceneDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(GCHandle) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(bool) xamarinSetGCHandle: (GCHandle) gc_handle flags: (enum XamarinGCHandleFlags) flags
	{
		if (((flags & XamarinGCHandleFlags_InitialSet) == XamarinGCHandleFlags_InitialSet) && __monoObjectGCHandle.gc_handle != INVALID_GCHANDLE) {
			return false;
		}
		flags = (enum XamarinGCHandleFlags) (flags & ~XamarinGCHandleFlags_InitialSet);
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.flags = flags;
		__monoObjectGCHandle.native_object = self;
		return true;
	}

	-(enum XamarinGCHandleFlags) xamarinGetFlags
	{
		return __monoObjectGCHandle.flags;
	}

	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags
	{
		__monoObjectGCHandle.flags = flags;
	}


	-(UIWindow *) window
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, 0x802);
	}

	-(void) setWindow:(UIWindow *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0x902);
	}

	-(void) scene:(UIScene *)p0 willConnectToSession:(UISceneSession *)p1 options:(UISceneConnectionOptions *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_5 (self, _cmd, &managed_method, p0, p1, p2, 0xA02);
	}

	-(void) sceneDidDisconnect:(UIScene *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0xB02);
	}

	-(void) sceneDidBecomeActive:(UIScene *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0xC02);
	}

	-(void) sceneWillResignActive:(UIScene *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0xD02);
	}

	-(void) sceneWillEnterForeground:(UIScene *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0xE02);
	}

	-(void) sceneDidEnterBackground:(UIScene *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, p0, 0xF02);
	}
	-(BOOL) conformsToProtocol: (void *) protocol
	{
		GCHandle exception_gchandle;
		BOOL rv = xamarin_invoke_conforms_to_protocol (self, (Protocol *) protocol, &exception_gchandle);
		xamarin_process_managed_exception_gchandle (exception_gchandle);
		return rv;
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x1002);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIResponder class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end






#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x16F04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop


#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapDomainDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x17604);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop




#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x1A204);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop


#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x1AA04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop






#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x23A04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop





#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x2A704);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop


#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapPushNotificationDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x2AF04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop


#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapSyncDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x2B704);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop



#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CleverTapURLDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x2CB04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop





#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CTIdentityRepo {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x33B04);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop






#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x3E904);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop



#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wprotocol"
#pragma clang diagnostic ignored "-Wobjc-protocol-property-synthesis"
#pragma clang diagnostic ignored "-Wobjc-property-implementation"
@implementation ApiDefinition__CleverTapSDK_CTInAppPassThroughViewDelegate {
}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x40704);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end
#pragma clang diagnostic pop



















@implementation UIKit_UIView_UIViewAppearance {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(GCHandle) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(bool) xamarinSetGCHandle: (GCHandle) gc_handle flags: (enum XamarinGCHandleFlags) flags
	{
		if (((flags & XamarinGCHandleFlags_InitialSet) == XamarinGCHandleFlags_InitialSet) && __monoObjectGCHandle.gc_handle != INVALID_GCHANDLE) {
			return false;
		}
		flags = (enum XamarinGCHandleFlags) (flags & ~XamarinGCHandleFlags_InitialSet);
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.flags = flags;
		__monoObjectGCHandle.native_object = self;
		return true;
	}

	-(enum XamarinGCHandleFlags) xamarinGetFlags
	{
		return __monoObjectGCHandle.flags;
	}

	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags
	{
		__monoObjectGCHandle.flags = flags;
	}

	-(BOOL) conformsToProtocol: (void *) protocol
	{
		GCHandle exception_gchandle;
		BOOL rv = xamarin_invoke_conforms_to_protocol (self, (Protocol *) protocol, &exception_gchandle);
		xamarin_process_managed_exception_gchandle (exception_gchandle);
		return rv;
	}
@end

@implementation CleverTapSDK_CTInAppPassThroughView_CTInAppPassThroughViewAppearance {
}
@end

@implementation UIKit_UIWindow_UIWindowAppearance {
}
@end

@implementation CleverTapSDK_CTInAppPassThroughWindow_CTInAppPassThroughWindowAppearance {
}
@end

@interface Foundation_NSDispatcher : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) xamarinApplySelector;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation Foundation_NSDispatcher {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(GCHandle) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(bool) xamarinSetGCHandle: (GCHandle) gc_handle flags: (enum XamarinGCHandleFlags) flags
	{
		if (((flags & XamarinGCHandleFlags_InitialSet) == XamarinGCHandleFlags_InitialSet) && __monoObjectGCHandle.gc_handle != INVALID_GCHANDLE) {
			return false;
		}
		flags = (enum XamarinGCHandleFlags) (flags & ~XamarinGCHandleFlags_InitialSet);
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.flags = flags;
		__monoObjectGCHandle.native_object = self;
		return true;
	}

	-(enum XamarinGCHandleFlags) xamarinGetFlags
	{
		return __monoObjectGCHandle.flags;
	}

	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags
	{
		__monoObjectGCHandle.flags = flags;
	}


	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, 0x15C0C);
	}
	-(BOOL) conformsToProtocol: (void *) protocol
	{
		GCHandle exception_gchandle;
		BOOL rv = xamarin_invoke_conforms_to_protocol (self, (Protocol *) protocol, &exception_gchandle);
		xamarin_process_managed_exception_gchandle (exception_gchandle);
		return rv;
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x15B0C);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface __MonoMac_NSSynchronizationContextDispatcher : Foundation_NSDispatcher {
}
	-(void) xamarinApplySelector;
@end

@implementation __MonoMac_NSSynchronizationContextDispatcher {
}

	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, 0x15E0C);
	}
@end

@interface Foundation_NSAsyncDispatcher : Foundation_NSDispatcher {
}
	-(void) xamarinApplySelector;
	-(id) init;
@end

@implementation Foundation_NSAsyncDispatcher {
}

	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, 0x1600C);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x15F0C);
		if (call_super && rv) {
			struct objc_super super = {  rv, [Foundation_NSDispatcher class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface __MonoMac_NSAsyncSynchronizationContextDispatcher : Foundation_NSAsyncDispatcher {
}
	-(void) xamarinApplySelector;
@end

@implementation __MonoMac_NSAsyncSynchronizationContextDispatcher {
}

	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_6 (self, _cmd, &managed_method, 0x1620C);
	}
@end

@interface __NSObject_Disposer : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	+(void) drain:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation __NSObject_Disposer {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(GCHandle) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(bool) xamarinSetGCHandle: (GCHandle) gc_handle flags: (enum XamarinGCHandleFlags) flags
	{
		if (((flags & XamarinGCHandleFlags_InitialSet) == XamarinGCHandleFlags_InitialSet) && __monoObjectGCHandle.gc_handle != INVALID_GCHANDLE) {
			return false;
		}
		flags = (enum XamarinGCHandleFlags) (flags & ~XamarinGCHandleFlags_InitialSet);
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.flags = flags;
		__monoObjectGCHandle.native_object = self;
		return true;
	}

	-(enum XamarinGCHandleFlags) xamarinGetFlags
	{
		return __monoObjectGCHandle.flags;
	}

	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags
	{
		__monoObjectGCHandle.flags = flags;
	}


	+(void) drain:(NSObject *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_7 (self, _cmd, &managed_method, p0, 0x22A0C);
	}
	-(BOOL) conformsToProtocol: (void *) protocol
	{
		GCHandle exception_gchandle;
		BOOL rv = xamarin_invoke_conforms_to_protocol (self, (Protocol *) protocol, &exception_gchandle);
		xamarin_process_managed_exception_gchandle (exception_gchandle);
		return rv;
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_1 (self, _cmd, &managed_method, &call_super, 0x2270C);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

	static MTClassMap __xamarin_class_map [] = {
		{ NULL, 0x330C /* #0 'NSObject' => 'Foundation.NSObject, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x6C0C /* #1 'Microsoft_iOS__UIKit_UIApplicationDelegate' => 'UIKit.UIApplicationDelegate, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x302 /* #2 'AppDelegate' => 'StarterDotNet.AppDelegate, StarterDotNet' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0x730C /* #3 'UIResponder' => 'UIKit.UIResponder, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x402 /* #4 'SceneDelegate' => 'StarterDotNet.SceneDelegate, StarterDotNet' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0x1F04 /* #5 'ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate' => 'CleverTapSDK.CleverTapDisplayUnitDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x2304 /* #6 'ApiDefinition__CleverTapSDK_CleverTapDomainDelegate' => 'CleverTapSDK.CleverTapDomainDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x2F04 /* #7 'ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate' => 'CleverTapSDK.CleverTapFeatureFlagsDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x3304 /* #8 'ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate' => 'CleverTapSDK.CleverTapInAppNotificationDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x690C /* #9 'UIViewController' => 'UIKit.UIViewController, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x790C /* #10 'UITableViewController' => 'UIKit.UITableViewController, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x4604 /* #11 'ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate' => 'CleverTapSDK.CleverTapInboxViewControllerDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x5704 /* #12 'ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate' => 'CleverTapSDK.CleverTapProductConfigDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x5B04 /* #13 'ApiDefinition__CleverTapSDK_CleverTapPushNotificationDelegate' => 'CleverTapSDK.CleverTapPushNotificationDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x5F04 /* #14 'ApiDefinition__CleverTapSDK_CleverTapSyncDelegate' => 'CleverTapSDK.CleverTapSyncDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x6604 /* #15 'ApiDefinition__CleverTapSDK_CleverTapURLDelegate' => 'CleverTapSDK.CleverTapURLDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x7604 /* #16 'ApiDefinition__CleverTapSDK_CTIdentityRepo' => 'CleverTapSDK.CTIdentityRepo, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x8A04 /* #17 'ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate' => 'CleverTapSDK.CTInAppNotificationDisplayDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x9104 /* #18 'ApiDefinition__CleverTapSDK_CTInAppPassThroughViewDelegate' => 'CleverTapSDK.CTInAppPassThroughViewDelegate, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (1) /* CustomType */ },
		{ NULL, 0x5D0C /* #19 'Microsoft_iOS__UIKit_UIAppearance' => 'UIKit.UIAppearance, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x680C /* #20 'UIKit_UIView_UIViewAppearance' => 'UIKit.UIView+UIViewAppearance, Microsoft.iOS' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0xF304 /* #21 'CleverTapSDK_CTInAppPassThroughView_CTInAppPassThroughViewAppearance' => 'CleverTapSDK.CTInAppPassThroughView+CTInAppPassThroughViewAppearance, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0x670C /* #22 'UIView' => 'UIKit.UIView, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x6B0C /* #23 'UIKit_UIWindow_UIWindowAppearance' => 'UIKit.UIWindow+UIWindowAppearance, Microsoft.iOS' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0xF404 /* #24 'CleverTapSDK_CTInAppPassThroughWindow_CTInAppPassThroughWindowAppearance' => 'CleverTapSDK.CTInAppPassThroughWindow+CTInAppPassThroughWindowAppearance, CleverTap.DotNet.iOS.Binding' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0x6A0C /* #25 'UIWindow' => 'UIKit.UIWindow, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0xF0C /* #26 'WKScriptMessage' => 'WebKit.WKScriptMessage, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x120C /* #27 'WKUserContentController' => 'WebKit.WKUserContentController, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x190C /* #28 'Foundation_NSDispatcher' => 'Foundation.NSDispatcher, Microsoft.iOS' */, (MTTypeFlags) (2) /* UserType */ },
		{ NULL, 0x1A0C /* #29 '__MonoMac_NSSynchronizationContextDispatcher' => 'Foundation.NSSynchronizationContextDispatcher, Microsoft.iOS' */, (MTTypeFlags) (2) /* UserType */ },
		{ NULL, 0x1B0C /* #30 'Foundation_NSAsyncDispatcher' => 'Foundation.NSAsyncDispatcher, Microsoft.iOS' */, (MTTypeFlags) (2) /* UserType */ },
		{ NULL, 0x1C0C /* #31 '__MonoMac_NSAsyncSynchronizationContextDispatcher' => 'Foundation.NSAsyncSynchronizationContextDispatcher, Microsoft.iOS' */, (MTTypeFlags) (2) /* UserType */ },
		{ NULL, 0x1D0C /* #32 'NSArray' => 'Foundation.NSArray, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x1F0C /* #33 'NSBundle' => 'Foundation.NSBundle, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x210C /* #34 'NSCalendar' => 'Foundation.NSCalendar, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x220C /* #35 'NSCoder' => 'Foundation.NSCoder, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x250C /* #36 'NSDate' => 'Foundation.NSDate, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x2A0C /* #37 'NSError' => 'Foundation.NSError, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x4E0C /* #38 'NSMutableArray' => 'Foundation.NSMutableArray, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x310C /* #39 'NSNull' => 'Foundation.NSNull, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x410C /* #40 'NSValue' => 'Foundation.NSValue, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x320C /* #41 'NSNumber' => 'Foundation.NSNumber, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x3A0C /* #42 'NSRunLoop' => 'Foundation.NSRunLoop, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x3B0C /* #43 'NSSet' => 'Foundation.NSSet, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x3E0C /* #44 'NSString' => 'Foundation.NSString, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x3F0C /* #45 'NSTimeZone' => 'Foundation.NSTimeZone, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x400C /* #46 'NSURL' => 'Foundation.NSUrl, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x470C /* #47 'NSAutoreleasePool' => 'Foundation.NSAutoreleasePool, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x4B0C /* #48 'NSEnumerator' => 'Foundation.NSEnumerator, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x4C0C /* #49 'NSException' => 'Foundation.NSException, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x4D0C /* #50 'NSInvocation' => 'Foundation.NSInvocation, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x500C /* #51 'NSUserActivity' => 'Foundation.NSUserActivity, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x5C0C /* #52 'CKShareMetadata' => 'CloudKit.CKShareMetadata, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x5F0C /* #53 'UIApplication' => 'UIKit.UIApplication, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x620C /* #54 'UIControl' => 'UIKit.UIControl, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x600C /* #55 'UIButton' => 'UIKit.UIButton, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x610C /* #56 'UIColor' => 'UIKit.UIColor, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x630C /* #57 'UIImage' => 'UIKit.UIImage, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x650C /* #58 'UIScreen' => 'UIKit.UIScreen, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x660C /* #59 'UITraitCollection' => 'UIKit.UITraitCollection, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x6D0C /* #60 'UIApplicationShortcutItem' => 'UIKit.UIApplicationShortcutItem, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x710C /* #61 'UILabel' => 'UIKit.UILabel, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x720C /* #62 'UIOpenURLContext' => 'UIKit.UIOpenUrlContext, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x740C /* #63 'UIScene' => 'UIKit.UIScene, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x750C /* #64 'UISceneConnectionOptions' => 'UIKit.UISceneConnectionOptions, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x780C /* #65 'UISceneSession' => 'UIKit.UISceneSession, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x7C0C /* #66 'UIWindowScene' => 'UIKit.UIWindowScene, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x230C /* #67 'NSData' => 'Foundation.NSData, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x260C /* #68 'NSDictionary' => 'Foundation.NSDictionary, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x2F0C /* #69 'NSMutableDictionary' => 'Foundation.NSMutableDictionary, Microsoft.iOS' */, (MTTypeFlags) (0) /* None */ },
		{ NULL, 0x370C /* #70 '__NSObject_Disposer' => 'Foundation.NSObject+NSObject_Disposer, Microsoft.iOS' */, (MTTypeFlags) (3) /* CustomType, UserType */ },
		{ NULL, 0 },
	};

	static const MTManagedClassMap __xamarin_skipped_map [] = {
		{ 0x1E0C, 0x1D0C /* 'Foundation.NSArray`1' => 'Foundation.NSArray' */ },
		{ 0x280C, 0x260C /* 'Foundation.NSDictionary`2' => 'Foundation.NSDictionary' */ },
		{ 0x2E0C, 0x4E0C /* 'Foundation.NSMutableArray`1' => 'Foundation.NSMutableArray' */ },
		{ 0x3D0C, 0x3B0C /* 'Foundation.NSSet`1' => 'Foundation.NSSet' */ },
	};

	static const MTAssembly __xamarin_registration_assemblies [] = {
		{ "aot-instances", "42b48a5c-01c3-4445-a2a8-9e9de4943073" }, 
		{ "StarterDotNet", "ed79d0ab-a224-47af-9dd2-46080756f4d1" }, 
		{ "CleverTap.DotNet.iOS.Binding", "4d2b04ae-4f2e-47b1-b252-64c2266dbfc8" }, 
		{ "System.Runtime.InteropServices", "42738490-6d3c-47d7-be95-6a1b34b28dc9" }, 
		{ "System.Runtime", "01994a86-1188-4f29-a782-2ff6d0241fe6" }, 
		{ "System.Private.CoreLib", "60761b23-3d9e-4d53-bbce-cb235e30d490" }, 
		{ "Microsoft.iOS", "26da26c4-3032-4a39-989c-cbc0b86e9372" }
	};

	static const MTProtocolWrapperMap __xamarin_protocol_wrapper_map [] = {
		{ 0xC04 /* CleverTapSDK.ICleverTap */, 0xE04 /* CleverTapWrapper */ },
		{ 0x1004 /* CleverTapSDK.ICleverTapConfigValue */, 0x1204 /* CleverTapConfigValueWrapper */ },
		{ 0x100C /* WebKit.IWKScriptMessageHandler */, 0x110C /* WKScriptMessageHandlerWrapper */ },
		{ 0x1404 /* CleverTapSDK.ICleverTapDisplayUnit */, 0x1604 /* CleverTapDisplayUnitWrapper */ },
		{ 0x1804 /* CleverTapSDK.ICleverTapDisplayUnitContent */, 0x1A04 /* CleverTapDisplayUnitContentWrapper */ },
		{ 0x1C04 /* CleverTapSDK.ICleverTapDisplayUnitDelegate */, 0x1E04 /* CleverTapDisplayUnitDelegateWrapper */ },
		{ 0x2004 /* CleverTapSDK.ICleverTapDomainDelegate */, 0x2204 /* CleverTapDomainDelegateWrapper */ },
		{ 0x2404 /* CleverTapSDK.ICleverTapEventDetail */, 0x2604 /* CleverTapEventDetailWrapper */ },
		{ 0x2804 /* CleverTapSDK.ICleverTapFeatureFlags */, 0x2A04 /* CleverTapFeatureFlagsWrapper */ },
		{ 0x2C04 /* CleverTapSDK.ICleverTapFeatureFlagsDelegate */, 0x2E04 /* CleverTapFeatureFlagsDelegateWrapper */ },
		{ 0x3004 /* CleverTapSDK.ICleverTapInAppNotificationDelegate */, 0x3204 /* CleverTapInAppNotificationDelegateWrapper */ },
		{ 0x3404 /* CleverTapSDK.ICleverTapInboxMessage */, 0x3604 /* CleverTapInboxMessageWrapper */ },
		{ 0x3804 /* CleverTapSDK.ICleverTapInboxMessageContent */, 0x3A04 /* CleverTapInboxMessageContentWrapper */ },
		{ 0x3C04 /* CleverTapSDK.ICleverTapInboxStyleConfig */, 0x3E04 /* CleverTapInboxStyleConfigWrapper */ },
		{ 0x4004 /* CleverTapSDK.ICleverTapInboxViewController */, 0x4104 /* CleverTapInboxViewControllerWrapper */ },
		{ 0x4304 /* CleverTapSDK.ICleverTapInboxViewControllerDelegate */, 0x4504 /* CleverTapInboxViewControllerDelegateWrapper */ },
		{ 0x4804 /* CleverTapSDK.ICleverTapInstanceConfig */, 0x4A04 /* CleverTapInstanceConfigWrapper */ },
		{ 0x490C /* Foundation.INSCopying */, 0x4A0C /* NSCopyingWrapper */ },
		{ 0x4C04 /* CleverTapSDK.ICleverTapJSInterface */, 0x4E04 /* CleverTapJSInterfaceWrapper */ },
		{ 0x5004 /* CleverTapSDK.ICleverTapProductConfig */, 0x5204 /* CleverTapProductConfigWrapper */ },
		{ 0x5404 /* CleverTapSDK.ICleverTapProductConfigDelegate */, 0x5604 /* CleverTapProductConfigDelegateWrapper */ },
		{ 0x5804 /* CleverTapSDK.ICleverTapPushNotificationDelegate */, 0x5A04 /* CleverTapPushNotificationDelegateWrapper */ },
		{ 0x5C04 /* CleverTapSDK.ICleverTapSyncDelegate */, 0x5E04 /* CleverTapSyncDelegateWrapper */ },
		{ 0x6004 /* CleverTapSDK.ICleverTapTrackedViewController */, 0x6204 /* CleverTapTrackedViewControllerWrapper */ },
		{ 0x6404 /* CleverTapSDK.ICleverTapURLDelegate */, 0x6504 /* CleverTapURLDelegateWrapper */ },
		{ 0x6704 /* CleverTapSDK.ICleverTapUTMDetail */, 0x6904 /* CleverTapUTMDetailWrapper */ },
		{ 0x6C04 /* CleverTapSDK.ICTDeviceInfo */, 0x6E04 /* CTDeviceInfoWrapper */ },
		{ 0x6E0C /* UIKit.IUICoordinateSpace */, 0x6F0C /* UICoordinateSpaceWrapper */ },
		{ 0x7004 /* CleverTapSDK.ICTEventBuilder */, 0x7104 /* CTEventBuilderWrapper */ },
		{ 0x7304 /* CleverTapSDK.ICTFlexibleIdentityRepo */, 0x7404 /* CTFlexibleIdentityRepoWrapper */ },
		{ 0x760C /* UIKit.IUISceneDelegate */, 0x770C /* UISceneDelegateWrapper */ },
		{ 0x7704 /* CleverTapSDK.ICTIdentityRepoFactory */, 0x7804 /* CTIdentityRepoFactoryWrapper */ },
		{ 0x7B04 /* CleverTapSDK.ICTInAppDisplayViewController */, 0x7D04 /* CTInAppDisplayViewControllerWrapper */ },
		{ 0x7D0C /* UIKit.IUIWindowSceneDelegate */, 0x7E0C /* UIWindowSceneDelegateWrapper */ },
		{ 0x7F04 /* CleverTapSDK.ICTInAppFCManager */, 0x8104 /* CTInAppFCManagerWrapper */ },
		{ 0x8304 /* CleverTapSDK.ICTInAppNotification */, 0x8504 /* CTInAppNotificationWrapper */ },
		{ 0x8704 /* CleverTapSDK.ICTInAppNotificationDisplayDelegate */, 0x8904 /* CTInAppNotificationDisplayDelegateWrapper */ },
		{ 0x8B04 /* CleverTapSDK.ICTInAppPassThroughView */, 0x8D04 /* CTInAppPassThroughViewWrapper */ },
		{ 0x8F04 /* CleverTapSDK.ICTInAppPassThroughViewDelegate */, 0x9004 /* CTInAppPassThroughViewDelegateWrapper */ },
		{ 0x9204 /* CleverTapSDK.ICTInAppPassThroughWindow */, 0x9304 /* CTInAppPassThroughWindowWrapper */ },
		{ 0x9504 /* CleverTapSDK.ICTInAppUtils */, 0x9604 /* CTInAppUtilsWrapper */ },
		{ 0x9804 /* CleverTapSDK.ICTKnownProfileFields */, 0x9904 /* CTKnownProfileFieldsWrapper */ },
		{ 0x9B04 /* CleverTapSDK.ICTLegacyIdentityRepo */, 0x9C04 /* CTLegacyIdentityRepoWrapper */ },
		{ 0x9E04 /* CleverTapSDK.ICTLocalDataStore */, 0xA004 /* CTLocalDataStoreWrapper */ },
		{ 0xA204 /* CleverTapSDK.ICTLocationManager */, 0xA304 /* CTLocationManagerWrapper */ },
		{ 0xA504 /* CleverTapSDK.ICTLogger */, 0xA604 /* CTLoggerWrapper */ },
		{ 0xA804 /* CleverTapSDK.ICTLoginInfoProvider */, 0xAA04 /* CTLoginInfoProviderWrapper */ },
		{ 0xAC04 /* CleverTapSDK.ICTNotificationButton */, 0xAE04 /* CTNotificationButtonWrapper */ },
		{ 0xB004 /* CleverTapSDK.ICTPlistInfo */, 0xB204 /* CTPlistInfoWrapper */ },
		{ 0xB404 /* CleverTapSDK.ICTPreferences */, 0xB504 /* CTPreferencesWrapper */ },
		{ 0xB704 /* CleverTapSDK.ICTProfileBuilder */, 0xB804 /* CTProfileBuilderWrapper */ },
		{ 0xBA04 /* CleverTapSDK.ICTUIUtils */, 0xBB04 /* CTUIUtilsWrapper */ },
		{ 0xBD04 /* CleverTapSDK.ICTUriHelper */, 0xBE04 /* CTUriHelperWrapper */ },
		{ 0xC004 /* CleverTapSDK.ICTUtils */, 0xC104 /* CTUtilsWrapper */ },
		{ 0xC304 /* CleverTapSDK.ICTValidationResult */, 0xC504 /* CTValidationResultWrapper */ },
		{ 0xC704 /* CleverTapSDK.ICTValidationResultStack */, 0xC904 /* CTValidationResultStackWrapper */ },
		{ 0xCB04 /* CleverTapSDK.ICTValidator */, 0xCC04 /* CTValidatorWrapper */ },
	};

	static struct MTRegistrationMap __xamarin_registration_map = {
		"2cb9d6666fb84a59e149049f20fee18de0902129",
		__xamarin_registration_assemblies,
		__xamarin_class_map,
		NULL,
		__xamarin_skipped_map,
		__xamarin_protocol_wrapper_map,
		{ NULL, NULL },
		7,
		71,
		0,
		4,
		57,
		0
	};

void xamarin_create_classes () {
	__xamarin_class_map [0].handle = objc_getClass ("NSObject");
	__xamarin_class_map [1].handle = objc_getClass ("Microsoft_iOS__UIKit_UIApplicationDelegate");
	__xamarin_class_map [2].handle = [AppDelegate class];
	__xamarin_class_map [3].handle = objc_getClass ("UIResponder");
	__xamarin_class_map [4].handle = [SceneDelegate class];
	__xamarin_class_map [5].handle = [ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate class];
	__xamarin_class_map [6].handle = [ApiDefinition__CleverTapSDK_CleverTapDomainDelegate class];
	__xamarin_class_map [7].handle = [ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate class];
	__xamarin_class_map [8].handle = [ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate class];
	__xamarin_class_map [9].handle = objc_getClass ("UIViewController");
	__xamarin_class_map [10].handle = objc_getClass ("UITableViewController");
	__xamarin_class_map [11].handle = [ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate class];
	__xamarin_class_map [12].handle = [ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate class];
	__xamarin_class_map [13].handle = [ApiDefinition__CleverTapSDK_CleverTapPushNotificationDelegate class];
	__xamarin_class_map [14].handle = [ApiDefinition__CleverTapSDK_CleverTapSyncDelegate class];
	__xamarin_class_map [15].handle = [ApiDefinition__CleverTapSDK_CleverTapURLDelegate class];
	__xamarin_class_map [16].handle = [ApiDefinition__CleverTapSDK_CTIdentityRepo class];
	__xamarin_class_map [17].handle = [ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate class];
	__xamarin_class_map [18].handle = [ApiDefinition__CleverTapSDK_CTInAppPassThroughViewDelegate class];
	__xamarin_class_map [19].handle = objc_getClass ("Microsoft_iOS__UIKit_UIAppearance");
	__xamarin_class_map [20].handle = objc_getClass ("UIKit_UIView_UIViewAppearance");
	__xamarin_class_map [21].handle = [CleverTapSDK_CTInAppPassThroughView_CTInAppPassThroughViewAppearance class];
	__xamarin_class_map [22].handle = objc_getClass ("UIView");
	__xamarin_class_map [23].handle = objc_getClass ("UIKit_UIWindow_UIWindowAppearance");
	__xamarin_class_map [24].handle = [CleverTapSDK_CTInAppPassThroughWindow_CTInAppPassThroughWindowAppearance class];
	__xamarin_class_map [25].handle = objc_getClass ("UIWindow");
	__xamarin_class_map [26].handle = objc_getClass ("WKScriptMessage");
	__xamarin_class_map [27].handle = objc_getClass ("WKUserContentController");
	__xamarin_class_map [28].handle = objc_getClass ("Foundation_NSDispatcher");
	__xamarin_class_map [29].handle = objc_getClass ("__MonoMac_NSSynchronizationContextDispatcher");
	__xamarin_class_map [30].handle = objc_getClass ("Foundation_NSAsyncDispatcher");
	__xamarin_class_map [31].handle = objc_getClass ("__MonoMac_NSAsyncSynchronizationContextDispatcher");
	__xamarin_class_map [32].handle = objc_getClass ("NSArray");
	__xamarin_class_map [33].handle = objc_getClass ("NSBundle");
	__xamarin_class_map [34].handle = objc_getClass ("NSCalendar");
	__xamarin_class_map [35].handle = objc_getClass ("NSCoder");
	__xamarin_class_map [36].handle = objc_getClass ("NSDate");
	__xamarin_class_map [37].handle = objc_getClass ("NSError");
	__xamarin_class_map [38].handle = objc_getClass ("NSMutableArray");
	__xamarin_class_map [39].handle = objc_getClass ("NSNull");
	__xamarin_class_map [40].handle = objc_getClass ("NSValue");
	__xamarin_class_map [41].handle = objc_getClass ("NSNumber");
	__xamarin_class_map [42].handle = objc_getClass ("NSRunLoop");
	__xamarin_class_map [43].handle = objc_getClass ("NSSet");
	__xamarin_class_map [44].handle = objc_getClass ("NSString");
	__xamarin_class_map [45].handle = objc_getClass ("NSTimeZone");
	__xamarin_class_map [46].handle = objc_getClass ("NSURL");
	__xamarin_class_map [47].handle = objc_getClass ("NSAutoreleasePool");
	__xamarin_class_map [48].handle = objc_getClass ("NSEnumerator");
	__xamarin_class_map [49].handle = objc_getClass ("NSException");
	__xamarin_class_map [50].handle = objc_getClass ("NSInvocation");
	__xamarin_class_map [51].handle = objc_getClass ("NSUserActivity");
	__xamarin_class_map [52].handle = objc_getClass ("CKShareMetadata");
	__xamarin_class_map [53].handle = objc_getClass ("UIApplication");
	__xamarin_class_map [54].handle = objc_getClass ("UIControl");
	__xamarin_class_map [55].handle = objc_getClass ("UIButton");
	__xamarin_class_map [56].handle = objc_getClass ("UIColor");
	__xamarin_class_map [57].handle = objc_getClass ("UIImage");
	__xamarin_class_map [58].handle = objc_getClass ("UIScreen");
	__xamarin_class_map [59].handle = objc_getClass ("UITraitCollection");
	__xamarin_class_map [60].handle = objc_getClass ("UIApplicationShortcutItem");
	__xamarin_class_map [61].handle = objc_getClass ("UILabel");
	__xamarin_class_map [62].handle = objc_getClass ("UIOpenURLContext");
	__xamarin_class_map [63].handle = objc_getClass ("UIScene");
	__xamarin_class_map [64].handle = objc_getClass ("UISceneConnectionOptions");
	__xamarin_class_map [65].handle = objc_getClass ("UISceneSession");
	__xamarin_class_map [66].handle = objc_getClass ("UIWindowScene");
	__xamarin_class_map [67].handle = objc_getClass ("NSData");
	__xamarin_class_map [68].handle = objc_getClass ("NSDictionary");
	__xamarin_class_map [69].handle = objc_getClass ("NSMutableDictionary");
	__xamarin_class_map [70].handle = objc_getClass ("__NSObject_Disposer");
	xamarin_add_registration_map (&__xamarin_registration_map, false);
}


} /* extern "C" */
