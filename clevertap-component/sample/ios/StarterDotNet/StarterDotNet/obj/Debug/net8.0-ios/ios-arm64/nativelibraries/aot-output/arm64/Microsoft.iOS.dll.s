.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug
Ldebug_abbrev_start:

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 8,1
	.asciz "Mono AOT Compiler 8.0.3.0 (8.0.324.11423 @Commit: 9f4b1f5d664afdfc80e1508ab7ed099dff210fbd)"
	.asciz "Microsoft.iOS.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,8,5
	.asciz "intptr"
LDIE_U:

	.byte 4,8,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,8,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,8,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,8,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,120,30
	.align 3
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 4
	.no_dead_strip _Module__cctor
_Module__cctor:
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_2
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip Registrar_SharedDynamic_PrepareInterfaceMethodMapping_System_Type
Registrar_SharedDynamic_PrepareInterfaceMethodMapping_System_Type:
.file 1 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/ObjCRuntime/DynamicRegistrar.cs"
.loc 1 29 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xf90023b9
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9002ba0
.word 0xf9002fa0
.word 0xf90033a0
.word 0xf90037a0
.word 0xf9003bbf
.word 0xd2800019
.loc 1 30 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #192]
.word 0xf9400000
.word 0xaa0003e1
.word 0xf94027b8
.word 0xaa0103f7
.word 0xb50006a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400000
.word 0xf9004ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54001f60

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #208]
.word 0xd2801001
bl _p_3
.word 0xf90047a0
.word 0xf9404ba1
.word 0xeb1f003f
.word 0x10000011
.word 0x54001dc0
.word 0xd5033bbf
.word 0xf94047a0
.word 0xf9001001
.word 0x91008002
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #216]
.word 0xf9002001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #224]
.word 0xf9001402
.word 0xf9401822
.word 0xf9000c02
.word 0xf9401421
.word 0xf9000801
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #192]
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000020
.word 0xaa0003f7
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xd2800002
.word 0xf9400303
.word 0xf9406c70
.word 0xd63f0200
.word 0xaa0003f8
.loc 1 35 0
.word 0xd2a00017
.word 0x140000b5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x540016a9
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.loc 1 36 0
.word 0x910143a8
.word 0xf94027a0
.word 0xaa1603e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9409850
.word 0xd63f0200
.loc 1 37 0
.word 0xd2a00016
.word 0x14000098

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 38 0
.word 0xf94037a0
.word 0x93407ec1
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54001389
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400015
.loc 1 39 0
.word 0xf94033a0
.word 0x93407ec1
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54001249
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400014
.loc 1 41 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #232]
.word 0xaa1503e0
bl _p_4
.word 0xb4000ee0
.loc 1 45 0
.word 0xb50005f9
.loc 1 46 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #240]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #248]
.word 0xf90047a0
bl _p_5
.word 0xf94047a0
.word 0xaa0003f9
.loc 1 47 0
.word 0xaa1903e0
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xd2800401
bl _p_3
.word 0xaa0003e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #264]
.word 0xf9400001
.word 0x91004043
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000061
.word 0xd349fc63
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0063

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040063
.word 0xd280003e
.word 0x3900007e
.word 0xf9003ba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #272]
.word 0x3940001e
.word 0xaa1403e1
bl _p_6
.word 0x1400002c
.loc 1 48 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #280]
.word 0x3940033e
.word 0xaa1903e0
.word 0xaa1403e1
.word 0x9101c3a2
bl _p_7
.word 0x53001c00
.word 0x35000440
.loc 1 49 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xd2800401
bl _p_3
.word 0xaa0003e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #264]
.word 0xf9400000
.word 0xf90043a0
.word 0x91004041
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xf9003ba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #272]
.word 0x3940033e
.word 0xaa1903e0
.word 0xaa1403e1
bl _p_6
.loc 1 51 0
.word 0xf9403ba0
.word 0xaa0003f4
.word 0xaa1503f3
.word 0x3940029e
.word 0xb9801e81
.word 0x11000421
.word 0xb9001c01
.word 0xf9400a95
.word 0xb9801a80
.word 0xb9007ba0
.word 0xb9801aa1
.word 0x6b01001f
.word 0x54000142
.word 0xb9807ba1
.word 0x11000420
.word 0xb9001a80
.word 0xaa1503e0
.word 0xaa1303e2
.word 0xf94002a3
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #288]
.word 0xaa1403e0
.word 0xaa1303e1
bl _p_8
.loc 1 37 0
.word 0x110006d6
.word 0xf94037a1
.word 0xb9801820
.word 0x6b0002df
.word 0x54ffeccb
.word 0x110006f7
.loc 1 35 0
.word 0xb9801b00
.word 0x6b0002ff
.word 0x54ffe94b
.loc 1 55 0
.word 0xaa1903e0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xf94023b9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd28009e0
.word 0xaa1103e1
bl _p_9

Lme_1:
.text
	.align 4
	.no_dead_strip Registrar_SharedDynamic_GetOneAttribute_T_REF_System_Reflection_ICustomAttributeProvider
Registrar_SharedDynamic_GetOneAttribute_T_REF_System_Reflection_ICustomAttributeProvider:
.loc 1 60 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf90017af
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #296]
.word 0xf94017a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf94017a0
.word 0xf9401401
.word 0xaa1a03e0
.word 0xd2a00002
.word 0xf9400343

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #304]
.word 0x92800ef0
.word 0xf8706870
.word 0xd63f0200
.word 0xaa0003f9
.loc 1 61 0
.word 0xaa1903e1
.word 0xb9801820
.word 0x35000060
.loc 1 62 0
.word 0xd2800000
.word 0x1400002e
.loc 1 63 0
.word 0xb9801b20
.word 0xd280003e
.word 0x6b1e001f
.word 0x54000161
.loc 1 64 0
.word 0xb9801b20
.word 0xeb1f001f
.word 0x10000011
.word 0x54000ea9
.word 0xf9401320
.word 0xf94017a1
.word 0xf9401022
.word 0xf9400441
bl _p_10
.word 0x14000020
.loc 1 65 0
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #312]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903f8
.loc 1 66 0
.word 0xb50002d9
.loc 1 68 0
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #320]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903f8
.loc 1 69 0
.word 0xb4000799
.word 0x14000020
.loc 1 72 0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 1 67 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800021
bl _p_11
.word 0xf9001ba0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9405c30
.word 0xd63f0200
.word 0xf9001fa0
.word 0xf94017a0
.word 0xf9401401
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_12
.word 0xaa0003e1
.word 0xd2806340
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 1 70 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800ba1
bl _p_11
.word 0xf9001ba0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9405c30
.word 0xd63f0200
.word 0xf9001fa0
.word 0xf94017a0
.word 0xf9401401
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_12
.word 0xaa0003e1
.word 0xd2806340
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0x14000001
.loc 1 72 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800021
bl _p_11
.word 0xf9001ba0
.word 0xf94017a0
.word 0xf9401401
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xaa1a03e1
bl _p_12
.word 0xaa0003e1
.word 0xd2806340
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2:
.text
	.align 4
	.no_dead_strip Registrar_SharedDynamic__c__cctor
Registrar_SharedDynamic__c__cctor:
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xd2800201
bl _p_3
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip Registrar_SharedDynamic__c__ctor
Registrar_SharedDynamic__c__ctor:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip Registrar_SharedDynamic__c__PrepareInterfaceMethodMappingb__0_0_System_Type_object
Registrar_SharedDynamic__c__PrepareInterfaceMethodMappingb__0_0_System_Type_object:
.loc 1 31 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #336]
.word 0xaa1a03e0
.word 0xd2800022
.word 0xf9400343
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003fa
.loc 1 32 0
.word 0xaa1a03e0
.word 0xb40000a0
.word 0xb9801b40
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x14000002
.word 0xd2a00000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_5:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__ctor
Registrar_DynamicRegistrar__ctor:
.loc 1 87 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #344]
.word 0xd2800201
bl _p_3
.word 0xf90023a0
.word 0x91018341
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 89 0
.word 0xaa1a03e0
bl _p_14
.loc 1 91 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf9400000
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #360]
.word 0xd2800901
bl _p_3
.word 0xf9401fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #368]
.word 0xf9001ba0
bl _p_15
.word 0x91012341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 92 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #376]
.word 0xf9400000
.word 0xf90017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #384]
.word 0xd2800901
bl _p_3
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #392]
.word 0xf90013a0
bl _p_16
.word 0x91016341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 93 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_6:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_SkipRegisterAssembly_System_Reflection_Assembly
Registrar_DynamicRegistrar_SkipRegisterAssembly_System_Reflection_Assembly:
.loc 1 97 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402b20
.word 0xb4000220
.word 0xf9402b20
.word 0xf90013a0
.word 0xaa1903e0
.word 0xf9400fa1
.word 0xf9400322
.word 0xf9406850
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #400]
.word 0x3940001e
bl _p_17
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_SetAssemblyRegistered_string
Registrar_DynamicRegistrar_SetAssemblyRegistered_string:
.loc 1 102 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9402800
.word 0xb5000340
.loc 1 103 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #408]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #416]
.word 0xf90013a0
bl _p_18
.word 0xf9400ba0
.word 0x91014001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 104 0
.word 0xf9400ba0
.word 0xf9402800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #424]
.word 0x3940001e
.word 0xf9400fa1
.word 0xd2800002
bl _p_19
.loc 1 105 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_8:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_ContainsPlatformReference_System_Reflection_Assembly
Registrar_DynamicRegistrar_ContainsPlatformReference_System_Reflection_Assembly:
.loc 1 109 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0x3940003e
.word 0xf9400800
.loc 1 111 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #432]
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 1 112 0
.word 0xd2800020
.word 0x14000027
.loc 1 114 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9404030
.word 0xd63f0200
.word 0xaa0003fa
.word 0xd2a00019
.word 0x1400001c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f20
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000329
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0xaa0003e1
.word 0x3940003e
.word 0xf9400800
.loc 1 115 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #432]
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 1 116 0
.word 0xd2800020
.word 0x14000006
.word 0x11000739
.loc 1 114 0
.word 0xb9801b40
.word 0x6b00033f
.word 0x54fffc6b
.loc 1 118 0
.word 0xd2a00000
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_9:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsCustomType_System_Type
Registrar_DynamicRegistrar_IsCustomType_System_Type:
.loc 1 126 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xf90017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0x3900e3bf
.word 0xf94013a0
.word 0xf9402c00
.word 0xf9001ba0
.word 0xd2a00000
.word 0x3900e3a0
.word 0xf9401bb8
.word 0x9100e3a0
.word 0xf90023a0
.word 0xaa1803e0
.word 0x9100e3a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1803e0
.word 0xf94023a1
bl _p_21
.loc 1 127 0
.word 0xf94013a0
.word 0xf9402c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #440]
.word 0x3940001e
.word 0xf94017a1
bl _p_22
.word 0x53001c00
.word 0x53001c1a
.word 0xf90027bf
.word 0x94000005
.word 0xf94027a0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9002bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940e3a0
.word 0x34000060
.word 0xf9401ba0
bl _p_24
.word 0xf9402bbe
.word 0xd61f03c0
.loc 1 128 0
.word 0xaa1a03e0
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_get_IsSimulatorOrDesktop
Registrar_DynamicRegistrar_get_IsSimulatorOrDesktop:
.loc 1 135 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #448]
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_get_Is64Bits
Registrar_DynamicRegistrar_get_Is64Bits:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd2800020
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_FindMethods_System_Type_string
Registrar_DynamicRegistrar_FindMethods_System_Type_string:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #456]
.word 0xd2800a01
bl _p_3
.word 0xf90023a0
.word 0x92800021
bl _p_25
.word 0xf94023a0
.word 0xaa0003e1
.word 0xf9001fa1
.word 0x91008002
.word 0xd5033bbf
.word 0xf9401fa0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9001ba0
.word 0x9100c002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf94013a1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_FindProperty_System_Type_string
Registrar_DynamicRegistrar_FindProperty_System_Type_string:
.loc 1 184 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf94013a1
.word 0xd28007c2
.word 0xf9400fa3
.word 0x3940007e
bl _p_26
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_FindType_System_Type_string_string
Registrar_DynamicRegistrar_FindType_System_Type_string_string:
.loc 1 189 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xf9001fa0
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9416430
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9407030
.word 0xd63f0200
.word 0xaa0003f8
.word 0xd2a00017
.word 0x14000024

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000469
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.loc 1 190 0
.word 0xaa1603e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9417030
.word 0xd63f0200
.word 0xaa1903e1
bl _p_20
.word 0x53001c00
.word 0x34000160
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa1a03e1
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 1 191 0
.word 0xaa1603e0
.word 0x14000006
.word 0x110006f7
.loc 1 189 0
.word 0xb9801b00
.word 0x6b0002ff
.word 0x54fffb6b
.loc 1 193 0
.word 0xd2800000
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CollectConstructors_System_Type
Registrar_DynamicRegistrar_CollectConstructors_System_Type:
.loc 1 203 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd28006c1
.word 0xf9400fa2
.word 0xf9400042
.word 0xf940e850
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CollectMethods_System_Type
Registrar_DynamicRegistrar_CollectMethods_System_Type:
.loc 1 208 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd28007c1
.word 0xf9400fa2
.word 0xf9400042
.word 0xf940c050
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CollectProperties_System_Type
Registrar_DynamicRegistrar_CollectProperties_System_Type:
.loc 1 213 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd28007c1
.word 0xf9400fa2
.word 0xf9400042
.word 0xf940ac50
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_12:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CollectTypes_System_Reflection_Assembly
Registrar_DynamicRegistrar_CollectTypes_System_Reflection_Assembly:
.loc 1 219 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9407030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetBindAsAttribute_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetBindAsAttribute_System_Reflection_PropertyInfo:
.loc 1 224 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb5000060
.word 0xd2800000
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #464]
.word 0xf9400fa0
.word 0xd2a00001
bl _p_27
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_14:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetBindAsAttribute_System_Reflection_MethodBase_int
Registrar_DynamicRegistrar_GetBindAsAttribute_System_Reflection_MethodBase_int:
.loc 1 231 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa9026bb9
.word 0xf9001ba0
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb5000079
.loc 1 232 0
.word 0xd2800000
.word 0x1400004f
.loc 1 234 0
.word 0xaa1903f7
.word 0xeb1f033f
.word 0x54000160
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800017
.word 0xaa1703f6
.loc 1 235 0
.word 0xb40003b7
.loc 1 236 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003f6
.loc 1 237 0
.word 0x9280001e
.word 0x6b1e035f
.word 0x540000e1
.loc 1 238 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9409c30
.word 0xd63f0200
.word 0xaa0003fa
.word 0x1400002d
.loc 1 240 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9409030
.word 0xd63f0200
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000a09
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf940001a
.word 0x1400001f
.loc 1 243 0
.word 0xaa1903f7
.word 0xeb1f033f
.word 0x54000160
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800017
.word 0xaa1703f6
.loc 1 244 0
.word 0x9280001e
.word 0x6b1e035f
.word 0x54000300
.loc 1 247 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9409030
.word 0xd63f0200
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000629
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf940001a
.loc 1 251 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #488]
.word 0xaa1a03e0
bl _p_28
.word 0xa9415fb6
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.loc 1 245 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801b61
bl _p_11
.word 0xf90027a0
.word 0xf9401ba0
.word 0xaa1903e1
bl _p_29
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2803141
bl _p_11
.word 0xaa0003e2
.word 0xf94027a0
.word 0xf9402ba1
bl _p_30
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31
.word 0xf94023a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400002
.word 0xd2800c60
bl _p_32
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_15:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetNullableType_System_Type
Registrar_DynamicRegistrar_GetNullableType_System_Type:
.loc 1 256 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 1 257 0
.word 0xd2800000
.word 0x14000016
.loc 1 258 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9411830
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #512]
bl _p_33
.word 0x53001c00
.word 0x34000060
.loc 1 259 0
.word 0xd2800000
.word 0x1400000a
.loc 1 260 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9411030
.word 0xd63f0200
.word 0xb9801801
.word 0xeb1f003f
.word 0x10000011
.word 0x540000c9
.word 0xf9401000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_16:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetConnectAttribute_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetConnectAttribute_System_Reflection_PropertyInfo:
.loc 1 265 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #520]
.word 0xf9400fa0
bl _p_34
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_17:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetExportAttribute_System_Reflection_MethodBase
Registrar_DynamicRegistrar_GetExportAttribute_System_Reflection_MethodBase:
.loc 1 270 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf90017a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903f8
.loc 1 271 0
.word 0xb4000159
.loc 1 272 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf940a030
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #232]
bl _p_4
.word 0x14000017
.loc 1 274 0
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903fa
.loc 1 275 0
.word 0xb40000f9
.loc 1 276 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #232]
.word 0xaa1a03e0
bl _p_4
.word 0x14000002
.loc 1 278 0
.word 0xd2800000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_18:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_PrepareMethodMapping_System_Type
Registrar_DynamicRegistrar_PrepareMethodMapping_System_Type:
.loc 1 283 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
bl _p_35
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetExportAttribute_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetExportAttribute_System_Reflection_PropertyInfo:
.loc 1 288 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
bl _p_36
.word 0xaa0003f9
.word 0xb5000040
.word 0xf94013b9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #232]
.word 0xaa1903e0
bl _p_4
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetRegisterAttribute_System_Type
Registrar_DynamicRegistrar_GetRegisterAttribute_System_Type:
.loc 1 293 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #528]
.word 0xf9400fa0
bl _p_37
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetProtocolAttribute_System_Type
Registrar_DynamicRegistrar_GetProtocolAttribute_System_Type:
.loc 1 298 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #536]
.word 0xf9400fa0
bl _p_38
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetProtocolMemberAttributes_System_Type
Registrar_DynamicRegistrar_GetProtocolMemberAttributes_System_Type:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #544]
.word 0xd2800801
bl _p_3
.word 0xf90017a0
.word 0x92800021
bl _p_39
.word 0xf94017a0
.word 0xaa0003e1
.word 0xf90013a1
.word 0x91008002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetSDKVersion
Registrar_DynamicRegistrar_GetSDKVersion:
.loc 1 317 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd28015c0
.word 0xf2a04000
bl _mono_create_corlib_exception_0
bl _p_13
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_get_PlatformName
Registrar_DynamicRegistrar_get_PlatformName:
.loc 1 327 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #552]
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetSystemVoidType
Registrar_DynamicRegistrar_GetSystemVoidType:
.loc 1 338 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #560]
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_20:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_MakeByRef_System_Type
Registrar_DynamicRegistrar_MakeByRef_System_Type:
.loc 1 343 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9408030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_21:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetCategoryAttribute_System_Type
Registrar_DynamicRegistrar_GetCategoryAttribute_System_Type:
.loc 1 348 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #568]
.word 0xf9400fa0
bl _p_40
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_22:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetProtocolAttributeWrapperType_System_Type
Registrar_DynamicRegistrar_GetProtocolAttributeWrapperType_System_Type:
.loc 1 353 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #536]
.word 0xaa1a03e0
bl _p_38
.word 0xaa0003fa
.loc 1 354 0
.word 0xaa1a03e0
.word 0xb4000080
.word 0x3940035e
.word 0xf9400b40
.word 0x14000002
.word 0xd2800000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_23:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetAdoptsAttributes_System_Type
Registrar_DynamicRegistrar_GetAdoptsAttributes_System_Type:
.loc 1 359 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #576]
.word 0xaa1a03e0
.word 0xd2a00002
.word 0xf9400343
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003fa
.word 0xb40002ba
.word 0xf9400340
.word 0xf9400000
.word 0x39406801
.word 0xd280003e
.word 0xeb1e003f
.word 0x10000011
.word 0x54000261
.word 0xf9400400
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #584]
.word 0xeb01001f
.word 0x10000011
.word 0x54000141
.word 0xf9400b40
.word 0xeb1f001f
.word 0x10000011
.word 0x540000c1
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_24:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetAssemblyName_System_Reflection_Assembly
Registrar_DynamicRegistrar_GetAssemblyName_System_Reflection_Assembly:
.loc 1 364 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0x3940003e
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_25:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetBaseType_System_Type
Registrar_DynamicRegistrar_GetBaseType_System_Type:
.loc 1 369 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf940a030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetBaseMethod_System_Reflection_MethodBase
Registrar_DynamicRegistrar_GetBaseMethod_System_Reflection_MethodBase:
.loc 1 374 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb4000180
.word 0xf9400fa0
.word 0xf9400000
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x10000011
.word 0x54000121
.word 0xf9400fa1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf940a030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_27:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetElementType_System_Type
Registrar_DynamicRegistrar_GetElementType_System_Type:
.loc 1 379 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9412030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetEnumUnderlyingType_System_Type
Registrar_DynamicRegistrar_GetEnumUnderlyingType_System_Type:
.loc 1 384 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
bl _p_41
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_29:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetFields_System_Type
Registrar_DynamicRegistrar_GetFields_System_Type:
.loc 1 394 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd2800681
.word 0xf9400fa2
.word 0xf9400042
.word 0xf940dc50
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetFieldType_System_Reflection_FieldInfo
Registrar_DynamicRegistrar_GetFieldType_System_Reflection_FieldInfo:
.loc 1 399 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9406830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetGetMethod_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetGetMethod_System_Reflection_PropertyInfo:
.loc 1 404 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd2800021
.word 0xf9400fa2
.word 0xf9400042
.word 0xf9406c50
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetSetMethod_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetSetMethod_System_Reflection_PropertyInfo:
.loc 1 409 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xd2800021
.word 0xf9400fa2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetMethodName_System_Reflection_MethodBase
Registrar_DynamicRegistrar_GetMethodName_System_Reflection_MethodBase:
.loc 1 414 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetNamespaceAndName_System_Type_string__string_
Registrar_DynamicRegistrar_GetNamespaceAndName_System_Type_string__string_:
.loc 1 419 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xaa0103f8
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9417030
.word 0xd63f0200
.word 0xf9001fa0
.word 0xd5033bbf
.word 0xf9401fa0
.word 0xf94013a1
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 420 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9405c30
.word 0xd63f0200
.word 0xf9001ba0
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf94017a1
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 421 0
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetParameters_System_Reflection_MethodBase
Registrar_DynamicRegistrar_GetParameters_System_Reflection_MethodBase:
.loc 1 425 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf90017a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9409030
.word 0xd63f0200
.word 0xaa0003fa
.loc 1 426 0
.word 0xaa1a03e0
.word 0xb9801801

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
bl _p_42
.word 0xaa0003f9
.loc 1 428 0
.word 0xd2a00018
.word 0x1400001b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 429 0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000329
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.loc 1 428 0
.word 0x11000718
.word 0xb9801b40
.word 0x6b00031f
.word 0x54fffc8b
.loc 1 431 0
.word 0xaa1903e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_30:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetParameterName_System_Reflection_MethodBase_int
Registrar_DynamicRegistrar_GetParameterName_System_Reflection_MethodBase_int:
.loc 1 436 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9409030
.word 0xd63f0200
.word 0xb98023a1
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000189
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_31:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetPropertyName_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetPropertyName_System_Reflection_PropertyInfo:
.loc 1 441 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_32:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetPropertyType_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetPropertyType_System_Reflection_PropertyInfo:
.loc 1 446 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9408030
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_33:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetReturnType_System_Reflection_MethodBase
Registrar_DynamicRegistrar_GetReturnType_System_Reflection_MethodBase:
.loc 1 451 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf90017a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903f8
.loc 1 452 0
.word 0xb40000d9
.loc 1 453 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf940a430
.word 0xd63f0200
.word 0x14000020
.loc 1 455 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2804ba1
bl _p_11
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90023a0
.word 0xf9001fa0
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94023a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba1
.word 0xf9401fa2
.word 0xd2a00000
bl _p_32
bl _p_13
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_34:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetTypeFullName_System_Type
Registrar_DynamicRegistrar_GetTypeFullName_System_Type:
.loc 1 460 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_35:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_VerifyIsConstrainedToNSObject_System_Type_System_Type_
Registrar_DynamicRegistrar_VerifyIsConstrainedToNSObject_System_Type_System_Type_:
.loc 1 465 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90027bf
.word 0xd5033bbf
.word 0xf900035f
.loc 1 467 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x35000360
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x340000e0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9407030
.word 0xd63f0200
.word 0x53001c00
.word 0x340001e0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9414430
.word 0xd63f0200
.word 0x53001c00
.word 0x35000120
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9413830
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 1 468 0
.word 0xd2800020
.word 0x140000a5
.loc 1 470 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9414430
.word 0xd63f0200
.word 0x53001c00
.word 0x34000a40
.loc 1 471 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #608]
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0x53001c00
.word 0x340008c0
.loc 1 473 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9410430
.word 0xd63f0200
.word 0xaa0003f9
.loc 1 474 0
.word 0xd2a00018
.word 0x14000029

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54001149
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400017
.loc 1 475 0
.word 0xaa1703e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406850
.word 0xd63f0200
.word 0x53001c00
.word 0x340001e0
.loc 1 476 0
.word 0xd5033bbf
.word 0xf9000357
.word 0xd349ff40
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 1 477 0
.word 0xd2800020
.word 0x14000067
.word 0x11000718
.loc 1 474 0
.word 0xb9801b20
.word 0x6b00031f
.word 0x54fffacb
.loc 1 481 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #608]
.word 0xf9002ba0
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000340
.word 0xd349ff41
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 482 0
.word 0xd2800020
.word 0x14000050
.loc 1 484 0
.word 0xd2a00000
.word 0x1400004e
.loc 1 487 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9413830
.word 0xd63f0200
.word 0x53001c00
.word 0x340008e0
.loc 1 488 0
.word 0xd2800020
.word 0x53001c17
.loc 1 489 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9411030
.word 0xd63f0200
.word 0xaa0003f6
.loc 1 490 0
.word 0xaa1603e0
.word 0xb9801801

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
bl _p_42
.word 0xaa0003f5
.loc 1 491 0
.word 0xd2a00014
.word 0x1400001f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 493 0
.word 0x93407e80
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54000689
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400001
.word 0xaa1803e0
.word 0x910123a2
.word 0xf9400303
.word 0xf9409870
.word 0xd63f0200
.word 0x53001c00
.word 0xa0002e0
.word 0x53001c17
.loc 1 494 0
.word 0xf94027a2
.word 0xaa1503e0
.word 0xaa1403e1
.word 0xf94002a3
.word 0xf9404070
.word 0xd63f0200
.loc 1 491 0
.word 0x11000694
.word 0xb9801ac0
.word 0x6b00029f
.word 0x54fffc0b
.loc 1 496 0
.word 0xaa1903e0
.word 0xaa1503e1
.word 0xf9400322
.word 0xf9407c50
.word 0xd63f0200
.word 0xf9002ba0
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000340
.word 0xd349ff41
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 497 0
.word 0xaa1703e0
.word 0x14000002
.loc 1 500 0
.word 0xd2800020
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_36:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CreateExceptionImpl_int_bool_System_Exception_System_Reflection_MethodBase_string_object__
Registrar_DynamicRegistrar_CreateExceptionImpl_int_bool_System_Exception_System_Reflection_MethodBase_string_object__:
.loc 1 507 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0xf90023a6

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394083a0
.word 0x340000e0
.loc 1 508 0
.word 0xb9801ba0
.word 0xf94017a1
.word 0xf9401fa2
.word 0xf94023a3
bl _p_43
.word 0x14000006
.loc 1 509 0
.word 0xb9801ba0
.word 0xf94017a1
.word 0xf9401fa2
.word 0xf94023a3
bl _p_44
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_37:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_CreateExceptionImpl_int_bool_System_Exception_System_Type_string_object__
Registrar_DynamicRegistrar_CreateExceptionImpl_int_bool_System_Exception_System_Type_string_object__:
.loc 1 516 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5
.word 0xf90023a6

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394083a0
.word 0x340000e0
.loc 1 517 0
.word 0xb9801ba0
.word 0xf94017a1
.word 0xf9401fa2
.word 0xf94023a3
bl _p_43
.word 0x14000006
.loc 1 518 0
.word 0xb9801ba0
.word 0xf94017a1
.word 0xf9401fa2
.word 0xf94023a3
bl _p_44
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_38:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetAssemblyQualifiedName_System_Type
Registrar_DynamicRegistrar_GetAssemblyQualifiedName_System_Type:
.loc 1 523 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9416c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_39:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_HasThisAttributeImpl_System_Reflection_MethodBase
Registrar_DynamicRegistrar_HasThisAttributeImpl_System_Reflection_MethodBase:
.loc 1 536 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903fa
.loc 1 537 0
.word 0xb5000079
.loc 1 538 0
.word 0xd2a00000
.word 0x1400000a
.loc 1 539 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #616]
.word 0xaa1a03e0
.word 0xd2a00002
.word 0xf9400343
.word 0xf9404c70
.word 0xd63f0200
.word 0x53001c00
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_HasThisAttribute_System_Reflection_MethodBase
Registrar_DynamicRegistrar_HasThisAttribute_System_Reflection_MethodBase:
.loc 1 544 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
bl _p_45
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetTypeName_System_Type
Registrar_DynamicRegistrar_GetTypeName_System_Type:
.loc 1 549 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_HasModelAttribute_System_Type
Registrar_DynamicRegistrar_HasModelAttribute_System_Type:
.loc 1 554 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #624]
.word 0xf9400fa0
.word 0xd2a00002
.word 0xf9400fa3
.word 0xf9400063
.word 0xf9404c70
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsArray_System_Type_int_
Registrar_DynamicRegistrar_IsArray_System_Type_int_:
.loc 1 559 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0
.word 0xaa0103f9
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
.word 0x3940033e
bl _p_46
.word 0x53001c00
.word 0x350000a0
.loc 1 560 0
.word 0xf94013a0
.word 0xb900001f
.loc 1 561 0
.word 0xd2a00000
.word 0x1400000a
.loc 1 563 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9411c30
.word 0xd63f0200
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94013a0
.word 0xb9000001
.loc 1 564 0
.word 0xd2800020
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_3e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsByRef_System_Type
Registrar_DynamicRegistrar_IsByRef_System_Type:
.loc 1 569 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_47
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsConstructor_System_Reflection_MethodBase
Registrar_DynamicRegistrar_IsConstructor_System_Reflection_MethodBase:
.loc 1 574 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0
.word 0xf90013a1
.word 0xf94013b9
.word 0xf94013a0
.word 0xeb1f001f
.word 0x54000180
.word 0xf94013a0
.word 0xf9400000
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xeb1f033f
.word 0x9a9f97e0
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_40:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsGenericType_System_Type
Registrar_DynamicRegistrar_IsGenericType_System_Type:
.loc 1 579 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x350001a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9413830
.word 0xd63f0200
.word 0x53001c00
.word 0x350000e0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9414430
.word 0xd63f0200
.word 0x53001c00
.word 0x14000002
.word 0xd2800020
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_41:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsGenericMethod_System_Reflection_MethodBase
Registrar_DynamicRegistrar_IsGenericMethod_System_Reflection_MethodBase:
.loc 1 584 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407c30
.word 0xd63f0200
.word 0x53001c00
.word 0x350000e0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407830
.word 0xd63f0200
.word 0x53001c00
.word 0x14000002
.word 0xd2800020
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_42:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetGenericTypeDefinition_System_Type
Registrar_DynamicRegistrar_GetGenericTypeDefinition_System_Type:
.loc 1 589 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9411830
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_43:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsDelegate_System_Type
Registrar_DynamicRegistrar_IsDelegate_System_Type:
.loc 1 594 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #632]
.word 0xf9400fa0
.word 0xf9400fa2
.word 0xf9400042
.word 0xf9406850
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_44:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsNullable_System_Type
Registrar_DynamicRegistrar_IsNullable_System_Type:
.loc 1 599 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 1 600 0
.word 0xd2a00000
.word 0x1400000a
.loc 1 602 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9411830
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #512]
bl _p_48
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_45:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsEnum_System_Type_bool_
Registrar_DynamicRegistrar_IsEnum_System_Type_bool_:
.loc 1 607 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0
.word 0xaa0103f9
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0x3900001f
.loc 1 608 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940fc30
.word 0xd63f0200
.word 0x53001c00
.word 0x34000180
.loc 1 609 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #640]
.word 0xaa1903e0
.word 0xd2a00002
.word 0xf9400323
.word 0xf9404c70
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94013a0
.word 0x39000001
.loc 1 610 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940fc30
.word 0xd63f0200
.word 0x53001c00
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_46:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsInterface_System_Type
Registrar_DynamicRegistrar_IsInterface_System_Type:
.loc 1 615 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_49
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_47:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsAbstract_System_Type
Registrar_DynamicRegistrar_IsAbstract_System_Type:
.loc 1 620 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_50
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_48:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsPointer_System_Type
Registrar_DynamicRegistrar_IsPointer_System_Type:
.loc 1 625 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_51
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_49:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsINativeObject_System_Type
Registrar_DynamicRegistrar_IsINativeObject_System_Type:
.loc 1 630 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #648]
.word 0xaa0203e0
.word 0xf9400fa1
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsNSObject_System_Type
Registrar_DynamicRegistrar_IsNSObject_System_Type:
.loc 1 635 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xf9400fa0
bl _p_48
.word 0x53001c00
.word 0x35000160

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xf9400fa0
.word 0xf9400fa2
.word 0xf9400042
.word 0xf9406850
.word 0xd63f0200
.word 0x53001c00
.word 0x14000002
.word 0xd2800020
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsStatic_System_Reflection_FieldInfo
Registrar_DynamicRegistrar_IsStatic_System_Reflection_FieldInfo:
.loc 1 640 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_52
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsStatic_System_Reflection_MethodBase
Registrar_DynamicRegistrar_IsStatic_System_Reflection_MethodBase:
.loc 1 645 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_53
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsStatic_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_IsStatic_System_Reflection_PropertyInfo:
.loc 1 650 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
bl _p_54
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsValueType_System_Type
Registrar_DynamicRegistrar_IsValueType_System_Type:
.loc 1 655 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_55
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsVirtual_System_Reflection_MethodBase
Registrar_DynamicRegistrar_IsVirtual_System_Reflection_MethodBase:
.loc 1 660 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0x3940003e
bl _p_56
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_50:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetInterfaces_System_Type
Registrar_DynamicRegistrar_GetInterfaces_System_Type:
.loc 1 665 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9409c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_51:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_TryGetAttribute_System_Type_string_string_object_
Registrar_DynamicRegistrar_TryGetAttribute_System_Type_string_string_object_:
.loc 1 670 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xf9002ba0
.word 0xaa0103f7
.word 0xaa0203f8
.word 0xaa0303f9
.word 0xaa0403fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1703e0
.word 0xd2a00001
.word 0xf94002e2
.word 0xf9404850
.word 0xd63f0200
.word 0xaa0003f6
.loc 1 672 0
.word 0xd5033bbf
.word 0xf900035f
.loc 1 674 0
.word 0xb9801ac0
.word 0x35000060
.loc 1 675 0
.word 0xd2a00000
.word 0x1400003e
.loc 1 677 0
.word 0xaa1603f5
.word 0xd2a00016
.word 0x14000033

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ec0
.word 0xb9801aa1
.word 0xeb00003f
.word 0x10000011
.word 0x54000969
.word 0xd37df000
.word 0x8b0002a0
.word 0x91008000
.word 0xf9400014
.loc 1 678 0
.word 0xaa1403e0
.word 0xf9400000
.word 0xf9400c13
.loc 1 679 0
.word 0xaa1303e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9417030
.word 0xd63f0200
.word 0xaa1803e1
bl _p_20
.word 0x53001c00
.word 0x340002e0
.word 0xaa1303e0
.word 0xf9400261
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa1903e1
bl _p_20
.word 0x53001c00
.word 0x340001e0
.loc 1 680 0
.word 0xf9400340
.word 0xb50003a0
.loc 1 682 0
.word 0xd5033bbf
.word 0xf9000354
.word 0xd349ff40
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0x110006d6
.loc 1 677 0
.word 0xb9801aa0
.word 0x6b0002df
.word 0x54fff98b
.loc 1 686 0
.word 0xf9400340
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.loc 1 681 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28054a1
bl _p_11
.word 0xf90033a0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94033a0
.word 0xaa1803e2
.word 0xaa1903e3
bl _p_57
.word 0xaa0003e1
.word 0xd2806340
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_52:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_ReportError_int_string_object__
Registrar_DynamicRegistrar_ReportError_int_string_object__:
.loc 1 691 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf94017a1
bl _p_58
bl _p_59
.loc 1 692 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_53:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetPropertyAttributes_Registrar_Registrar_ObjCProperty_int__bool
Registrar_DynamicRegistrar_GetPropertyAttributes_Registrar_Registrar_ObjCProperty_int__bool:
.loc 1 697 0 prologue_end
.word 0xa9b37bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xf9001bb9
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xf9001fa3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #656]
.word 0xd28000a1
bl _p_42
.word 0xaa0003f6
.loc 1 698 0
.word 0xb900033f
.loc 1 700 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #664]
.word 0xf90067a0
.word 0xd5033bbf
.word 0xf94067a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0
.word 0xf90063a0
.word 0xaa1803e0
.word 0x3940031e
bl _p_60
.word 0xaa0003e1
.word 0xaa1703e0
.word 0xaa1803e2
.word 0xd2800023
bl _p_61
.word 0xaa0003e1
.word 0xf94063a0
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf9004ba0
.word 0xf94057a0
.word 0xf9004fa0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54003ba9
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf9404ba1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9404fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 701 0
.word 0xb9803b17
.word 0xaa1703e0
.word 0xd280003e
.word 0x6b1e001f
.word 0x540000a0
.word 0xd280005e
.word 0x6b1e02ff
.word 0x54000ae0
.word 0x140000aa
.loc 1 703 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #672]
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #680]
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf90043a0
.word 0xf94057a0
.word 0xf90047a0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54003009
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf94043a1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf94047a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 704 0
.word 0x14000055
.loc 1 706 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #688]
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #680]
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf9003ba0
.word 0xf94057a0
.word 0xf9003fa0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54002569
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf9403ba1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9403fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 709 0
.word 0x3940e3a0
.word 0x35000a80
.loc 1 710 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #696]
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0
.word 0x3940031e
.word 0xf9401b01
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf90033a0
.word 0xf94057a0
.word 0xf90037a0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54001ac9
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf94033a1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf94037a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 712 0
.word 0xaa1803e0
.word 0x3940031e
bl _p_62
.word 0x53001c00
.word 0x34000ac0
.loc 1 713 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #704]
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #712]
.word 0xf9400021
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf9002ba0
.word 0xf94057a0
.word 0xf9002fa0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54000f89
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf9402ba1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9402fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 715 0
.word 0xb9800335
.word 0xaa1503e0
.word 0x11000400
.word 0xb9000320
.word 0xd2800000
.word 0xf90053a0
.word 0xf90057a0
.word 0x910283a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #720]
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf90053a0
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910283a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #712]
.word 0xf9400021
.word 0xf9005fa1
.word 0x91002001
.word 0xd5033bbf
.word 0xf9405fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94053a0
.word 0xf90023a0
.word 0xf94057a0
.word 0xf90027a0
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x540004e9
.word 0xd37cec00
.word 0x8b0002c0
.word 0x91008000
.word 0xf9005ba0
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf94023a1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf94027a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 1 716 0
.word 0xaa1603e0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xf9401bb9
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_54:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_OnRegisterProtocol_Registrar_Registrar_ObjCType
Registrar_DynamicRegistrar_OnRegisterProtocol_Registrar_Registrar_ObjCType:
.loc 1 721 0 prologue_end
.word 0xa9b17bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9002fa0
.word 0xf90033a0
.word 0xf90037a0
.word 0xb90073bf
.word 0xd2800000
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_63
bl _p_64
.word 0xaa0003f8
.loc 1 723 0
.word 0xaa1803e0
.word 0xb4000280
.loc 1 724 0
.word 0xf9003f58
.loc 1 725 0
.word 0xf9402720

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #728]
.word 0x3940001e
.word 0xaa1803e1
bl _p_65
.word 0x53001c00
.word 0x35002380
.loc 1 726 0
.word 0xf9402720

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #736]
.word 0x3940001e
.word 0xaa1803e1
.word 0xaa1a03e2
bl _p_66
.loc 1 727 0
.word 0x14000113
.loc 1 730 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_63
bl _p_67
.word 0xaa0003f8
.loc 1 732 0
.word 0xf9401f40
.word 0xb4000800
.loc 1 733 0
.word 0xf9401f57
.word 0xd2a00016
.word 0x1400003a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x54002089
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.loc 1 734 0
.word 0xaa1503e1
.word 0xaa0103e0
.word 0x3940003e
bl _p_63

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #744]
bl _p_20
.word 0x53001c00
.word 0x340003a0
.loc 1 740 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #752]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9006ba0
.word 0xf90067a0
.word 0xf9401741
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd2820660
bl _p_68
bl _p_69
.loc 1 742 0
.word 0xf9403ea1
.word 0xaa1803e0
bl _p_70
.word 0x110006d6
.loc 1 733 0
.word 0xb9801ae0
.word 0x6b0002df
.word 0x54fff8ab
.loc 1 746 0
.word 0xf9402f40
.word 0xb4001020
.loc 1 747 0
.word 0xf9402f40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #760]
.word 0x3940001e
.word 0x910163a8
bl _p_71
.word 0x14000061

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037b7
.loc 1 749 0
.word 0xaa1903e0
.word 0xaa1703e1
.word 0x9101c3a2
.word 0xd2800023
bl _p_72
.word 0xaa0003f6
.loc 1 753 0
.word 0x394002fe
.word 0xf9401ae0
.word 0xf9006fa0
.word 0xb98073a0
.word 0xf90073a0
.word 0x3940f6e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0xf90077a0
.word 0xaa1703e0
.word 0x394002fe
bl _p_73
.word 0xf9406fa1
.word 0xf94073a3
.word 0xf94077a4
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e5
.word 0xaa1803e0
.word 0xaa1603e2
bl _p_74
.loc 1 755 0
.word 0xaa1703e0
.word 0x394002fe
bl _p_60
.word 0xaa0003e1
.word 0xaa1903e0
.word 0xaa1703e2
.word 0xd2a00003
bl _p_61
.word 0xaa0003f6
.loc 1 756 0
.word 0xf9402ae0
bl _p_75
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #768]
.word 0xaa1603e0
bl _p_76
.word 0xf90067a0
.word 0x3940f6e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0xf9006ba0
.word 0xaa1703e0
.word 0x394002fe
bl _p_73
.word 0xf94063a1
.word 0xf94067a2
.word 0xf9406ba3
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e4
.word 0xaa1803e0
bl _p_77
.loc 1 757 0
.word 0xaa1703e0
.word 0x394002fe
bl _p_62
.word 0x53001c00
.word 0x35000320
.loc 1 758 0
.word 0xf9402ee0
bl _p_75
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #776]
.word 0xaa1603e1
bl _p_76
.word 0xf90067a0
.word 0x3940f6e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0xf9006ba0
.word 0xaa1703e0
.word 0x394002fe
bl _p_73
.word 0xf94063a1
.word 0xf94067a2
.word 0xf9406ba3
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e4
.word 0xaa1803e0
bl _p_77
.loc 1 747 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #784]
.word 0x910163a0
bl _p_78
.word 0x53001c00
.word 0x35fff340
.word 0xf90047bf
.word 0x94000005
.word 0xf94047a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9004fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910163a0
.word 0xf9004ba0
.word 0xf9404fbe
.word 0xd61f03c0
.loc 1 762 0
.word 0xf9402b40
.word 0xb40007e0
.loc 1 763 0
.word 0xf9402b40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #792]
.word 0x3940001e
.word 0x910103a8
bl _p_79
.word 0x1400001f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402bb7
.loc 1 764 0
.word 0x394002fe
.word 0xf9401ae0
bl _p_75
.word 0xf90063a0
.word 0xaa1703e0
.word 0x394002fe
bl _p_80
.word 0xf90067a0
.word 0x3940f6e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0xf9006ba0
.word 0xaa1703e0
.word 0x394002fe
bl _p_81
.word 0xf94063a1
.word 0xf94067a2
.word 0xf9406ba3
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e4
.word 0xaa1803e0
bl _p_77
.loc 1 763 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #800]
.word 0x910103a0
bl _p_82
.word 0x53001c00
.word 0x35fffb80
.word 0xf9003fbf
.word 0x94000005
.word 0xf9403fa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90057be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910103a0
.word 0xf90043a0
.word 0xf94057be
.word 0xd61f03c0
.loc 1 768 0
.word 0xaa1803e0
bl _p_83
.loc 1 769 0
.word 0xf9402720

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #736]
.word 0x3940001e
.word 0xaa1803e1
.word 0xaa1a03e2
bl _p_66
.loc 1 772 0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8cf7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_55:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_OnRegisterCategory_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_
Registrar_DynamicRegistrar_OnRegisterCategory_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_:
.loc 1 776 0 prologue_end
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xf9402b20
.word 0xb4000de0
.loc 1 777 0
.word 0xf9402b20

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #792]
.word 0x3940001e
.word 0x9100c3a8
bl _p_79
.word 0x1400004f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94023b7
.loc 1 778 0
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_84
.word 0x53001c00
.word 0x35000860
.loc 1 779 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #808]
.word 0xf9003ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf90057a0
.word 0xf90053a0
.word 0xf9401721
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94057a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94053a0
.word 0xf9004fa0
.word 0xf9004ba0
.word 0xaa1703e0
.word 0x394002fe
bl _p_85
.word 0xaa0003e2
.word 0xf9404fa3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xf90047a0
.word 0x394002fe
.word 0xf9401ae2
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0
.word 0xaa1903e0
.word 0x3940033e
bl _p_86
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403ba1
.word 0xf9403fa2
.word 0xd2820760
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 1 777 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #800]
.word 0x9100c3a0
bl _p_82
.word 0x53001c00
.word 0x35fff580
.word 0xf90027bf
.word 0x94000005
.word 0xf94027a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9002fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100c3a0
.word 0xf9002ba0
.word 0xf9402fbe
.word 0xd61f03c0
.loc 1 784 0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0

Lme_56:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_OnReloadType_Registrar_Registrar_ObjCType
Registrar_DynamicRegistrar_OnReloadType_Registrar_Registrar_ObjCType:
.loc 1 788 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9403f40
.word 0xb5000160
.loc 1 791 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_86
.word 0x910083a1
.word 0xf90017a1
bl _p_88
.word 0xf94017be
.word 0xf90003c0
.word 0xf94013a0
.word 0xf9003f40
.loc 1 792 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_57:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_OnRegisterType_Registrar_Registrar_ObjCType
Registrar_DynamicRegistrar_OnRegisterType_Registrar_Registrar_ObjCType:
.loc 1 796 0 prologue_end
.word 0xa9af7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9003ba0
.word 0xf9003fa0
.word 0xf90043a0
.word 0xb9008bbf
.word 0xd2800000
.word 0xf9002fa0
.word 0xf90033a0
.word 0xf90037a0
.word 0xd2800000
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_86
.word 0x9100e3a1
.word 0xf9004ba1
bl _p_88
.word 0xf9404bbe
.word 0xf90003c0
.word 0xf9401fa0
.word 0xf9003f40
.loc 1 798 0
.word 0xf9403f40
.word 0xb4000260
.loc 1 799 0
.word 0xf9402720
.word 0xf9403f41

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #728]
.word 0x3940001e
bl _p_65
.word 0x53001c00
.word 0x35001be0
.loc 1 800 0
.word 0xf9402720
.word 0xf9403f41

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #736]
.word 0x3940001e
.word 0xaa1a03e2
bl _p_66
.loc 1 801 0
.word 0x140000d6
.loc 1 806 0
.word 0x3941cf40
.word 0x34000060
.word 0x3941c340
.word 0x34001a40
.loc 1 811 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_89
.word 0x53001c00
.word 0x350019a0
.loc 1 814 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_90
.word 0xaa0003f8
.loc 1 816 0
.word 0xf9403f00
.word 0xf90083a0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_86
.word 0xaa0003e1
.word 0xf94083a0
.word 0xd2800002
bl _p_91
.word 0xf9003f40
.loc 1 818 0
.word 0xf9402f40
.word 0xb4000680
.loc 1 819 0
.word 0xf9402f40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #760]
.word 0x3940001e
.word 0x9101c3a8
bl _p_71
.word 0x14000014

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94043b8
.loc 1 821 0
.word 0xaa1903e0
.word 0xaa1803e1
.word 0x910223a2
.word 0xd2a00003
bl _p_72
.word 0xaa0003f7
.loc 1 822 0
.word 0xf9403f40
.word 0x3940031e
.word 0xf9401b01
.word 0xb9808ba3
.word 0xaa1703e2
bl _p_92
.loc 1 819 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #784]
.word 0x9101c3a0
bl _p_78
.word 0x53001c00
.word 0x35fffce0
.word 0xf9005fbf
.word 0x94000005
.word 0xf9405fa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90067be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9101c3a0
.word 0xf90063a0
.word 0xf94067be
.word 0xd61f03c0
.loc 1 826 0
.word 0xf9402740
.word 0xb4000680
.loc 1 827 0
.word 0xf9402740

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #816]
.word 0x3940001e
bl _p_93

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #824]
.word 0x3940001e
.word 0x910163a8
bl _p_94
.word 0x1400000f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037b8
.loc 1 828 0
.word 0xf9403f40
.word 0xf9401301
.word 0xb9804b02
.word 0x93407c42
.word 0x39413303
.word 0xf9402304
bl _p_95
.loc 1 827 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #832]
.word 0x910163a0
bl _p_96
.word 0x53001c00
.word 0x35fffd80
.word 0xf90057bf
.word 0x94000005
.word 0xf94057a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9006fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910163a0
.word 0xf9005ba0
.word 0xf9406fbe
.word 0xd61f03c0
.loc 1 831 0
.word 0xf9402b40
.word 0xb4000560
.loc 1 832 0
.word 0xf9402b40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #792]
.word 0x3940001e
.word 0x910103a8
bl _p_79
.word 0x1400000b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402bb8
.loc 1 833 0
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_84
.loc 1 832 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #800]
.word 0x910103a0
bl _p_82
.word 0x53001c00
.word 0x35fffe00
.word 0xf9004fbf
.word 0x94000005
.word 0xf9404fa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90077be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910103a0
.word 0xf90053a0
.word 0xf94077be
.word 0xd61f03c0
.loc 1 836 0
.word 0xf9401f40
.word 0xb4000340
.loc 1 837 0
.word 0xf9401f58
.word 0xd2a00017
.word 0x14000014

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x540003e9
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.loc 1 838 0
.word 0xf9403f40
.word 0xf9403ec1
bl _p_97
.word 0x110006f7
.loc 1 837 0
.word 0xb9801b00
.word 0x6b0002ff
.word 0x54fffd6b
.loc 1 842 0
.word 0xf9403f40
bl _p_98
.loc 1 843 0
.word 0xf9402720
.word 0xf9403f41

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #736]
.word 0x3940001e
.word 0xaa1a03e2
bl _p_66
.loc 1 844 0
.word 0xf9401741
.word 0xaa1903e0
bl _p_99
.loc 1 847 0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8d17bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_58:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_AddCustomType_System_Type
Registrar_DynamicRegistrar_AddCustomType_System_Type:
.loc 1 851 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90017bf
.word 0x3900c3bf
.word 0xf9400fa0
.word 0xf9402c00
.word 0xf90017a0
.word 0xd2a00000
.word 0x3900c3a0
.word 0xf94017b8
.word 0x9100c3a0
.word 0xf9001fa0
.word 0xaa1803e0
.word 0x9100c3a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1803e0
.word 0xf9401fa1
bl _p_21
.loc 1 852 0
.word 0xf9400fa0
.word 0xf9402c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #840]
.word 0x3940001e
.word 0xf94013a1
.word 0xd2800002
bl _p_100
.word 0xf90023bf
.word 0x94000005
.word 0xf94023a0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf90027be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940c3a0
.word 0x34000060
.word 0xf94017a0
bl _p_24
.word 0xf94027be
.word 0xd61f03c0
.loc 1 853 0
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_59:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetMethodDescriptionAndObject_System_Type_intptr_bool_intptr_intptr__intptr
Registrar_DynamicRegistrar_GetMethodDescriptionAndObject_System_Type_intptr_bool_intptr_intptr__intptr:
.loc 1 857 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xf90013b8
.word 0xf90017a0
.word 0xaa0103f5
.word 0xaa0203f6
.word 0xf9001ba3
.word 0xaa0403f8
.word 0xf9001fa5
.word 0xf90023a6

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90027bf
.word 0xf9002bbf
.word 0xaa1603e0
bl _p_101
.word 0xaa0003f6
.loc 1 858 0
.word 0xf94017a0
.word 0xaa1503e1
.word 0xaa1503e2
.word 0xaa1603e3
.word 0x3940c3a4
bl _p_102
.word 0xf90027a0
.loc 1 859 0
.word 0xf94027a0
.word 0xb4000cc0
.loc 1 862 0
.word 0xf94027a1
.word 0xaa0103e0
.word 0x3940003e
bl _p_103
.word 0x53001c00
.word 0x34000080
.loc 1 863 0
.word 0xf9401fa0
.word 0xf900001f
.word 0x14000053
.loc 1 866 0
.word 0xaa1803e0
.word 0xd2a00001
.word 0xd2800022
bl _p_104
.word 0xaa0003f8
.loc 1 867 0
.word 0xaa1803e0
bl _p_105
.word 0xaa0003e1
.word 0xf9401fa0
.word 0xf9000001
.loc 1 868 0
.word 0xf94027a0
.word 0xf9402001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9407030
.word 0xd63f0200
.word 0x53001c00
.word 0x340001e0
.loc 1 869 0
.word 0xf94027a0
.word 0xf90043a0
.word 0xf9400300
.word 0xf9400c00
.word 0xf94027a1
.word 0xf9402021
bl _p_106
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xf94023a1
.word 0x3940007e
bl _p_107
.loc 1 870 0
.word 0x14000038
.loc 1 872 0
.word 0x14000032
.word 0xf9002fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402fa0
.word 0xf9002ba0
.loc 1 873 0
.word 0xf9402ba0
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280f021
bl _p_11
.word 0xf9004ba0
.word 0xf94027a1
.word 0xaa0103e0
.word 0x3940003e
bl _p_108
.word 0xf9004fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280fde1
bl _p_11
.word 0xaa0003e2
.word 0xf9404ba0
.word 0xf9404fa1
bl _p_30
.word 0xf90047a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31
.word 0xf94043a1
.word 0xf94047a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400000
.word 0xf90037a0
.word 0xf94037a3
.word 0xd283ec60
bl _p_43
bl _p_13
.loc 1 877 0
.word 0xf94027a2
.word 0xaa0203e0
.word 0xf94023a1
.word 0x3940005e
bl _p_109
.loc 1 878 0
.word 0xa9415bb5
.word 0xf94013b8
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.loc 1 860 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280e321
bl _p_11
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9004fa0
.word 0xaa0303e0
.word 0xd2a00001
.word 0xaa1603e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xaa1503e0
.word 0xf94002a1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a1
.word 0xf94047a2
.word 0xd283e8c0
bl _p_32
bl _p_13

Lme_5a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetMethodDescription_System_Type_intptr_bool_intptr
Registrar_DynamicRegistrar_GetMethodDescription_System_Type_intptr_bool_intptr:
.loc 1 882 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xaa0003f6
.word 0xaa0103f7
.word 0xaa0203f8
.word 0xaa0303f9
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803e0
bl _p_101
.word 0xaa0003f8
.loc 1 883 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xaa1703e2
.word 0xaa1803e3
.word 0xaa1903e4
bl _p_102
.word 0xaa0003f9
.loc 1 884 0
.word 0xaa1903e0
.word 0xb40003e0
.loc 1 886 0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf9413c30
.word 0xd63f0200
.word 0x53001c00
.word 0x34000200
.word 0xf9402338
.word 0xaa1803f6
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800016
.word 0xb5000636
.loc 1 889 0
.word 0xaa1903e0
.word 0xf9401ba1
.word 0x3940033e
bl _p_109
.loc 1 890 0
.word 0xa9415fb6
.word 0xa94267b8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.loc 1 885 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280e321
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9002fa0
.word 0xaa0303e0
.word 0xd2a00001
.word 0xaa1803e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa0
.word 0xf9002ba0
.word 0xf90027a0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a1
.word 0xf94027a2
.word 0xd283e8c0
bl _p_32
bl _p_13
.loc 1 887 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280fe61
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9002ba0
.word 0xf90027a0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a1
.word 0xf94027a2
.word 0xd28204a0
bl _p_32
bl _p_13

Lme_5b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetMethodNoThrow_System_Type_System_Type_string_bool
Registrar_DynamicRegistrar_GetMethodNoThrow_System_Type_System_Type_string_bool:
.loc 1 894 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000bb5
.word 0xf9000fb8
.word 0xf90013ba
.word 0xf90017a0
.word 0xf9001ba1
.word 0xaa0203f8
.word 0xf9001fa3
.word 0xaa0403fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90023bf
.word 0xf94017a0
.word 0xaa1803e1
bl _p_110
.word 0xaa0003f5
.loc 1 896 0
.word 0xaa1503e0
.word 0xb40006c0
.loc 1 899 0
.word 0xf90023bf
.loc 1 901 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf940a030
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #848]
bl _p_33
.word 0x53001c00
.word 0x34000280
.word 0xaa1503e0
.word 0xf9401fa1
.word 0xaa1a03e2
.word 0x910103a3
.word 0x394002be
bl _p_111
.word 0x53001c00
.word 0x35000180
.loc 1 902 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94017a0
.word 0xf9401ba1
.word 0xf9401fa3
.word 0xaa1a03e4
bl _p_102
.word 0x14000012
.loc 1 904 0
.word 0xf94023ba
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803fa
.loc 1 906 0
.word 0xb40004b8
.loc 1 909 0
.word 0xaa1a03e0
.word 0xf9400bb5
.word 0xf9400fb8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.loc 1 897 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28115c1
bl _p_11
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90033a0
.word 0xf9002fa0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xd28205c0
bl _p_32
bl _p_13
.loc 1 907 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2811e41
bl _p_11
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf90037a0
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9401fa2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xf9401ba0
.word 0xf9401ba1
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xd283e8e0
bl _p_32
bl _p_13

Lme_5c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_Lookup_intptr_bool
Registrar_DynamicRegistrar_Lookup_intptr_bool:
.loc 1 915 0 prologue_end
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xf90013b7
.word 0xa902ebb9
.word 0xf9001fa0
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9002bbf
.word 0x390163bf
.word 0x390183bf
.word 0xf90037b9
.loc 1 916 0
.word 0xd2a00000
.word 0x390163a0
.loc 1 919 0
.word 0xf9401fb7
.word 0x910163b6
.word 0xf9400ef5
.word 0xaa1603f7
.word 0xaa1503e0
.word 0xaa1603e1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1503e0
.word 0xaa1703e1
bl _p_21

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 922 0
.word 0xf9401fa0
.word 0xf9402400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #864]
.word 0x3940001e
.word 0xaa1903e1
.word 0x910143a2
bl _p_112
.word 0x53001c00
.word 0x34000120
.loc 1 923 0
.word 0xf9402ba0
.word 0xf940141a
.word 0xf9003bbf
.word 0x9400002a
.word 0xf9403ba0
.word 0xb4000040
bl _p_23
.word 0x14000036
.loc 1 926 0
.word 0xf90027bf
.word 0xf90027b9
.word 0xf94027a0
.word 0xf90023a0
.word 0xf94023a0
.word 0x910183a1
bl _p_113
.word 0xaa0003f7
.loc 1 927 0
.word 0xaa1703e0
.word 0xb4000220
.loc 1 928 0
.word 0xf9401fa0
.word 0xaa1703e1
bl _p_110
.word 0xf9002ba0
.loc 1 929 0
.word 0x394183a0
.word 0x34000080
.loc 1 930 0
.word 0xf9401fa0
.word 0xaa1703e1
bl _p_99
.loc 1 931 0
.word 0xaa1703fa
.word 0xf9003bbf
.word 0x94000010
.word 0xf9403ba0
.word 0xb4000040
bl _p_23
.word 0x1400001c
.loc 1 934 0
.word 0xaa1903e0
bl _p_114
.word 0xaa0003f9
.loc 1 935 0
.word 0xaa1903e0
.word 0xb5fff920
.loc 1 936 0
.word 0xf9003bbf
.word 0x94000005
.word 0xf9403ba0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9003fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 937 0
.word 0x394163a0
.word 0x34000060
.loc 1 938 0
.word 0xf9401fa0
bl _p_115
.loc 1 939 0
.word 0xf9403fbe
.word 0xd61f03c0
.loc 1 941 0
.word 0x3500015a
.loc 1 943 0
.word 0xd2800000
.word 0x14000002
.loc 1 944 0
.word 0xaa1a03e0
.word 0xa9415bb5
.word 0xf94013b7
.word 0xa942ebb9
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0
.loc 1 942 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2813e61
bl _p_11
.word 0xf9004ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90053a0
.word 0xf9004fa0
.word 0xf94037a0
bl _p_116
bl _p_117
.word 0xaa0003e2
.word 0xf94053a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404ba1
.word 0xf9404fa2
.word 0xd28205e0
bl _p_32
bl _p_13

Lme_5d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_RegisterMethod_Registrar_Registrar_ObjCMethod
Registrar_DynamicRegistrar_RegisterMethod_Registrar_Registrar_ObjCMethod:
.loc 1 951 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0x3940035e
bl _p_81
.word 0x53001c00
.word 0x340000c0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_118
.word 0x53001c00
.word 0x34000080
.word 0xf9400f40
.word 0xf9403c19
.word 0x14000005
.word 0xf9400f40
.word 0xf9403c00
bl _p_119
.word 0xaa0003f9
.word 0xf90017b9
.loc 1 953 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_120
.word 0x93407c00
.word 0xaa0003f9
.word 0xaa1903e0
.word 0x51000419
.word 0xd28002be
.word 0x6b1e033f
.word 0x54002002
.word 0xd37df320
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #872]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.loc 1 955 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9401c19
.loc 1 956 0
.word 0x14000113
.loc 1 958 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c19
.loc 1 959 0
.word 0x14000106
.loc 1 961 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9403419
.loc 1 962 0
.word 0x140000f9
.loc 1 964 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9400019
.loc 1 965 0
.word 0x140000ec
.loc 1 967 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9401019
.loc 1 968 0
.word 0x140000df
.loc 1 970 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9401419
.loc 1 971 0
.word 0x140000d2
.loc 1 973 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9400819
.loc 1 974 0
.word 0x140000c5
.loc 1 976 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9401819
.loc 1 977 0
.word 0x140000b8
.loc 1 979 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9402819
.loc 1 980 0
.word 0x140000ab
.loc 1 982 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9403819
.loc 1 983 0
.word 0x1400009e
.loc 1 985 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9402419
.loc 1 986 0
.word 0x14000091
.loc 1 988 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9402c19
.loc 1 989 0
.word 0x14000084
.loc 1 991 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9400419
.loc 1 992 0
.word 0x14000077
.loc 1 994 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9403019
.loc 1 995 0
.word 0x1400006a
.loc 1 997 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9402019
.loc 1 998 0
.word 0x1400005d
.loc 1 1008 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9403c19
.loc 1 1009 0
.word 0x14000050
.loc 1 1011 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9404019
.loc 1 1012 0
.word 0x14000043
.loc 1 1014 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9404419
.loc 1 1015 0
.word 0x14000036
.loc 1 1017 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xf9400000
.word 0xf9400800
.word 0xf9404819
.loc 1 1018 0
.word 0x14000029
.loc 1 1020 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2815fc1
bl _p_11
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90027a0
.word 0xf90023a0
.word 0xf9400f40
.word 0xf9401401
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94027a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a3
.word 0xaa0303e0
.word 0xf9001fa0
.word 0xf9401342
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba1
.word 0xf9401fa2
.word 0xd2820600
bl _p_32
bl _p_13
.loc 1 1023 0
.word 0x3940035e
.word 0xf9401b40
bl _p_75
.word 0xf9001ba0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_80
.word 0xaa0003e3
.word 0xf9401ba1
.word 0xf94017a0
.word 0xaa1903e2
bl _p_121
.word 0x53001c00
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_5e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetPropertyMethod_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetPropertyMethod_System_Reflection_PropertyInfo:
.loc 1 1028 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407830
.word 0xd63f0200
.word 0x53001c00
.word 0x340000e0
.loc 1 1029 0
.word 0xaa1a03e0
.word 0xd2800021
.word 0xf9400342
.word 0xf9406c50
.word 0xd63f0200
.word 0x14000006
.loc 1 1031 0
.word 0xaa1a03e0
.word 0xd2800021
.word 0xf9400342
.word 0xf9406450
.word 0xd63f0200
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsStaticProperty_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_IsStaticProperty_System_Reflection_PropertyInfo:
.loc 1 1036 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_122
.word 0xaa0003e1
.word 0xaa0103e0
.word 0x3940003e
bl _p_53
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_60:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_IsVirtualProperty_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_IsVirtualProperty_System_Reflection_PropertyInfo:
.loc 1 1041 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_122
.word 0xaa0003e1
.word 0xaa0103e0
.word 0x3940003e
bl _p_56
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_61:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_GetBasePropertyInTypeHierarchy_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_GetBasePropertyInTypeHierarchy_System_Reflection_PropertyInfo:
.loc 1 1046 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_54
.word 0x53001c00
.word 0x350000a0
.word 0xaa1a03e0
bl _p_123
.word 0x53001c00
.word 0x35000060
.loc 1 1047 0
.word 0xaa1a03e0
.word 0x14000026
.loc 1 1049 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003f9
.word 0x14000019

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 1051 0
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_124
.word 0xaa0003f8
.loc 1 1052 0
.word 0xaa1803e0
.word 0xb4000100
.loc 1 1053 0
.word 0xaa1803e0
bl _p_36
.word 0xaa0003fa
.word 0xb5000040
.word 0xaa1803fa
.word 0xaa1a03e0
.word 0x14000008
.loc 1 1055 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003f9
.loc 1 1050 0
.word 0xb5fffd19
.loc 1 1058 0
.word 0xd2800000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_62:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_TryMatchProperty_System_Type_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_TryMatchProperty_System_Type_System_Reflection_PropertyInfo:
.loc 1 1063 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
.word 0xd28006c1
.word 0xf9400322
.word 0xf940ac50
.word 0xd63f0200
.word 0xaa0003f9
.word 0xd2a00018
.word 0x14000018

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x540002c9
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400017
.loc 1 1064 0
.word 0xaa1703e0
.word 0xaa1a03e1
bl _p_125
.word 0x53001c00
.word 0x34000060
.loc 1 1065 0
.word 0xaa1703e0
.word 0x14000006
.word 0x11000718
.loc 1 1063 0
.word 0xb9801b20
.word 0x6b00031f
.word 0x54fffceb
.loc 1 1067 0
.word 0xd2800000
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_63:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_PropertyMatch_System_Reflection_PropertyInfo_System_Reflection_PropertyInfo
Registrar_DynamicRegistrar_PropertyMatch_System_Reflection_PropertyInfo_System_Reflection_PropertyInfo:
.loc 1 1072 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405c30
.word 0xd63f0200
.word 0xf90013a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94013a0
bl _p_126
.word 0x53001c00
.word 0x34000060
.loc 1 1073 0
.word 0xd2a00000
.word 0x14000052
.loc 1 1075 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9407830
.word 0xd63f0200
.word 0x53001c00
.word 0x34000360
.loc 1 1076 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407830
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 1 1077 0
.word 0xd2a00000
.word 0x14000044
.loc 1 1078 0
.word 0xaa1903e0
.word 0xd2800021
.word 0xf9400322
.word 0xf9406c50
.word 0xd63f0200
.word 0xf90013a0
.word 0xaa1a03e0
.word 0xd2800021
.word 0xf9400342
.word 0xf9406c50
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94013a0
bl _p_127
.word 0x53001c00
.word 0x35000160
.loc 1 1079 0
.word 0xd2a00000
.word 0x14000032
.loc 1 1080 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407830
.word 0xd63f0200
.word 0x53001c00
.word 0x34000060
.loc 1 1081 0
.word 0xd2a00000
.word 0x1400002a
.loc 1 1084 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9407430
.word 0xd63f0200
.word 0x53001c00
.word 0x34000360
.loc 1 1085 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407430
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 1 1086 0
.word 0xd2a00000
.word 0x1400001c
.loc 1 1087 0
.word 0xaa1903e0
.word 0xd2800021
.word 0xf9400322
.word 0xf9406450
.word 0xd63f0200
.word 0xf90013a0
.word 0xaa1a03e0
.word 0xd2800021
.word 0xf9400342
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94013a0
bl _p_127
.word 0x53001c00
.word 0x35000160
.loc 1 1088 0
.word 0xd2a00000
.word 0x1400000a
.loc 1 1089 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9407430
.word 0xd63f0200
.word 0x53001c00
.word 0x34000060
.loc 1 1090 0
.word 0xd2a00000
.word 0x14000002
.loc 1 1093 0
.word 0xd2800020
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_64:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_MethodMatch_System_Reflection_MethodInfo_System_Reflection_MethodInfo
Registrar_DynamicRegistrar_MethodMatch_System_Reflection_MethodInfo_System_Reflection_MethodInfo:
.loc 1 1098 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
.word 0x3940033e
bl _p_56
.word 0x53001c00
.word 0x35000060
.loc 1 1099 0
.word 0xd2a00000
.word 0x14000060
.loc 1 1101 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405c30
.word 0xd63f0200
.word 0xf9001ba0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba0
bl _p_126
.word 0x53001c00
.word 0x34000060
.loc 1 1102 0
.word 0xd2a00000
.word 0x14000050
.loc 1 1104 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940a430
.word 0xd63f0200
.word 0xf9001ba0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940a430
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba0
bl _p_128
.word 0x53001c00
.word 0x35000060
.loc 1 1105 0
.word 0xd2a00000
.word 0x14000040
.loc 1 1107 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9409030
.word 0xd63f0200
.word 0xaa0003f9
.loc 1 1108 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9409030
.word 0xd63f0200
.word 0xaa0003fa
.loc 1 1109 0
.word 0xb9801b20
.word 0xb9801b41
.word 0x6b01001f
.word 0x54000060
.loc 1 1110 0
.word 0xd2a00000
.word 0x14000030
.loc 1 1112 0
.word 0xd2a00018
.word 0x1400002a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 1 1113 0
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000509
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xf9001ba0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000349
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba0
bl _p_128
.word 0x53001c00
.word 0x35000060
.loc 1 1114 0
.word 0xd2a00000
.word 0x14000006
.loc 1 1112 0
.word 0x11000718
.word 0xb9801b20
.word 0x6b00031f
.word 0x54fffaab
.loc 1 1116 0
.word 0xd2800020
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_65:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_TypeMatch_System_Type_System_Type
Registrar_DynamicRegistrar_TypeMatch_System_Type_System_Type:
.loc 1 1121 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_48
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_66:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_Register_System_Type
Registrar_DynamicRegistrar_Register_System_Type:
.loc 1 1126 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf
.word 0xf90013bf
.loc 1 1127 0
.word 0xf9400fa0
.word 0xaa1a03e1
.word 0x910083a2
bl _p_129
.word 0xaa0003fa
.loc 1 1128 0
.word 0xf94013a0
.word 0xb40000e0
.word 0xf94013a0
.word 0xaa0003e1
.word 0x3940003e
.word 0xb9801800
.word 0x6b1f001f
.word 0x5400012c
.loc 1 1130 0
.word 0xb500007a
.loc 1 1131 0
.word 0xd2800000
.word 0x14000002
.loc 1 1132 0
.word 0xf9403f40
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 1 1129 0
.word 0xf94013a0
.word 0xf9001fa0
.word 0xd2800940
bl _p_130
.word 0xf9401fa1
.word 0xf9001ba0
bl _p_131
.word 0xf9401ba0
bl _p_13

Lme_67:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar_ComputeSignature_System_Reflection_MethodInfo_bool
Registrar_DynamicRegistrar_ComputeSignature_System_Reflection_MethodInfo_bool:
.loc 1 1142 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xf9400fa2
.word 0xd2800003
.word 0xd2a00004
.word 0x394083a5
bl _p_132
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_68:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__FindMethodsd__16__ctor_int
Registrar_DynamicRegistrar__FindMethodsd__16__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9004001
bl _p_133
.word 0x93407c00
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xb9004401
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_69:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__FindMethodsd__16_System_IDisposable_Dispose
Registrar_DynamicRegistrar__FindMethodsd__16_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6a:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__FindMethodsd__16_MoveNext
Registrar_DynamicRegistrar__FindMethodsd__16_MoveNext:
.loc 1 0 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9804359
.word 0xaa1903e0
.word 0x340000c0
.word 0xd280003e
.word 0x6b1e033f
.word 0x54000860
.word 0xd2a00000
.word 0x1400004d
.word 0x9280001e
.word 0xb900435e
.loc 1 177 0
.word 0xf9400f42
.word 0xaa0203e0
.word 0xd28007c1
.word 0xf9400042
.word 0xf940c050
.word 0xd63f0200
.word 0xf90013a0
.word 0x9100e341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xb9004b5f
.word 0x1400002d
.word 0xf9401f40
.word 0xb9804b41
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000629
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400019
.loc 1 178 0
.word 0xaa1903e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405c30
.word 0xd63f0200
.word 0xf9401741
bl _p_20
.word 0x53001c00
.word 0x340002c0
.loc 1 179 0
.word 0x91004340
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xd280003e
.word 0xb900435e
.word 0xd2800020
.word 0x1400000d
.word 0x9280001e
.word 0xb900435e
.word 0xb9804b40
.word 0x11000400
.word 0xb9004b40
.loc 1 177 0
.word 0xb9804b40
.word 0xf9401f42
.word 0xb9801841
.word 0x6b01001f
.word 0x54fffa0b
.word 0xf9001f5f
.loc 1 180 0
.word 0xd2a00000
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_6b:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__FindMethodsd__16_System_Collections_Generic_IEnumerator_System_Reflection_MethodBase_get_Current
Registrar_DynamicRegistrar__FindMethodsd__16_System_Collections_Generic_IEnumerator_System_Reflection_MethodBase_get_Current:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6c:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__FindMethodsd__16_System_Collections_Generic_IEnumerable_System_Reflection_MethodBase_GetEnumerator
Registrar_DynamicRegistrar__FindMethodsd__16_System_Collections_Generic_IEnumerable_System_Reflection_MethodBase_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9804340
.word 0x9280003e
.word 0x6b1e001f
.word 0x54000181
.word 0xb9804740
.word 0xf90013a0
bl _p_133
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94013a0
.word 0x6b01001f
.word 0x54000081
.word 0xb900435f
.word 0xaa1a03f9
.word 0x1400000b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #456]
.word 0xd2800a01
bl _p_3
.word 0xf90013a0
.word 0xd2a00001
bl _p_25
.word 0xf94013a0
.word 0xaa0003f9
.word 0xf9401340
.word 0xf90017a0
.word 0x91006321
.word 0xd5033bbf
.word 0xf94017a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf9401b40
.word 0xf90013a0
.word 0x9100a321
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_6d:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33__ctor_int
Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9003001
bl _p_133
.word 0x93407c00
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xb9003401
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6e:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_IDisposable_Dispose
Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6f:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_MoveNext
Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_MoveNext:
.loc 1 0 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9803359
.word 0xaa1903e0
.word 0x340000c0
.word 0xd280003e
.word 0x6b1e033f
.word 0x540008c0
.word 0xd2a00000
.word 0x14000050
.word 0x9280001e
.word 0xb900335e
.loc 1 303 0
.word 0xf9400f42
.word 0xaa0203e0
.word 0xd2a00001
.word 0xf9400042
.word 0xf9404850
.word 0xd63f0200
.word 0xf9001ba0
.word 0x9100a341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xb9003b5f
.word 0x14000030
.word 0xf9401740
.word 0xb9803b41
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540006a9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400019
.word 0xaa1903f8
.word 0xeb1f033f
.word 0x54000100
.word 0xf9400320

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #896]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803f9
.loc 1 305 0
.word 0xb40002d8
.loc 1 306 0
.word 0x91004340
.word 0xf9001ba0
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xd280003e
.word 0xb900335e
.word 0xd2800020
.word 0x1400000d
.word 0x9280001e
.word 0xb900335e
.word 0xb9803b40
.word 0x11000400
.word 0xb9003b40
.loc 1 303 0
.word 0xb9803b40
.word 0xf9401742
.word 0xb9801841
.word 0x6b01001f
.word 0x54fff9ab
.word 0xf900175f
.loc 1 308 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_70:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_Collections_Generic_IEnumerator_Foundation_ProtocolMemberAttribute_get_Current
Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_Collections_Generic_IEnumerator_Foundation_ProtocolMemberAttribute_get_Current:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_71:
.text
	.align 4
	.no_dead_strip Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_Collections_Generic_IEnumerable_Foundation_ProtocolMemberAttribute_GetEnumerator
Registrar_DynamicRegistrar__GetProtocolMemberAttributesd__33_System_Collections_Generic_IEnumerable_Foundation_ProtocolMemberAttribute_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9803340
.word 0x9280003e
.word 0x6b1e001f
.word 0x54000181
.word 0xb9803740
.word 0xf90013a0
bl _p_133
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94013a0
.word 0x6b01001f
.word 0x54000081
.word 0xb900335f
.word 0xaa1a03f9
.word 0x1400000b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #544]
.word 0xd2800801
bl _p_3
.word 0xf90013a0
.word 0xd2a00001
bl _p_39
.word 0xf94013a0
.word 0xaa0003f9
.word 0xf9401340
.word 0xf90013a0
.word 0x91006321
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_72:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateSetterSelector_string
Registrar_Registrar_CreateSetterSelector_string:
.file 2 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/ObjCRuntime/Registrar.core.cs"
.loc 2 10 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x790043bf
.word 0xaa1a03f9
.word 0xb40000ba
.word 0xb9801320
.word 0x6b1f001f
.word 0x9a9f17f9
.word 0x14000002
.word 0xd2800039
.word 0x53001f20
.word 0x34000060
.loc 2 14 0
.word 0xaa1a03e0
.word 0x14000025
.loc 2 16 0
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x54000489
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402819
.loc 2 18 0
.word 0xaa1903e0
.word 0xd2800c3e
.word 0x6b1e001f
.word 0x540000cb
.word 0xd2800f5e
.word 0x6b1e033f
.word 0x5400006c
.loc 2 19 0
.word 0x51008320
.word 0x53003c19
.loc 2 20 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #904]
.word 0xf9001ba0
.word 0x790043b9
.word 0x910083a0
bl _p_134
.word 0xf9001fa0
.word 0xaa1a03e0
.word 0xd2800021
.word 0x3940035e
bl _p_135
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xf9401fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #912]
bl _p_136
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_73:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_SanitizeObjectiveCName_string
Registrar_Registrar_SanitizeObjectiveCName_string:
.loc 2 25 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800019
.loc 2 27 0
.word 0xd2a00018
.word 0x1400004d

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 2 28 0
.word 0x93407f00
.word 0xb9801341
.word 0xeb00003f
.word 0x10000011
.word 0x54000a49
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c17
.word 0xaa1703e0
.word 0xd28005fe
.word 0x6b1e001f
.word 0x54000208
.word 0xd280049e
.word 0x6b1e02ff
.word 0x54000380
.word 0x5100aef6
.word 0xd28000be
.word 0x6b1e02df
.word 0x540005a2
.word 0xd37df2c0
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #920]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0x5100f2f6
.word 0xd28000be
.word 0x6b1e02df
.word 0x54000122
.word 0xd37df2c0
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #928]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800c1e
.word 0x6b1e02ff
.word 0x540002c1
.loc 2 39 0
.word 0xb5000219
.loc 2 40 0
.word 0xb9801340
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xd2800601
bl _p_3
.word 0xf94027a4
.word 0xf90023a0
.word 0xaa1a03e1
.word 0xd2a00002
.word 0xaa1803e3
bl _p_137
.word 0xf94023a0
.word 0xaa0003f9
.loc 2 41 0
.word 0xaa1903e0
.word 0xd2800be1
.word 0x3940033e
bl _p_138
.loc 2 42 0
.word 0x14000006
.loc 2 44 0
.word 0xb40000b9
.loc 2 45 0
.word 0xaa1903e0
.word 0xaa1703e1
.word 0x3940033e
bl _p_138
.loc 2 27 0
.word 0x11000718
.word 0xb9801340
.word 0x6b00031f
.word 0x54fff64b
.loc 2 50 0
.word 0xb40000d9
.loc 2 51 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9403030
.word 0xd63f0200
.word 0x14000002
.loc 2 53 0
.word 0xaa1a03e0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_74:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_OnRegisterType_Registrar_Registrar_ObjCType
Registrar_Registrar_OnRegisterType_Registrar_Registrar_ObjCType:
.file 3 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/ObjCRuntime/Registrar.cs"
.loc 3 1066 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_75:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_OnSkipType_System_Type_Registrar_Registrar_ObjCType
Registrar_Registrar_OnSkipType_System_Type_Registrar_Registrar_ObjCType:
.loc 3 1067 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_76:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_OnReloadType_Registrar_Registrar_ObjCType
Registrar_Registrar_OnReloadType_Registrar_Registrar_ObjCType:
.loc 3 1068 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_77:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_OnRegisterProtocol_Registrar_Registrar_ObjCType
Registrar_Registrar_OnRegisterProtocol_Registrar_Registrar_ObjCType:
.loc 3 1069 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_78:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_OnRegisterCategory_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_OnRegisterCategory_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_:
.loc 3 1070 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_79:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_SkipRegisterAssembly_System_Reflection_Assembly
Registrar_Registrar_SkipRegisterAssembly_System_Reflection_Assembly:
.loc 3 1072 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7a:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetLinkedAwayInterfaces_System_Type
Registrar_Registrar_GetLinkedAwayInterfaces_System_Type:
.loc 3 1082 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xd2800000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_82:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetSdkIntroducedVersion_System_Type_string_
Registrar_Registrar_GetSdkIntroducedVersion_System_Type_string_:
.loc 3 1109 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf900001f
.word 0xd2800000
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_9d:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_get_LaxMode
Registrar_Registrar_get_LaxMode:
.loc 3 1155 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c3:
.text
	.align 4
	.no_dead_strip Registrar_Registrar__ctor
Registrar_Registrar__ctor:
.loc 3 97 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #944]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #952]
.word 0xf90023a0
bl _p_139
.word 0x91004341
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 99 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #960]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #968]
.word 0xf9001fa0
bl _p_140
.word 0x91006341
.word 0xd5033bbf
.word 0xf9401fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 102 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #976]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #984]
.word 0xf9001ba0
bl _p_141
.word 0x91008341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 105 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #976]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #984]
.word 0xf90017a0
bl _p_141
.word 0x9100a341
.word 0xd5033bbf
.word 0xf94017a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 108 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #976]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #984]
.word 0xf90013a0
bl _p_141
.word 0x9100c341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 1159 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_c4:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsPropertyAccessor_System_Reflection_MethodBase
Registrar_Registrar_IsPropertyAccessor_System_Reflection_MethodBase:
.loc 3 1163 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb500007a
.loc 3 1164 0
.word 0xd2a00000
.word 0x14000023
.loc 3 1166 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_142
.word 0x53001c00
.word 0x35000060
.loc 3 1167 0
.word 0xd2a00000
.word 0x1400001c
.loc 3 1169 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1170 0
.word 0xaa1a03e3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #992]
.word 0xaa0303e0
.word 0xd2800082
.word 0x3940007e
bl _p_143
.word 0x53001c00
.word 0x35000180

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1000]
.word 0xaa1a03e0
.word 0xd2800082
.word 0x3940035e
bl _p_143
.word 0x53001c00
.word 0x35000060
.loc 3 1171 0
.word 0xd2a00000
.word 0x14000002
.loc 3 1173 0
.word 0xd2800020
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c5:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsArray_System_Type
Registrar_Registrar_IsArray_System_Type:
.loc 3 1190 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb90023bf
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910083a2
.word 0xf9400ba3
.word 0xf9400063
.word 0xf940c070
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_c6:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsEnum_System_Type
Registrar_Registrar_IsEnum_System_Type:
.loc 3 1196 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x390083bf
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910083a2
.word 0xf9400ba3
.word 0xf9400063
.word 0xf940bc70
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_c7:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetBindAsAttribute_Registrar_Registrar_ObjCMethod_int
Registrar_Registrar_GetBindAsAttribute_Registrar_Registrar_ObjCMethod_int:
.loc 3 1201 0 prologue_end
.word 0xa9b77bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402321
.word 0xaa1803e0
.word 0xaa1a03e2
.word 0xf9400303
.word 0xf940d870
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1202 0
.word 0xaa1703e0
.word 0xb40009e0
.loc 3 1203 0
.word 0x9280001e
.word 0x6b1e035f
.word 0x54000200
.word 0xf9402321
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9414850
.word 0xd63f0200
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540028a9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400000
.word 0x14000006
.word 0xf9402321
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9411050
.word 0xd63f0200
.loc 3 1204 0
.word 0x9280001e
.word 0x6b1e035f
.word 0x54000201
.loc 3 1205 0
.word 0xf9402321
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9411050
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1206 0
.word 0xf9400ae2
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400303
.word 0xf9404470
.word 0xd63f0200
.word 0x53001c00
.word 0x34000ba0
.word 0x14000024
.loc 3 1209 0
.word 0xf9402321
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9414850
.word 0xd63f0200
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540023e9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400016
.loc 3 1210 0
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400302
.word 0xf9413050
.word 0xd63f0200
.word 0x53001c00
.word 0x340000e0
.loc 3 1211 0
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400302
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003f6
.loc 3 1212 0
.word 0xf9400ae2
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400303
.word 0xf9404470
.word 0xd63f0200
.word 0x53001c00
.word 0x34000ee0
.loc 3 1216 0
.word 0xaa1703e0
.word 0x14000031
.loc 3 1219 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_144
.word 0x53001c00
.word 0x35000060
.loc 3 1220 0
.word 0xd2800000
.word 0x1400002a
.loc 3 1222 0
.word 0xf9400f20
.word 0xf9401400
.word 0xf90023a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_85
.word 0xaa0003e2
.word 0xaa0203e0
.word 0xd2800081
.word 0x3940005e
bl _p_135
.word 0xaa0003e2
.word 0xf94023a1
.word 0xaa1803e0
.word 0xf9400303
.word 0xf9406c70
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1223 0
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400302
.word 0xf940d450
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1224 0
.word 0xaa1703e0
.word 0xb40001e0
.loc 3 1225 0
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400302
.word 0xf9405450
.word 0xd63f0200
.word 0xaa0003f6
.loc 3 1226 0
.word 0xf9400ae2
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400303
.word 0xf9404470
.word 0xd63f0200
.word 0x53001c00
.word 0x340010e0
.loc 3 1229 0
.word 0xaa1703e0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.loc 3 1207 0
.word 0xf9402320
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2818da1
bl _p_11
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9003fa0
.word 0xf9003ba0
.word 0xaa1903e0
.word 0x3940033e
bl _p_108
.word 0xaa0003e2
.word 0xf9403fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403ba0
.word 0xf90037a0
.word 0xf90033a0
.word 0xf9400ae1
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94037a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94033a0
.word 0xf9002fa0
.word 0xf9002ba0
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402fa3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a2
.word 0xf94027a3
.word 0xf9402ba4
.word 0xaa1803e0
.word 0xd2820961
bl _p_145
bl _p_13
.loc 3 1213 0
.word 0xf9402320
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd281ae41
bl _p_11
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf90043a0
.word 0xf9003ba0
.word 0x11000740
.word 0xf9003fa0
.word 0xd28012a0
bl _p_130
.word 0xaa0003e2
.word 0xf9403fa0
.word 0xf94043a3
.word 0xb9001040
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403ba0
.word 0xf90037a0
.word 0xf90033a0
.word 0xf9400ae1
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94037a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94033a0
.word 0xf9002fa0
.word 0xf9002ba0
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402fa3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a2
.word 0xf94027a3
.word 0xf9402ba4
.word 0xaa1803e0
.word 0xd2820961
bl _p_145
bl _p_13
.loc 3 1227 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd281cba1
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf90043a0
.word 0xf9003fa0
.word 0xf9400f20
.word 0xf9401401
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400302
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xf9400ae1
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa0
.word 0xf9002ba0
.word 0xf90027a0
.word 0xaa1803e0
.word 0xaa1603e1
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a3
.word 0xf94027a4
.word 0xaa1803e0
.word 0xd2820961
.word 0xaa1a03e2
bl _p_146
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_c8:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsSmartEnum_System_Type
Registrar_Registrar_IsSmartEnum_System_Type:
.loc 3 1235 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf
.word 0xf90017bf
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910083a2
.word 0x9100a3a3
bl _p_147
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_c9:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsSmartEnum_System_Type_System_Reflection_MethodBase__System_Reflection_MethodBase_
Registrar_Registrar_IsSmartEnum_System_Type_System_Reflection_MethodBase__System_Reflection_MethodBase_:
.loc 3 1240 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9002bbf
.word 0xd5033bbf
.word 0xf900033f
.loc 3 1241 0
.word 0xd5033bbf
.word 0xf900035f
.loc 3 1243 0
.word 0xaa1703e0
.word 0xaa1803e1
bl _p_148
.word 0x53001c00
.word 0x35000060
.loc 3 1244 0
.word 0xd2a00000
.word 0x1400013d
.loc 3 1246 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9417030
.word 0xd63f0200
.word 0xf9004ba0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9405c30
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1008]
bl _p_76
.word 0xaa0003e3
.word 0xf9404ba2
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e4
.word 0xf9407490
.word 0xd63f0200
.word 0xaa0003f6
.loc 3 1247 0
.word 0xaa1603e0
.word 0xb5000060
.loc 3 1248 0
.word 0xd2a00000
.word 0x14000124
.loc 3 1250 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1016]
.word 0xaa1703e0
.word 0xaa1603e1
.word 0xf94002e3
.word 0xf9407070
.word 0xd63f0200
.word 0xaa0003e1
.loc 3 1251 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1024]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1032]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9002ba0
.word 0x14000053

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 1252 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9411050
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1064]
.word 0xaa1703e0
bl _p_149
.word 0x53001c00
.word 0x34000600
.loc 3 1254 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003f4
.loc 3 1255 0
.word 0xaa1403e0
.word 0xb5000060
.word 0xd2800033
.word 0x14000007
.word 0xb9801a80
.word 0xd280003e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17f3
.word 0x350003f3
.loc 3 1257 0
.word 0xb9801a80
.word 0xeb1f001f
.word 0x10000011
.word 0x54001ba9
.word 0xf9401281
.word 0xaa1703e0
.word 0xaa1803e2
.word 0xf94002e3
.word 0xf9404470
.word 0xd63f0200
.word 0x53001c00
.word 0x34000260
.loc 3 1259 0
.word 0xd5033bbf
.word 0xf9000335
.word 0xd349ff20
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 1260 0
.word 0xf9002fbf
.word 0x94000016
.word 0xf9402fa0
.word 0xb4000040
bl _p_23
.word 0x14000026
.loc 3 1251 0
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff480
.word 0xf9002fbf
.word 0x94000005
.word 0xf9402fa0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9003bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba0
.word 0xb4000140
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9403bbe
.word 0xd61f03c0
.loc 3 1262 0
.word 0xf9400320
.word 0xb5000060
.loc 3 1263 0
.word 0xd2a00000
.word 0x14000093
.loc 3 1265 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1088]
.word 0xaa1703e0
.word 0xaa1603e1
.word 0xf94002e3
.word 0xf9407070
.word 0xd63f0200
.word 0xaa0003e1
.loc 3 1266 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1024]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1032]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9002ba0
.word 0x14000053

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 1267 0
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xf94002e2
.word 0xf9411050
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1703e0
.word 0xaa1803e2
.word 0xf94002e3
.word 0xf9404470
.word 0xd63f0200
.word 0x53001c00
.word 0x34000660
.loc 3 1269 0
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xf94002e2
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003f6
.loc 3 1270 0
.word 0xaa1603e0
.word 0xb5000060
.word 0xd2800033
.word 0x14000007
.word 0xb9801ac0
.word 0xd280003e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17f3
.word 0x35000453
.loc 3 1272 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x540009e9
.word 0xf94012c1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1064]
.word 0xaa1703e0
bl _p_149
.word 0x53001c00
.word 0x34000260
.loc 3 1274 0
.word 0xd5033bbf
.word 0xf9000359
.word 0xd349ff40
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 1275 0
.word 0xf90033bf
.word 0x94000016
.word 0xf94033a0
.word 0xb4000040
bl _p_23
.word 0x14000026
.loc 3 1266 0
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff480
.word 0xf90033bf
.word 0x94000005
.word 0xf94033a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90043be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba0
.word 0xb4000140
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94043be
.word 0xd61f03c0
.loc 3 1277 0
.word 0xf9400340
.word 0xb5000060
.loc 3 1278 0
.word 0xd2a00000
.word 0x14000002
.loc 3 1280 0
.word 0xd2800020
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_ca:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetMemberName_Registrar_Registrar_ObjCMember
Registrar_Registrar_GetMemberName_Registrar_Registrar_ObjCMember:
.loc 3 1285 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803f7
.loc 3 1286 0
.word 0xb4000278
.loc 3 1287 0
.word 0xf94022e0
.word 0xb40000e0
.loc 3 1288 0
.word 0xf94022e1
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9405050
.word 0xd63f0200
.word 0x1400002c
.loc 3 1289 0
.word 0xaa1703e0
.word 0x394002fe
bl _p_85
.word 0xaa0003fa
.word 0xb5000080

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x26, [x16, #1096]
.word 0xaa1a03e0
.word 0x14000022
.loc 3 1291 0
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1104]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803f7
.loc 3 1292 0
.word 0xb40000f8
.loc 3 1293 0
.word 0xf94022e1
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9405850
.word 0xd63f0200
.word 0x1400000d
.loc 3 1294 0
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1112]
.word 0xeb01001f
.word 0x10000011
.word 0x540000e1
.word 0xf9401340
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_cb:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_string_object__
Registrar_Registrar_CreateException_int_string_object__:
.loc 3 1404 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
bl _p_150
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_cc:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_System_Reflection_MethodBase_string_object__
Registrar_Registrar_CreateException_int_System_Reflection_MethodBase_string_object__:
.loc 3 1409 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
bl _p_151
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_cd:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_System_Reflection_PropertyInfo_string_object__
Registrar_Registrar_CreateException_int_System_Reflection_PropertyInfo_string_object__:
.loc 3 1414 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
bl _p_152
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_ce:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_System_Type_string_object__
Registrar_Registrar_CreateException_int_System_Type_string_object__:
.loc 3 1419 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
bl _p_153
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_cf:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_System_Exception_System_Reflection_PropertyInfo_string_object__
Registrar_Registrar_CreateException_int_System_Exception_System_Reflection_PropertyInfo_string_object__:
.loc 3 1424 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
.word 0xf9401fa6
bl _p_154
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d0:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_string_object__:
.loc 3 1429 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0x394083a2
.word 0xd2800003
.word 0xf94017a4
.word 0xf9401ba5
bl _p_151
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d1:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_System_Reflection_MethodBase_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_System_Reflection_MethodBase_string_object__:
.loc 3 1434 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0x394083a2
.word 0xd2800003
.word 0xf94017a4
.word 0xf9401ba5
.word 0xf9401fa6
.word 0xf9400ba7
.word 0xf94000e7
.word 0xf94080f0
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d2:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_System_Reflection_PropertyInfo_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_System_Reflection_PropertyInfo_string_object__:
.loc 3 1439 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0x394083a2
.word 0xd2800003
.word 0xf94017a4
.word 0xf9401ba5
.word 0xf9401fa6
bl _p_154
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d3:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_System_Type_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_System_Type_string_object__:
.loc 3 1444 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4
.word 0xf9001fa5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0x394083a2
.word 0xd2800003
.word 0xf94017a4
.word 0xf9401ba5
.word 0xf9401fa6
.word 0xf9400ba7
.word 0xf94000e7
.word 0xf9407cf0
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d4:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_System_Exception_System_Reflection_PropertyInfo_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_System_Exception_System_Reflection_PropertyInfo_string_object__:
.loc 3 1449 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xaa0003f4
.word 0xf90013a1
.word 0xf90017a2
.word 0xf9001ba3
.word 0xf9001fa4
.word 0xf90023a5
.word 0xf90027a6

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401fa0
.word 0xb5000180
.loc 3 1450 0
.word 0xaa1403e0
.word 0xb98023a1
.word 0x3940a3a2
.word 0xf9401ba3
.word 0xd2800004
.word 0xf94023a5
.word 0xf94027a6
.word 0xf9400287
.word 0xf94080f0
.word 0xd63f0200
.word 0x14000023
.loc 3 1451 0
.word 0xaa1403e0
.word 0xf9401fa1
.word 0xf9400282
.word 0xf9414050
.word 0xd63f0200
.word 0xaa0003f3
.loc 3 1452 0
.word 0xaa1303e0
.word 0xb4000180
.loc 3 1453 0
.word 0xaa1403e0
.word 0xb98023a1
.word 0x3940a3a2
.word 0xf9401ba3
.word 0xaa1303e4
.word 0xf94023a5
.word 0xf94027a6
.word 0xf9400287
.word 0xf94080f0
.word 0xd63f0200
.word 0x14000010
.loc 3 1454 0
.word 0xaa1403e0
.word 0xf9401fa1
.word 0xf9400282
.word 0xf9413c50
.word 0xd63f0200
.word 0xaa0003e4
.word 0xaa1403e0
.word 0xb98023a1
.word 0x3940a3a2
.word 0xf9401ba3
.word 0xf94023a5
.word 0xf94027a6
.word 0xf9400287
.word 0xf94080f0
.word 0xd63f0200
.word 0xa94153b3
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_d5:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateException_int_Registrar_Registrar_ObjCMember_string_object__
Registrar_Registrar_CreateException_int_Registrar_Registrar_ObjCMember_string_object__:
.loc 3 1459 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2800022
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
bl _p_155
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d6:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateExceptionImpl_int_bool_Registrar_Registrar_ObjCMember_string_object__
Registrar_Registrar_CreateExceptionImpl_int_bool_Registrar_Registrar_ObjCMember_string_object__:
.loc 3 1464 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xf90013b8
.word 0xf90017a0
.word 0xf9001ba1
.word 0xf9001fa2
.word 0xaa0303f8
.word 0xf90023a4
.word 0xf90027a5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803f4
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800014
.word 0xaa1403f3
.loc 3 1465 0
.word 0xb4000134
.loc 3 1466 0
.word 0xf9402263
.word 0xf94017a0
.word 0xb98033a1
.word 0x3940e3a2
.word 0xf94023a4
.word 0xf94027a5
bl _p_151
.word 0x1400001e
.loc 3 1467 0
.word 0xaa1803f4
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1104]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800014
.word 0xaa1403f8
.loc 3 1468 0
.word 0xb4000134
.loc 3 1469 0
.word 0xf9402303
.word 0xf94017a0
.word 0xb98033a1
.word 0x3940e3a2
.word 0xf94023a4
.word 0xf94027a5
bl _p_152
.word 0x14000007
.loc 3 1470 0
.word 0xf94017a0
.word 0xb98033a1
.word 0x3940e3a2
.word 0xf94023a3
.word 0xf94027a4
bl _p_150
.word 0xa94153b3
.word 0xf94013b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_d7:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_CreateWarning_int_Registrar_Registrar_ObjCMember_string_object__
Registrar_Registrar_CreateWarning_int_Registrar_Registrar_ObjCMember_string_object__:
.loc 3 1475 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xf9001ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xd2a00002
.word 0xf94013a3
.word 0xf94017a4
.word 0xf9401ba5
bl _p_155
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d8:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetDescriptiveMethodName_System_Reflection_MethodBase
Registrar_Registrar_GetDescriptiveMethodName_System_Reflection_MethodBase:
.loc 3 1480 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb50000da
.loc 3 1481 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #712]
.word 0xf9400000
.word 0x14000055
.loc 3 1483 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xd2800601
bl _p_3
.word 0xf9001fa0
bl _p_156
.word 0xf9401fa0
.word 0xaa0003f8
.loc 3 1485 0
.word 0xaa1803e0
.word 0xf9001ba0
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba2
.word 0xaa0203e0
.word 0x3940005e
bl _p_157
.loc 3 1486 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1120]
.word 0xaa1803e0
.word 0x3940031e
bl _p_157
.loc 3 1487 0
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1488 0
.word 0xaa1a03e0
.word 0xb4000500
.word 0xb9801b40
.word 0x340004c0
.loc 3 1489 0
.word 0xd2a00017
.word 0x14000021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1490 0
.word 0x6b1f02ff
.word 0x540000ed
.loc 3 1491 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1128]
.word 0xaa1803e0
.word 0x3940031e
bl _p_157
.loc 3 1492 0
.word 0x93407ee0
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000409
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400001
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1803e0
.word 0x3940031e
bl _p_157
.loc 3 1489 0
.word 0x110006f7
.word 0xb9801b40
.word 0x6b0002ff
.word 0x54fffbcb
.loc 3 1495 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1136]
.word 0xaa1803e0
.word 0x3940031e
bl _p_157
.loc 3 1496 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9403030
.word 0xd63f0200
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_d9:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetDescriptiveMethodName_System_Type_System_Reflection_MethodBase
Registrar_Registrar_GetDescriptiveMethodName_System_Type_System_Reflection_MethodBase:
.loc 3 1501 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0xf9001fa0
.word 0xf9400ba0
.word 0xf94013a1
bl _p_29
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xf9401fa1
bl _p_30
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_da:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsNSObject_System_Type
Registrar_Registrar_IsNSObject_System_Type:
.loc 3 1510 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf
.word 0xf90017bf
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0x910083a2
.word 0x9100a3a3
.word 0xf9400324
.word 0xf9410c90
.word 0xd63f0200
.loc 3 1512 0
.word 0xf94013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1056]
bl _p_20
.word 0x53001c00
.word 0x34000140
.word 0xf94017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 1513 0
.word 0xd2800020
.word 0x14000011
.loc 3 1515 0
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9415850
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1516 0
.word 0xaa1a03e0
.word 0xb4000100
.loc 3 1517 0
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9404850
.word 0xd63f0200
.word 0x53001c00
.word 0x14000002
.loc 3 1519 0
.word 0xd2a00000
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_db:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_AreEqual_System_Type_System_Type
Registrar_Registrar_AreEqual_System_Type_System_Type:
.loc 3 1524 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf94013a1
bl _p_48
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_dc:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_Is_System_Type_string_string
Registrar_Registrar_Is_System_Type_string_string:
.loc 3 1530 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0xf9001fbf
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x9100c3a2
.word 0x9100e3a3
.word 0xf9400ba4
.word 0xf9400084
.word 0xf9410c90
.word 0xd63f0200
.loc 3 1531 0
.word 0xf9401ba0
.word 0xf94013a1
bl _p_20
.word 0x53001c00
.word 0x340000c0
.word 0xf9401fa0
.word 0xf94017a1
bl _p_20
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_dd:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_HasModelAttribute_System_Type
Registrar_Registrar_HasModelAttribute_System_Type:
.loc 3 1539 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1160]
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910083a4
.word 0xf9400ba5
.word 0xf94000a5
.word 0xf94108b0
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_de:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_HasProtocolAttribute_System_Type
Registrar_Registrar_HasProtocolAttribute_System_Type:
.loc 3 1547 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1168]
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910083a4
.word 0xf9400ba5
.word 0xf94000a5
.word 0xf94108b0
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_df:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_RegisterType_System_Type
Registrar_Registrar_RegisterType_System_Type:
.loc 3 1554 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90017bf
.word 0xf9001bbf
.word 0xf9001fbf
.word 0x390103bf
.word 0xf9001bbf
.loc 3 1556 0
.word 0xf94013a0
.word 0xf9400c00
.word 0xf9001fa0
.word 0xd2a00000
.word 0x390103a0
.word 0xf9401fb8
.word 0x910103a0
.word 0xf90027a0
.word 0xaa1803e0
.word 0x910103a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1803e0
.word 0xf94027a1
bl _p_21
.loc 3 1557 0
.word 0xf94013a0
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1176]
.word 0x3940001e
.word 0xaa1a03e1
.word 0x9100a3a2
bl _p_158
.word 0x53001c00
.word 0x34000100
.loc 3 1558 0
.word 0xf94017ba
.word 0xf9002bbf
.word 0x94000010
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x14000023
.loc 3 1560 0
.word 0xf94013a0
.word 0xaa1a03e1
.word 0x9100c3a2
bl _p_159
.word 0xf90017a0
.loc 3 1561 0
.word 0xf9002bbf
.word 0x94000005
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9002fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394103a0
.word 0x34000060
.word 0xf9401fa0
bl _p_24
.word 0xf9402fbe
.word 0xd61f03c0
.loc 3 1563 0
.word 0xf9401ba0
.word 0xb40000e0
.word 0xf9401ba0
.word 0xaa0003e1
.word 0x3940003e
.word 0xb9801800
.word 0x6b1f001f
.word 0x5400012c
.loc 3 1566 0
.word 0xf94017a0
.word 0x14000002
.loc 3 1567 0
.word 0xaa1a03e0
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.loc 3 1564 0
.word 0xf9401ba0
.word 0xf9003fa0
.word 0xd2800940
bl _p_130
.word 0xf9403fa1
.word 0xf9003ba0
bl _p_131
.word 0xf9403ba0
bl _p_13

Lme_e0:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_RegisterType_System_Type_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_RegisterType_System_Type_System_Collections_Generic_List_1_System_Exception_:
.loc 3 1572 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xf9000fba
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001fbf
.word 0x390103bf
.word 0xf94013a0
.word 0xf9400c00
.word 0xf9001fa0
.word 0xd2a00000
.word 0x390103a0
.word 0xf9401fb7
.word 0x910103a0
.word 0xf90027a0
.word 0xaa1703e0
.word 0x910103a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1703e0
.word 0xf94027a1
bl _p_21
.loc 3 1573 0
.word 0xf94013a0
.word 0xf94017a1
.word 0xf9401ba2
bl _p_159
.word 0xaa0003fa
.word 0xf9002bbf
.word 0x94000005
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9002fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394103a0
.word 0x34000060
.word 0xf9401fa0
bl _p_24
.word 0xf9402fbe
.word 0xd61f03c0
.loc 3 1574 0
.word 0xaa1a03e0
.word 0xf9400bb7
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_e1:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_VerifyNonGenericMethod_System_Collections_Generic_List_1_System_Exception__System_Type_System_Reflection_MethodBase
Registrar_Registrar_VerifyNonGenericMethod_System_Collections_Generic_List_1_System_Exception__System_Type_System_Reflection_MethodBase:
.loc 3 1578 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xaa0003f7
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1703e0
.word 0xf94017a1
.word 0xf94002e2
.word 0xf940ac50
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 3 1579 0
.word 0xd2800020
.word 0x14000021
.loc 3 1581 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1184]
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90023a0
.word 0xf9001fa0
.word 0xaa1703e0
.word 0xf94013a1
.word 0xf94017a2
bl _p_160
.word 0xaa0003e2
.word 0xf94023a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba3
.word 0xf9401fa4
.word 0xaa1703e0
.word 0xd2820221
.word 0xf94017a2
bl _p_145
.word 0xaa0003e1
.word 0xf9400fa0
bl _p_87
.loc 3 1583 0
.word 0xd2a00000
.word 0xf9400bb7
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_e2:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_VerifyInSdk_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCMethod
Registrar_Registrar_VerifyInSdk_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCMethod:
.loc 3 1588 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940035e
.word 0xf9403340
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x35000180
.word 0xf9402340
.word 0xb40002a0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_161
.word 0x53001c00
.word 0x35000200
.word 0xaa1a03e0
.word 0x3940035e
bl _p_162
.word 0xb4000180
.loc 3 1589 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_162
.word 0xaa0003e2
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xd2800003
.word 0xaa1a03e4
.word 0xd2800005
.word 0xd2800006
bl _p_163
.loc 3 1591 0
.word 0x3940035e
.word 0xf9402b40
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x350000e0
.word 0xf9402340
.word 0xb40004c0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_164
.word 0xb4000440
.loc 3 1592 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_164
.word 0xaa0003f7
.word 0xd2a00016
.word 0x14000019

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540002e9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.loc 3 1593 0
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xaa1503e2
.word 0xaa1a03e3
.word 0xd2800004
.word 0xd2800005
.word 0xd2800006
bl _p_163
.word 0x110006d6
.loc 3 1592 0
.word 0xb9801ae0
.word 0x6b0002df
.word 0x54fffccb
.loc 3 1595 0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_e3:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_VerifyInSdk_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCProperty
Registrar_Registrar_VerifyInSdk_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCProperty:
.loc 3 1599 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf94013a1
.word 0x3940003e
bl _p_60
.word 0xaa0003e2
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xd2800003
.word 0xd2800004
.word 0xf94013a5
.word 0xd2800006
bl _p_163
.loc 3 1600 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_e4:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_VerifyTypeInSDK_System_Collections_Generic_List_1_System_Exception__System_Type_Registrar_Registrar_ObjCMethod_Registrar_Registrar_ObjCMethod_Registrar_Registrar_ObjCProperty_System_Type
Registrar_Registrar_VerifyTypeInSDK_System_Collections_Generic_List_1_System_Exception__System_Type_Registrar_Registrar_ObjCMethod_Registrar_Registrar_ObjCMethod_Registrar_Registrar_ObjCProperty_System_Type:
.loc 3 1604 0 prologue_end
.word 0xa9b37bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025fb6
.word 0xf9001bb8
.word 0xf9001fba
.word 0xaa0003f4
.word 0xf90023a1
.word 0xaa0203f6
.word 0xaa0303f7
.word 0xaa0403f8
.word 0xf90027a5
.word 0xf9002ba6

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9002fbf
.word 0xaa1403e0
.word 0xaa1603e1
.word 0x910163a2
.word 0xf9400283
.word 0xf940e470
.word 0xd63f0200
.word 0xaa0003f3
.loc 3 1605 0
.word 0xaa1303e0
.word 0xb4002240
.loc 3 1608 0
.word 0xaa1403e0
.word 0xf9400281
.word 0xf940e030
.word 0xd63f0200
.word 0xf90033a0
.loc 3 1609 0
.word 0xaa1303e0
.word 0xf94033a1
bl _p_165
.word 0x53001c00
.word 0x35002100
.loc 3 1613 0
.word 0xaa1403e0
.word 0xaa1603e1
.word 0xf9400282
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003f6
.loc 3 1614 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #712]
.word 0xf9400000
.word 0xf90037a0
.loc 3 1615 0
.word 0xaa1403e0
.word 0xf9400281
.word 0xf9407830
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1616 0
.word 0xf94033a0
.word 0xf94033a1
.word 0xf9400021
.word 0xf9403030
.word 0xd63f0200
.word 0xf90033a0
.loc 3 1617 0
.word 0xaa1303e0
.word 0xf9400261
.word 0xf9403030
.word 0xd63f0200
.word 0xaa0003f3
.loc 3 1618 0
.word 0xf9402fa0
.word 0xf9003ba0
.word 0xf9403ba0
.word 0xb40000e0
.word 0xf9403ba0
.word 0xb9801000
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x3901e3a0
.word 0x14000003
.word 0xd280003e
.word 0x3901e3be
.word 0x3941e3a0
.word 0x53001c00
.word 0x35000160

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1192]
.word 0xf9402fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1200]
bl _p_30
.word 0xf90043a0
.word 0x14000005

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0xf90043a0
.word 0xf94043a0
.word 0xf90047a0
.loc 3 1619 0
.word 0xf9402ba0
.word 0xb4000180
.loc 3 1620 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1208]
.word 0xf9004ba0
.loc 3 1621 0
.word 0xaa1403e0
.word 0xf9402ba1
.word 0xf9400282
.word 0xf9406450
.word 0xd63f0200
.word 0xf90037a0
.word 0x14000026
.loc 3 1622 0
.word 0xb4000157
.loc 3 1623 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1216]
.word 0xf9004ba0
.loc 3 1624 0
.word 0xaa1703e0
.word 0x394002fe
bl _p_108
.word 0xf90037a0
.word 0x1400001c
.loc 3 1625 0
.word 0xb4000158
.loc 3 1626 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1224]
.word 0xf9004ba0
.loc 3 1627 0
.word 0xaa1803e0
.word 0x3940031e
bl _p_108
.word 0xf90037a0
.word 0x14000012
.loc 3 1628 0
.word 0xf94027a0
.word 0xb4000180
.loc 3 1629 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1232]
.word 0xf9004ba0
.loc 3 1630 0
.word 0xf94027a0
.word 0xf94027a1
.word 0xf9400021
.word 0xf9404030
.word 0xd63f0200
.word 0xf90037a0
.word 0x14000005
.loc 3 1632 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1240]
.word 0xf9004ba0
.loc 3 1635 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd28000c1
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf90067a0
.word 0xaa0303e0
.word 0xd2a00001
.word 0xaa1603e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94067a3
.word 0xaa0303e0
.word 0xf90063a0
.word 0xaa0303e0
.word 0xd2800021
.word 0xf94037a2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xaa0303e0
.word 0xf9005fa0
.word 0xaa0303e0
.word 0xd2800041
.word 0xaa1a03e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9405fa3
.word 0xaa0303e0
.word 0xf9005ba0
.word 0xaa0303e0
.word 0xd2800061
.word 0xf94033a2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9405ba3
.word 0xaa0303e0
.word 0xf90057a0
.word 0xaa0303e0
.word 0xd2800081
.word 0xaa1303e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94057a3
.word 0xaa0303e0
.word 0xf90053a0
.word 0xaa0303e0
.word 0xd28000a1
.word 0xf94047a2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94053a1
.word 0xf9404ba0
bl _p_58
.word 0xf9004ba0
.loc 3 1639 0
.word 0xf9402ba0
.word 0xb4000240
.loc 3 1640 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400004
.word 0xaa1403e0
.word 0xd2820841
.word 0xf9402ba2
.word 0xf9404ba3
bl _p_166
.word 0xaa0003fa
.word 0x14000047
.loc 3 1641 0
.word 0xb4000257
.loc 3 1642 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400004
.word 0xaa1403e0
.word 0xd2820841
.word 0xaa1703e2
.word 0xf9404ba3
bl _p_167
.word 0xaa0003fa
.word 0x14000035
.loc 3 1643 0
.word 0xb4000258
.loc 3 1644 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400004
.word 0xaa1403e0
.word 0xd2820841
.word 0xaa1803e2
.word 0xf9404ba3
bl _p_167
.word 0xaa0003fa
.word 0x14000023
.loc 3 1645 0
.word 0xf94027a0
.word 0xb4000240
.loc 3 1646 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400004
.word 0xaa1403e0
.word 0xd2820841
.word 0xf94027a2
.word 0xf9404ba3
bl _p_167
.word 0xaa0003fa
.word 0x14000010
.loc 3 1648 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400003
.word 0xaa1403e0
.word 0xd2820841
.word 0xf9404ba2
bl _p_168
.word 0xaa0003fa
.loc 3 1651 0
.word 0xf94023a0
.word 0xaa1a03e1
bl _p_87
.loc 3 1652 0
.word 0xa94153b3
.word 0xa9425fb6
.word 0xf9401bb8
.word 0xf9401fba
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0

Lme_e5:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_AddException_System_Collections_Generic_List_1_System_Exception__System_Exception
Registrar_Registrar_AddException_System_Collections_Generic_List_1_System_Exception__System_Exception:
.loc 3 1656 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400320
.word 0xb50004e0
.loc 3 1657 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1248]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1256]
.word 0xf9400021
.word 0xf9001fa1
.word 0xf9001ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9401fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000320
.word 0xd349ff21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 1658 0
.word 0xf9400320
.word 0xaa0003f9
.word 0xaa1a03f8
.word 0x3940033e
.word 0xb9801f21
.word 0x11000421
.word 0xb9001c01
.word 0xf9400b3a
.word 0xb9801b37
.word 0xaa1703e0
.word 0xb9801b41
.word 0x6b01001f
.word 0x54000142
.word 0x110006e0
.word 0xb9001b20
.word 0xaa1a03e0
.word 0xaa1703e1
.word 0xaa1803e2
.word 0xf9400343
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1264]
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_169
.loc 3 1659 0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e6:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_IsSubClassOf_System_Type_string_string
Registrar_Registrar_IsSubClassOf_System_Type_string_string:
.loc 3 0 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0xf9001fbf
.word 0x1400001a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1665 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0x9100c3a2
.word 0x9100e3a3
.word 0xf94002e4
.word 0xf9410c90
.word 0xd63f0200
.loc 3 1666 0
.word 0xf9401ba0
.word 0xaa1903e1
bl _p_20
.word 0x53001c00
.word 0x34000100
.word 0xf9401fa0
.word 0xaa1a03e1
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 1667 0
.word 0xd2800020
.word 0x1400000b
.loc 3 1663 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9415850
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xaa0103f8
.word 0xb5fffbe0
.loc 3 1670 0
.word 0xd2a00000
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e7:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_VerifyIsConstrainedToNSObject_System_Collections_Generic_List_1_System_Exception__System_Type_Registrar_Registrar_ObjCMethod
Registrar_Registrar_VerifyIsConstrainedToNSObject_System_Collections_Generic_List_1_System_Exception__System_Type_Registrar_Registrar_ObjCMethod:
.loc 3 1675 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90367b8
.word 0xf90023ba
.word 0xf90027a0
.word 0xf9002ba1
.word 0xf9002fa2
.word 0xf90033a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90037bf
.word 0xf90037bf
.loc 3 1677 0
.word 0xf94033a0
.word 0xf94033a1
.word 0x3940003e
bl _p_170
.word 0xaa0003e1
.word 0xf94027a0
.word 0x9101a3a2
.word 0xf94027a3
.word 0xf9400063
.word 0xf9409870
.word 0xd63f0200
.word 0x53001c00
.word 0x35000740
.loc 3 1678 0
.word 0xf94033a0
.word 0xf9402000
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1272]
.word 0xf90047a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90057a0
.word 0xf90053a0
.word 0xf94033a0
.word 0xf94033a1
.word 0x3940003e
bl _p_170
.word 0xaa0003e1
.word 0xf94027a0
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94057a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94053a0
.word 0xf9004fa0
.word 0xf9004ba0
.word 0xf94033a0
.word 0xf9402002
.word 0xf94027a0
.word 0xf9402fa1
bl _p_160
.word 0xaa0003e2
.word 0xf9404fa3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a2
.word 0xf94047a3
.word 0xf9404ba4
.word 0xf94027a0
.word 0xd2820421
bl _p_145
.word 0xaa0003e1
.word 0xf9402ba0
bl _p_87
.loc 3 1679 0
.word 0xd2a00000
.word 0x14000126
.loc 3 1681 0
.word 0xf94037a0
.word 0xb4000280
.loc 3 1682 0
.word 0xf94037a1
.word 0xf94033a0
.word 0x3940001e
.word 0xf90043a0
.word 0x91018002
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf900341f
.loc 3 1684 0
.word 0xf94033a0
.word 0xf94033a1
.word 0x3940003e
bl _p_164
.word 0xaa0003f6
.loc 3 1685 0
.word 0xaa1603e0
.word 0xb5000060
.loc 3 1686 0
.word 0xd2800020
.word 0x14000108
.loc 3 1688 0
.word 0xd2800015
.loc 3 1689 0
.word 0xd2a00014
.word 0x140000e7

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1690 0
.word 0x93407e80
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54002029
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400013
.loc 3 1691 0
.word 0xf94027a0
.word 0xaa1303e1
.word 0x9101a3a2
.word 0xf94027a3
.word 0xf9400063
.word 0xf9409870
.word 0xd63f0200
.word 0x53001c00
.word 0x35000900
.loc 3 1692 0
.word 0xf94033a0
.word 0xf9402000
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1280]
.word 0xf90047a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9005fa0
.word 0xf9005ba0
.word 0xf94027a0
.word 0xaa1303e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9405fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9405ba0
.word 0xf90057a0
.word 0xf90053a0
.word 0xf94033a0
.word 0xf9402002
.word 0xf94027a0
.word 0xf9402fa1
bl _p_160
.word 0xaa0003e2
.word 0xf94057a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94053a0
.word 0xf9004fa0
.word 0xf9004ba0
.word 0xf94033a0
.word 0xf9402001
.word 0xf94027a0
.word 0xaa1403e2
.word 0xf94027a3
.word 0xf9400063
.word 0xf9414470
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404fa3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a2
.word 0xf94047a3
.word 0xf9404ba4
.word 0xf94027a0
.word 0xd2820401
bl _p_145
.word 0xaa0003e1
.word 0xf9402ba0
bl _p_87
.loc 3 1693 0
.word 0xd2a00000
.word 0x140000a6
.loc 3 1695 0
.word 0xf94037a0
.word 0xb4000ce0
.loc 3 1696 0
.word 0xb5000935
.loc 3 1697 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1288]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1296]
.word 0xf9400021
.word 0xf90043a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003f5
.loc 3 1698 0
.word 0xd2a0001a
.word 0x1400002c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1699 0
.word 0x93407f40
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54001089
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400000
.word 0xaa1503f9
.word 0xaa0003f8
.word 0x394002be
.word 0xb9801ea0
.word 0x11000400
.word 0xb9001ea0
.word 0xf9400ab3
.word 0xb9801aa0
.word 0xb9007ba0
.word 0xb9801a61
.word 0x6b01001f
.word 0x54000142
.word 0xb9807ba1
.word 0x11000420
.word 0xb9001b20
.word 0xaa1303e0
.word 0xaa1803e2
.word 0xf9400263
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1304]
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_171
.loc 3 1698 0
.word 0x1100075a
.word 0x6b14035f
.word 0x54fffa8b
.loc 3 1701 0
.word 0xf94037a0
.word 0xaa1503fa
.word 0xaa0003f9
.word 0x394002be
.word 0xb9801ea0
.word 0x11000400
.word 0xb9001ea0
.word 0xf9400ab3
.word 0xb9801aa0
.word 0xb9007ba0
.word 0xb9801a61
.word 0x6b01001f
.word 0x54000142
.word 0xb9807ba1
.word 0x11000420
.word 0xb9001b40
.word 0xaa1303e0
.word 0xaa1903e2
.word 0xf9400263
.word 0xf9404070
.word 0xd63f0200
.word 0x14000026

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1304]
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_171
.word 0x1400001f
.loc 3 1702 0
.word 0xb40003d5
.loc 3 1703 0
.word 0xf9003bb5
.word 0xaa1303fa
.word 0xf9403ba0
.word 0x3940001e
.word 0xb9801c01
.word 0x11000421
.word 0xb9001c01
.word 0xf9400813
.word 0xb9801800
.word 0xb9007ba0
.word 0xb9801a61
.word 0x6b01001f
.word 0x54000162
.word 0xb9807ba1
.word 0x11000422
.word 0xf9403ba0
.word 0xb9001802
.word 0xaa1303e0
.word 0xaa1a03e2
.word 0xf9400263
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1304]
.word 0xf9403ba0
.word 0xaa1a03e1
bl _p_171
.loc 3 1689 0
.word 0x11000694
.word 0xb9801ac0
.word 0x6b00029f
.word 0x54ffe30b
.loc 3 1706 0
.word 0xb4000355
.loc 3 1707 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1312]
.word 0x394002be
.word 0xaa1503e0
bl _p_172
.word 0xaa0003e1
.word 0xf94033a0
.word 0x3940001e
.word 0xf90043a0
.word 0x91014002
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9002c1f
.loc 3 1709 0
.word 0xd2800020
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_e8:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_FlattenInterfaces_System_Type__
Registrar_Registrar_FlattenInterfaces_System_Type__:
.loc 3 1721 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801b40
.word 0xd280003e
.word 0x6b1e001f
.word 0x54000e00
.loc 3 1724 0
.word 0xd2a00018
.word 0x1400006b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1725 0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000d29
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400017
.loc 3 1726 0
.word 0xaa1703e0
.word 0xb4000b20
.loc 3 1728 0
.word 0xaa1903e0
.word 0xaa1703e1
.word 0xf9400322
.word 0xf9415450
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1729 0
.word 0xaa1703e0
.word 0xb4000a20
.loc 3 1731 0
.word 0xd2a00016
.word 0x1400004c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1732 0
.word 0xd2a00015
.word 0x14000040

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1733 0
.word 0x6b1802bf
.word 0x540006e0
.loc 3 1735 0
.word 0x93407ea0
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000889
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0xb40005a0
.loc 3 1737 0
.word 0x93407ea0
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000749
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0x93407ec1
.word 0xb9801ae2
.word 0xeb01005f
.word 0x10000011
.word 0x54000629
.word 0xd37df021
.word 0x8b0102e1
.word 0x91008021
.word 0xf9400021
bl _p_48
.word 0x53001c00
.word 0x34000300
.loc 3 1738 0
.word 0xd2800000
.word 0xf90023a0
.word 0x93407ea0
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000469
.word 0xd37df000
.word 0x8b000340
.word 0x91008001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf900003f
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 1732 0
.word 0x110006b5
.word 0xb9801b40
.word 0x6b0002bf
.word 0x54fff7eb
.loc 3 1731 0
.word 0x110006d6
.word 0xb9801ae0
.word 0x6b0002df
.word 0x54fff66b
.loc 3 1724 0
.word 0x11000718
.word 0xb9801b40
.word 0x6b00031f
.word 0x54fff28b
.loc 3 1742 0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_e9:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetInterfacesImpl_Registrar_Registrar_ObjCType
Registrar_Registrar_GetInterfacesImpl_Registrar_Registrar_ObjCType:
.loc 3 1754 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90017bf
.word 0xf9401741
.loc 3 1755 0
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9415450
.word 0xd63f0200
.word 0xf90017a0
.loc 3 1756 0
.word 0xf94017a0
.word 0xb4000080
.word 0xf94017a1
.word 0xb9801820
.word 0x35000060
.loc 3 1757 0
.word 0xf94017a0
.word 0x14000055
.loc 3 1758 0
.word 0xf94017a1
.word 0xaa1903e0
bl _p_173
.loc 3 1760 0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_90
.word 0xaa0003fa
.loc 3 1761 0
.word 0xaa1a03e0
.word 0xb4000060
.word 0xf9401740
.word 0xb5000060
.loc 3 1762 0
.word 0xf94017a0
.word 0x14000048
.loc 3 1764 0
.word 0xf9401741
.word 0xaa1903e0
.word 0xf9400322
.word 0xf9415450
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1765 0
.word 0xaa1a03e0
.word 0xb4000060
.word 0xb9801b40
.word 0x35000060
.loc 3 1766 0
.word 0xf94017a0
.word 0x1400003c
.loc 3 1767 0
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_173
.loc 3 1770 0
.word 0xd2a00019
.loc 3 1771 0
.word 0xd2a00018
.word 0x1400002b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1772 0
.word 0xf94017a0
.word 0x93407f01
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540005e9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1320]
.word 0xaa1a03e0
bl _p_174
.word 0x93407c00
.word 0x6b1f001f
.word 0x5400024a
.loc 3 1773 0
.word 0xf94017a3
.word 0xaa1903e1
.word 0x11000739
.word 0xf94017a0
.word 0x93407f02
.word 0xb9801804
.word 0xeb02009f
.word 0x10000011
.word 0x54000349
.word 0xd37df042
.word 0x8b020000
.word 0x91008000
.word 0xf9400002
.word 0xaa0303e0
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.loc 3 1771 0
.word 0x11000718
.word 0xf94017a1
.word 0xb9801820
.word 0x6b00031f
.word 0x54fffa6b
.loc 3 1776 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1328]
.word 0x9100a3a0
.word 0xaa1903e1
bl _p_175
.loc 3 1777 0
.word 0xf94017a0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_ea:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetProtocols_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_GetProtocols_Registrar_Registrar_ObjCType_System_Collections_Generic_List_1_System_Exception_:
.loc 3 1782 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803e0
.word 0xaa1903e1
bl _p_176
.word 0xaa0003f7
.loc 3 1783 0
.word 0xd2800016
.loc 3 1784 0
.word 0xb4000db7
.word 0xb9801ae0
.word 0x34000d60
.loc 3 1785 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1288]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1336]
.word 0xf9003ba0
.word 0xaa1703e1
bl _p_177
.word 0xf9403ba0
.word 0xaa0003f5
.loc 3 1786 0
.word 0xb9801ae0
.word 0xf90037a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1344]
.word 0xd2800401
bl _p_3
.word 0xf94037a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1352]
.word 0xf90033a0
bl _p_178
.word 0xf94033a0
.word 0xaa0003f6
.loc 3 1787 0
.word 0xd2a00017
.word 0x14000049

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1788 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1360]
.word 0x394002be
.word 0xaa1503e0
.word 0xaa1703e1
bl _p_179
.word 0xb4000740
.loc 3 1790 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1360]
.word 0x394002be
.word 0xaa1503e0
.word 0xaa1703e1
bl _p_179
.word 0xaa0003e1
.word 0xaa1803e0
.word 0xaa1a03e2
bl _p_159
.word 0xaa0003f4
.loc 3 1791 0
.word 0xaa1403e0
.word 0xb4000580
.loc 3 1792 0
.word 0x3941ca80
.word 0x340001e0
.loc 3 1793 0
.word 0xaa1803e0
.word 0xaa1403e1
bl _p_176
.word 0xaa0003f4
.loc 3 1794 0
.word 0xaa1403e0
.word 0xb4000480
.loc 3 1795 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1368]
.word 0x394002be
.word 0xaa1503e0
.word 0xaa1403e1
bl _p_180
.word 0x1400001c
.loc 3 1797 0
.word 0xaa1603f3
.word 0xf9002bb4
.word 0x394002de
.word 0xb9801ec0
.word 0x11000400
.word 0xb9001ec0
.word 0xf9400ad4
.word 0xb9801ac0
.word 0xb9005ba0
.word 0xb9801a81
.word 0x6b01001f
.word 0x54000142
.word 0xb9805ba1
.word 0x11000420
.word 0xb9001a60
.word 0xaa1403e0
.word 0xf9402ba2
.word 0xf9400283
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1376]
.word 0xaa1303e0
.word 0xf9402ba1
bl _p_181
.loc 3 1787 0
.word 0x110006f7
.word 0x394002be
.word 0xb9801aa0
.word 0x6b0002ff
.word 0x54fff6ab
.loc 3 1804 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1288]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1296]
.word 0xf9400021
.word 0xf90033a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003fa
.loc 3 1805 0
.word 0xf9401721
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9415050
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1806 0
.word 0xf9401b35
.loc 3 1808 0
.word 0xb40003f7
.loc 3 1809 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1368]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1703e1
bl _p_180
.word 0x14000017

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1812 0
.word 0xf94016a1
.word 0xaa1803e0
.word 0xf9400302
.word 0xf9415050
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1813 0
.word 0xaa1703e0
.word 0xb4000100
.loc 3 1814 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1368]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1703e1
bl _p_180
.loc 3 1815 0
.word 0xf9401ab5
.loc 3 1811 0
.word 0xb4000075
.word 0x3941c2a0
.word 0x35fffd00
.loc 3 1817 0
.word 0x3940035e
.word 0xb9801b40
.word 0x6b1f001f
.word 0x5400122d
.loc 3 1818 0
.word 0xb5000356
.loc 3 1819 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1344]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1384]
.word 0xf9400021
.word 0xf90033a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003f6
.loc 3 1820 0
.word 0xd2a00019
.word 0x14000071

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1821 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1360]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_179
.word 0xaa0003f7
.loc 3 1822 0
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400302
.word 0xf940ec50
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 1823 0
.word 0xaa1503e0
.word 0xb4000b40
.loc 3 1825 0
.word 0x394002be
.word 0x394082a0
.word 0x53001c00
.word 0x34000220
.loc 3 1826 0
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400302
.word 0xf9415050
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 1827 0
.word 0xaa1703e0
.word 0xb40009c0
.loc 3 1828 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1368]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1703e1
bl _p_180
.loc 3 1829 0
.word 0x14000046
.loc 3 1835 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1392]
.word 0xd2801001
bl _p_3
.word 0xf9003ba0
bl _p_182
.word 0xf9403ba1
.word 0xaa0103e0
.word 0xf90037a0
.word 0x91004022
.word 0xd5033bbf
.word 0xf94037a0
.word 0xf9000058
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf90033a0
.word 0x9100a002
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9000057
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xd280003e
.word 0x3901c43e
.word 0xaa0003f7
.loc 3 1845 0
.word 0xaa1603f5
.word 0xaa0003f7
.word 0x394002de
.word 0xb9801ec0
.word 0x11000400
.word 0xb9001ec0
.word 0xf9400ad4
.word 0xb9801ad3
.word 0xaa1303e0
.word 0xb9801a81
.word 0x6b01001f
.word 0x54000142
.word 0x11000660
.word 0xb9001aa0
.word 0xaa1403e0
.word 0xaa1303e1
.word 0xaa1703e2
.word 0xf9400283
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1376]
.word 0xaa1503e0
.word 0xaa1703e1
bl _p_181
.loc 3 1820 0
.word 0x11000739
.word 0x3940035e
.word 0xb9801b40
.word 0x6b00033f
.word 0x54fff1ab
.loc 3 1848 0
.word 0xb4000096
.word 0x394002de
.word 0xb9801ac0
.word 0x35000060
.loc 3 1849 0
.word 0xd2800000
.word 0x14000007
.loc 3 1850 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1400]
.word 0x394002de
.word 0xaa1603e0
bl _p_183
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_eb:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetAdoptedProtocols_Registrar_Registrar_ObjCType
Registrar_Registrar_GetAdoptedProtocols_Registrar_Registrar_ObjCType:
.loc 3 1855 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401741
.word 0xaa1903e0
.word 0xf9400322
.word 0xf940d050
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 1856 0
.word 0xaa1a03e0
.word 0xb40001c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1408]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1416]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0x35000060
.loc 3 1857 0
.word 0xd2800000
.word 0x14000041
.loc 3 1858 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1408]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1416]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1424]
bl _p_42
.word 0xaa0003f9
.loc 3 1859 0
.word 0xd2a00018
.word 0x1400001e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 1860 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1432]
.word 0xaa1a03e0
.word 0xaa1803e1
.word 0xf9400342

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1440]
.word 0x928010f0
.word 0xf8706850
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0x3940003e
bl _p_184
.word 0xaa0003e2
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.loc 3 1859 0
.word 0x11000718

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1408]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1416]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0x6b00031f
.word 0x54fffacb
.loc 3 1861 0
.word 0xaa1903e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_ec:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_RegisterCategory_System_Type_ObjCRuntime_CategoryAttribute_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_RegisterCategory_System_Type_ObjCRuntime_CategoryAttribute_System_Collections_Generic_List_1_System_Exception_:
.loc 3 1866 0 prologue_end
.word 0xa9af7bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9002bbf
.word 0x390163bf
.word 0xf90033bf
.word 0xf90037bf
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf940c850
.word 0xd63f0200
.word 0x53001c00
.word 0x34000420
.loc 3 1867 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1448]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd2820700
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1868 0
.word 0xd2800000
.word 0x14000385
.loc 3 1871 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf940b050
.word 0xd63f0200
.word 0x53001c00
.word 0x34000420
.loc 3 1872 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1456]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd2820720
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1873 0
.word 0xd2800000
.word 0x1400035e
.loc 3 1876 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_185
.word 0xb5000420
.loc 3 1877 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1464]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd28206e0
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1878 0
.word 0xd2800000
.word 0x1400033a
.loc 3 1881 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_185
.word 0xaa0003e1
.word 0xaa1703e0
.word 0xaa1a03e2
bl _p_129
.word 0xaa0003f6
.loc 3 1882 0
.word 0xaa1603e0
.word 0xb5000660
.loc 3 1883 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1472]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90073a0
.word 0xf9006fa0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_185
.word 0xaa0003e1
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd28206c0
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1884 0
.word 0xd2800000
.word 0x140002fe
.loc 3 1887 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1392]
.word 0xd2801001
bl _p_3
.word 0xf90073a0
bl _p_182
.word 0xf94073a0
.word 0xaa0003e1
.word 0xf9006fa1
.word 0x91004001
.word 0xd5033bbf
.word 0xf9406fa0
.word 0xf9000037
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf9006ba0
.word 0x9100a001
.word 0xd5033bbf
.word 0xf9406ba0
.word 0xf9000038
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf90067a0
.word 0x9100c001
.word 0xd5033bbf
.word 0xf94067a0
.word 0xf9000036
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf90063a0
.word 0x91008001
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf9000039
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0003f9
.loc 3 1894 0
.word 0xf9401ae0
.word 0xf9002ba0
.word 0xd2a00000
.word 0x390163a0
.word 0xf9402bb5
.word 0x910163b4
.word 0xaa1503e0
.word 0x910163a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1503e0
.word 0xaa1403e1
bl _p_21
.loc 3 1896 0
.word 0xf9401ae0
.word 0xf90063a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_186
.word 0xaa0003e1
.word 0xf94063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1480]
.word 0x3940001e
.word 0x910183a2
bl _p_187
.word 0x53001c00
.word 0x34000840
.loc 3 1897 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1488]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9007ba0
.word 0xf90077a0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9407ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94077a0
.word 0xf90073a0
.word 0xf9006fa0
.word 0xf94033a1
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_186
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a1
.word 0xf94067a2
.word 0xd2820780
bl _p_32
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1899 0
.word 0xd280001a
.word 0xf9003bbf
.word 0x94000018
.word 0xf9403ba0
.word 0xb4000040
bl _p_23
.word 0x14000259
.loc 3 1901 0
.word 0xf9401ae0
.word 0xf90063a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_186
.word 0xaa0003e1
.word 0xf94063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1496]
.word 0x3940001e
.word 0xaa1803e2
bl _p_188
.loc 3 1902 0
.word 0xf9003bbf
.word 0x94000005
.word 0xf9403ba0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf90047be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394163a0
.word 0x34000060
.word 0xf9402ba0
bl _p_24
.word 0xf94047be
.word 0xd61f03c0
.loc 3 1904 0
.word 0xf9400ee0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1504]
.word 0x3940001e
.word 0xaa1803e1
.word 0xaa1903e2
bl _p_189
.loc 3 1908 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9416050
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1024]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1032]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf90037a0
.word 0x14000047

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 1909 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9410050
.word 0xd63f0200
.loc 3 1910 0
.word 0xb40005c0
.loc 3 1913 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1512]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90073a0
.word 0xf9006fa0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1503e1
bl _p_29
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xf94067a4
.word 0xaa1703e0
.word 0xd28207c1
.word 0xaa1503e2
bl _p_145
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1908 0
.word 0xf94037a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff600
.word 0xf9003fbf
.word 0x94000005
.word 0xf9403fa0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9004fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037a0
.word 0xb4000140
.word 0xf94037a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9404fbe
.word 0xd61f03c0
.loc 3 1916 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9416850
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1024]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1032]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf90037a0
.word 0x14000173

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 1917 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9410050
.word 0xd63f0200
.word 0xaa0003f4
.loc 3 1919 0
.word 0xaa1403e0
.word 0xb4002b00
.loc 3 1922 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9412450
.word 0xd63f0200
.word 0x53001c00
.word 0x350006e0
.loc 3 1923 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1520]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90073a0
.word 0xf9006fa0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xf94067a4
.word 0xaa1703e0
.word 0xd28207e1
.word 0xaa1503e2
bl _p_145
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1924 0
.word 0xd280001a
.word 0xf90043bf
.word 0x94000130
.word 0xf94043a0
.word 0xb4000040
bl _p_23
.word 0x14000148
.loc 3 1927 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9411c50
.word 0xd63f0200
.word 0x53001c00
.word 0x34001600
.loc 3 1928 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003f3
.loc 3 1929 0
.word 0xaa1303e0
.word 0xb4000060
.word 0xb9801a60
.word 0x35000800
.loc 3 1930 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1528]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9007ba0
.word 0xf90077a0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9407ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94077a0
.word 0xf90073a0
.word 0xf9006fa0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xf94016c1
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xf94067a4
.word 0xaa1703e0
.word 0xd28207a1
.word 0xaa1503e2
bl _p_145
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1932 0
.word 0x140000cb
.loc 3 1933 0
.word 0xb9801a60
.word 0xeb1f001f
.word 0x10000011
.word 0x54001f89
.word 0xf9401261
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xf90063a0
.word 0xf94016c1
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94063a0
bl _p_126
.word 0x53001c00
.word 0x34000a60
.loc 3 1934 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1536]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf90083a0
.word 0xf9007fa0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94083a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9407fa0
.word 0xf9007ba0
.word 0xf90077a0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9407ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94077a0
.word 0xf90073a0
.word 0xf9006fa0
.word 0xb9801a60
.word 0xeb1f001f
.word 0x10000011
.word 0x540017e9
.word 0xf9401261
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xf94016c1
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xf94067a4
.word 0xaa1703e0
.word 0xd28206a1
.word 0xaa1503e2
bl _p_145
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1936 0
.word 0x14000065
.loc 3 1940 0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf940ac50
.word 0xd63f0200
.word 0x53001c00
.word 0x34000620
.loc 3 1941 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1544]
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90073a0
.word 0xf9006fa0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94073a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xf90067a0
.word 0xaa1703e0
.word 0xaa1503e1
.word 0xf94002e2
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94063a3
.word 0xf94067a4
.word 0xaa1703e0
.word 0xd2820741
.word 0xaa1503e2
bl _p_145
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 1942 0
.word 0x1400002e
.loc 3 1947 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf90067a0
.word 0xaa1703e1
.word 0xaa1603e2
.word 0xaa1503e3
bl _p_190
.word 0xf94067a0
.word 0xaa0003e3
.word 0x9100a000
.word 0xf90063a0
.word 0xd5033bbf
.word 0xf94063a0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xaa0303f5
.loc 3 1950 0
.word 0xaa0303e0
.word 0xaa1403e1
.word 0xaa1a03e2
.word 0x3940007e
bl _p_191
.word 0x53001c00
.word 0x34000160
.loc 3 1951 0
.word 0xaa1903e0
.word 0xaa1503e1
.word 0xaa1a03e2
.word 0x3940033e
bl _p_192
.loc 3 1952 0
.word 0xaa1603e0
.word 0xaa1503e1
.word 0xaa1a03e2
.word 0x394002de
bl _p_192
.loc 3 1916 0
.word 0xf94037a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35ffd080
.word 0xf90043bf
.word 0x94000005
.word 0xf94043a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90057be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94037a0
.word 0xb4000140
.word 0xf94037a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94057be
.word 0xd61f03c0
.loc 3 1958 0
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf94002e3
.word 0xf9417470
.word 0xd63f0200
.loc 3 1960 0
.word 0xaa1903e0
.word 0x14000002
.loc 3 1961 0
.word 0xaa1a03e0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8d17bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_ed:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_RegisterTypeUnsafe_System_Type_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_RegisterTypeUnsafe_System_Type_System_Collections_Generic_List_1_System_Exception_:
.loc 3 1968 0 prologue_end
.word 0xd280a610
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa9007bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xf9002ba0
.word 0xf9002fa1
.word 0xf90033a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf900dfbf
.word 0x390703bf
.word 0x390723bf
.word 0xf900ebbf
.word 0x390763bf
.word 0x390783bf
.word 0xf900f7bf
.word 0xf900fbbf
.word 0x3907e3bf
.word 0xd2800000
.word 0xf900d3a0
.word 0xf900d7a0
.word 0xf900dba0
.word 0xf90103bf
.word 0xd2800000
.word 0xf900c7a0
.word 0xf900cba0
.word 0xf900cfa0
.word 0xf90107bf
.word 0xf9010bbf
.word 0xf9010fbf
.word 0xf90113bf
.word 0xf90117bf
.word 0xf9011bbf
.word 0xf9011fbf
.word 0xd2800000
.word 0xf900bba0
.word 0xf900bfa0
.word 0xf900c3a0
.word 0xf90123bf
.word 0xf90127bf
.word 0xf9012bbf
.word 0xf9012fbf
.word 0xf90133bf
.word 0xf90137bf
.word 0xf9013bbf
.word 0xd2a00000
.word 0x390703a0
.loc 3 1969 0
.word 0xd2a00000
.word 0x390723a0
.loc 3 1970 0
.word 0xd2a00000
.word 0x53001c1a
.loc 3 1972 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940b050
.word 0xd63f0200
.word 0x53001c00
.word 0x34000140
.loc 3 1973 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9409c50
.word 0xd63f0200
.word 0xf9002fa0
.loc 3 1974 0
.word 0xd2800020
.word 0x390703a0
.loc 3 1977 0
.word 0xf9402ba0
.word 0xf9400c00
.word 0xf9402fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1176]
.word 0x3940001e
.word 0x9106e3a2
bl _p_158
.word 0x53001c00
.word 0x34000120
.loc 3 1978 0
.word 0xf9402ba2
.word 0xf940dfa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9417c50
.word 0xd63f0200
.loc 3 1979 0
.word 0xf940dfa0
.word 0x14000f1e
.loc 3 1982 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940f450
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 1983 0
.word 0xaa1903e0
.word 0xb40000e0
.loc 3 1984 0
.word 0xf9402ba0
.word 0xf9402fa1
.word 0xf94033a3
.word 0xaa1903e2
bl _p_193
.word 0x14000f0f
.loc 3 1986 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9404850
.word 0xd63f0200
.word 0x53001c00
.word 0x35000c40
.loc 3 1988 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940a850
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 3 1989 0
.word 0xd2800000
.word 0x14000efd
.loc 3 1991 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9403c50
.word 0xd63f0200
.word 0x53001c00
.word 0x35000060
.loc 3 1992 0
.word 0xd2800000
.word 0x14000ef3
.loc 3 1994 0
.word 0x394703a0
.word 0x340007e0
.loc 3 1995 0
.word 0xf94033a0
.word 0xf9400000
.word 0xf9023ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1560]
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90247a0
.word 0xf90243a0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94247a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa1
.word 0xf94243a2
.word 0xd2820680
bl _p_32
.word 0xaa0003e1
.word 0xf9423ba0
.word 0xaa0003fa
.word 0xaa0103f9
.word 0x3940035e
.word 0xb9801f41
.word 0x11000421
.word 0xb9001c01
.word 0xf9400b58
.word 0xb9801b57
.word 0xaa1703e0
.word 0xb9801b01
.word 0x6b01001f
.word 0x54000142
.word 0x110006e0
.word 0xb9001b40
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xaa1903e2
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1264]
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_169
.loc 3 1996 0
.word 0xd2800000
.word 0x14000eb3
.loc 3 2000 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940ec50
.word 0xd63f0200
.word 0xaa0003e1
.word 0x3940003e
.word 0x39408000
.loc 3 2001 0
.word 0x53001c00
.word 0x53001c1a
.loc 3 2002 0
.word 0xd2800020
.word 0x390723a0
.loc 3 2011 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9415850
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 2012 0
.word 0xd2800018
.loc 3 2013 0
.word 0xb40000d9
.loc 3 2015 0
.word 0xf9402ba0
.word 0xf94033a2
.word 0xaa1903e1
bl _p_159
.word 0xaa0003f8
.loc 3 2018 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940f850
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 2019 0
.word 0xaa1903e0
.word 0xb40001c0
.word 0x3940033e
.word 0x39406720
.word 0x53001c00
.word 0x34000140
.loc 3 2020 0
.word 0xf9402ba3
.word 0xf9402fa1
.word 0xaa0303e0
.word 0xaa1803e2
.word 0xf9400063
.word 0xf9418070
.word 0xd63f0200
.loc 3 2021 0
.word 0xaa1803e0
.word 0x14000e82
.loc 3 2024 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1392]
.word 0xd2801001
bl _p_3
.word 0xf9025ba0
bl _p_182
.word 0xf9425ba0
.word 0xaa0003e1
.word 0xf90257a1
.word 0xf9402ba1
.word 0x91004002
.word 0xd5033bbf
.word 0xf94257a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003e1
.word 0xf9024fa1
.word 0xf90253a0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940f850
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94253a0
.word 0x91006002
.word 0xd5033bbf
.word 0xf9424fa0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003e1
.word 0xf9024ba1
.word 0xf9402fa1
.word 0xf90243a0
.word 0x9100a002
.word 0xd5033bbf
.word 0xf9424ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf90247a0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9404050
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94243a0
.word 0xf94247a2
.word 0x3901c001
.word 0xaa0203e1
.word 0xaa0103e0
.word 0x394723a3
.word 0x3901c443
.word 0x3901c83a
.word 0x394703a2
.word 0x3901d022
.word 0xf900dfa0
.loc 3 2033 0
.word 0xf940dfa2
.word 0xf94033a1
.word 0xaa0203e0
.word 0x3940005e
bl _p_194
.loc 3 2034 0
.word 0xf940dfa0
.word 0xf9023fa0
.word 0xf9402ba0
.word 0xf940dfa1
bl _p_195
.word 0xaa0003e1
.word 0xf9423fa0
.word 0xf9023ba1
.word 0x91010001
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 2035 0
.word 0xf940dfa2
.word 0xf94033a1
.word 0xaa0203e0
.word 0x3940005e
bl _p_196
.loc 3 2036 0
.word 0xf940dfa1
.word 0x394723a0
.word 0xaa0103f9
.word 0x350000a0
.word 0xaa1803f7
.word 0xb5000098
.word 0xf940dfb7
.word 0x14000002
.word 0xd2800017
.word 0x9100c320
.word 0xf90243a0
.word 0xd5033bbf
.word 0xf94243a0
.word 0xf9000017
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 2037 0
.word 0xf940dfa0
.word 0xf9023fa0
.word 0xf9402ba0
.word 0xf940dfa1
.word 0xf94033a2
bl _p_197
.word 0xaa0003e1
.word 0xf9423fa0
.word 0xf9023ba1
.word 0x9100e001
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 2041 0
.word 0xf940dfa1
.word 0x394723a0
.word 0xaa0103f9
.word 0x34000040
.word 0x340001ba
.word 0xf940dfa0
.word 0xf9400c00
.word 0xb4000100
.word 0xf940dfa0
.word 0xf9400c00
.word 0xaa0003e1
.word 0x3940003e
.word 0x39406000
.word 0x53001c18
.word 0x1400000e
.word 0xd2a00018
.word 0x1400000c
.word 0xf9402ba2
.word 0xf940dfa0
.word 0xf9401401
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940dc50
.word 0xd63f0200
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17f8
.word 0x3901cf38
.loc 3 2043 0
.word 0xf940dfa0
.word 0x3941cc00
.word 0x350001e0
.word 0xf940dfa0
.word 0xf9401800
.word 0xb4000180
.loc 3 2044 0
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf940dfa2
.word 0xf9401842
.word 0xf9401442
.word 0xf940dfa3
.word 0xf9401466
.word 0xd2800003
.word 0xd2800004
.word 0xd2800005
bl _p_163
.loc 3 2046 0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
bl _p_198
.word 0x53001c00
.word 0x34000600
.loc 3 2047 0
.word 0xf94033a0
.word 0xf9023ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1568]
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf9024fa0
.word 0xf9024ba0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424ba0
.word 0xf90247a0
.word 0xf90243a0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e2
.word 0xf94247a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa1
.word 0xf94243a2
.word 0xd2820900
bl _p_32
.word 0xaa0003e1
.word 0xf9423ba0
bl _p_87
.loc 3 2050 0
.word 0xf940dfa0
.word 0xf9401c00
.word 0xb40003c0
.loc 3 2051 0
.word 0xf940dfa0
.word 0xf9401c19
.word 0xd2a00018
.word 0x14000017

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x5401ae89
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400017
.loc 3 2053 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1703e1
.word 0xf9400042
.word 0xf9417850
.word 0xd63f0200
.word 0x11000718
.loc 3 2051 0
.word 0xb9801b20
.word 0x6b00031f
.word 0x54fffd0b
.loc 3 2058 0
.word 0xf940dfa0
.word 0x3941c400
.word 0x34001000
.loc 3 2059 0
.word 0xf9402ba0
.word 0xf9401400
.word 0xf900fba0
.word 0xd2a00000
.word 0x3907e3a0
.word 0xf940fbb9
.word 0x9107e3b8
.word 0xaa1903e0
.word 0x9107e3a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_21
.loc 3 2060 0
.word 0xf9402ba0
.word 0xf9401400
.word 0xf9023ba0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e1
.word 0xf9423ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1480]
.word 0x3940001e
.word 0x910743a2
bl _p_187
.word 0x53001c00
.word 0x340007c0
.loc 3 2061 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd284a781
bl _p_11
.word 0xf9023ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf90253a0
.word 0xf9024fa0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94253a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424fa0
.word 0xf9024ba0
.word 0xf90247a0
.word 0xf9402ba2
.word 0xf940eba1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94247a0
.word 0xf90243a0
.word 0xf9023fa0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e2
.word 0xf94243a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423ba1
.word 0xf9423fa2
.word 0xd28203c0
bl _p_32
bl _p_13
.loc 3 2063 0
.word 0xf9402ba0
.word 0xf9401400
.word 0xf9023ba0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e1
.word 0xf9423ba0
.word 0xf9402fa2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1496]
.word 0x3940001e
bl _p_188
.loc 3 2064 0
.word 0xf901e7bf
.word 0x94000005
.word 0xf941e7a0
.word 0xb4000040
bl _p_23
.word 0x1400008d
.word 0xf901efbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3947e3a0
.word 0x34000060
.word 0xf940fba0
bl _p_24
.word 0xf941efbe
.word 0xd61f03c0
.loc 3 2066 0
.word 0xf9402ba0
.word 0xf9401000
.word 0xf900fba0
.word 0xd2a00000
.word 0x3907e3a0
.word 0xf940fbb9
.word 0x9107e3b8
.word 0xaa1903e0
.word 0x9107e3a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_21
.loc 3 2067 0
.word 0xf9402ba0
.word 0xf9401000
.word 0xf9023ba0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e1
.word 0xf9423ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1480]
.word 0x3940001e
.word 0x910743a2
bl _p_187
.word 0x53001c00
.word 0x340007c0
.loc 3 2068 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd284be61
bl _p_11
.word 0xf9023ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf90253a0
.word 0xf9024fa0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94253a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424fa0
.word 0xf9024ba0
.word 0xf90247a0
.word 0xf9402ba2
.word 0xf940eba1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94247a0
.word 0xf90243a0
.word 0xf9023fa0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e2
.word 0xf94243a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423ba1
.word 0xf9423fa2
.word 0xd28202c0
bl _p_32
bl _p_13
.loc 3 2070 0
.word 0xf9402ba0
.word 0xf9401000
.word 0xf9023ba0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_86
.word 0xaa0003e1
.word 0xf9423ba0
.word 0xf9402fa2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1496]
.word 0x3940001e
bl _p_188
.loc 3 2071 0
.word 0xf9013fbf
.word 0x94000005
.word 0xf9413fa0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf901f7be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3947e3a0
.word 0x34000060
.word 0xf940fba0
bl _p_24
.word 0xf941f7be
.word 0xd61f03c0
.loc 3 2074 0
.word 0xf9402ba0
.word 0xf9400c00
.word 0xf9402fa1
.word 0xf940dfa2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1504]
.word 0x3940001e
bl _p_189
.loc 3 2079 0
.word 0xd2a00000
.word 0x390a03a0
.loc 3 2080 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9416850
.word 0xd63f0200
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #256]
.word 0xd2800401
bl _p_3
.word 0xf9423fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1576]
.word 0xf9023ba0
bl _p_199
.word 0xf9423ba0
.word 0xaa0003f6
.loc 3 2081 0
.word 0x394723a0
.word 0x350049e0
.loc 3 2082 0
.word 0xf940dfa0
.word 0x3941cc00
.word 0x350001c0
.word 0xf940dfa0
.word 0x3941c000
.word 0x35000160
.word 0xf940dfa0
.word 0xf9401800
.word 0x3941cc00
.word 0x350000a0
.word 0xf940dfa0
.word 0xf9401800
.word 0x3941c019
.word 0x14000004
.word 0xd2800039
.word 0x14000002
.word 0xd2a00019
.word 0x53001f20
.word 0x390a03b9
.loc 3 2083 0
.word 0x34003860
.loc 3 2084 0
.word 0xf9402ba0
.word 0xf940dfa1
.word 0xf9401421

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1584]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1592]
bl _p_200
.word 0x53001c00
.loc 3 2085 0
.word 0x35001260
.loc 3 2086 0
.word 0xf940dfa0
.word 0xf9025ba0
.word 0xf9402ba0
.word 0xf90263a0
.word 0xf940dfa0
.word 0xf90267a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf94263a1
.word 0xf94267a2
.word 0xf9025fa0
.word 0xd2800003
bl _p_190
.word 0xf9425fa2
.word 0xaa0203e0
.word 0xf90257a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1600]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf94257a0
.word 0xf9425ba3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd28000be
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #776]
.word 0xf90253a0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf94253a0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x3905a3bf
.word 0x3905a7bf
.word 0x3905a7bf
.word 0xd280003e
.word 0x3905a3be
.word 0x3985a3a0
.word 0x390363a0
.word 0x3985a7a0
.word 0x390367a0
.word 0xeb1f003f
.word 0x10000011
.word 0x54017c20
.word 0x9101d020
.word 0x398363a2
.word 0x39000002
.word 0x398367a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2093 0
.word 0xf940dfa0
.word 0xf90243a0
.word 0xf9402ba0
.word 0xf9024ba0
.word 0xf940dfa0
.word 0xf9024fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424ba1
.word 0xf9424fa2
.word 0xf90247a0
.word 0xd2800003
bl _p_190
.word 0xf94247a2
.word 0xaa0203e0
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1608]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423fa0
.word 0xf94243a3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd28000de
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1616]
.word 0xf9023ba0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x390583bf
.word 0x390587bf
.word 0x390587bf
.word 0xd280003e
.word 0x390583be
.word 0x398583a0
.word 0x390343a0
.word 0x398587a0
.word 0x390347a0
.word 0xeb1f003f
.word 0x10000011
.word 0x54017300
.word 0x9101d020
.word 0x398343a2
.word 0x39000002
.word 0x398347a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2101 0
.word 0xf940dfa0
.word 0xf9028ba0
.word 0xf9402ba0
.word 0xf90293a0
.word 0xf940dfa0
.word 0xf90297a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf94293a1
.word 0xf94297a2
.word 0xf9028fa0
.word 0xd2800003
bl _p_190
.word 0xf9428fa2
.word 0xaa0203e0
.word 0xf90287a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1624]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf94287a0
.word 0xf9428ba3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd280025e
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1632]
.word 0xf90283a0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf94283a0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x390563bf
.word 0x390567bf
.word 0x390567bf
.word 0xd280003e
.word 0x390563be
.word 0x398563a0
.word 0x390323a0
.word 0x398567a0
.word 0x390327a0
.word 0xeb1f003f
.word 0x10000011
.word 0x540169e0
.word 0x9101d020
.word 0x398323a2
.word 0x39000002
.word 0x398327a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2108 0
.word 0xf940dfa0
.word 0xf90273a0
.word 0xf9402ba0
.word 0xf9027ba0
.word 0xf940dfa0
.word 0xf9027fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9427ba1
.word 0xf9427fa2
.word 0xf90277a0
.word 0xd2800003
bl _p_190
.word 0xf94277a2
.word 0xaa0203e0
.word 0xf9026fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1640]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9426fa0
.word 0xf94273a3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd280027e
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1648]
.word 0xf9026ba0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf9426ba0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x390543bf
.word 0x390547bf
.word 0x390547bf
.word 0xd280003e
.word 0x390543be
.word 0x398543a0
.word 0x390303a0
.word 0x398547a0
.word 0x390307a0
.word 0xeb1f003f
.word 0x10000011
.word 0x540160c0
.word 0x9101d020
.word 0x398303a2
.word 0x39000002
.word 0x398307a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2115 0
.word 0xf940dfa0
.word 0xf9025ba0
.word 0xf9402ba0
.word 0xf90263a0
.word 0xf940dfa0
.word 0xf90267a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf94263a1
.word 0xf94267a2
.word 0xf9025fa0
.word 0xd2800003
bl _p_190
.word 0xf9425fa2
.word 0xaa0203e0
.word 0xf90257a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1656]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf94257a0
.word 0xf9425ba3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd280029e
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1632]
.word 0xf90253a0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf94253a0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x390523bf
.word 0x390527bf
.word 0x390527bf
.word 0xd280003e
.word 0x390523be
.word 0x398523a0
.word 0x3902e3a0
.word 0x398527a0
.word 0x3902e7a0
.word 0xeb1f003f
.word 0x10000011
.word 0x540157a0
.word 0x9101d020
.word 0x3982e3a2
.word 0x39000002
.word 0x3982e7a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2122 0
.word 0xf940dfa0
.word 0xf90243a0
.word 0xf9402ba0
.word 0xf9024ba0
.word 0xf940dfa0
.word 0xf9024fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424ba1
.word 0xf9424fa2
.word 0xf90247a0
.word 0xd2800003
bl _p_190
.word 0xf94247a2
.word 0xaa0203e0
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1664]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423fa0
.word 0xf94243a3
.word 0xaa0003e2
.word 0xaa0203e1
.word 0x3940005e
.word 0xd28002be
.word 0xb900701e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1672]
.word 0xf9023ba0
.word 0x3940003e
.word 0x91012022
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0x3940003e
.word 0x390503bf
.word 0x390507bf
.word 0x390507bf
.word 0xd280003e
.word 0x390503be
.word 0x398503a0
.word 0x3902c3a0
.word 0x398507a0
.word 0x3902c7a0
.word 0xeb1f003f
.word 0x10000011
.word 0x54014e80
.word 0x9101d020
.word 0x3982c3a2
.word 0x39000002
.word 0x3982c7a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2131 0
.word 0xf9402ba0
.word 0xf9401c00
.word 0xb5000ec0
.word 0xf9402ba0
.word 0xf9402fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1152]
bl _p_149
.word 0x53001c00
.word 0x34000d60
.loc 3 2132 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1680]
.word 0x394002de
.word 0x910683a8
.word 0xaa1603e0
bl _p_202
.word 0x1400004b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf940dbb9
.loc 3 2133 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003f8
.word 0xaa1803e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1688]
bl _p_20
.word 0x53001c00
.word 0x35000120

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1696]
.word 0xaa1803e0
bl _p_20
.word 0x53001c00
.word 0x35000260
.word 0x14000022
.loc 3 2135 0
.word 0xf9402ba0
.word 0x91010000
.word 0xf9023ba0
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 2136 0
.word 0x14000011
.loc 3 2138 0
.word 0xf9402ba0
.word 0x9100e000
.word 0xf9023ba0
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 2142 0
.word 0xf9402ba0
.word 0xf9402000
.word 0xb4000140
.word 0xf9402ba0
.word 0xf9401c00
.word 0xb40000e0
.loc 3 2143 0
.word 0xf901dfbf
.word 0x94000012
.word 0xf941dfa0
.word 0xb4000040
bl _p_23
.word 0x14000019
.loc 3 2132 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1704]
.word 0x910683a0
bl _p_203
.word 0x53001c00
.word 0x35fff600
.word 0xf901dfbf
.word 0x94000005
.word 0xf941dfa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf901ffbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910683a0
.word 0xf901e3a0
.word 0xf941ffbe
.word 0xd61f03c0
.loc 3 2162 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9416450
.word 0xd63f0200
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1712]
.word 0xd2800401
bl _p_3
.word 0xf9423fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1720]
.word 0xf9023ba0
bl _p_204
.word 0xf9423ba0
.word 0xaa0003f5
.loc 3 2163 0
.word 0xd2a00000
.word 0x390763a0
.loc 3 2164 0
.word 0x394723a0
.word 0x340064c0
.word 0x350064ba
.loc 3 2165 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940e850
.word 0xd63f0200
.word 0xaa0003e1
.loc 3 2166 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1728]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1736]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf90103a0
.word 0x140002ec

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94103a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1744]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1752]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 2167 0
.word 0xd2800020
.word 0x390763a0
.loc 3 2168 0
.word 0x3940035e
.word 0x39418740
.word 0x53001c00
.word 0x34003c00
.loc 3 2169 0
.word 0x3940035e
.word 0x39418b40
.word 0x53001c00
.word 0x34002460
.loc 3 2171 0
.word 0xf9402ba0
.word 0xf9024ba0
.word 0xf940dfa0
.word 0xf9024fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424ba1
.word 0xf9424fa2
.word 0xf90247a0
.word 0xd2800003
bl _p_190
.word 0xf94247a0
.word 0xf9023fa0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0x3940035e
.word 0xf9400b41
.word 0xf90243a1
.word 0x91008001
.word 0xd5033bbf
.word 0xf94243a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x3940035e
.word 0xf9402b41
.word 0xaa1803e0
.word 0x3940031e
bl _p_201

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xd2a00001
bl _p_42
.word 0xaa0003e1
.word 0x3940031e
.word 0x91014302
.word 0xd5033bbf
.word 0xf9423fa0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9002c1f
.word 0xf9023ba0
.word 0x3940035e
.word 0xf9402741
.word 0x3940031e
.word 0x91018302
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf900341f
.word 0x3940035e
.word 0x39418b41
.word 0x3940031e
.word 0x3904e3bf
.word 0x3904e7bf
.word 0x3904e7a1
.word 0xd280003e
.word 0x3904e3be
.word 0x3984e3a1
.word 0x3902a3a1
.word 0x3984e7a1
.word 0x3902a7a1
.word 0xeb1f031f
.word 0x10000011
.word 0x54012920
.word 0x9101d301
.word 0x3982a3a2
.word 0x39000022
.word 0x3982a7a2
.word 0x39000422
.word 0x3940035e
.word 0x39418341
.word 0x53001c21
.word 0x6b1f003f
.word 0x9a9f17e1
.word 0x3900f401
.word 0x3940031e
.word 0x3904c3bf
.word 0x3904c7bf
.word 0x3904c7bf
.word 0xd280003e
.word 0x3904c3be
.word 0x3984c3a0
.word 0x390283a0
.word 0x3984c7a0
.word 0x390287a0
.word 0xeb1f031f
.word 0x10000011
.word 0x54012620
.word 0x9101db00
.word 0x398283a1
.word 0x39000001
.word 0x398287a1
.word 0x39000401
.word 0xaa1803f9
.loc 3 2181 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1803e1
.word 0x3940007e
bl _p_192
.loc 3 2183 0
.word 0x3940035e
.word 0xf9402f59
.word 0xb40000b9
.word 0xb9801320
.word 0x6b1f001f
.word 0x9a9f17f9
.word 0x14000003
.word 0xd2800039
.word 0x14000001
.word 0x53001f20
.word 0x35004800
.loc 3 2184 0
.word 0xf9402ba0
.word 0xf9024fa0
.word 0xf940dfa0
.word 0xf90253a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424fa1
.word 0xf94253a2
.word 0xf9024ba0
.word 0xd2800003
bl _p_190
.word 0xf9424ba0
.word 0xf9023fa0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0x3940035e
.word 0xf9400b41
.word 0xf90247a1
.word 0x91008001
.word 0xd5033bbf
.word 0xf94247a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x3940035e
.word 0xf9402f41
.word 0xaa1803e0
.word 0x3940031e
bl _p_201

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xd2800021
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf90243a0
.word 0x3940035e
.word 0xf9402742
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94243a1
.word 0x3940031e
.word 0x91014302
.word 0xd5033bbf
.word 0xf9423fa0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9002c1f
.word 0xf9023ba0
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9413830
.word 0xd63f0200
.word 0xaa0003e1
.word 0x3940031e
.word 0x91018302
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf900341f
.word 0x3940035e
.word 0x39418b41
.word 0x3940031e
.word 0x3904a3bf
.word 0x3904a7bf
.word 0x3904a7a1
.word 0xd280003e
.word 0x3904a3be
.word 0x3984a3a1
.word 0x390263a1
.word 0x3984a7a1
.word 0x390267a1
.word 0xeb1f031f
.word 0x10000011
.word 0x54011580
.word 0x9101d301
.word 0x398263a2
.word 0x39000022
.word 0x398267a2
.word 0x39000422
.word 0x3940035e
.word 0x39418341
.word 0x53001c21
.word 0x6b1f003f
.word 0x9a9f17e1
.word 0x3900f401
.word 0x3940031e
.word 0x390483bf
.word 0x390487bf
.word 0x390487bf
.word 0xd280003e
.word 0x390483be
.word 0x398483a0
.word 0x390243a0
.word 0x398487a0
.word 0x390247a0
.word 0xeb1f031f
.word 0x10000011
.word 0x54011280
.word 0x9101db00
.word 0x398243a1
.word 0x39000001
.word 0x398247a1
.word 0x39000401
.word 0xaa1803fa
.loc 3 2193 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1803e1
.word 0x3940007e
bl _p_192
.word 0x140001ad
.loc 3 2196 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1760]
.word 0xd2800d01
bl _p_3
.word 0xaa0003e2
.word 0x9280001e
.word 0xb900385e
.word 0xf9402ba0
.word 0xf90247a0
.word 0x91004041
.word 0xd5033bbf
.word 0xf94247a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xf940dfa0
.word 0xf90243a0
.word 0x91006041
.word 0xd5033bbf
.word 0xf94243a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xf900205f
.word 0x3940035e
.word 0xf9400b40
.word 0xf9023fa0
.word 0x91008041
.word 0xd5033bbf
.word 0xf9423fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0203e0
.word 0xf9023ba0
.word 0x3940035e
.word 0xf9400f41
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423ba1
.word 0xaa0103e0
.word 0x3940035e
.word 0xb9806742
.word 0xb9003822
.word 0xaa0003f9
.word 0xaa0003f8
.word 0x3940035e
.word 0xf9402f57
.word 0xb40000b7
.word 0xb98012e0
.word 0x6b1f001f
.word 0x9a9f17f7
.word 0x14000003
.word 0xd2800037
.word 0x14000001
.word 0x3940031e
.word 0x390463bf
.word 0x390467bf
.word 0x390467b7
.word 0xd280003e
.word 0x390463be
.word 0x398463a0
.word 0x390223a0
.word 0x398467a0
.word 0x390227a0
.word 0xeb1f031f
.word 0x10000011
.word 0x54010520
.word 0x91018b00
.word 0x398223a1
.word 0x39000001
.word 0x398227a1
.word 0x39000401
.word 0x3940035e
.word 0x39418b40
.word 0x3940033e
.word 0x390443bf
.word 0x390447bf
.word 0x390447a0
.word 0xd280003e
.word 0x390443be
.word 0x398443a0
.word 0x390203a0
.word 0x398447a0
.word 0x390207a0
.word 0xeb1f033f
.word 0x10000011
.word 0x540102a0
.word 0x91018320
.word 0x398203a1
.word 0x39000001
.word 0x398207a1
.word 0x39000401
.word 0x3940035e
.word 0x39418340
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x3900f720
.word 0x3940035e
.word 0xf9402b40
.word 0xf90243a0
.word 0x91014321
.word 0xd5033bbf
.word 0xf94243a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x3940035e
.word 0xf9402f40
.word 0xf9023fa0
.word 0x91016321
.word 0xd5033bbf
.word 0xf9423fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x3940035e
.word 0xf9402740
.word 0xf9023ba0
.word 0x3940033e
.word 0x91012321
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa1903fa
.loc 3 2210 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1903e1
.word 0x3940007e
bl _p_205
.word 0x140000f4
.loc 3 2217 0
.word 0xf9402ba0
.word 0xf90247a0
.word 0xf940dfa0
.word 0xf9024ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf94247a1
.word 0xf9424ba2
.word 0xf90243a0
.word 0xd2800003
bl _p_190
.word 0xf94243a0
.word 0xaa0003e2
.word 0x3940035e
.word 0xf9400b41
.word 0xf9023fa1
.word 0x91008001
.word 0xd5033bbf
.word 0xf9423fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0203e0
.word 0xf9023ba0
.word 0x3940035e
.word 0xf9400f41
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423ba1
.word 0xaa0103e0
.word 0xaa0003e2
.word 0x3940035e
.word 0xb9806743
.word 0xb9003823
.word 0x3940035e
.word 0x39418f41
.word 0x3900f001
.word 0x3940035e
.word 0xf9401340
.word 0xaa0003e1
.word 0xaa0203f9
.word 0xaa0203f7
.word 0xaa0103f4
.word 0xb50000e0
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9413830
.word 0xd63f0200
.word 0xaa0003f4
.word 0x394002fe
.word 0x910182e0
.word 0xf9023ba0
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000014
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xf90036ff
.word 0x3940035e
.word 0x39418b40
.word 0x3940033e
.word 0x390423bf
.word 0x390427bf
.word 0x390427a0
.word 0xd280003e
.word 0x390423be
.word 0x398423a0
.word 0x3901e3a0
.word 0x398427a0
.word 0x3901e7a0
.word 0xeb1f033f
.word 0x10000011
.word 0x5400ee00
.word 0x9101d320
.word 0x3981e3a1
.word 0x39000001
.word 0x3981e7a1
.word 0x39000401
.word 0x3940035e
.word 0x39418340
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x3900f720
.word 0x3940033e
.word 0x390403bf
.word 0x390407bf
.word 0x390407bf
.word 0xd280003e
.word 0x390403be
.word 0x398403a0
.word 0x3901c3a0
.word 0x398407a0
.word 0x3901c7a0
.word 0xeb1f033f
.word 0x10000011
.word 0x5400eb00
.word 0x9101db20
.word 0x3981c3a1
.word 0x39000001
.word 0x3981c7a1
.word 0x39000401
.word 0xaa1903f8
.loc 3 2228 0
.word 0x3940035e
.word 0xf9401b40
.word 0xb4000b20
.loc 3 2229 0
.word 0x3940035e
.word 0xf9401b40
.word 0xb9801801

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
bl _p_42
.word 0xaa0003f9
.loc 3 2230 0
.word 0xd2a00017
.word 0x1400003a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 2231 0
.word 0x3940035e
.word 0xf9401f40
.word 0x93407ee1
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x5400e769
.word 0x8b010000
.word 0x91008000
.word 0x39400000
.word 0x34000300
.loc 3 2232 0
.word 0xf9402ba2
.word 0x3940035e
.word 0xf9401b40
.word 0x93407ee1
.word 0xb9801803
.word 0xeb01007f
.word 0x10000011
.word 0x5400e5e9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412050
.word 0xd63f0200
.word 0xaa0003e2
.word 0xaa1903e0
.word 0xaa1703e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.word 0x14000011
.loc 3 2234 0
.word 0x3940035e
.word 0xf9401b40
.word 0x93407ee1
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x5400e329
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400002
.word 0xaa1903e0
.word 0xaa1703e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.loc 3 2230 0
.word 0x110006f7
.word 0xb9801b20
.word 0x6b0002ff
.word 0x54fff8ab
.loc 3 2237 0
.word 0x3940031e
.word 0x91014300
.word 0xf9023ba0
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xf9002f1f
.word 0x14000017
.loc 3 2239 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xd2a00001
bl _p_42
.word 0xf9023ba0
.word 0x3940031e
.word 0x91014301
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf9002f1f
.loc 3 2242 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1803e1
.word 0x3940007e
bl _p_192
.loc 3 2166 0
.word 0xf94103a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35ffa160
.word 0xf901dbbf
.word 0x94000005
.word 0xf941dba0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90207be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94103a0
.word 0xb4000140
.word 0xf94103a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94207be
.word 0xd61f03c0
.loc 3 2247 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1768]
.word 0x394002be
.word 0x910623a8
.word 0xaa1503e0
bl _p_206
.word 0x140003cb

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf940cfba
.loc 3 2248 0
.word 0x394763a0
.word 0x35007840
.loc 3 2251 0
.word 0x394723a0
.word 0x35001be0
.loc 3 2252 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf940f050
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 2253 0
.word 0xaa1903e0
.word 0xb4001ac0
.loc 3 2254 0
.word 0xf9402ba0
.word 0xf9023ba0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9423ba2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940c850
.word 0xd63f0200
.word 0x53001c00
.word 0x350009e0
.loc 3 2255 0
.word 0xf94033a0
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1776]
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9025ba0
.word 0xf90257a0
.word 0xf9402ba0
.word 0xf9025fa0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9425fa2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9425ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94257a0
.word 0xf90253a0
.word 0xf9024fa0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94253a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424fa0
.word 0xf9024ba0
.word 0xf90247a0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a3
.word 0xf94247a4
.word 0xd2820561
.word 0xaa1a03e2
bl _p_146
.word 0xaa0003e1
.word 0xf9423ba0
bl _p_87
.loc 3 2257 0
.word 0x14000359
.loc 3 2260 0
.word 0xf940dfa0
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1784]
.word 0xd2800a01
bl _p_3
.word 0x9280001e
.word 0xb900381e
.word 0xf940dfa1
.word 0xf90247a0
.word 0x91006002
.word 0xd5033bbf
.word 0xf94247a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003e1
.word 0xf9023fa1
.word 0xf9023ba0
.word 0xaa1903e0
.word 0x3940033e
bl _p_207
.word 0xf9423ba2
.word 0xf9423fa3
.word 0xf94243a4
.word 0xaa0003e1
.word 0xaa0403f9
.word 0xaa0303f7
.word 0xaa0203f4
.word 0xaa0103f8
.word 0xb5000100
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003f8
.word 0x91008280
.word 0xf9023ba0
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000018
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0xaa1703f4
.word 0x35000060
.word 0xd2800098
.word 0x14000002
.word 0xd2800118
.word 0xb9004a98
.word 0xf9402ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0xaa1703f4
.word 0x35000060
.word 0xd2800058
.word 0x14000002
.word 0xd2800078
.word 0x39013298

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1792]
.word 0xf9023ba0
.word 0x910102e1
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xd280003e
.word 0x390136fe
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9412c50
.word 0xd63f0200
.word 0x394002fe
.word 0x39013ae0
.word 0xf94033a2
.word 0xaa1903e0
.word 0xaa1703e1
.word 0x3940033e
bl _p_208
.loc 3 2277 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9410450
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 2279 0
.word 0xaa1503e0
.word 0xb4005b20
.loc 3 2282 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9412c50
.word 0xd63f0200
.word 0x53001c00
.word 0x340000e0
.word 0xf940dfa0
.word 0x3941cc00
.word 0x350059c0
.word 0xf940dfa0
.word 0x3941c000
.word 0x35005960
.loc 3 2288 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9412c50
.word 0xd63f0200
.word 0x53001c00
.word 0x394703a1
.word 0xa010000
.word 0x340006e0
.loc 3 2289 0
.word 0xf94033a0
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1800]
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90253a0
.word 0xf9024fa0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94253a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424fa0
.word 0xf9024ba0
.word 0xf90247a0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a3
.word 0xf94247a4
.word 0xd2820461
.word 0xaa1a03e2
bl _p_146
.word 0xaa0003e1
.word 0xf9423ba0
bl _p_87
.loc 3 2290 0
.word 0x1400028b
.loc 3 2293 0
.word 0xf90107bf
.loc 3 2294 0
.word 0x394703a0
.word 0x34000c00
.word 0xf9402ba0
.word 0xf9023ba0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9423ba3
.word 0xaa0303e0
.word 0x910823a2
.word 0xf9400063
.word 0xf9409870
.word 0xd63f0200
.word 0x53001c00
.word 0x350009e0
.loc 3 2295 0
.word 0xf94033a0
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1808]
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9025ba0
.word 0xf90257a0
.word 0xf9402ba0
.word 0xf9025fa0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9425fa2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9425ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94257a0
.word 0xf90253a0
.word 0xf9024fa0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94253a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9424fa0
.word 0xf9024ba0
.word 0xf90247a0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a3
.word 0xf94247a4
.word 0xd2820481
.word 0xaa1a03e2
bl _p_146
.word 0xaa0003e1
.word 0xf9423ba0
bl _p_87
.loc 3 2296 0
.word 0x14000229
.loc 3 2298 0
.word 0xf94107a0
.word 0xb5000100
.loc 3 2299 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xf90107a0
.loc 3 2303 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1760]
.word 0xd2800d01
bl _p_3
.word 0x9280001e
.word 0xb900381e
.word 0xf9402ba1
.word 0xf9024fa0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9424fa0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf940dfa1
.word 0xf9024ba0
.word 0x91006002
.word 0xd5033bbf
.word 0xf9424ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf90247a0
.word 0x91010001
.word 0xd5033bbf
.word 0xf94247a0
.word 0xf900003a
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0003e1
.word 0xf90243a1
.word 0xf9023fa0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9423fa0
.word 0xf94243a2
.word 0xf9023ba1
.word 0x91008001
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0203e3
.word 0x394002be
.word 0xf9400aa0
.word 0xaa0003e1
.word 0xaa0303f9
.word 0xaa0203f7
.word 0xaa0103f4
.word 0xb5000100
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003f4
.word 0xaa1703e0
.word 0xaa1403e1
.word 0x394002fe
bl _p_201
.word 0x394002be
.word 0xb9801aa0
.word 0xb9003b20
.word 0xf94107a0
.word 0xf9023ba0
.word 0x3940033e
.word 0x91012321
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa1903f3
.loc 3 2313 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9414050
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 2314 0
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9413c50
.word 0xd63f0200
.word 0xf90147a0
.loc 3 2316 0
.word 0xb4001819
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf9402fa2
.word 0xaa1903e3
bl _p_209
.word 0x53001c00
.word 0x34001720
.loc 3 2317 0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf940dfa0
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9423fa1
.word 0xf94243a2
.word 0xf9023ba0
.word 0xaa1903e3
bl _p_190
.word 0xf9423ba2
.word 0xaa0203e3
.word 0x394002be
.word 0xf9400aa0
.word 0xaa0003e1
.word 0xaa0303f9
.word 0xaa0203f7
.word 0xaa0103f4
.word 0xb5000100
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003f4
.word 0xaa1703e0
.word 0xaa1403e1
.word 0x394002fe
bl _p_201
.word 0x394002be
.word 0xb9801aa0
.word 0xb9003b20
.word 0xf94107a0
.word 0xf9023ba0
.word 0x3940033e
.word 0x91018321
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf900373f
.word 0xaa1903f8
.loc 3 2323 0
.word 0xf9010bbf
.loc 3 2324 0
.word 0xaa1903e0
.word 0x910843a1
.word 0x3940033e
bl _p_210
.word 0x53001c00
.word 0x35000e40
.loc 3 2325 0
.word 0xf94033a0
.word 0xf9400000
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf9410ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1816]
.word 0x3940001e
.word 0xd2a00001
bl _p_211
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1824]
.word 0xf90247a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9025fa0
.word 0xf9025ba0
.word 0xf9402ba0
.word 0xf90263a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9408030
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94263a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9425fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9425ba0
.word 0xf90257a0
.word 0xf90253a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94257a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94253a0
.word 0xf9024fa0
.word 0xf9024ba0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424fa3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a2
.word 0xf94247a4
.word 0xf9424ba5
.word 0xd2820541
.word 0xaa1a03e3
bl _p_212
.word 0xf9423ba1
.word 0xaa0103fa
.word 0xaa0003f9
.word 0x3940035e
.word 0xb9801f40
.word 0x11000400
.word 0xb9001f40
.word 0xf9400b58
.word 0xb9801b57
.word 0xaa1703e0
.word 0xb9801b01
.word 0x6b01001f
.word 0x54000142
.word 0x110006e0
.word 0xb9001b40
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xaa1903e2
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.word 0x14000008

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1264]
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_169
.word 0x14000001
.loc 3 2327 0
.word 0x140000e3
.loc 3 2330 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1803e1
.word 0x3940007e
bl _p_192
.word 0x53001c00
.word 0x34001b60
.loc 3 2336 0
.word 0xf94147a0
.word 0xb4001a60
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf9402fa2
.word 0xf94147a3
bl _p_209
.word 0x53001c00
.word 0x34001980
.loc 3 2337 0
.word 0x394002be
.word 0xf9400aa0
.word 0xaa0003f9
.word 0xb5000100
.word 0xf9402ba2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003f9
.word 0xaa1903f8
.loc 3 2339 0
.word 0xf9402ba0
.word 0xf9024fa0
.word 0xf940dfa0
.word 0xf90253a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424fa1
.word 0xf94253a2
.word 0xf9024ba0
.word 0xf94147a3
bl _p_190
.word 0xf9424ba0
.word 0xf90243a0
.word 0xaa0003f8
.word 0xaa1803e0
.word 0xf90247a0
.word 0xaa1903e0
bl _p_213
.word 0xaa0003e1
.word 0xf94247a2
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf94243a0
.word 0x394002be
.word 0xb9801aa1
.word 0xb9003801
.word 0xf9023ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xd2800021
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9023fa0
.word 0xf94107a2
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa1
.word 0x3940031e
.word 0x91014302
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9002c1f
.word 0xaa1803f9
.loc 3 2345 0
.word 0xf9010fbf
.loc 3 2346 0
.word 0xaa1803e0
.word 0x910863a1
.word 0x3940031e
bl _p_210
.word 0x53001c00
.word 0x35000e40
.loc 3 2347 0
.word 0xf94033a0
.word 0xf9400000
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf9410fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1816]
.word 0x3940001e
.word 0xd2a00001
bl _p_211
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1824]
.word 0xf90247a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9025fa0
.word 0xf9025ba0
.word 0xf9402ba0
.word 0xf90263a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9408030
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94263a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9425fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9425ba0
.word 0xf90257a0
.word 0xf90253a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94257a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94253a0
.word 0xf9024fa0
.word 0xf9024ba0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9424fa3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a2
.word 0xf94247a4
.word 0xf9424ba5
.word 0xd2820541
.word 0xaa1a03e3
bl _p_212
.word 0xf9423ba1
.word 0xaa0103fa
.word 0xaa0003f9
.word 0x3940035e
.word 0xb9801f40
.word 0x11000400
.word 0xb9001f40
.word 0xf9400b58
.word 0xb9801b57
.word 0xaa1703e0
.word 0xb9801b01
.word 0x6b01001f
.word 0x54000142
.word 0x110006e0
.word 0xb9001b40
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xaa1903e2
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.word 0x14000008

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1264]
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_169
.word 0x14000001
.loc 3 2349 0
.word 0x1400000f
.loc 3 2352 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1903e1
.word 0x3940007e
bl _p_192
.word 0x53001c00
.word 0x340000e0
.loc 3 2358 0
.word 0xf940dfa3
.word 0xf94033a2
.word 0xaa0303e0
.word 0xaa1303e1
.word 0x3940007e
bl _p_205
.loc 3 2247 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1832]
.word 0x910623a0
bl _p_214
.word 0x53001c00
.word 0x35ff8600
.word 0xf9014bbf
.word 0x94000005
.word 0xf9414ba0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9020fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910623a0
.word 0xf9014fa0
.word 0xf9420fbe
.word 0xd61f03c0
.loc 3 2361 0
.word 0x394a03a0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x390783a0
.loc 3 2374 0
.word 0xf900f7bf
.loc 3 2376 0
.word 0x394723a0
.word 0x35000100
.loc 3 2377 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940fc50
.word 0xd63f0200
.word 0xf900f7a0
.loc 3 2379 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1680]
.word 0x394002de
.word 0x910683a8
.word 0xaa1603e0
bl _p_202
.word 0x1400014a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910683a0
.word 0xf90153a0
.word 0xf94153a0
.word 0xf9400800
.word 0xf90157a0
.word 0xf94157a0
.word 0xf90113a0
.loc 3 2380 0
.word 0x394763a0
.word 0x35002760
.loc 3 2383 0
.word 0xf9402ba2
.word 0xf94113a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9410050
.word 0xd63f0200
.word 0xf90117a0
.loc 3 2385 0
.word 0xf94117a0
.word 0xb5000c40
.loc 3 2387 0
.word 0xf940f7a0
.word 0xb4000c00
.word 0xf940f7a0
.word 0xf94113a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #280]
.word 0x3940001e
.word 0x9108e3a2
bl _p_7
.word 0x53001c00
.word 0x34000ac0
.loc 3 2388 0
.word 0xf9411fa0
.word 0xf9016ba0
.word 0xf9416ba0
.word 0x3940001e
.word 0xf9416ba0
.word 0xb9801800
.word 0xb902dba0
.word 0xb982dba0
.word 0xd280003e
.word 0x6b1e001f
.word 0x54000760
.loc 3 2389 0
.word 0xf94113a0
.word 0xf9411fa1
bl _p_215

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1840]
.word 0x3940001e
.word 0x9103a3a8
bl _p_216
.word 0xf94077a0
.word 0xf900bba0
.word 0xf9407ba0
.word 0xf900bfa0
.word 0xf9407fa0
.word 0xf900c3a0
.word 0x14000011

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9105c3a0
.word 0xf90173a0
.word 0xf94173a0
.word 0xf9400800
.word 0xf90177a0
.word 0xf94177a0
.word 0xf90123a0
.loc 3 2390 0
.word 0xf94033a0
.word 0xf94123a1
bl _p_87
.loc 3 2389 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1848]
.word 0x9105c3a0
bl _p_217
.word 0x53001c00
.word 0x35fffd40
.word 0xf9017bbf
.word 0x94000005
.word 0xf9417ba0
.word 0xb4000040
bl _p_23
.word 0x140000ee
.word 0xf90217be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9105c3a0
.word 0xf9017fa0
.word 0xf9417fa0
.word 0x3940001e
.word 0xf94217be
.word 0xd61f03c0
.loc 3 2394 0
.word 0xf9402ba0
.word 0xf9023ba0
.word 0xf9411fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1856]
.word 0x3940001e
.word 0xd2a00001
bl _p_218
.word 0xaa0003e1
.word 0xf9423ba2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9410050
.word 0xd63f0200
.word 0xf90117a0
.loc 3 2398 0
.word 0xf94117a0
.word 0xb40019e0
.loc 3 2401 0
.word 0xf9402ba2
.word 0xf94113a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412450
.word 0xd63f0200
.word 0x53001c00
.word 0x34000200
.word 0xf940dfa0
.word 0x3941cc00
.word 0x35000080
.word 0xf940dfa0
.word 0x3941c000
.word 0x34000140
.word 0xf940dfa0
.word 0x3941c400
.word 0x340017c0
.word 0xf940dfa1
.word 0xaa0103e0
.word 0x3940003e
bl _p_89
.word 0x53001c00
.word 0x35001700
.loc 3 2407 0
.word 0xf940dfa0
.word 0x3941c000
.word 0x34000120
.word 0xf9402ba2
.word 0xf94113a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9413450
.word 0xd63f0200
.word 0x53001c00
.word 0x350015a0
.loc 3 2412 0
.word 0x394783a0
.word 0x35000680
.word 0xf94113a1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xf9402fa1
bl _p_48
.word 0x53001c00
.word 0x34000560
.word 0xf9402ba2
.word 0xf94113a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9414c50
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9402ba0
.word 0xf9401c00
.word 0xf9015fa1
.word 0xf90163a0
.word 0xf94163a0
.word 0xb50000c0
.word 0xf9415fa0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x390b23a0
.word 0x14000014
.word 0xf9415fa0
.word 0xf94163a1
.word 0xeb01001f
.word 0x54000081
.word 0xd280003e
.word 0x390b23be
.word 0x1400000d
.word 0xf9415fa0
.word 0xb4000120
.word 0xf9415fa2
.word 0xf94163a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9402c50
.word 0xd63f0200
.word 0x390b23a0
.word 0x14000003
.word 0x390b23bf
.word 0x14000001
.word 0x394b23a0
.word 0x53001c00
.word 0x34000060
.loc 3 2413 0
.word 0xd2800020
.word 0x390783a0
.loc 3 2415 0
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf9402fa2
.word 0xf94113a3
bl _p_209
.word 0x53001c00
.word 0x34000e20
.loc 3 2418 0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf940dfa0
.word 0xf90243a0
.word 0xf94113a0
.word 0xf90247a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9423fa1
.word 0xf94243a2
.word 0xf94247a3
.word 0xf9023ba0
bl _p_190
.word 0xf9423ba0
.word 0xf9011ba0
.loc 3 2419 0
.word 0xf9411ba3
.word 0xf94117a1
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_191
.word 0x53001c00
.word 0x34000ae0
.loc 3 2427 0
.word 0xf9402ba2
.word 0xf94113a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412450
.word 0xd63f0200
.word 0x53001c00
.word 0x394703a1
.word 0xa010000
.word 0x34000540
.loc 3 2428 0
.word 0xf94033a0
.word 0xf9023ba0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf94113a0
.word 0xf90243a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1864]
.word 0xf90247a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9015ba0
.word 0xf9415ba0
.word 0xf9024ba0
.word 0xf9415ba0
.word 0xf9024fa0
.word 0xf9402ba0
.word 0xf9402fa1
.word 0xf94113a2
bl _p_160
.word 0xaa0003e2
.word 0xf9424fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9423fa0
.word 0xf94243a2
.word 0xf94247a3
.word 0xf9424ba4
.word 0xd2820441
bl _p_145
.word 0xaa0003e1
.word 0xf9423ba0
bl _p_87
.loc 3 2429 0
.word 0x14000024
.loc 3 2430 0
.word 0x394703a0
.word 0x34000100
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf9402fa2
.word 0xf9411ba3
bl _p_219
.word 0x53001c00
.word 0x34000360
.loc 3 2435 0
.word 0xf940dfa3
.word 0xf9411ba1
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2436 0
.word 0x14000014
.word 0xf901eba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf941eba0
.word 0xf90127a0
.loc 3 2437 0
.word 0xf94033a0
.word 0xf94127a1
bl _p_87
.loc 3 2438 0
bl _p_220
.word 0xf90237a0
.word 0xf94237a0
.word 0xb4000060
.word 0xf94237a0
bl _p_13
.word 0x14000001
.loc 3 2379 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1704]
.word 0x910683a0
bl _p_203
.word 0x53001c00
.word 0x35ffd620
.word 0xf90183bf
.word 0x94000005
.word 0xf94183a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90227be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910683a0
.word 0xf90187a0
.word 0xf94227be
.word 0xd61f03c0
.loc 3 2441 0
.word 0x394723a0
.word 0x35000da0
.word 0x394783a0
.word 0x35000d60
.loc 3 2442 0
.word 0xf940dfa0
.word 0xf90243a0
.word 0xf9402ba0
.word 0xf9024ba0
.word 0xf940dfa0
.word 0xf9024fa0
.word 0xf9402ba0
.word 0xf9402000
.word 0xf90253a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9424ba1
.word 0xf9424fa2
.word 0xf94253a3
.word 0xf90247a0
bl _p_190
.word 0xf94247a0
.word 0xf901aba0
.word 0xf941aba0
.word 0xf9023fa0
.word 0xf941aba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1872]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423fa0
.word 0xf94243a3
.word 0xf901afa0
.word 0xf941afa0
.word 0xf941afa1
.word 0xf901b3a1
.word 0xd280003e
.word 0xb9036bbe
.word 0xf941b3a1
.word 0x3940003e
.word 0xf941b3a1
.word 0xb9836ba2
.word 0xb9007022
.word 0xf901bba0
.word 0xf941bba0
.word 0xf9023ba0
.word 0xf941bba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1880]
.word 0xf901bfa1
.word 0xf901c3a0
.word 0xf941bfa0
.word 0x3940001e
.word 0xf941bfa0
.word 0xf941c3a1
.word 0x91012002
.word 0xd5033bbf
.word 0xf9423ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x4, [x16, #16]
.word 0x8b040042
.word 0xd280003e
.word 0x3900005e
.word 0xf901c7a0
.word 0xf941c7a1
.word 0xf941c7a0
.word 0xf901cba0
.word 0x390e63bf
.word 0xf941cba0
.word 0x3940001e
.word 0xf941cba0
.word 0x394e63a2
.word 0x390383bf
.word 0x390387bf
.word 0x910383a4
.word 0xf901d3a4
.word 0x390ea3a2
.word 0xf941d3a2
.word 0x394ea3a4
.word 0x39000444
.word 0xf941d3a2
.word 0xd280003e
.word 0x3900005e
.word 0x398383a2
.word 0x3901a3a2
.word 0x398387a2
.word 0x3901a7a2
.word 0xeb1f001f
.word 0x10000011
.word 0x54001e00
.word 0x9101d000
.word 0x3981a3a2
.word 0x39000002
.word 0x3981a7a2
.word 0x39000402
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2465 0
.word 0xf9402ba2
.word 0xf9402fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9416050
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1024]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1032]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9012ba0
.word 0x14000092

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9412ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9012fa0
.loc 3 2466 0
.word 0xf9402ba2
.word 0xf9412fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412450
.word 0xd63f0200
.word 0x53001c00
.word 0x35000ee0
.loc 3 2469 0
.word 0xf9402ba2
.word 0xf9412fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9414850
.word 0xd63f0200
.word 0xf90133a0
.loc 3 2470 0
.word 0xf94133a0
.word 0xb4000080
.word 0xf94133a1
.word 0xb9801820
.word 0x35000600
.loc 3 2473 0
.word 0xf940dfa0
.word 0xf9023fa0
.word 0xf9402ba0
.word 0xf90247a0
.word 0xf940dfa0
.word 0xf9024ba0
.word 0xf9412fa0
.word 0xf9024fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf94247a1
.word 0xf9424ba2
.word 0xf9424fa3
.word 0xf90243a0
bl _p_190
.word 0xf94243a0
.word 0xf9018ba0
.word 0xf9418ba0
.word 0xf9023ba0
.word 0xf9418ba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1888]
.word 0xaa0203e0
.word 0x3940005e
bl _p_201
.word 0xf9423ba0
.word 0xf9423fa3
.word 0xf9018fa0
.word 0xf9418fa1
.word 0xf9418fa0
.word 0xf90193a0
.word 0xd280017e
.word 0xb9032bbe
.word 0xf94193a0
.word 0x3940001e
.word 0xf94193a0
.word 0xb9832ba2
.word 0xb9007002
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2477 0
.word 0x1400003c
.loc 3 2480 0
.word 0xf9402ba2
.word 0xf9412fa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9410050
.word 0xd63f0200
.word 0xf90137a0
.loc 3 2482 0
.word 0xf94137a0
.word 0xb4000660
.loc 3 2487 0
.word 0xf9402ba0
.word 0xf94033a1
.word 0xf9402fa2
.word 0xf9412fa3
bl _p_209
.word 0x53001c00
.word 0x34000580
.loc 3 2490 0
.word 0xf9402ba0
.word 0xf9023fa0
.word 0xf940dfa0
.word 0xf90243a0
.word 0xf9412fa0
.word 0xf90247a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1552]
.word 0xd2800f01
bl _p_3
.word 0xf9423fa1
.word 0xf94243a2
.word 0xf94247a3
.word 0xf9023ba0
bl _p_190
.word 0xf9423ba0
.word 0xf9019ba0
.word 0xf9419ba0
.word 0xf9419ba1
.word 0xf9019fa1
.word 0xd280017e
.word 0xb90343be
.word 0xf9419fa1
.word 0x3940003e
.word 0xf9419fa1
.word 0xb98343a2
.word 0xb9007022
.word 0xf9013ba0
.loc 3 2493 0
.word 0xf9413ba3
.word 0xf94137a1
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_191
.word 0x53001c00
.word 0x340000e0
.loc 3 2494 0
.word 0xf940dfa3
.word 0xf9413ba1
.word 0xf94033a2
.word 0xaa0303e0
.word 0x3940007e
bl _p_192
.loc 3 2465 0
.word 0xf9412ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35ffeca0
.word 0xf901a7bf
.word 0x94000005
.word 0xf941a7a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9022fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9412ba0
.word 0xb4000140
.word 0xf9412ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9422fbe
.word 0xd61f03c0
.loc 3 2497 0
.word 0xf940dfa0
.word 0x3941c400
.word 0x34000100
.loc 3 2498 0
.word 0xf9402ba2
.word 0xf940dfa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9417850
.word 0xd63f0200
.word 0x14000007
.loc 3 2500 0
.word 0xf9402ba2
.word 0xf940dfa1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9418450
.word 0xd63f0200
.loc 3 2503 0
.word 0xf940dfa0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa9407bfd
.word 0xd280a610
.word 0x910003f1
.word 0x8b100231
.word 0x9100023f
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_ee:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_RegisterAssembly_System_Reflection_Assembly
Registrar_Registrar_RegisterAssembly_System_Reflection_Assembly:
.loc 3 2508 0 prologue_end
.word 0xa9ae7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0
.word 0xf90017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0xf9001fbf
.word 0x390103bf
.word 0xf90027bf
.word 0xf9002bbf
.word 0xf94017a0
.word 0xb40026c0
.loc 3 2511 0
.word 0xf94013a0
.word 0xf9400800
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1896]
.word 0x3940001e
bl _p_221
.word 0x53001c00
.word 0x35002500
.loc 3 2514 0
.word 0xf94013a2
.word 0xf94017a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9417050
.word 0xd63f0200
.word 0x53001c00
.word 0x35002400
.loc 3 2519 0
.word 0xf94013a2
.word 0xf94017a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9415c50
.word 0xd63f0200
.word 0x53001c00
.word 0x35000160
.loc 3 2520 0
.word 0xf94013a0
.word 0xf9400800
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1904]
.word 0x3940001e
.word 0xd2800002
bl _p_222
.loc 3 2521 0
.word 0x1400010e
.loc 3 2524 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1248]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1256]
.word 0xf9400021
.word 0xf9007ba0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9407ba0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9001ba0
.loc 3 2527 0
.word 0xf94013a2
.word 0xf94017a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9416c50
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 2535 0
.word 0xf94013a0
.word 0xf9400c00
.word 0xf9001fa0
.word 0xd2a00000
.word 0x390103a0
.word 0xf9401fb9
.word 0x910103a0
.word 0xf9002fa0
.word 0xaa1903e0
.word 0x910103a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1903e0
.word 0xf9402fa1
bl _p_21
.loc 3 2536 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1912]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1920]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf90027a0
.word 0x14000018

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94027a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1928]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1936]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 2538 0
.word 0xf94013a0
.word 0xaa1a03e1
.word 0x9100c3a2
bl _p_159
.loc 3 2536 0
.word 0xf94027a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fffbe0
.word 0xf90033bf
.word 0x94000005
.word 0xf94033a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9005fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94027a0
.word 0xb4000140
.word 0xf94027a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9405fbe
.word 0xd61f03c0
.loc 3 2540 0
.word 0xf90037bf
.word 0x94000005
.word 0xf94037a0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf90067be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394103a0
.word 0x34000060
.word 0xf9401fa0
bl _p_24
.word 0xf94067be
.word 0xd61f03c0
.loc 3 2542 0
.word 0xf94013a0
.word 0xf9400800
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1904]
.word 0x3940001e
.word 0xd2800002
bl _p_222
.loc 3 2543 0
.word 0x14000041
.word 0xf90053a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94053a0
.word 0xf9002ba0
.loc 3 2544 0
.word 0xf94013a0
.word 0xf90083a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1944]
.word 0xf9007ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90057a0
.word 0xf94057a0
.word 0xf90087a0
.word 0xf94057a0
.word 0xf9008ba0
.word 0xf94013a2
.word 0xf94017a1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9408ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94087a0
.word 0xf9005ba0
.word 0xf9405ba0
.word 0xf9007fa0
.word 0xf9405ba3
.word 0xf9402ba2
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9407ba2
.word 0xf9407fa3
.word 0xf94083a4
.word 0xaa0403e0
.word 0xd2820281
.word 0xf9400084
.word 0xf9403890
.word 0xd63f0200
.loc 3 2545 0
bl _p_220
.word 0xf90077a0
.word 0xf94077a0
.word 0xb4000060
.word 0xf94077a0
bl _p_13
.word 0x14000001
.loc 3 2549 0
.word 0xf9401ba0
.word 0xf9003ba0
.word 0xf9403ba0
.word 0x3940001e
.word 0xf9403ba0
.word 0xb9801800
.word 0xb9007ba0
.word 0xb9807ba0
.word 0x6b1f001f
.word 0x540005cd
.loc 3 2550 0
.word 0xf9401ba0
.word 0xf90043a0
.word 0xf94043a0
.word 0x3940001e
.word 0xf94043a0
.word 0xb9801800
.word 0xb9008ba0
.word 0xb9808ba0
.word 0xd280003e
.word 0x6b1e001f
.word 0x540001c0
.word 0xf9401ba0
.word 0xf9007fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1952]
.word 0xd2801401
bl _p_3
.word 0xf9407fa1
.word 0xf9007ba0
bl _p_131
.word 0xf9407ba0
.word 0xf9004ba0
.word 0x1400000a
.word 0xf9401ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1816]
.word 0x3940001e
.word 0xd2a00001
bl _p_211
.word 0xf9004ba0
.word 0x14000001
.word 0xf9404ba0
.loc 3 2552 0
.word 0xf9004fa0
.word 0xf9404fa0
.word 0xf9007ba0
.word 0xf9404fa1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9403030
.word 0xd63f0200
bl _p_59
.word 0xf9407ba0
.loc 3 2554 0
bl _p_13
.loc 3 2556 0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8d27bfd
.word 0xd65f03c0
.loc 3 2509 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28593e1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_ef:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ComputeSignature_System_Type_System_Reflection_MethodBase_Registrar_Registrar_ObjCMember_bool_bool
Registrar_Registrar_ComputeSignature_System_Type_System_Reflection_MethodBase_Registrar_Registrar_ObjCMember_bool_bool:
.loc 3 2561 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xd2800210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa90153b3
.word 0xf90013b5
.word 0xa902e3b7
.word 0xf9001fba
.word 0xaa0003f5
.word 0xf90023a1
.word 0xaa0203f7
.word 0xaa0303f8
.word 0xf90027a4
.word 0xf9002ba5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803f4
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800014
.word 0xaa1403f3
.loc 3 2562 0
.word 0xd2800014
.loc 3 2564 0
.word 0xb4000137
.loc 3 2565 0
.word 0xaa1503e0
.word 0xaa1703e1
.word 0xf94002a2
.word 0xf9411850
.word 0xd63f0200
.word 0x53001c00
.word 0x390163a0
.word 0x14000006
.loc 3 2567 0
.word 0xaa1303e0
.word 0x3940027e
bl _p_161
.word 0x53001c00
.word 0x390163a0
.loc 3 2570 0
.word 0x394163a0
.word 0x350001c0
.loc 3 2571 0
.word 0xb50000d7
.word 0xaa1303e0
.word 0x3940027e
bl _p_162
.word 0xaa0003fa
.word 0x14000007
.word 0xaa1503e0
.word 0xaa1703e1
.word 0xf94002a2
.word 0xf9411050
.word 0xd63f0200
.word 0xaa0003fa
.word 0xaa1a03f4
.loc 3 2574 0
.word 0xb4000117
.loc 3 2575 0
.word 0xaa1503e0
.word 0xaa1703e1
.word 0xf94002a2
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003fa
.word 0x14000005
.loc 3 2577 0
.word 0xaa1303e0
.word 0x3940027e
bl _p_223
.word 0xaa0003fa
.loc 3 2580 0
.word 0xaa1503e0
.word 0xf94023a1
.word 0x394163a2
.word 0xaa1403e3
.word 0xaa1a03e4
.word 0xaa1703e5
.word 0xaa1803e6
.word 0x394123a7
.word 0x394143a9
.word 0x390003e9
bl _p_224
.word 0xa94153b3
.word 0xf94013b5
.word 0xa942e3b7
.word 0xf9401fba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_f0:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ComputeSignature_System_Type_bool_System_Type_System_Type___System_Reflection_MethodBase_Registrar_Registrar_ObjCMember_bool_bool
Registrar_Registrar_ComputeSignature_System_Type_bool_System_Type_System_Type___System_Reflection_MethodBase_Registrar_Registrar_ObjCMember_bool_bool:
.loc 3 2585 0 prologue_end
.word 0xa9b37bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xf90023bc
.word 0x910343bc
.word 0xf90027a0
.word 0xf9002ba1
.word 0xf9002fa2
.word 0xaa0303f5
.word 0xaa0403f6
.word 0xaa0503f7
.word 0xaa0603f8
.word 0xf90033a7

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3901a3bf
.word 0xd2800020
.word 0x3901a3a0
.loc 3 2586 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xd2800601
bl _p_3
.word 0xf90043a0
bl _p_156
.word 0xf94043a0
.word 0xaa0003fa
.loc 3 2587 0
.word 0xb50002d7
.loc 3 2588 0
.word 0xaa1803f9
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xf9003bb9
.word 0xb5000079
.word 0xf9003bbf
.word 0x14000004
.word 0xf9403ba0
.word 0xf9402000
.word 0xf9003ba0
.word 0xf9403bb7
.loc 3 2590 0
.word 0x394163a0
.word 0x340000c0
.loc 3 2591 0
.word 0xaa1a03e0
.word 0xd2800801
.word 0x3940035e
bl _p_138
.word 0x1400000d
.loc 3 2593 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xaa1803e2
.word 0x9101a3a3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xaa1a03e0
.word 0x3940035e
bl _p_157
.loc 3 2594 0
.word 0x3941a3a0
.word 0x34001b60
.loc 3 2598 0
.word 0xf9003bba
.word 0x39400380
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x25, [x16, #768]
.word 0x14000004

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x25, [x16, #1960]
.word 0xf9403ba0
.word 0xaa1903e1
.word 0xf9403ba2
.word 0x3940005e
bl _p_157
.loc 3 2600 0
.word 0xb4001816
.loc 3 2601 0
.word 0xd2a00019
.word 0x140000bb

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 2602 0
.word 0x6b1f033f
.word 0x9a9f17e0
.word 0x394183a1
.word 0xa010000
.word 0x350015e0
.loc 3 2604 0
.word 0x93407f20
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54001ee9
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400015
.loc 3 2605 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9413050
.word 0xd63f0200
.word 0x53001c00
.word 0x34000640
.loc 3 2606 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1968]
.word 0xaa1a03e0
.word 0x3940035e
bl _p_157
.loc 3 2607 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 2608 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf940b850
.word 0xd63f0200
.word 0x53001c00
.word 0x34000240
.loc 3 2609 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf940cc50
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94027a0
.word 0xaa1803e2
.word 0x9101a3a3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xaa1a03e0
.word 0x3940035e
bl _p_157
.word 0x14000016
.loc 3 2611 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xaa1803e2
.word 0x9101a3a3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xaa1a03e0
.word 0x3940035e
bl _p_157
.word 0x1400000b
.loc 3 2614 0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xaa1803e2
.word 0x9101a3a3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xaa1a03e0
.word 0x3940035e
bl _p_157
.loc 3 2616 0
.word 0x3941a3a0
.word 0x35000c20
.loc 3 2617 0
.word 0xb4000137
.loc 3 2621 0
.word 0xf94027a0
.word 0xaa1703e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9414850
.word 0xd63f0200
.word 0xaa0003f6
.word 0x14000001
.loc 3 2623 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd285b781
bl _p_11
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf90063a0
.word 0xf9005fa0
.word 0x93407f20
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54001269
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400001
.word 0xf94027a0
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94063a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9405fa0
.word 0xf9005ba0
.word 0xf90057a0
.word 0xf94027a0
.word 0xaa1703e1
.word 0xaa1903e2
.word 0xf94027a3
.word 0xf9400063
.word 0xf9414470
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9405ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94057a0
.word 0xf90053a0
.word 0xf9004fa0
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94053a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xf94027a0
.word 0xaa1703e1
bl _p_29
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a3
.word 0xf94047a4
.word 0xf94027a0
.word 0xd2820501
.word 0xaa1703e2
bl _p_145
bl _p_13
.loc 3 2601 0
.word 0x11000739
.word 0xb9801ac0
.word 0x6b00033f
.word 0x54ffe88b
.loc 3 2628 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9403030
.word 0xd63f0200
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0xf94023bc
.word 0x910003bf
.word 0xa8cd7bfd
.word 0xd65f03c0
.loc 3 2595 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd285a0e1
bl _p_11
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9005ba0
.word 0xf90057a0
.word 0xf94027a0
.word 0xaa1503e1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9405ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94057a0
.word 0xf90053a0
.word 0xf9004fa0
.word 0xf94027a0
.word 0xf9402ba1
.word 0xf94027a2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94053a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xf94027a0
.word 0xaa1703e1
bl _p_29
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a3
.word 0xf94047a4
.word 0xf94027a0
.word 0xd2820101
.word 0xaa1703e2
bl _p_145
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_f1:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ToSignature_System_Type_Registrar_Registrar_ObjCMember_bool
Registrar_Registrar_ToSignature_System_Type_Registrar_Registrar_ObjCMember_bool:
.loc 3 2633 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xa901ebb9
.word 0xaa0003f7
.word 0xf90017a1
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3900c3bf
.word 0xd2800020
.word 0x3900c3a0
.loc 3 2634 0
.word 0xaa1703e0
.word 0xf94017a1
.word 0xaa1903e2
.word 0x9100c3a3
.word 0xaa1a03e4
bl _p_225
.word 0xaa0003fa
.loc 3 2635 0
.word 0x3940c3a0
.word 0x34000060
.loc 3 2636 0
.word 0xaa1a03e0
.word 0x14000011
.loc 3 2638 0
.word 0xaa1903fa
.word 0xeb1f033f
.word 0x54000160
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd280001a
.word 0xaa1a03f9
.loc 3 2639 0
.word 0xb400089a
.word 0x14000006
.loc 3 2642 0
.word 0xf9400bb7
.word 0xa941ebb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.loc 3 2640 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd285d0e1
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1703e0
.word 0xf94017a1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf9002ba0
.word 0xf90027a0
.word 0xf9400f20
.word 0xf9401401
.word 0xaa1703e0
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xf9002fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280fde1
bl _p_11
.word 0xf90033a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_85
.word 0xaa0003e2
.word 0xf9402fa0
.word 0xf94033a1
bl _p_30
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a1
.word 0xf94027a2
.word 0xd28201e0
bl _p_32
bl _p_13
.word 0x14000001
.loc 3 2642 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd285e2c1
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9002ba0
.word 0xf90027a0
.word 0xaa1703e0
.word 0xf94017a1
.word 0xf94002e2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a1
.word 0xf94027a2
.word 0xd28200a0
bl _p_32
bl _p_13

Lme_f2:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetExportedTypeName_System_Type_Foundation_RegisterAttribute
Registrar_Registrar_GetExportedTypeName_System_Type_Foundation_RegisterAttribute:
.loc 3 2647 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xf90013ba
.word 0xaa0003f8
.word 0xf90017a1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800017
.loc 3 2648 0
.word 0xb400021a
.loc 3 2649 0
.word 0x3940035e
.word 0x39406740
.word 0x53001c00
.word 0x34000140
.loc 3 2650 0
.word 0xaa1803e0
.word 0xf94017a1
.word 0xf9400302
.word 0xf9415850
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1803e0
bl _p_226
.word 0x1400000c
.loc 3 2651 0
.word 0x3940035e
.word 0xf9400b57
.loc 3 2653 0
.word 0xb50000f7
.loc 3 2654 0
.word 0xaa1803e0
.word 0xf94017a1
.word 0xf9400302
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 2655 0
.word 0xaa1703e0
bl _p_227
.word 0xa94163b7
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_f3:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_GetExportedTypeName_System_Type
Registrar_Registrar_GetExportedTypeName_System_Type:
.loc 3 2660 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf940f850
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_228
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_f4:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ToSignature_System_Type_Registrar_Registrar_ObjCMember_bool__bool
Registrar_Registrar_ToSignature_System_Type_Registrar_Registrar_ObjCMember_bool__bool:
.loc 3 2667 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f6
.word 0xaa0103f7
.word 0xaa0203f8
.word 0xaa0303f9
.word 0xaa0403fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x390123bf
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xb4003720
.word 0xb98012b4
.word 0xaa1403e0
.word 0x51002c14
.word 0xd28000be
.word 0x6b1e029f
.word 0x54003662
.word 0xd37df280
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1976]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd28000e0
.word 0xb98012a1
.word 0xd28000fe
.word 0xeb1e003f
.word 0x10000011
.word 0x54005de9
.word 0xd37ff800
.word 0x8b150000
.word 0x79402800
.word 0x53003c14
.word 0xaa1403e0
.word 0xd280085e
.word 0x6b1e001f
.word 0x54000d40
.word 0xd2800abe
.word 0x6b1e029f
.word 0x54000be0
.word 0x14000199
.word 0xd2800160
.word 0xb98012a1
.word 0xd280017e
.word 0xeb1e003f
.word 0x10000011
.word 0x54005ba9
.word 0xd37ff800
.word 0x8b150000
.word 0x79402800
.word 0x53003c14
.word 0xaa1403e0
.word 0xd28006de
.word 0x6b1e001f
.word 0x54000168
.word 0xd280063e
.word 0x6b1e029f
.word 0x54000ca0
.word 0xd280067e
.word 0x6b1e029f
.word 0x54000d40
.word 0xd28006de
.word 0x6b1e029f
.word 0x54000de0
.word 0x14000181
.word 0xd2800d9e
.word 0x6b1e029f
.word 0x54000e60
.word 0xd2800dde
.word 0x6b1e029f
.word 0x54000fe0
.word 0xd2800e9e
.word 0x6b1e029f
.word 0x540009a0
.word 0x14000177
.word 0xd2800140
.word 0xb98012a1
.word 0xd280015e
.word 0xeb1e003f
.word 0x10000011
.word 0x54005769
.word 0xd37ff800
.word 0x8b150000
.word 0x79402800
.word 0x53003c14
.word 0xaa1403e0
.word 0xd280067e
.word 0x6b1e001f
.word 0x54000108
.word 0xd280063e
.word 0x6b1e029f
.word 0x54000f40
.word 0xd280067e
.word 0x6b1e029f
.word 0x54000fe0
.word 0x14000162
.word 0xd28006de
.word 0x6b1e029f
.word 0x54001060
.word 0xd2800dde
.word 0x6b1e029f
.word 0x54001100
.word 0xd2800e9e
.word 0x6b1e029f
.word 0x54000ca0
.word 0x14000158
.word 0xd28000e0
.word 0xb98012a1
.word 0xd28000fe
.word 0xeb1e003f
.word 0x10000011
.word 0x54005389
.word 0xd37ff800
.word 0x8b150000
.word 0x79402800
.word 0x53003c14
.word 0xaa1403e0
.word 0xd280087e
.word 0x6b1e001f
.word 0x54000108
.word 0xd280085e
.word 0x6b1e029f
.word 0x54000f60
.word 0xd280087e
.word 0x6b1e029f
.word 0x54001000
.word 0x14000143
.word 0xd2800ade
.word 0x6b1e029f
.word 0x54001080
.word 0xd2800dde
.word 0x6b1e029f
.word 0x54001120
.word 0x1400013c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1984]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001220
.word 0x14000134

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1992]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001720
.word 0x1400012c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2000]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001020
.word 0x14000124

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2008]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350011a0
.word 0x1400011c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2016]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350011a0
.word 0x14000114

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2024]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350011a0
.word 0x1400010c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2032]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001120

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2040]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350010c0
.word 0x140000fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2048]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001280
.word 0x140000f5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2056]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350009c0
.word 0x140000ed

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2064]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000a40
.word 0x140000e5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2072]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000a40
.word 0x140000dd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2080]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000a40
.word 0x140000d5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2088]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35001060
.word 0x140000cd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2096]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000540
.word 0x140000c5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2104]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x350004c0
.word 0x140000bd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2112]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000a00
.word 0x140000b5

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2120]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000aa0
.word 0x140000ad

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2128]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x35000d20
.word 0x140000a5
.loc 3 2671 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2136]
.word 0x140001c5
.loc 3 2672 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2144]
.word 0x140001c1
.loc 3 2673 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #672]
.word 0x140001bd
.loc 3 2674 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2152]
.word 0x140001b9
.loc 3 2675 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2152]
.word 0x140001b5
.loc 3 2676 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2160]
.word 0x140001b1
.loc 3 2677 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2168]
.word 0x140001ad
.loc 3 2678 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2176]
.word 0x140001a9
.loc 3 2679 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2184]
.word 0x140001a5
.loc 3 2680 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2192]
.word 0x140001a1
.loc 3 2681 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2200]
.word 0x1400019d
.loc 3 2682 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2208]
.word 0x14000199
.loc 3 2688 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2144]
.word 0x1400018f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2216]
.word 0x1400018b
.loc 3 2690 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2224]
.word 0x14000187
.loc 3 2692 0
.word 0x350000ba

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1792]
.word 0x14000182

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2232]
.word 0x1400017e
.loc 3 2694 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2168]
.word 0x14000174

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2184]
.word 0x14000170
.loc 3 2696 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2176]
.word 0x14000166

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2192]
.word 0x14000162
.loc 3 2698 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2863a01
bl _p_11
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9004ba0
.word 0xf90047a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2862cc1
bl _p_11
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2865121
bl _p_11
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9404030
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94033a3
.word 0xf94037a4
.word 0xaa1603e0
.word 0xd28200c1
.word 0xaa1803e2
bl _p_167
bl _p_13
.loc 3 2701 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2240]
.word 0xaa1503e0
bl _p_20
.word 0x53001c00
.word 0x340001e0
.loc 3 2702 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2200]
.word 0x14000114

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2208]
.word 0x14000110
.loc 3 2704 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #2248]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #2256]
.word 0xaa1603e0
.word 0xaa1703e1
bl _p_149
.word 0x53001c00
.word 0x340000a0
.loc 3 2705 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #912]
.word 0x14000101
.loc 3 2707 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #2248]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #2264]
.word 0xaa1603e0
.word 0xaa1703e1
bl _p_149
.word 0x53001c00
.word 0x340000a0
.loc 3 2708 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2272]
.word 0x140000f2
.loc 3 2710 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940c850
.word 0xd63f0200
.word 0x53001c00
.word 0x34000c40
.loc 3 2711 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940b050
.word 0xd63f0200
.word 0x53001c00
.word 0x35000820
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940a850
.word 0xd63f0200
.word 0x53001c00
.word 0x35000740
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9404850
.word 0xd63f0200
.word 0x53001c00
.word 0x35000660
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940a450
.word 0xd63f0200
.word 0x53001c00
.word 0x34000580
.loc 3 2712 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2280]
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf90043a0
.word 0xf9003fa0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9404030
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94033a3
.word 0xf94037a4
.word 0xaa1603e0
.word 0xd2820a61
.word 0xaa1803e2
bl _p_229
bl _p_69
.loc 3 2713 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9404850
.word 0xd63f0200
.word 0x53001c00
.word 0xa1a0000
.word 0x340001e0
.loc 3 2714 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2288]
.word 0xf90033a0
.word 0xaa1603e0
.word 0xaa1703e1
bl _p_226
.word 0xaa0003e1
.word 0xf94033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #2296]
bl _p_30
.word 0x1400008e
.loc 3 2716 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1792]
.word 0x1400008a
.loc 3 2720 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940b450
.word 0xd63f0200
.word 0x53001c00
.word 0x340000a0
.loc 3 2721 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2136]
.word 0x1400007f
.loc 3 2723 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0x910123a2
.word 0xf94002c3
.word 0xf940bc70
.word 0xd63f0200
.word 0x53001c00
.word 0x340006e0
.loc 3 2724 0
.word 0x394123a0
.word 0x34000520
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x35000460
.loc 3 2725 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9409450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003fa
.word 0xaa1a03e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2080]
bl _p_20
.word 0x53001c00
.word 0x35000120

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2024]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x34000ba0
.word 0x14000005
.loc 3 2727 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2168]
.word 0x14000051
.loc 3 2729 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2176]
.word 0x1400004d
.loc 3 2734 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9409450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1603e0
.word 0xaa1803e2
.word 0xaa1903e3
.word 0xd2a00004
bl _p_225
.word 0x14000041
.loc 3 2738 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940c450
.word 0xd63f0200
.word 0x53001c00
.word 0x340000e0
.loc 3 2739 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xaa1803e2
.word 0xaa1903e3
bl _p_230
.word 0x14000034
.loc 3 2741 0
.word 0xaa1603e0
.word 0xaa1703e1
bl _p_231
.word 0x53001c00
.word 0x34000200
.loc 3 2742 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1603e0
.word 0xaa1803e2
.word 0xaa1903e3
.word 0xd2a00004
bl _p_225
.loc 3 2743 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1792]
.word 0x14000020
.loc 3 2746 0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf940a050
.word 0xd63f0200
.word 0x53001c00
.word 0x34000280
.loc 3 2747 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1968]
.word 0xf90033a0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1603e0
.word 0xaa1803e2
.word 0xaa1903e3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xf94033a0
bl _p_76
.word 0x14000006
.loc 3 2749 0
.word 0x3900033f
.loc 3 2750 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #712]
.word 0xf9400000
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.loc 3 2731 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2869001
bl _p_11
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1603e0
.word 0xaa1703e1
.word 0xf94002c2
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94033a2
.word 0xf94037a3
.word 0xaa1603e0
.word 0xd2820621
bl _p_168
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_f5:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ValueTypeSignature_System_Type_Registrar_Registrar_ObjCMember_bool_
Registrar_Registrar_ValueTypeSignature_System_Type_Registrar_Registrar_ObjCMember_bool_:
.loc 3 2761 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001fbf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xd2800601
bl _p_3
.word 0xf9003fa0
bl _p_156
.word 0xf9403fa0
.word 0xaa0003f6
.loc 3 2762 0
.word 0xaa1603e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2304]
.word 0xaa0203e0
.word 0x3940005e
bl _p_157
.loc 3 2763 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2312]
.word 0xf9003ba0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9405c50
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba1
.word 0xaa1603e0
.word 0x394002de
bl _p_232
.loc 3 2764 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9409050
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2320]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2328]
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9001fa0
.word 0x1400002a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2336]
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2344]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xaa0003f8
.loc 3 2765 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9412850
.word 0xd63f0200
.word 0x53001c00
.word 0x35000200
.loc 3 2768 0
.word 0xaa1703e0
.word 0xaa1803e1
.word 0xf94002e2
.word 0xf9408c50
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa1703e0
.word 0xaa1903e2
.word 0xaa1a03e3
.word 0xd2a00004
bl _p_225
.word 0xaa0003e1
.word 0xaa1603e0
.word 0x394002de
bl _p_157
.loc 3 2764 0
.word 0xf9401fa1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff9a0
.word 0xf90023bf
.word 0x94000005
.word 0xf94023a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90033be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401fa0
.word 0xb4000140
.word 0xf9401fa1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94033be
.word 0xd61f03c0
.loc 3 2771 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2352]
.word 0xaa1603e0
.word 0x394002de
bl _p_157
.loc 3 2772 0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9403030
.word 0xd63f0200
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_f6:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_LockRegistrar_bool_
Registrar_Registrar_LockRegistrar_bool_:
.loc 3 2777 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf9400c18
.word 0xf94017b9
.word 0xaa1803e0
.word 0xf94017a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1803e0
.word 0xaa1903e1
bl _p_21
.loc 3 2778 0
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_f7:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_UnlockRegistrar
Registrar_Registrar_UnlockRegistrar:
.loc 3 2782 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400c00
bl _p_24
.loc 3 2783 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_f8:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ReportError_int_string_object__
Registrar_Registrar_ReportError_int_string_object__:
.loc 3 2798 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf94017a1
bl _p_58
bl _p_59
.loc 3 2799 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_f9:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_IsCategory
Registrar_Registrar_ObjCType_get_IsCategory:
.loc 3 147 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401000
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_fa:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_VerifyRegisterAttribute_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_VerifyRegisterAttribute_System_Collections_Generic_List_1_System_Exception_:
.loc 3 207 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xaa0003f9
.word 0xf90023a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9004bbf
.word 0xf9400f20
.word 0xb40014e0
.loc 3 210 0
.word 0xf9400f20
.word 0xaa0003e1
.word 0x3940003e
.word 0xf9400818
.loc 3 211 0
.word 0xaa1803f7
.word 0xb40000b7
.word 0xb98012e0
.word 0x6b1f001f
.word 0x9a9f17f7
.word 0x14000002
.word 0xd2800037
.word 0x53001ee0
.word 0x35001340
.loc 3 214 0
.word 0xd2a00017
.word 0x14000095

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 215 0
.word 0x93407ee0
.word 0xb9801301
.word 0xeb00003f
.word 0x10000011
.word 0x54001269
.word 0xd37ff800
.word 0x8b180000
.word 0x79402800
bl _p_233
.word 0x53001c00
.word 0x34001060
.loc 3 224 0
.word 0xd2a00000
.word 0x53001c16
.loc 3 225 0
.word 0xaa1803e0
.word 0x3940031e
bl _p_234
.word 0xaa0003f5
.loc 3 226 0
.word 0xd2a00014
.word 0x14000016

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 227 0
.word 0x93407e80
.word 0xb98012a1
.word 0xeb00003f
.word 0x10000011
.word 0x54000f49
.word 0xd37ff800
.word 0x8b150000
.word 0x79402800
bl _p_233
.word 0x53001c00
.word 0x34000080
.loc 3 228 0
.word 0xd2800020
.word 0x53001c16
.loc 3 229 0
.word 0x14000005
.loc 3 226 0
.word 0x11000694
.word 0xb98012a0
.word 0x6b00029f
.word 0x54fffd2b
.loc 3 232 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2360]
.word 0xf9002fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf9004fa0
.word 0xf9004ba0
.word 0xf9400b22
.word 0xf9401721
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404ba0
.word 0xf90047a0
.word 0xf9003fa0
.word 0x93407ee0
.word 0xb9801301
.word 0xeb00003f
.word 0x10000011
.word 0x540009a9
.word 0xd37ff800
.word 0x8b180000
.word 0x79402800
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2368]
.word 0xd2800241
bl _p_3
.word 0xaa0003e2
.word 0xf94043a0
.word 0xf94047a3
.word 0x79002040
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0x93407ee0
.word 0xb9801301
.word 0xeb00003f
.word 0x10000011
.word 0x54000669
.word 0xd37ff800
.word 0x8b180000
.word 0x79402800
.word 0xb9004ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2376]
.word 0x910123a0
bl _p_235
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a3
.word 0xaa0303e0
.word 0xf90033a0
.word 0xaa0303e0
.word 0xd2800061
.word 0xaa1803e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2384]
.word 0xd2801301
bl _p_3
.word 0xf9402fa3
.word 0xf94033a4
.word 0xf9002ba0
.word 0xd2820641
.word 0xaa1603e2
bl _p_236
.word 0xf9402ba1
.word 0xf94023a0
bl _p_87
.loc 3 233 0
.word 0x14000005
.loc 3 214 0
.word 0x110006f7
.word 0xb9801300
.word 0x6b0002ff
.word 0x54ffed4b
.loc 3 235 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_fb:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_VerifySelector_Registrar_Registrar_ObjCMethod_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_VerifySelector_Registrar_Registrar_ObjCMethod_System_Collections_Generic_List_1_System_Exception_:
.loc 3 242 0 prologue_end
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xf90023a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9004bbf
.word 0xf9402320
.word 0xb4003320
.loc 3 245 0
.word 0x3940033e
.word 0xf9401b23
.word 0xaa0303e0
.word 0xd2800741
.word 0xd2a00002
.word 0x3940007e
bl _p_237
.word 0xaa0003e1
.word 0xb9801820
.loc 3 246 0
.word 0x51000417
.loc 3 248 0
.word 0x3940f320
.word 0x34000040
.loc 3 249 0
.word 0x110006f7
.loc 3 251 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_164
.word 0xaa0003f6
.loc 3 252 0
.word 0xaa1603e0
.word 0xb4000080
.word 0xb9801ac0
.word 0xaa0003f5
.word 0x14000002
.word 0xd2a00015
.word 0xaa1503f4
.loc 3 253 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_118
.word 0x53001c00
.word 0x34000040
.loc 3 254 0
.word 0x51000694
.loc 3 256 0
.word 0x6b1402ff
.word 0x54001860
.loc 3 259 0
.word 0x3940f320
.word 0x34000c00
.loc 3 260 0
.word 0xf9400b00
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2392]
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd28000a1
bl _p_42
.word 0xf90053a0
.word 0xf9004fa0
.word 0xf9402321
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94053a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_85
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2400]
.word 0xd2800281
bl _p_3
.word 0xaa0003e2
.word 0xf94043a3
.word 0xb9001057
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2400]
.word 0xd2800281
bl _p_3
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xb9001054
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a3
.word 0xaa0303e0
.word 0xf9002fa0
.word 0x3940033e
.word 0xf9401b22
.word 0xaa0303e0
.word 0xd2800081
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba3
.word 0xf9402fa4
.word 0xf94033a5
.word 0xaa0503e0
.word 0xd2820581
.word 0xaa1903e2
.word 0x394000be
bl _p_167
.word 0xaa0003f7
.word 0x1400005f
.loc 3 263 0
.word 0xf9400b00
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2408]
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd28000a1
bl _p_42
.word 0xf90053a0
.word 0xf9004fa0
.word 0xf9402321
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94053a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xaa1903e0
.word 0x3940033e
bl _p_85
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2400]
.word 0xd2800281
bl _p_3
.word 0xaa0003e2
.word 0xf94043a3
.word 0xb9001057
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2400]
.word 0xd2800281
bl _p_3
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xb9001054
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a3
.word 0xaa0303e0
.word 0xf9002fa0
.word 0x3940033e
.word 0xf9401b22
.word 0xaa0303e0
.word 0xd2800081
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba3
.word 0xf9402fa4
.word 0xf94033a5
.word 0xaa0503e0
.word 0xd28202a1
.word 0xaa1903e2
.word 0x394000be
bl _p_167
.word 0xaa0003f7
.loc 3 267 0
.word 0xf94023a0
.word 0xaa1703e1
bl _p_87
.loc 3 270 0
.word 0x3940f320
.word 0x34000760
.word 0xb4000756
.word 0xf9400b02
.word 0x51000680
.word 0x93407c00
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54001669
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2000]
bl _p_126
.word 0x53001c00
.word 0x340004a0
.loc 3 271 0
.word 0xf9400b00
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2416]
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90037a0
.word 0xf9002fa0
.word 0xf9400b02
.word 0xf9402321
.word 0xaa0203e0
.word 0x3940005e
bl _p_29
.word 0xaa0003e2
.word 0xf94037a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba3
.word 0xf9402fa4
.word 0xf94033a5
.word 0xaa0503e0
.word 0xd2820361
.word 0xaa1903e2
.word 0x394000be
bl _p_167
.word 0xaa0003e1
.word 0xf94023a0
bl _p_87
.loc 3 274 0
.word 0x3940033e
.word 0xf9401b22

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2424]
.word 0xf9400001
.word 0xaa0203e0
.word 0x3940005e
bl _p_238
.word 0x93407c00
.word 0xaa0003f7
.loc 3 275 0
.word 0xaa1703e0
.word 0x9280001e
.word 0x6b1e001f
.word 0x54000d80
.loc 3 276 0
.word 0x3940033e
.word 0xf9401b21
.word 0x93407ee0
.word 0xb9801022
.word 0xeb00005f
.word 0x10000011
.word 0x54000d69
.word 0xd37ff800
.word 0x8b010000
.word 0x79402800
.word 0xf90053a0
.word 0x53003c17
.loc 3 277 0
.word 0xf9400b00
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2432]
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd28000a1
bl _p_42
.word 0xf90057a0
.word 0xf9004fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2368]
.word 0xd2800241
bl _p_3
.word 0xaa0003e2
.word 0xf94053a0
.word 0xf94057a3
.word 0x79002040
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9404fa0
.word 0xf9004ba0
.word 0xf90047a0
.word 0xb9004bb7

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2376]
.word 0x910123a0
bl _p_235
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a3
.word 0xaa0303e0
.word 0xf90043a0
.word 0x3940033e
.word 0xf9401b22
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a0
.word 0xf9003fa0
.word 0xf9003ba0
.word 0xf9400b02
.word 0xf9401701
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403fa3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403ba0
.word 0xf90037a0
.word 0xf9002fa0
.word 0xf9400b02
.word 0xf9402321
.word 0xaa0203e0
.word 0x3940005e
bl _p_29
.word 0xaa0003e2
.word 0xf94037a3
.word 0xaa0303e0
.word 0xd2800081
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba3
.word 0xf9402fa4
.word 0xf94033a5
.word 0xaa0503e0
.word 0xd2820801
.word 0xaa1903e2
.word 0x394000be
bl _p_167
.word 0xaa0003e1
.word 0xf94023a0
bl _p_87
.loc 3 280 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_fc:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_VerifyAdoptedProtocolsNames_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_VerifyAdoptedProtocolsNames_System_Collections_Generic_List_1_System_Exception_:
.loc 3 284 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x790093bf
.word 0xf9402320
.word 0xb4000ec0
.loc 3 287 0
.word 0xf9402338
.word 0xd2a00017
.word 0x14000070

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000de9
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.loc 3 290 0
.word 0xaa1603e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2424]
.word 0xf9400001
.word 0xaa0203e0
.word 0x3940005e
bl _p_238
.word 0x93407c00
.word 0xaa0003f5
.loc 3 291 0
.word 0xaa1603f4
.loc 3 292 0
.word 0x9280001e
.word 0x6b1e02bf
.word 0x54000a40
.loc 3 293 0
.word 0x93407ea0
.word 0xb98012c1
.word 0xeb00003f
.word 0x10000011
.word 0x54000b09
.word 0xd37ff800
.word 0x8b160000
.word 0x79402800
.word 0x790093a0
.loc 3 294 0
.word 0x910123a0
bl _p_134
.word 0xaa0003f6
.loc 3 295 0
.word 0x794093a0
.word 0xd2800f7e
.word 0x6b1e001f
.word 0x540001a1
.loc 3 296 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x22, [x16, #2440]
.loc 3 297 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #2304]
.word 0xaa1403e0
.word 0xaa1503e1
.word 0x3940029e
bl _p_239
.word 0xaa0003f4
.word 0x14000010
.loc 3 298 0
.word 0x794093a0
.word 0xd2800fbe
.word 0x6b1e001f
.word 0x54000181
.loc 3 299 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x22, [x16, #2448]
.loc 3 300 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #2352]
.word 0xaa1403e0
.word 0xaa1503e1
.word 0x3940029e
bl _p_239
.word 0xaa0003f4
.loc 3 303 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2456]
.word 0xf90033a0
.word 0xf9400b22
.word 0xf9401721
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94033a0
.word 0xaa1403e2
.word 0xaa1603e3
bl _p_57
.word 0xaa0003f6
.loc 3 304 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1424]
.word 0xd2a00001
bl _p_42
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xf9002fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2384]
.word 0xd2801301
bl _p_3
.word 0xf9402fa4
.word 0xf9002ba0
.word 0xd2820a21
.word 0xd2800022
.word 0xaa1603e3
bl _p_236
.word 0xf9402ba1
.word 0xaa1a03e0
bl _p_87
.word 0x110006f7
.loc 3 287 0
.word 0xb9801b00
.word 0x6b0002ff
.word 0x54fff1eb
.loc 3 308 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_fd:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCField_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCField_System_Collections_Generic_List_1_System_Exception_:
.loc 3 313 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9001ba2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401b38
.loc 3 314 0
.word 0x3940035e
.word 0x39413b40
.word 0x53001c00
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x23, [x16, #2464]
.word 0x14000004

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x23, [x16, #2472]
.word 0xf9401341
.word 0xaa1703e0
bl _p_76
.word 0xaa0003f7
.word 0x14000016

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 316 0
.word 0xf9402700
.word 0xb4000140
.word 0xf9402700

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2480]
.word 0x3940001e
.word 0xaa1703e1
bl _p_240
.word 0x53001c00
.word 0x35000500
.loc 3 320 0
.word 0xf9401b00
.word 0xeb00031f
.word 0x54000060
.loc 3 322 0
.word 0xf9401b18
.loc 3 315 0
.word 0xb5fffd78
.loc 3 325 0
.word 0xf9402720
.word 0xb5000320
.loc 3 326 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2488]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2496]
.word 0xf90023a0
bl _p_241
.word 0x91012321
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 328 0
.word 0xf9402720

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2504]
.word 0x3940001e
.word 0xaa1703e1
.word 0xaa1a03e2
bl _p_242
.loc 3 329 0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_fe:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCMethod_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCMethod_System_Collections_Generic_List_1_System_Exception_:
.loc 3 335 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402b00
.word 0xb5000500
.loc 3 336 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2512]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2520]
.word 0xf9400021
.word 0xf90027a1
.word 0xf90023a0
.word 0x91004001
.word 0xd5033bbf
.word 0xf94027a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x91014301
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 338 0
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xaa1a03e2
bl _p_243
.loc 3 339 0
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0x3940033e
bl _p_210
.loc 3 342 0
.word 0xaa1903e0
.word 0x3940033e
bl _p_144
.word 0x53001c00
.word 0x35000140
.word 0xf9400f20
.word 0x3941c400
.word 0x350000e0
.loc 3 343 0
.word 0xf9400b03
.word 0xaa0303e0
.word 0xaa1a03e1
.word 0xaa1903e2
.word 0x3940007e
bl _p_244
.loc 3 345 0
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xaa1a03e2
bl _p_245
.word 0x53001c1a
.loc 3 346 0
.word 0xf9402b00
.word 0xaa0003f8
.word 0xaa1903f7
.word 0x3940031e
.word 0xb9801f01
.word 0x11000421
.word 0xb9001c01
.word 0xf9400b19
.word 0xb9801b16
.word 0xaa1603e0
.word 0xb9801b21
.word 0x6b01001f
.word 0x54000142
.word 0x110006c0
.word 0xb9001b00
.word 0xaa1903e0
.word 0xaa1603e1
.word 0xaa1703e2
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2528]
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_246
.loc 3 347 0
.word 0xaa1a03e0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_ff:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCProperty_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_Add_Registrar_Registrar_ObjCProperty_System_Collections_Generic_List_1_System_Exception_:
.loc 3 352 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xf90023a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402f00
.word 0xb5000500
.loc 3 353 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2536]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2544]
.word 0xf9400021
.word 0xf9002fa1
.word 0xf9002ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9402fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x91016301
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 355 0
.word 0xf9402f00
.word 0xaa0003f7
.word 0xaa1903f6
.word 0x394002fe
.word 0xb9801ee1
.word 0x11000421
.word 0xb9001c01
.word 0xf9400af5
.word 0xb9801af4
.word 0xaa1403e0
.word 0xb9801aa1
.word 0x6b01001f
.word 0x54000142
.word 0x11000680
.word 0xb9001ae0
.word 0xaa1503e0
.word 0xaa1403e1
.word 0xaa1603e2
.word 0xf94002a3
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2552]
.word 0xaa1703e0
.word 0xaa1603e1
bl _p_247
.loc 3 358 0
.word 0xf9400f20
.word 0x3941c400
.word 0x350000e0
.loc 3 359 0
.word 0xf9400b03
.word 0xaa0303e0
.word 0xf94023a1
.word 0xaa1903e2
.word 0x3940007e
bl _p_248
.loc 3 360 0
.word 0xaa1803e0
.word 0xf94023a1
.word 0xaa1903e2
bl _p_249
.loc 3 361 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_100:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_IsObjectiveCKeyword_string
Registrar_Registrar_ObjCType_IsObjectiveCKeyword_string:
.loc 3 0 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb400415a
.word 0xb9801359
.word 0xaa1903e0
.word 0x51000819
.word 0xd280013e
.word 0x6b1e033f
.word 0x54004082
.word 0xd37df320
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2560]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800020
.word 0xb9801341
.word 0xd280003e
.word 0xeb1e003f
.word 0x10000011
.word 0x54003f89
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800d1e
.word 0x6b1e001f
.word 0x54000108
.word 0xd2800c3e
.word 0x6b1e033f
.word 0x540017a0
.word 0xd2800d1e
.word 0x6b1e033f
.word 0x54001840
.word 0x140001e7
.word 0x5101b338
.word 0xd280009e
.word 0x6b1e031f
.word 0x54000122
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2568]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800ebe
.word 0x6b1e033f
.word 0x54001440
.word 0x140001d7
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x54003b09
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0x51017c18
.word 0xd28000be
.word 0x6b1e031f
.word 0x54000122
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2576]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800cde
.word 0x6b1e033f
.word 0x54001ac0
.word 0x5101cf38
.word 0xd28000be
.word 0x6b1e031f
.word 0x54003742
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2584]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800080
.word 0xb9801341
.word 0xd280009e
.word 0xeb1e003f
.word 0x10000011
.word 0x54003649
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800cfe
.word 0x6b1e001f
.word 0x54002080
.word 0xd2800d3e
.word 0x6b1e033f
.word 0x54001c20
.word 0x5101b338
.word 0xd280013e
.word 0x6b1e031f
.word 0x540033a2
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2592]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x540032c9
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800c9e
.word 0x6b1e001f
.word 0x54002000
.word 0xd2800e9e
.word 0x6b1e033f
.word 0x540020a0
.word 0x14000184
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x540030a9
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800c9e
.word 0x6b1e001f
.word 0x54001fe0
.word 0xd2800d3e
.word 0x6b1e033f
.word 0x54002080
.word 0x14000173
.word 0xd2800040
.word 0xb9801341
.word 0xd280005e
.word 0xeb1e003f
.word 0x10000011
.word 0x54002e69
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800d3e
.word 0x6b1e001f
.word 0x54000168
.word 0xd2800c3e
.word 0x6b1e033f
.word 0x54002620
.word 0xd2800cfe
.word 0x6b1e033f
.word 0x540023c0
.word 0xd2800d3e
.word 0x6b1e033f
.word 0x54002760
.word 0x1400015b
.word 0xd2800d9e
.word 0x6b1e033f
.word 0x540021e0
.word 0x5101c338
.word 0xd28000de
.word 0x6b1e031f
.word 0x54000122
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2600]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd2800f5e
.word 0x6b1e033f
.word 0x54002200
.word 0x14000148
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x54002929
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800cde
.word 0x6b1e001f
.word 0x54002440
.word 0xd2800d3e
.word 0x6b1e033f
.word 0x540024e0
.word 0x14000137

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2608]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350025c0
.word 0x1400012f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2616]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350024c0
.word 0x14000127

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2624]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350023c0
.word 0x1400011f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2632]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350022c0
.word 0x14000117

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2640]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350021c0
.word 0x1400010f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2648]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x350020c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2656]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001fe0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2664]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001f00
.word 0x140000f9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2672]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001e00
.word 0x140000f1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2680]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001d00
.word 0x140000e9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2688]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001c00
.word 0x140000e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2696]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001b00
.word 0x140000d9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2704]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001a00
.word 0x140000d1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2712]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001900
.word 0x140000c9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2720]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001800
.word 0x140000c1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2728]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001700
.word 0x140000b9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2736]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001600
.word 0x140000b1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2744]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001500
.word 0x140000a9

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2752]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001400
.word 0x140000a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2760]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001300
.word 0x14000099

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2768]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001200
.word 0x14000091

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2776]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001100
.word 0x14000089

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2784]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001000
.word 0x14000081

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2792]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000f00
.word 0x14000079

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2800]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000e00
.word 0x14000071

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2808]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000d00
.word 0x14000069

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2816]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000c00
.word 0x14000061

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2824]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000b00
.word 0x14000059

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2832]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000a00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2840]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000920
.word 0x1400004a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2848]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000820
.word 0x14000042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2856]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000720
.word 0x1400003a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2864]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000620
.word 0x14000032

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2872]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000520
.word 0x1400002a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2880]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000420
.word 0x14000022

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2888]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000320
.word 0x1400001a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2896]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000220
.word 0x14000012

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2904]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000120
.word 0x1400000a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2912]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 405 0
.word 0xd2800020
.word 0x14000002
.loc 3 407 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_101:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_VerifyIsNotKeyword_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCProperty
Registrar_Registrar_ObjCType_VerifyIsNotKeyword_System_Collections_Generic_List_1_System_Exception__Registrar_Registrar_ObjCProperty:
.loc 3 413 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xf90013a1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940035e
.word 0xf9401b40
bl _p_198
.word 0x53001c00
.word 0x340004c0
.loc 3 414 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2920]
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf90023a0
.word 0xf9401342
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a3
.word 0xaa0303e0
.word 0xf9001fa0
.word 0x3940035e
.word 0xf9401b42
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba3
.word 0xf9401fa4
.word 0xf9400fa0
.word 0xd2820881
.word 0xaa1a03e2
bl _p_250
.word 0xaa0003e1
.word 0xf94013a0
bl _p_87
.loc 3 415 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_102:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_TryGetMember_string_bool_Registrar_Registrar_ObjCMember_
Registrar_Registrar_ObjCType_TryGetMember_string_bool_Registrar_Registrar_ObjCMember_:
.loc 3 419 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xaa0103f8
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394083a0
.word 0x34000100
.loc 3 420 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2472]
.word 0xaa1803e1
bl _p_76
.word 0xaa0003f8
.word 0x14000007
.loc 3 422 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2464]
.word 0xaa1803e1
bl _p_76
.word 0xaa0003f8
.loc 3 423 0
.word 0xf9400fa0
.word 0xf9403000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2928]
.word 0x3940001e
.word 0xaa1803e1
.word 0xf94017a2
bl _p_251
.word 0x53001c00
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_103:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_AddToMap_Registrar_Registrar_ObjCMember_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCType_AddToMap_Registrar_Registrar_ObjCMember_System_Collections_Generic_List_1_System_Exception_:
.loc 3 429 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0xd2800020
.word 0x53001c17
.loc 3 430 0
.word 0x3940033e
.word 0xf9401b20
.word 0xf90023a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9403c30
.word 0xd63f0200
.word 0xf94023a1
.word 0x53001c02
.word 0xaa1803e0
.word 0x9100c3a3
bl _p_111
.word 0x53001c00
.word 0x34001200
.loc 3 431 0
.word 0xf9401ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9403830
.word 0xd63f0200
.word 0x53001c00
.word 0x340007a0
.loc 3 432 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2936]
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf90037a0
.word 0x3940033e
.word 0xf9401b22
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xf9400b02
.word 0xf9401701
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa0
.word 0xf9002ba0
.word 0xf90027a0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1903e1
.word 0x3940005e
bl _p_252
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a3
.word 0xf94027a4
.word 0xaa1803e0
.word 0xd28205a1
.word 0xaa1903e2
bl _p_250
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.word 0x1400004b
.loc 3 434 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2944]
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9003fa0
.word 0x3940033e
.word 0xf9401b22
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xf9400b02
.word 0xf9401701
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1903e1
.word 0x3940005e
bl _p_252
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa0
.word 0xf9002ba0
.word 0xf90027a0
.word 0xf9400b02
.word 0xf9401ba1
.word 0xaa0203e0
.word 0x3940005e
bl _p_252
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a3
.word 0xf94027a4
.word 0xaa1803e0
.word 0xd28202e1
.word 0xaa1903e2
bl _p_250
.word 0xaa0003e1
.word 0xaa1a03e0
bl _p_87
.loc 3 436 0
.word 0xd2a00000
.word 0x53001c17
.loc 3 439 0
.word 0xf9403300
.word 0xf90023a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9403c30
.word 0xd63f0200
.word 0xf94023a1
.word 0x53001c00
.word 0xaa0103fa
.word 0x350000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x24, [x16, #2464]
.word 0x14000004

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x24, [x16, #2472]
.word 0x3940033e
.word 0xf9401b21
.word 0xaa1803e0
bl _p_76
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2952]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1903e2
bl _p_253
.loc 3 440 0
.word 0xaa1703e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_104:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_CreateException_int_Registrar_Registrar_ObjCMember_string_object__
Registrar_Registrar_ObjCType_CreateException_int_Registrar_Registrar_ObjCMember_string_object__:
.loc 3 445 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xf9001bb8
.word 0xaa0003f6
.word 0xaa0103f7
.word 0xaa0203f8
.word 0xf9001fa3
.word 0xf90023a4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1803f5
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #856]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800015
.word 0xaa1503f4
.loc 3 446 0
.word 0xb4000155
.loc 3 447 0
.word 0xf9400ac5
.word 0xf9402282
.word 0xaa0503e0
.word 0xaa1703e1
.word 0xf9401fa3
.word 0xf94023a4
.word 0x394000be
bl _p_145
.word 0x14000034
.loc 3 448 0
.word 0xaa1803f5
.word 0xeb1f031f
.word 0x54000160
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1104]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800015
.word 0xaa1503f8
.loc 3 449 0
.word 0xb40003d5
.word 0xf9402300
.word 0xb4000380
.loc 3 450 0
.word 0xf9400ac0
.word 0xf9002ba0
.word 0xf9402301
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9407030
.word 0xd63f0200
.word 0xf9402ba2
.word 0xaa0003e1
.word 0xaa0203f6
.word 0xaa1703f5
.word 0xaa0103f7
.word 0xb50000e0
.word 0xf9402301
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9406830
.word 0xd63f0200
.word 0xaa0003f7
.word 0xaa1603e0
.word 0xaa1503e1
.word 0xaa1703e2
.word 0xf9401fa3
.word 0xf94023a4
.word 0x394002de
bl _p_145
.word 0x14000008
.loc 3 451 0
.word 0xf9400ac4
.word 0xaa0403e0
.word 0xaa1703e1
.word 0xf9401fa2
.word 0xf94023a3
.word 0x3940009e
bl _p_168
.word 0xa94157b4
.word 0xa9425fb6
.word 0xf9401bb8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_105:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_CategoryName
Registrar_Registrar_ObjCType_get_CategoryName:
.loc 3 460 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401340
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000280
.loc 3 462 0
.word 0xf9401341
.loc 3 463 0
.word 0xaa0103e0
.word 0x3940003e
bl _p_254
.word 0xaa0003f9
.word 0xb5000100
.word 0xf9400b42
.word 0xf9401741
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 464 0
.word 0xaa1903e0
bl _p_227
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.loc 3 461 0
.word 0xd2801340
.word 0xf2a04000
bl _mono_create_corlib_exception_0
bl _p_13

Lme_106:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_ProtocolName
Registrar_Registrar_ObjCType_get_ProtocolName:
.loc 3 470 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3941c740
.word 0x34000320
.loc 3 472 0
.word 0xf9400b42
.word 0xf9401741
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940ec50
.word 0xd63f0200
.word 0xaa0003e1
.word 0x3940003e
.word 0xf9400c00
.loc 3 473 0
.word 0xaa0003f9
.word 0xb5000100
.word 0xf9400b42
.word 0xf9401741
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003f9
.loc 3 474 0
.word 0xaa1903e0
bl _p_227
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.loc 3 471 0
.word 0xd2801340
.word 0xf2a04000
bl _mono_create_corlib_exception_0
bl _p_13

Lme_107:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_ExportedName
Registrar_Registrar_ObjCType_get_ExportedName:
.loc 3 480 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400803
.word 0xf9401401
.word 0xf9400c02
.word 0xaa0303e0
.word 0x3940007e
bl _p_228
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_108:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_IsFakeProtocol
Registrar_Registrar_ObjCType_get_IsFakeProtocol:
.loc 3 486 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400f40
.word 0xb40000a0
.word 0x3941c740
.word 0x35000060
.word 0x3941c340
.word 0x34000060
.loc 3 487 0
.word 0xd2a00000
.word 0x14000008
.loc 3 489 0
.word 0xf9400b42
.word 0xf9401741
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9403c50
.word 0xd63f0200
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_109:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType_get_SuperType
Registrar_Registrar_ObjCType_get_SuperType:
.loc 3 498 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9403740
.word 0xb4000060
.loc 3 499 0
.word 0xf9403740
.word 0x14000022
.loc 3 501 0
.word 0xf9401b59
.word 0x14000008

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 503 0
.word 0xf9401b39
.loc 3 502 0
.word 0xb4000119
.word 0x3941c320
.word 0x35fffee0
.word 0xaa1903e0
.word 0x3940033e
bl _p_89
.word 0x53001c00
.word 0x35fffe40
.loc 3 504 0
.word 0x9101a340
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 505 0
.word 0xf9403740
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_10a:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType__ctor
Registrar_Registrar_ObjCType__ctor:
.loc 3 143 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2960]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #2968]
.word 0xf90013a0
bl _p_255
.word 0xf9400ba0
.word 0x91018001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_10b:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCType__cctor
Registrar_Registrar_ObjCType__cctor:
.loc 3 239 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2976]
.word 0xd2800361
bl _p_42
.word 0xf9000fa0
.word 0x91008000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2984]
.word 0xd28006c2
bl _p_256
.word 0xf9400fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2424]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10c:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember_SetExportAttribute_Foundation_ExportAttribute_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCMember_SetExportAttribute_Foundation_ExportAttribute_System_Collections_Generic_List_1_System_Exception_:
.loc 3 521 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xf90013b9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940033e
.word 0xf9400b37
.word 0xb40000b7
.word 0xb98012e0
.word 0x6b1f001f
.word 0x9a9f17f7
.word 0x14000002
.word 0xd2800037
.word 0x53001ee0
.word 0x340004c0
.loc 3 522 0
.word 0xf9400b00
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #2992]
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90027a0
.word 0xf9001fa0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9404030
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94027a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba3
.word 0xf9401fa4
.word 0xf94023a5
.word 0xaa0503e0
.word 0xd28204e1
.word 0xaa1803e2
.word 0x394000be
bl _p_167
.word 0xaa0003e1
.word 0xf94017a0
bl _p_87
.loc 3 523 0
.word 0xd2a00000
.word 0x1400000c
.loc 3 525 0
.word 0x3940033e
.word 0xf9400b21
.word 0xaa1803e0
bl _p_201
.loc 3 526 0
.word 0x3940033e
.word 0xb9801b20
.word 0xb9003b00
.loc 3 527 0
.word 0x3940033e
.word 0x39407320
.word 0x3900f300
.loc 3 528 0
.word 0xd2800020
.word 0xa94163b7
.word 0xf94013b9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_10d:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember__ctor
Registrar_Registrar_ObjCMember__ctor:
.loc 3 515 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x9280001e
.word 0xb900381e
.loc 3 533 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10e:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember__ctor_Registrar_Registrar_Registrar_Registrar_ObjCType
Registrar_Registrar_ObjCMember__ctor_Registrar_Registrar_Registrar_Registrar_ObjCType:
.loc 3 515 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0x9280001e
.word 0xb900381e
.loc 3 537 0
.word 0xf9001ba0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 3 538 0
.word 0x91006001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 539 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_10f:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember_get_Selector
Registrar_Registrar_ObjCMember_get_Selector:
.loc 3 543 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_110:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember_set_Selector_string
Registrar_Registrar_ObjCMember_set_Selector_string:
.loc 3 545 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xaa0003f9
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013b8
.word 0xb40000b8
.word 0xb9801300
.word 0x6b1f001f
.word 0x9a9f17f8
.word 0x14000002
.word 0xd2800038
.word 0x53001f00
.word 0x35000260
.loc 3 547 0
.word 0x9100c321
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 548 0
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.loc 3 546 0
.word 0xf9400b20
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2880f81
bl _p_11
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90027a0
.word 0xf9001fa0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9404030
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94027a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba3
.word 0xf9401fa4
.word 0xf94023a5
.word 0xaa0503e0
.word 0xd28204e1
.word 0xaa1903e2
.word 0x394000be
bl _p_167
bl _p_13

Lme_111:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMember_get_IsImplicit
Registrar_Registrar_ObjCMember_get_IsImplicit:
.loc 3 553 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_114:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod__ctor_Registrar_Registrar_Registrar_Registrar_ObjCType_System_Reflection_MethodBase
Registrar_Registrar_ObjCMethod__ctor_Registrar_Registrar_Registrar_Registrar_ObjCType_System_Reflection_MethodBase:
.loc 3 573 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_257
.loc 3 575 0
.word 0xf9400ba0
.word 0x91010001
.word 0xd5033bbf
.word 0xf94017a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 576 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_115:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_MethodName
Registrar_Registrar_ObjCMethod_get_MethodName:
.loc 3 580 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9401000
.word 0xaa0003f9
.word 0xb5000120
.word 0xf9400fa0
.word 0xf9400802
.word 0xf9402001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_116:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsImplicit
Registrar_Registrar_ObjCMethod_get_IsImplicit:
.loc 3 586 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0
.word 0xf9400fa0
.word 0xf9402000
.word 0xb4000060
.loc 3 587 0
.word 0xd2a00000
.word 0x1400000f
.loc 3 589 0
.word 0xf9400fa0
.word 0xb9807019
.word 0xaa1903e0
.word 0x51001400
.word 0xd280003e
.word 0x6b1e001f
.word 0x540000a9
.word 0x51004b20
.word 0xd280007e
.word 0x6b1e001f
.word 0x54000068
.loc 3 596 0
.word 0xd2800020
.word 0x14000002
.loc 3 598 0
.word 0xd2a00000
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_117:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsConstructor
Registrar_Registrar_ObjCMethod_get_IsConstructor:
.loc 3 605 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xeb1f035f
.word 0x10000011
.word 0x54000500
.word 0x3941db40
.word 0x53001c00
.word 0x35000300
.loc 3 606 0
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9411850
.word 0xd63f0200
.word 0x390083bf
.word 0x390087bf
.word 0x390087a0
.word 0xd280003e
.word 0x390083be
.word 0x398083a0
.word 0x390063a0
.word 0x398087a0
.word 0x390067a0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000260
.word 0x9101db40
.word 0x398063a1
.word 0x39000001
.word 0x398067a1
.word 0x39000401
.loc 3 607 0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000160
.word 0x9101db40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3000]
bl _p_258
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_118:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_IsConstructor_bool
Registrar_Registrar_ObjCMethod_set_IsConstructor_bool:
.loc 3 610 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x3900a3bf
.word 0x3900a7bf
.word 0x394063a0
.word 0x3900a7a0
.word 0xd280003e
.word 0x3900a3be
.word 0x3980a3a0
.word 0x390083a0
.word 0x3980a7a0
.word 0x390087a0
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000120
.word 0x9101d800
.word 0x398083a1
.word 0x39000001
.word 0x398087a1
.word 0x39000401
.loc 3 611 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_119:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsInstanceCategory
Registrar_Registrar_ObjCMethod_get_IsInstanceCategory:
.loc 3 625 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9402000
bl _p_45
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_11a:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_WriteUnmanagedDescription_intptr
Registrar_Registrar_ObjCMethod_WriteUnmanagedDescription_intptr:
.loc 3 631 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9402018
.word 0xb4000178
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3008]
.word 0xeb01001f
.word 0x10000011
.word 0x54000121
.word 0xf9400fa0
.word 0xf94013a1
.word 0xaa1803e2
bl _p_107
.loc 3 632 0
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_11b:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_WriteUnmanagedDescription_intptr_System_Reflection_MethodBase
Registrar_Registrar_ObjCMethod_WriteUnmanagedDescription_intptr_System_Reflection_MethodBase:
.loc 3 636 0 prologue_end
.word 0xa9a77bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9009ba0
.word 0xf9009fa0
.word 0xf900a3a0
.word 0xf900a7a0
.word 0xf900aba0
.word 0xb9803b17
.loc 3 637 0
.word 0xaa1a03f6
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800016
.word 0xaa1603f5
.loc 3 638 0
.word 0xb4000336
.word 0xaa1503e0
.word 0xf94002a1
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9409c30
.word 0xd63f0200
.word 0xaa0003e3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3016]
.word 0xaa0303e0
.word 0xd2a00002
.word 0xf9400063

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3024]
.word 0x928002f0
.word 0xf8706870
.word 0xd63f0200
.word 0x53001c16
.word 0x14000002
.word 0xd2a00016
.loc 3 639 0
.word 0xb40000b5
.word 0xaa1503e0
bl _p_45
.word 0x53001c15
.word 0x14000002
.word 0xd2a00015
.word 0x53001eb4
.loc 3 642 0
.word 0x9280001e
.word 0x6b1e02ff
.word 0x54000041
.loc 3 643 0
.word 0xd2a00017
.loc 3 645 0
.word 0x34000076
.loc 3 646 0
.word 0xd280801e
.word 0x2a1e02f7
.loc 3 647 0
.word 0x34000074
.loc 3 648 0
.word 0xd281001e
.word 0x2a1e02f7
.loc 3 650 0
.word 0x91002320
.word 0x91001000
bl _p_259
.word 0x93407c00
.word 0xaa0003f6
.loc 3 651 0
.word 0xaa1603e0
.word 0xf900c3a0
.word 0xaa1803e0
bl _p_164
.word 0xaa0003e2
.word 0xf940c3a0
.word 0xb9801841
.word 0x11000421
.word 0x6b01001f
.word 0x540033ab
.word 0x1400013b
.word 0xaa1503f4
.word 0xeb1f02ff
.word 0x10000011
.word 0x54003580
.word 0x910042e0
.word 0xb98022e1
.word 0xaa0003f3
.word 0xb9015ba1
.word 0xb9800801
.word 0xb9815ba0
.word 0x6b01001f
.word 0x54003408
.word 0xf9400260
.word 0xb9815ba2
.word 0x2a0203e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800a60
.word 0x4b020000
.word 0xd2800002
.word 0xf90093a2
.word 0xf90097a2
.word 0xf90093a1
.word 0xb9012ba0
.word 0xf94093a0
.word 0xf90043a0
.word 0xf94097a0
.word 0xf90047a0
.word 0xaa1403f3
.word 0xf94043a0
.word 0xf9008ba0
.word 0xf94047a0
.word 0xf9008fa0
.word 0x3940029e
.word 0xd2a00000
.word 0x53001c14
.word 0xb9801260
.word 0xb9811ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9408ba0
.word 0xeb1f027f
.word 0x10000011
.word 0x54003080
.word 0x91005261
.word 0xb9801262
.word 0x2a0203e2
.word 0xf90087bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c14
.word 0x53001e80
.word 0x340000c0
.word 0xb98022e0
.word 0xb98012a1
.word 0xb010000
.word 0xb90022e0
.word 0x14000004
.word 0xaa1703e0
.word 0xaa1503e1
bl _p_261
.loc 3 652 0
.word 0xf9402b01
.word 0xb9801820
.word 0x11000401

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3032]
.word 0x9104c3a0
bl _p_262

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3040]
.word 0x9104c3b8
.word 0xaa0003f7
.word 0xaa0003f5
.word 0xeb1f031f
.word 0x10000011
.word 0x54002c20
.word 0x91004301
.word 0xb98153a0
.word 0xaa0103f4
.word 0xaa0003f3
.word 0xb9800821
.word 0x6b01001f
.word 0x54002a68
.word 0xf9400280
.word 0x2a1303e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800a80
.word 0x4b130000
.word 0xd2800002
.word 0xf9007fa2
.word 0xf90083a2
.word 0xf9007fa1
.word 0xb90103a0
.word 0xf9407fa0
.word 0xf9003ba0
.word 0xf94083a0
.word 0xf9003fa0
.word 0xaa1503f4
.word 0xf9403ba0
.word 0xf90077a0
.word 0xf9403fa0
.word 0xf9007ba0
.word 0x394002be
.word 0xd2a00000
.word 0x53001c15
.word 0xb9801280
.word 0xb980f3a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94077a0
.word 0xeb1f029f
.word 0x10000011
.word 0x54002760
.word 0x91005281
.word 0xb9801282
.word 0x2a0203e2
.word 0xf90073bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c15
.word 0x53001ea0
.word 0x340000c0
.word 0xb9802300
.word 0xb98012e1
.word 0xb010000
.word 0xb9002300
.word 0x14000004
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3032]
.word 0x9104c3a0
.word 0xaa1603e1
bl _p_262

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3048]
.word 0x9104c3b8
.word 0xaa0003f7
.word 0xaa0003f6
.word 0xeb1f031f
.word 0x10000011
.word 0x54002340
.word 0x91004301
.word 0xb98153a0
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb9800821
.word 0x6b01001f
.word 0x540021a8
.word 0xf94002a0
.word 0x2a1403e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800aa0
.word 0x4b140000
.word 0xd2800002
.word 0xf9006ba2
.word 0xf9006fa2
.word 0xf9006ba1
.word 0xb900dba0
.word 0xf9406ba0
.word 0xf90033a0
.word 0xf9406fa0
.word 0xf90037a0
.word 0xaa1603f5
.word 0xf94033a0
.word 0xf90063a0
.word 0xf94037a0
.word 0xf90067a0
.word 0x394002de
.word 0xd2a00000
.word 0x53001c16
.word 0xb98012a0
.word 0xb980cba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94063a0
.word 0xeb1f02bf
.word 0x10000011
.word 0x54001e80
.word 0x910052a1
.word 0xb98012a2
.word 0x2a0203e2
.word 0xf9005fbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c16
.word 0x53001ec0
.word 0x340000c0
.word 0xb9802300
.word 0xb98012e1
.word 0xb010000
.word 0xb9002300
.word 0x14000004
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_261
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xf900c3a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0xf900c7a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf940c3a0
.word 0xf940c7a1
bl _p_30
.word 0xaa0003e1
.word 0x9104c3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3056]
.word 0x9104c3ba
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f035f
.word 0x10000011
.word 0x54001800
.word 0x91004341
.word 0xb98153a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x54001688
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf90057a2
.word 0xf9005ba2
.word 0xf90057a1
.word 0xb900b3a0
.word 0xf94057a0
.word 0xf9002ba0
.word 0xf9405ba0
.word 0xf9002fa0
.word 0xaa1703f6
.word 0xf9402ba0
.word 0xf9004fa0
.word 0xf9402fa0
.word 0xf90053a0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb980a3a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9404fa0
.word 0xeb1f02df
.word 0x10000011
.word 0x54001340
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf9004bbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802340
.word 0xb9801301
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_261
.word 0x14000001
.word 0x9104c3a0
bl _p_264
.word 0xf900c3a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #496]
.word 0x3980d410
.word 0xb5000050
bl _p_31
.word 0xf940c3a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #504]
.word 0xf9400002
.word 0xaa1903e0
bl _p_32
bl _p_13
.loc 3 654 0
.word 0xaa1a03e0
bl _p_105
.word 0xaa0003e1
.word 0xaa1903e0
bl _p_265
.loc 3 655 0
.word 0x91002320
.word 0xaa1703e1
bl _p_266
.loc 3 657 0
.word 0xaa1803e0
bl _p_161
.word 0x53001c00
.word 0x35000280
.word 0xaa1803e0
bl _p_170
.word 0xf900c3a0
.word 0xaa1803e0
bl _p_162
.word 0xaa0003e1
.word 0xf940c3a0
bl _p_33
.word 0x53001c00
.word 0x34000140
.loc 3 658 0
.word 0x91002320
.word 0x91002000
.word 0xf900c3a0
.word 0xaa1803e0
bl _p_162
bl _p_105
.word 0xaa0003e1
.word 0xf940c3a0
bl _p_265
.loc 3 659 0
.word 0xd2a0001a
.word 0x14000034

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 660 0
.word 0xf9402b00
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540008c9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400000
.word 0xf9402f01
.word 0x93407f42
.word 0xb9801823
.word 0xeb02007f
.word 0x10000011
.word 0x54000789
.word 0xd37df042
.word 0x8b020021
.word 0x91008021
.word 0xf9400021
bl _p_48
.word 0x53001c00
.word 0x350002c0
.loc 3 662 0
.word 0x91002320
.word 0x91002000
.word 0x11000741
.word 0x531d7021
.word 0x93407c21
.word 0x8b010000
.word 0xf900c3a0
.word 0xf9402f00
.word 0x93407f41
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000509
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400000
bl _p_105
.word 0xaa0003e1
.word 0xf940c3a0
bl _p_265
.loc 3 659 0
.word 0x1100075a
.word 0xaa1803e0
bl _p_223
.word 0xaa0003e1
.word 0xb9801820
.word 0x6b00035f
.word 0x54fff90b
.loc 3 664 0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8d97bfd
.word 0xd65f03c0
.loc 3 652 0
.word 0xd283ea59
.word 0x9104c3a0
.word 0xd28017e1
.word 0xd2800062
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28824e1
bl _p_11
.word 0x9104c3b7
.word 0xaa0003f5
.word 0x17fffe59
bl _p_268
bl _p_268
bl _p_268
bl _p_268
.word 0xd2801260
.word 0xaa1103e1
bl _p_9
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_11c:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_HasParameters
Registrar_Registrar_ObjCMethod_get_HasParameters:
.loc 3 669 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402800
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_11d:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_Parameters
Registrar_Registrar_ObjCMethod_get_Parameters:
.loc 3 675 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402b40
.word 0xb50002c0
.loc 3 676 0
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9414850
.word 0xd63f0200
.word 0xf90013a0
.word 0x91014341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 677 0
.word 0xf9402b40
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_11e:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_Parameters_System_Type__
Registrar_Registrar_ObjCMethod_set_Parameters_System_Type__:
.loc 3 680 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf90013a0
.word 0x91014002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 3 681 0
.word 0xf9002c1f
.loc 3 682 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_11f:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_NativeParameters
Registrar_Registrar_ObjCMethod_get_NativeParameters:
.loc 3 687 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402f40
.word 0xb5000b20
.word 0xaa1a03e0
bl _p_164
.word 0xb4000ac0
.loc 3 690 0
.word 0xf9402b40
.word 0xb9801801

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
bl _p_42
.word 0xaa0003f9
.loc 3 691 0
.word 0xd2a00018
.word 0x1400003a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 692 0
.word 0xf9400b43
.word 0xaa0303e0
.word 0xaa1a03e1
.word 0xaa1803e2
.word 0x3940007e
bl _p_269
.word 0xaa0003f7
.word 0xb5000060
.word 0xd2800017
.word 0x14000002
.word 0xf9400ef7
.word 0xaa1703f6
.loc 3 693 0
.word 0xb40002f7
.loc 3 694 0
.word 0xf9402b40
.word 0x93407f01
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x540012c9
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400002
.word 0xaa1a03e0
.word 0xaa1603e1
bl _p_270
.word 0x53001c00
.word 0x34000640
.loc 3 696 0
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xaa1603e2
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.word 0x14000010
.loc 3 698 0
.word 0xf9402b40
.word 0x93407f01
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54001009
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400002
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.loc 3 691 0
.word 0x11000718
.word 0xf9402b41
.word 0xb9801820
.word 0x6b00031f
.word 0x54fff88b
.loc 3 701 0
.word 0x91016340
.word 0xf90023a0
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.loc 3 703 0
.word 0xf9402f40
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.loc 3 695 0
.word 0xf9400b40
.word 0xf9002fa0
.word 0xf9402340
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28855e1
bl _p_11
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf9004ba0
.word 0xf90047a0
.word 0xf9400b42
.word 0xf9402b40
.word 0x93407f01
.word 0xb9801803
.word 0xeb01007f
.word 0x10000011
.word 0x54000889
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xf9400b43
.word 0xf9402341
.word 0xaa0303e0
.word 0xaa1803e2
.word 0xf9400063
.word 0xf9414470
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002ba0
.word 0xaa1a03e0
bl _p_108
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a2
.word 0xf94027a3
.word 0xf9402ba4
.word 0xf9402fa5
.word 0xaa0503e0
.word 0xd2820981
.word 0x394000be
bl _p_145
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_120:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_IsValidToManagedTypeConversion_System_Type_System_Type
Registrar_Registrar_ObjCMethod_IsValidToManagedTypeConversion_System_Type_System_Type:
.loc 3 709 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb90043bf
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf940cc50
.word 0xd63f0200
.word 0xaa0003f7
.loc 3 710 0
.word 0xaa1703e0
.word 0xeb1f001f
.word 0x9a9f97e0
.word 0xf9003ba0
.loc 3 711 0
.word 0xb90043bf
.loc 3 712 0
.word 0xf9400b03
.word 0xaa0303e0
.word 0xaa1a03e1
.word 0x910103a2
.word 0xf9400063
.word 0xf940c070
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9403ba0
.word 0x53001c21
.word 0x390123a1
.loc 3 714 0
.word 0xaa1a03f5
.loc 3 715 0
.word 0xaa1903f4
.loc 3 716 0
.word 0x34000060
.loc 3 717 0
.word 0xaa1703f5
.word 0x14000020
.loc 3 718 0
.word 0x394123a0
.word 0x340003c0
.loc 3 719 0
.word 0xb98043a0
.word 0xd280003e
.word 0x6b1e001f
.word 0x54000060
.loc 3 720 0
.word 0xd2a00000
.word 0x14000256
.loc 3 721 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1903e1
.word 0x3940005e
bl _p_231
.word 0x53001c00
.word 0x35000060
.loc 3 722 0
.word 0xd2a00000
.word 0x1400024d
.loc 3 723 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf9400042
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003f5
.loc 3 724 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1903e1
.word 0xf9400042
.word 0xf9411450
.word 0xd63f0200
.word 0xaa0003f4
.loc 3 726 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1503e1
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003fa
.loc 3 728 0
.word 0xf9400b04

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #3064]
.word 0xaa0403e0
.word 0xaa1403e1
.word 0x3940009e
bl _p_149
.word 0x53001c00
.word 0x34001f40
.word 0xb4001d3a
.word 0xb9801359
.word 0xaa1903e0
.word 0x51002c19
.word 0xd280009e
.word 0x6b1e033f
.word 0x54001c62
.word 0xd37df320
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3072]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd28000e0
.word 0xb9801341
.word 0xd28000fe
.word 0xeb1e003f
.word 0x10000011
.word 0x54004389
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280085e
.word 0x6b1e001f
.word 0x54000aa0
.word 0xd2800dde
.word 0x6b1e033f
.word 0x54000b40
.word 0x140000c9
.word 0xd2800140
.word 0xb9801341
.word 0xd280015e
.word 0xeb1e003f
.word 0x10000011
.word 0x54004149
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280067e
.word 0x6b1e001f
.word 0x54000108
.word 0xd280063e
.word 0x6b1e033f
.word 0x54000b00
.word 0xd280067e
.word 0x6b1e033f
.word 0x54000ba0
.word 0x140000b4
.word 0xd28006de
.word 0x6b1e033f
.word 0x54000c20
.word 0xd2800dde
.word 0x6b1e033f
.word 0x54000cc0
.word 0xd2800e9e
.word 0x6b1e033f
.word 0x54000860
.word 0x140000aa
.word 0xd2800160
.word 0xb9801341
.word 0xd280017e
.word 0xeb1e003f
.word 0x10000011
.word 0x54003d69
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280067e
.word 0x6b1e001f
.word 0x54000108
.word 0xd280063e
.word 0x6b1e033f
.word 0x54000b20
.word 0xd280067e
.word 0x6b1e033f
.word 0x54000bc0
.word 0x14000095
.word 0xd28006de
.word 0x6b1e033f
.word 0x54000c40
.word 0xd2800d9e
.word 0x6b1e033f
.word 0x54000de0
.word 0xd2800e9e
.word 0x6b1e033f
.word 0x54000c80
.word 0x1400008b
.word 0xd28000e0
.word 0xb9801341
.word 0xd28000fe
.word 0xeb1e003f
.word 0x10000011
.word 0x54003989
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280085e
.word 0x6b1e001f
.word 0x54000e80
.word 0xd2800abe
.word 0x6b1e033f
.word 0x54000d20
.word 0x14000079

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2096]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000e00
.word 0x14000071

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2120]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000d00
.word 0x14000069

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2056]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000c00
.word 0x14000061

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2064]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000b00
.word 0x14000059

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2072]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000a00
.word 0x14000051

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2080]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000900
.word 0x14000049

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2088]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000800
.word 0x14000041

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2008]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000700
.word 0x14000039

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2016]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000600
.word 0x14000031

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2024]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000500
.word 0x14000029

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2000]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000400
.word 0x14000021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2032]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000300

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2040]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000220
.word 0x14000012

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1984]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000120
.word 0x1400000a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1992]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 745 0
.word 0xd2800020
.word 0x14000142
.loc 3 747 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #2240]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 748 0
.word 0xd2800020
.word 0x14000139
.loc 3 749 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1503e1
.word 0x3940005e
bl _p_148
.word 0x53001c00
.word 0x14000132
.loc 3 751 0
.word 0xf9400b04

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #3080]
.word 0xaa0403e0
.word 0xaa1403e1
.word 0x3940009e
bl _p_149
.word 0x53001c00
.word 0x34002200
.word 0xb40021ba
.word 0xb9801359
.word 0xaa1903e0
.word 0x51003818
.word 0xd280023e
.word 0x6b1e031f
.word 0x54000122
.word 0xd37df300
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3088]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0xd280047e
.word 0x6b1e033f
.word 0x54001760
.word 0x140000fb
.word 0xd2800080
.word 0xb9801341
.word 0xd280009e
.word 0xeb1e003f
.word 0x10000011
.word 0x54002249
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280083e
.word 0x6b1e001f
.word 0x54000aa0
.word 0xd28009be
.word 0x6b1e033f
.word 0x54000b40
.word 0x140000e9
.word 0xd28001e0
.word 0xb9801341
.word 0xd28001fe
.word 0xeb1e003f
.word 0x10000011
.word 0x54002009
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800a7e
.word 0x6b1e001f
.word 0x54000108
.word 0xd2800a5e
.word 0x6b1e033f
.word 0x54000c00
.word 0xd2800a7e
.word 0x6b1e033f
.word 0x54000ca0
.word 0x140000d4
.word 0xd2800e5e
.word 0x6b1e033f
.word 0x54000d20
.word 0xd2800e9e
.word 0x6b1e033f
.word 0x54000dc0
.word 0x140000cd
.word 0xd2800080
.word 0xb9801341
.word 0xd280009e
.word 0xeb1e003f
.word 0x10000011
.word 0x54001c89
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd28008fe
.word 0x6b1e001f
.word 0x54000dc0
.word 0xd28009be
.word 0x6b1e033f
.word 0x54000e60
.word 0x140000bb
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x54001a69
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd280087e
.word 0x6b1e001f
.word 0x54000fa0
.word 0xd28009be
.word 0x6b1e033f
.word 0x54001040
.word 0x140000aa
.word 0xd2800000
.word 0xb9801341
.word 0xeb1f003f
.word 0x10000011
.word 0x54001849
.word 0xd37ff800
.word 0x8b1a0000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd28008de
.word 0x6b1e001f
.word 0x54000f80
.word 0xd2800abe
.word 0x6b1e033f
.word 0x54001020
.word 0x14000099

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3096]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001200
.word 0x14000091

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3104]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001100
.word 0x14000089

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3112]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35001000
.word 0x14000081

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3120]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000f00
.word 0x14000079

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3128]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000e00
.word 0x14000071

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3136]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000d00
.word 0x14000069

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3144]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000c00
.word 0x14000061

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3152]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000b00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3160]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000a20
.word 0x14000052

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3168]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000920
.word 0x1400004a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3176]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000820
.word 0x14000042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3184]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000720
.word 0x1400003a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3192]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000620
.word 0x14000032

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3200]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000520
.word 0x1400002a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3208]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000420
.word 0x14000022

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3216]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000320
.word 0x1400001a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3224]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000220
.word 0x14000012

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3232]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x35000120
.word 0x1400000a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3240]
.word 0xaa1a03e0
bl _p_20
.word 0x53001c00
.word 0x34000060
.loc 3 772 0
.word 0xd2800020
.word 0x14000018
.loc 3 774 0
.word 0xd2a00000
.word 0x14000016
.loc 3 776 0
.word 0xf9400b04

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1056]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #1064]
.word 0xaa0403e0
.word 0xaa1403e1
.word 0x3940009e
bl _p_149
.word 0x53001c00
.word 0x34000100
.loc 3 777 0
.word 0xf9400b02
.word 0xaa0203e0
.word 0xaa1503e1
.word 0x3940005e
bl _p_271
.word 0x53001c00
.word 0x14000002
.loc 3 779 0
.word 0xd2a00000
.word 0xa94157b4
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_121:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_HasReturnType
Registrar_Registrar_ObjCMethod_get_HasReturnType:
.loc 3 790 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9403000
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_122:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_ReturnType
Registrar_Registrar_ObjCMethod_get_ReturnType:
.loc 3 796 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9403340
.word 0xb50002c0
.loc 3 797 0
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9411050
.word 0xd63f0200
.word 0xf90013a0
.word 0x91018341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 798 0
.word 0xf9403340
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_123:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_ReturnType_System_Type
Registrar_Registrar_ObjCMethod_set_ReturnType_System_Type:
.loc 3 801 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf90013a0
.word 0x91018002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 3 802 0
.word 0xf900341f
.loc 3 803 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_124:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_NativeReturnType
Registrar_Registrar_ObjCMethod_get_NativeReturnType:
.loc 3 808 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9403740
.word 0xb5000b40
.loc 3 809 0
.word 0xf9400b40
.word 0xf9001ba0
.word 0xaa1a03e0
bl _p_170
.word 0xaa0003e1
.word 0xf9401ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #3248]

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #3256]
.word 0xaa0403e0
.word 0x3940009e
bl _p_149
.word 0x53001c00
.word 0x34000260
.loc 3 810 0
.word 0xaa1a03e0
bl _p_170
.word 0xf9001ba0
.word 0x9101a341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x14000037
.loc 3 812 0
.word 0xf9400b43
.word 0xaa0303e0
.word 0xaa1a03e1
.word 0x92800002
.word 0x3940007e
bl _p_269
.word 0xaa0003f9
.word 0xb5000060
.word 0xd2800019
.word 0x14000002
.word 0xf9400f39
.word 0xaa1903f8
.loc 3 813 0
.word 0xb4000339
.loc 3 814 0
.word 0xaa1a03e0
bl _p_170
.word 0xaa0003e2
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_270
.word 0x53001c00
.word 0x34000500
.loc 3 816 0
.word 0x9101a340
.word 0xf9001ba0
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000018
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0x14000012
.loc 3 818 0
.word 0xaa1a03e0
bl _p_170
.word 0xf9001ba0
.word 0x9101a341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 822 0
.word 0xf9403740
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.loc 3 815 0
.word 0xf9400b40
.word 0xf90027a0
.word 0xf9402340
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd288e101
bl _p_11
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf9003ba0
.word 0xf90037a0
.word 0xf9400b40
.word 0xf9003fa0
.word 0xaa1a03e0
bl _p_170
.word 0xaa0003e1
.word 0xf9403fa2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa0
.word 0xf9002ba0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_108
.word 0xaa0003e2
.word 0xf9402ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba2
.word 0xf9401fa3
.word 0xf94023a4
.word 0xf94027a5
.word 0xaa0503e0
.word 0xd2820941
.word 0x394000be
bl _p_145
bl _p_13

Lme_125:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsStatic
Registrar_Registrar_ObjCMethod_get_IsStatic:
.loc 3 828 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xeb1f035f
.word 0x10000011
.word 0x54000320
.word 0x3941d340
.word 0x53001c00
.word 0x35000120
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412450
.word 0xd63f0200
.word 0x53001c00
.word 0x1400000a
.word 0xeb1f035f
.word 0x10000011
.word 0x54000160
.word 0x9101d340

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3000]
bl _p_258
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_126:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_IsStatic_bool
Registrar_Registrar_ObjCMethod_set_IsStatic_bool:
.loc 3 829 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x3900a3bf
.word 0x3900a7bf
.word 0x394063a0
.word 0x3900a7a0
.word 0xd280003e
.word 0x3900a3be
.word 0x3980a3a0
.word 0x390083a0
.word 0x3980a7a0
.word 0x390087a0
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000120
.word 0x9101d000
.word 0x398083a1
.word 0x39000001
.word 0x398087a1
.word 0x39000401
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_127:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsNativeStatic
Registrar_Registrar_ObjCMethod_get_IsNativeStatic:
.loc 3 834 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_81
.word 0x53001c00
.word 0x340000e0
.word 0xf9400ba0
bl _p_118
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x14000002
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_128:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsCategoryInstance
Registrar_Registrar_ObjCMethod_get_IsCategoryInstance:
.loc 3 840 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9401400
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000140
.word 0xf9400ba0
.word 0xf9400802
.word 0xf9402001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9411c50
.word 0xd63f0200
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_129:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsCategory
Registrar_Registrar_ObjCMethod_get_IsCategory:
.loc 3 845 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401400
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_12a:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_Trampoline
Registrar_Registrar_ObjCMethod_get_Trampoline:
.loc 3 863 0 prologue_end
.word 0xa9b77bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9807340
.word 0x34000060
.word 0xb9807340
.word 0x140000a0
.loc 3 868 0
.word 0xf9402359
.word 0xb4000179
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #472]
.word 0xeb01001f
.word 0x10000011
.word 0x54001ce1
.loc 3 883 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #448]
.word 0xd2a00000
.word 0x6b1f001f
.word 0xd2800100
.word 0xd280009e
.word 0x6b1e001f
.word 0xd2a00000
.word 0x53001c19
.loc 3 893 0
.word 0xaa1a03e0
bl _p_81
.word 0x53001c00
.word 0x340000e0
.word 0xaa1a03e0
bl _p_118
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17f8
.word 0x14000002
.word 0xd2a00018
.word 0x53001f17
.loc 3 894 0
.word 0xf9400b40
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_162
.word 0xaa0003e1
.word 0xf94023a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940c450
.word 0xd63f0200
.word 0x53001c00
.word 0x340001c0
.word 0xf9400b40
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_162
.word 0xaa0003e1
.word 0xf94023a2
.word 0xaa0203e0
.word 0x3940005e
bl _p_148
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f17f8
.word 0x14000002
.word 0xd2a00018
.loc 3 896 0
.word 0x340001b8
.word 0xf9400b40
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_162
.word 0xaa0003e1
.word 0xf94023a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940b050
.word 0xd63f0200
.word 0x53001c00
.word 0x35000b80
.loc 3 899 0
.word 0x340003b9
.loc 3 900 0
.word 0xf9400b41
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9408830
.word 0xd63f0200
.word 0x53001c00
.word 0x340001e0
.word 0xf9400b41
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9408430
.word 0xd63f0200
.word 0x53001c00
.word 0x35000100
.loc 3 901 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd28001f8
.word 0x14000002
.word 0xd28001d8
.word 0xb9007338
.word 0x14000040
.loc 3 903 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd2800058
.word 0x14000002
.word 0xd2800118
.word 0xb9007338
.word 0x14000039
.loc 3 906 0
.word 0xaa1a03e0
bl _p_80
.word 0xaa0003e1
.word 0xd2800000
.word 0xb9801022
.word 0xeb1f005f
.word 0x10000011
.word 0x54001049
.word 0xd37ff800
.word 0x8b010000
.word 0x79402800
.word 0x53003c19
.word 0xaa1903e0
.word 0xd2800c9e
.word 0x6b1e001f
.word 0x54000108
.word 0xd2800a3e
.word 0x6b1e033f
.word 0x54000160
.word 0xd2800c9e
.word 0x6b1e033f
.word 0x540002c0
.word 0x1400001c
.word 0xd2800cde
.word 0x6b1e033f
.word 0x54000160
.word 0xd2800e3e
.word 0x6b1e033f
.word 0x540002c1
.loc 3 909 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd2800198
.word 0x14000002
.word 0xd28001b8
.word 0xb9007338
.loc 3 910 0
.word 0x14000015
.loc 3 912 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd2800078
.word 0x14000002
.word 0xd2800138
.word 0xb9007338
.loc 3 913 0
.word 0x1400000e
.loc 3 915 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd2800098
.word 0x14000002
.word 0xd2800158
.word 0xb9007338
.loc 3 916 0
.word 0x14000007
.loc 3 918 0
.word 0xaa1a03f9
.word 0x35000077
.word 0xd2800038
.word 0x14000002
.word 0xd28000f8
.word 0xb9007338
.loc 3 923 0
.word 0xb9807340
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.loc 3 897 0
.word 0xf9400b40
.word 0xf9002fa0
.word 0xf9402340
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd285a0e1
bl _p_11
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800061
bl _p_42
.word 0xf90043a0
.word 0xf9003fa0
.word 0xf9400b40
.word 0xf90047a0
.word 0xaa1a03e0
bl _p_162
.word 0xaa0003e1
.word 0xf94047a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xf9400b42
.word 0xf9400f40
.word 0xf9401401
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002ba0
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0x3940005e
bl _p_29
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94023a2
.word 0xf94027a3
.word 0xf9402ba4
.word 0xf9402fa5
.word 0xaa0503e0
.word 0xd2820101
.word 0x394000be
bl _p_145
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_12b:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_Trampoline_Registrar_Trampoline
Registrar_Registrar_ObjCMethod_set_Trampoline_Registrar_Trampoline:
.loc 3 927 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9007001
.loc 3 928 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_12c:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_Signature
Registrar_Registrar_ObjCMethod_get_Signature:
.loc 3 933 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402740
.word 0xb5000240
.loc 3 934 0
.word 0xaa1a03e0
bl _p_272
.word 0xf90013a0
.word 0x91012341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 935 0
.word 0xf9402740
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_12d:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_set_Signature_string
Registrar_Registrar_ObjCMethod_set_Signature_string:
.loc 3 938 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91012001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 939 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_12e:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_ValidateSignature_System_Collections_Generic_List_1_System_Exception_
Registrar_Registrar_ObjCMethod_ValidateSignature_System_Collections_Generic_List_1_System_Exception_:
.loc 3 944 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90013bf
.word 0x3900a3bf
.word 0xf9400b41
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9404c30
.word 0xd63f0200
.word 0x53001c00
.word 0x34000060
.loc 3 945 0
.word 0xd2800020
.word 0x1400002d
.loc 3 947 0
.word 0xf9402740
.word 0xb5000500
.loc 3 949 0
.word 0xaa1a03e0
bl _p_272
.word 0xf9002ba0
.word 0x91012341
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 950 0
.word 0x14000016
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401ba0
.word 0xf90013a0
.loc 3 951 0
.word 0xf9400fa0
.word 0xf94013a1
bl _p_87
.loc 3 952 0
.word 0xd2a00000
.word 0x3900a3a0
bl _p_220
.word 0xf90027a0
.word 0xf94027a0
.word 0xb4000060
.word 0xf94027a0
bl _p_13
.word 0x14000003
.loc 3 956 0
.word 0xd2800020
.word 0x14000002
.loc 3 957 0
.word 0x3940a3a0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_12f:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_ComputeSignature
Registrar_Registrar_ObjCMethod_ComputeSignature:
.loc 3 961 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400b40
.word 0xf90017a0
.word 0xf9400f40
.word 0xf9401400
.word 0xf90013a0
.word 0xaa1a03e0
bl _p_118
.word 0xf94013a1
.word 0xf94017a6
.word 0x53001c04
.word 0xaa0603e0
.word 0xd2800002
.word 0xaa1a03e3
.word 0xd2a00005
.word 0x394000de
bl _p_132
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_130:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_ToString
Registrar_Registrar_ObjCMethod_ToString:
.loc 3 966 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bb5
.word 0xa901e3b7
.word 0xf90017ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3264]
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xaa0003e1
.word 0xf94023a3
.word 0xaa0103e2
.word 0xf9402340
.word 0xf9001ba3
.word 0xaa0203f8
.word 0xaa0103f7
.word 0xb9003bbf
.word 0xb50000a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x21, [x16, #3272]
.word 0x14000008
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003f5
.word 0xaa1703e0
.word 0xb9803ba1
.word 0xaa1503e2
.word 0xf94002e3
.word 0xf9404070
.word 0xd63f0200
.word 0xaa1a03e0
bl _p_81
.word 0xf90027a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3280]
.word 0xd2800221
bl _p_3
.word 0xaa0003e2
.word 0xf94027a0
.word 0x39004040
.word 0xaa1803e0
.word 0xd2800021
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.word 0xaa1a03e0
bl _p_120
.word 0x93407c00
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3288]
.word 0xd2800281
bl _p_3
.word 0xaa0003e2
.word 0xf94023a0
.word 0xb9001040
.word 0xaa1803e0
.word 0xd2800041
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #680]
.word 0xaa1803e0
.word 0xd2800061
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.word 0xf9401ba0
.word 0xaa1803e1
bl _p_58
.word 0xf9400bb5
.word 0xa941e3b7
.word 0xf94017ba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_131:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_DescriptiveMethodName
Registrar_Registrar_ObjCMethod_get_DescriptiveMethodName:
.loc 3 971 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xf9000fba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400b42
.word 0xf9400f40
.word 0xf9401401
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1144]
.word 0xf9402340
.word 0xf90013a2
.word 0xf90017a1
.word 0xb4000120
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9405050
.word 0xd63f0200
.word 0xaa0003f7
.word 0x14000002
.word 0xf9401357
.word 0xf94013a0
.word 0xf94017a1
.word 0xaa1703e2
bl _p_30
.word 0xf9400bb7
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_132:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_FullName
Registrar_Registrar_ObjCMethod_get_FullName:
.loc 3 977 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_108
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_133:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCMethod_get_IsPropertyAccessor
Registrar_Registrar_ObjCMethod_get_IsPropertyAccessor:
.loc 3 983 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9402000
bl _p_273
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_134:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_get_PropertyType
Registrar_Registrar_ObjCProperty_get_PropertyType:
.loc 3 994 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402740
.word 0xb50002a0
.loc 3 995 0
.word 0xf9402341
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9408030
.word 0xd63f0200
.word 0xf90013a0
.word 0x91012341
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 996 0
.word 0xf9402740
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_135:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_set_PropertyType_System_Type
Registrar_Registrar_ObjCProperty_set_PropertyType_System_Type:
.loc 3 999 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91012001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 3 1000 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_136:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_get_IsReadOnly
Registrar_Registrar_ObjCProperty_get_IsReadOnly:
.loc 3 1009 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xeb1f035f
.word 0x10000011
.word 0x54000540
.word 0x39418b40
.word 0x53001c00
.word 0x35000340
.loc 3 1010 0
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9413c50
.word 0xd63f0200
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x390083bf
.word 0x390087bf
.word 0x390087a0
.word 0xd280003e
.word 0x390083be
.word 0x398083a0
.word 0x390063a0
.word 0x398087a0
.word 0x390067a0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000260
.word 0x91018b40
.word 0x398063a1
.word 0x39000001
.word 0x398067a1
.word 0x39000401
.loc 3 1011 0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000160
.word 0x91018b40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3000]
bl _p_258
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_137:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_set_IsReadOnly_bool
Registrar_Registrar_ObjCProperty_set_IsReadOnly_bool:
.loc 3 1014 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x3900a3bf
.word 0x3900a7bf
.word 0x394063a0
.word 0x3900a7a0
.word 0xd280003e
.word 0x3900a3be
.word 0x3980a3a0
.word 0x390083a0
.word 0x3980a7a0
.word 0x390087a0
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000120
.word 0x91018800
.word 0x398083a1
.word 0x39000001
.word 0x398087a1
.word 0x39000401
.loc 3 1015 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_138:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_get_IsStatic
Registrar_Registrar_ObjCProperty_get_IsStatic:
.loc 3 1019 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xeb1f035f
.word 0x10000011
.word 0x54000320
.word 0x39418340
.word 0x53001c00
.word 0x35000120
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9412c50
.word 0xd63f0200
.word 0x53001c00
.word 0x1400000a
.word 0xeb1f035f
.word 0x10000011
.word 0x54000160
.word 0x91018340

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3000]
bl _p_258
.word 0x53001c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_139:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_set_IsStatic_bool
Registrar_Registrar_ObjCProperty_set_IsStatic_bool:
.loc 3 1020 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x3900a3bf
.word 0x3900a7bf
.word 0x394063a0
.word 0x3900a7a0
.word 0xd280003e
.word 0x3900a3be
.word 0x3980a3a0
.word 0x390083a0
.word 0x3980a7a0
.word 0x390087a0
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000120
.word 0x91018000
.word 0x398083a1
.word 0x39000001
.word 0x398087a1
.word 0x39000401
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_13a:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_get_IsNativeStatic
Registrar_Registrar_ObjCProperty_get_IsNativeStatic:
.loc 3 1024 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_73
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13b:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty__ctor
Registrar_Registrar_ObjCProperty__ctor:
.loc 3 1027 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x9280001e
.word 0xb900381e
.loc 3 1029 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13c:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCProperty_get_FullName
Registrar_Registrar_ObjCProperty_get_FullName:
.loc 3 1033 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400b42
.word 0xf9400f40
.word 0xf9401401
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0xaa0003e2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1144]
.word 0xf9402340
.word 0xf9000fa2
.word 0xf90013a1
.word 0xb5000060
.word 0xf940135a
.word 0x14000008
.word 0xf9400b42
.word 0xf9402341
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9405850
.word 0xd63f0200
.word 0xaa0003fa
.word 0xf9400fa0
.word 0xf94013a1
.word 0xaa1a03e2
bl _p_30
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_13d:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCField_get_FullName
Registrar_Registrar_ObjCField_get_FullName:
.loc 3 1052 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400802
.word 0xf9400c00
.word 0xf9401401
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1144]
.word 0xf9400ba2
.word 0xf9401042
bl _p_30
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13e:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCField_get_IsStatic
Registrar_Registrar_ObjCField_get_IsStatic:
.loc 3 1057 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39413800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13f:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCField_set_IsStatic_bool
Registrar_Registrar_ObjCField_set_IsStatic_bool:
.loc 3 1058 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39013801
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_140:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCField_get_IsNativeStatic
Registrar_Registrar_ObjCField_get_IsNativeStatic:
.loc 3 1062 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39413800
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_141:
.text
	.align 4
	.no_dead_strip Registrar_Registrar_ObjCField__ctor
Registrar_Registrar_ObjCField__ctor:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x9280001e
.word 0xb900381e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_142:
.text
	.align 4
	.no_dead_strip Registrar_Shared_GetMT4127_System_Reflection_MethodBase_System_Collections_Generic_List_1_System_Reflection_MethodBase
Registrar_Shared_GetMT4127_System_Reflection_MethodBase_System_Collections_Generic_List_1_System_Reflection_MethodBase:
.loc 3 74 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3296]
.word 0xd2800401
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3304]
.word 0xf9400021
.word 0xf90043a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94043a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xaa0003f8
.loc 3 75 0
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3312]
.word 0xf9002fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800041
bl _p_42
.word 0xf9003fa0
.word 0xf9003ba0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403ba0
.word 0xf90037a0
.word 0xf90033a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94037a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402fa1
.word 0xf94033a2
.word 0xd28203e0
bl _p_32
.word 0xaa0003e1
.word 0xf9402ba0
.word 0xaa0003f7
.word 0xaa0103f6
.word 0x394002fe
.word 0xb9801ee1
.word 0x11000421
.word 0xb9001c01
.word 0xf9400af5
.word 0xb9801af4
.word 0xaa1403e0
.word 0xb9801aa1
.word 0x6b01001f
.word 0x54000142
.word 0x11000680
.word 0xb9001ae0
.word 0xaa1503e0
.word 0xaa1403e1
.word 0xaa1603e2
.word 0xf94002a3
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3320]
.word 0xaa1703e0
.word 0xaa1603e1
bl _p_274
.loc 3 76 0
.word 0xd2a00017
.word 0x14000079

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 3 77 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1856]
.word 0x3940035e
.word 0xaa1a03e0
.word 0xaa1703e1
bl _p_218
.word 0xaa0003f6
.loc 3 78 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3328]
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf9004ba0
.word 0xf90047a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404ba3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94047a0
.word 0xf90043a0
.word 0xf9003fa0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94043a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9403fa0
.word 0xf9003ba0
.word 0xf90037a0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9405830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9403ba3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94037a0
.word 0xf90033a0
.word 0xf9002fa0
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf94033a3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xd2820520
bl _p_32
.word 0xaa1803f6
.word 0xaa0003f5
.word 0x3940031e
.word 0xb9801f00
.word 0x11000400
.word 0xb9001f00
.word 0xf9400b14
.word 0xb9801b13
.word 0xaa1303e0
.word 0xb9801a81
.word 0x6b01001f
.word 0x54000142
.word 0x11000660
.word 0xb9001ac0
.word 0xaa1403e0
.word 0xaa1303e1
.word 0xaa1503e2
.word 0xf9400283
.word 0xf9404070
.word 0xd63f0200
.word 0x14000007

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3320]
.word 0xaa1603e0
.word 0xaa1503e1
bl _p_274
.loc 3 76 0
.word 0x110006f7
.word 0x3940035e
.word 0xb9801b40
.word 0x6b0002ff
.word 0x54fff0ab
.loc 3 80 0
.word 0xaa1803e0
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0

Lme_143:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessage_get_ClassHandle
WebKit_WKScriptMessage_get_ClassHandle:
.file 4 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/WebKit/WKScriptMessage.g.cs"
.loc 4 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3336]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_144:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessage__ctor_ObjCRuntime_NativeHandle
WebKit_WKScriptMessage__ctor_ObjCRuntime_NativeHandle:
.loc 4 80 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 4 82 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_145:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessage_Dispose_bool
WebKit_WKScriptMessage_Dispose_bool:
.loc 4 161 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 4 162 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 4 165 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_146:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessage__cctor
WebKit_WKScriptMessage__cctor:
.loc 4 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3344]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3336]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_147:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessageHandlerWrapper__ctor_ObjCRuntime_NativeHandle_bool
WebKit_WKScriptMessageHandlerWrapper__ctor_ObjCRuntime_NativeHandle_bool:
.file 5 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/WebKit/WKScriptMessageHandler.g.cs"
.loc 5 67 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_277
.loc 5 69 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_149:
.text
	.align 4
	.no_dead_strip WebKit_WKScriptMessageHandlerWrapper_DidReceiveScriptMessage_WebKit_WKUserContentController_WebKit_WKScriptMessage
WebKit_WKScriptMessageHandlerWrapper_DidReceiveScriptMessage_WebKit_WKUserContentController_WebKit_WKScriptMessage:
.loc 5 74 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3352]
.word 0x9100c3a0
.word 0xf90023a0
.word 0xf9400fa0
bl _p_278
.word 0xf94023be
.word 0xf90003c0
.loc 5 75 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3360]
.word 0x9100a3a0
.word 0xf90023a0
.word 0xf94013a0
bl _p_278
.word 0xf94023be
.word 0xf90003c0
.loc 5 76 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
.word 0xf9401ba2
.word 0xf94017a3
bl _p_279
.loc 5 77 0
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_14a:
.text
	.align 4
	.no_dead_strip WebKit_WKUserContentController_get_ClassHandle
WebKit_WKUserContentController_get_ClassHandle:
.file 6 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/WebKit/WKUserContentController.g.cs"
.loc 6 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3368]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_14b:
.text
	.align 4
	.no_dead_strip WebKit_WKUserContentController__ctor_ObjCRuntime_NativeHandle
WebKit_WKUserContentController__ctor_ObjCRuntime_NativeHandle:
.loc 6 93 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 6 95 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_14c:
.text
	.align 4
	.no_dead_strip WebKit_WKUserContentController__cctor
WebKit_WKUserContentController__cctor:
.loc 6 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3376]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3368]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_14d:
.text
	.align 4
	.no_dead_strip Foundation_ConnectAttribute_get_Name
Foundation_ConnectAttribute_get_Name:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2894521
bl _p_11
.word 0xaa0003e1
.word 0xd28015e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_14e:
.text
	.align 4
	.no_dead_strip Foundation_ExportAttribute__ctor_string
Foundation_ExportAttribute__ctor_string:
.file 7 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/ExportAttribute.cs"
.loc 7 50 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf90013a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 7 51 0
.word 0x9280001e
.word 0xb900181e
.loc 7 52 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_14f:
.text
	.align 4
	.no_dead_strip Foundation_ExportAttribute__ctor_string_ObjCRuntime_ArgumentSemantic
Foundation_ExportAttribute__ctor_string_ObjCRuntime_ArgumentSemantic:
.loc 7 56 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xf9001ba0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 7 57 0
.word 0xb98023a1
.word 0xb9001801
.loc 7 58 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_150:
.text
	.align 4
	.no_dead_strip Foundation_ExportAttribute_get_Selector
Foundation_ExportAttribute_get_Selector:
.loc 7 61 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_151:
.text
	.align 4
	.no_dead_strip Foundation_ExportAttribute_get_ArgumentSemantic
Foundation_ExportAttribute_get_ArgumentSemantic:
.loc 7 66 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xb9801800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_152:
.text
	.align 4
	.no_dead_strip Foundation_ExportAttribute_get_IsVariadic
Foundation_ExportAttribute_get_IsVariadic:
.loc 7 71 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39407000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_153:
.text
	.align 4
	.no_dead_strip Foundation_FieldAttribute__ctor_string_string
Foundation_FieldAttribute__ctor_string_string:
.file 8 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/FieldAttribute.cs"
.loc 8 40 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xf9001ba0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 8 41 0
.word 0x91006001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 8 42 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_154:
.text
	.align 4
	.no_dead_strip Foundation_FieldAttribute_set_SymbolName_string
Foundation_FieldAttribute_set_SymbolName_string:
.loc 8 43 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_155:
.text
	.align 4
	.no_dead_strip Foundation_FieldAttribute_set_LibraryName_string
Foundation_FieldAttribute_set_LibraryName_string:
.loc 8 44 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91006001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_156:
.text
	.align 4
	.no_dead_strip Foundation_ModelAttribute__ctor
Foundation_ModelAttribute__ctor:
.file 9 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/ModelAttribute.cs"
.loc 9 30 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_157:
.text
	.align 4
	.no_dead_strip Foundation_ModelNotImplementedException__ctor
Foundation_ModelNotImplementedException__ctor:
.file 10 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/ModelNotImplementedException.cs"
.loc 10 27 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x929d5ffe
.word 0xf2b0027e
.word 0xb900601e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_158:
.text
	.align 4
	.no_dead_strip Foundation_You_Should_Not_Call_base_In_This_Method__ctor
Foundation_You_Should_Not_Call_base_In_This_Method__ctor:
.loc 10 31 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x929d5ffe
.word 0xf2b0027e
.word 0xb900601e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_159:
.text
	.align 4
	.no_dead_strip Foundation_NSDispatcher__ctor
Foundation_NSDispatcher__ctor:
.file 11 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSAction.cs"
.loc 11 38 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_280
.loc 11 40 0
.word 0xf9400ba0
.word 0xd2a00001
bl _p_281
.loc 11 41 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_15a:
.text
	.align 4
	.no_dead_strip Foundation_NSSynchronizationContextDispatcher__ctor_System_Threading_SendOrPostCallback_object
Foundation_NSSynchronizationContextDispatcher__ctor_System_Threading_SendOrPostCallback_object:
.loc 11 70 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_282
.loc 11 72 0
.word 0xf9400fa0
.word 0xb4000460
.loc 11 75 0
.word 0xf9400ba0
.word 0xf9001ba0
.word 0x9100c002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 11 76 0
.word 0x9100e001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 11 77 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 11 73 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2863581
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_15c:
.text
	.align 4
	.no_dead_strip Foundation_NSSynchronizationContextDispatcher_Apply
Foundation_NSSynchronizationContextDispatcher_Apply:
.loc 11 79 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9401802
.word 0xf9401c01
.word 0xaa0203e0
.word 0xf90013a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_15d:
.text
	.align 4
	.no_dead_strip Foundation_NSAsyncDispatcher__ctor
Foundation_NSAsyncDispatcher__ctor:
.loc 11 110 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_282
.loc 11 112 0
.word 0x910063a0
.word 0xf90013a0
.word 0xaa1a03e0
bl _p_283
.word 0xf94013be
.word 0xf90003c0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000100
.word 0x9100c340
.word 0xf9400fa1
.word 0xf9000001
.loc 11 113 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_15e:
.text
	.align 4
	.no_dead_strip Foundation_NSAsyncDispatcher_Apply
Foundation_NSAsyncDispatcher_Apply:
.loc 11 117 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9000fbf
.word 0xf9400ba0
.word 0x9100c000
.word 0xf9400000
.word 0xf9000fa0
.word 0x910063a0
bl _p_284
.loc 11 129 0
.word 0xf9400ba0
bl _p_285
.loc 11 131 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_15f:
.text
	.align 4
	.no_dead_strip Foundation_NSAsyncSynchronizationContextDispatcher__ctor_System_Threading_SendOrPostCallback_object
Foundation_NSAsyncSynchronizationContextDispatcher__ctor_System_Threading_SendOrPostCallback_object:
.loc 11 164 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_286
.loc 11 166 0
.word 0xf9400fa0
.word 0xb4000460
.loc 11 169 0
.word 0xf9400ba0
.word 0xf9001ba0
.word 0x9100e002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 11 170 0
.word 0x91010001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 11 171 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 11 167 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2863581
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_160:
.text
	.align 4
	.no_dead_strip Foundation_NSAsyncSynchronizationContextDispatcher_Apply
Foundation_NSAsyncSynchronizationContextDispatcher_Apply:
.loc 11 176 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9401c02
.word 0xf9400ba0
.word 0xf9402001
.word 0xaa0203e0
.word 0xf9001ba2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf9401ba0
.loc 11 177 0
.word 0xf9000fbf
.word 0x94000005
.word 0xf9400fa0
.word 0xb4000040
bl _p_23
.word 0x14000010
.word 0xf90013be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 11 178 0
.word 0xf9400ba0
.word 0xf9001c1f
.loc 11 179 0
.word 0xf9400ba0
.word 0xf900201f
.loc 11 180 0
.word 0xf9400ba0
bl _p_287
.loc 11 181 0
.word 0xf94013be
.word 0xd61f03c0
.loc 11 182 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_161:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromNSObjects_Foundation_NSObject__
Foundation_NSArray_FromNSObjects_Foundation_NSObject__:
.file 12 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSArray.cs"
.loc 12 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3384]
.word 0xf9400ba0
bl _p_288
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_162:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromNSObjects_T_REF_T_REF__
Foundation_NSArray_FromNSObjects_T_REF_T_REF__:
.loc 12 75 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3392]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400fa0
.word 0xf940100f
.word 0xf9400ba0
bl _p_289
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_163:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromNativeObjects_T_REF_T_REF__
Foundation_NSArray_FromNativeObjects_T_REF_T_REF__:
.loc 12 166 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000faf
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3400]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xb500013a
.loc 12 167 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3408]
bl _p_290
.word 0xf90013a0
bl _p_291
.word 0xf94013a0
.word 0x14000007
.loc 12 169 0
.word 0xb9801b40
.word 0x93407c01
.word 0xf9400fa0
.word 0xf940100f
.word 0xaa1a03e0
bl _p_292
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_164:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromNativeObjects_T_REF_T_REF___intptr
Foundation_NSArray_FromNativeObjects_T_REF_T_REF___intptr:
.loc 12 174 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xf9002baf
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb5000139
.loc 12 175 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3408]
bl _p_290
.word 0xf90033a0
bl _p_291
.word 0xf94033a0
.word 0x14000044
.loc 12 177 0
.word 0xb9801b20
.word 0x93407c00
.word 0xeb00035f
.word 0x540008cc
.loc 12 180 0
.word 0xd37df340
bl _p_293
.word 0xaa0003f8
.loc 12 181 0
.word 0xd2800017
.word 0x1400002e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 12 182 0
.word 0x93407ee0
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x540008e9
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400016
.loc 12 183 0
.word 0xaa1603e0
.word 0xb40001c0
.word 0x910103a0
.word 0xf90027a0
.word 0xaa1603e0
.word 0xf94002c1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3416]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94027be
.word 0xf90003c0
.word 0x14000007
bl _p_294
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a0
.word 0xf9001fa0
.word 0xf9401fb6
.loc 12 184 0
.word 0xd37df2e0
.word 0x93407c01
.word 0xaa1803e0
.word 0xaa1603e2
bl _p_295
.loc 12 181 0
.word 0x910006f7
.word 0xeb1a02ff
.word 0x54fffa4b
.loc 12 186 0
.word 0xaa1803e0
.word 0xaa1a03e1
bl _p_296

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3424]
bl _p_297
.word 0xaa0003fa
.loc 12 187 0
.word 0xaa1803e0
bl _p_298
.loc 12 188 0
.word 0xaa1a03e0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.loc 12 178 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2894821
bl _p_11
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2895261
bl _p_11
.word 0xaa0003e2
.word 0xf94033a1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_2
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_165:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromStrings_string__
Foundation_NSArray_FromStrings_string__:
.loc 12 205 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_299
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_166:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromStrings_System_Collections_Generic_IReadOnlyList_1_string
Foundation_NSArray_FromStrings_System_Collections_Generic_IReadOnlyList_1_string:
.loc 12 209 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001fbf
.word 0xb400103a
.loc 12 212 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3432]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3440]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0x531d7000
bl _p_300
.word 0xf9001fa0
.loc 12 214 0
.word 0xd2a00019
.word 0x14000034

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 12 217 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3448]
.word 0xaa1a03e0
.word 0xaa1903e1
.word 0xf9400342

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3456]
.word 0x928011f0
.word 0xf8706850
.word 0xd63f0200
.word 0xb5000120
.loc 12 218 0
bl _p_294
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401bb8
.word 0x14000014
.loc 12 220 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3448]
.word 0xaa1a03e0
.word 0xaa1903e1
.word 0xf9400342

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3456]
.word 0x928011f0
.word 0xf8706850
.word 0xd63f0200
.word 0x9100a3a1
.word 0xf90023a1
.word 0xd2800021
bl _p_301
.word 0xf94023be
.word 0xf90003c0
.word 0xf94017b8
.loc 12 223 0
.word 0xf9401fa0
.word 0x531d7321
.word 0xaa1803e2
bl _p_295
.loc 12 214 0
.word 0x11000739

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3432]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3440]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0x6b00033f
.word 0x54fff80b
.loc 12 225 0
.word 0xf9401fa0
.word 0xf90033a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3432]
.word 0xaa1a03e0
.word 0xf9400341

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3440]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94033a0
.word 0x93407c21
bl _p_296

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3424]
bl _p_297
.word 0xaa0003fa
.loc 12 226 0
.word 0xf90027bf
.word 0x94000005
.word 0xf94027a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9002bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 12 228 0
.word 0xf9401fa0
bl _p_298
.loc 12 229 0
.word 0xf9402bbe
.word 0xd61f03c0
.loc 12 230 0
.word 0xaa1a03e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.loc 12 210 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28953e1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_167:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_GetCount_intptr
Foundation_NSArray_GetCount_intptr:
.loc 12 252 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
adrp x1, L_OBJC_SELECTOR_REFERENCES_1@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_1@PAGEOFF
ldr x1, [x1]
.word 0xf9400ba0
bl _p_302
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_168:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_GetAtIndex_ObjCRuntime_NativeHandle_uintptr
Foundation_NSArray_GetAtIndex_ObjCRuntime_NativeHandle_uintptr:
.loc 12 259 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf9001ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_2@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_2@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90023a2
.word 0xf9401ba2
bl _p_303
.word 0xf94023be
.word 0xf90003c0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_169:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_ArrayFromHandle_T_REF_ObjCRuntime_NativeHandle
Foundation_NSArray_ArrayFromHandle_T_REF_ObjCRuntime_NativeHandle:
.loc 12 286 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf9002faf
.word 0xf90017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3464]
.word 0xf9402fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9001fa0
.word 0xf94017a0
.word 0xf9002ba0
.word 0xf9401fa0
.word 0xf90027a0
.word 0xf9402ba0
.word 0xf94027a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 12 287 0
.word 0xd2800000
.word 0x14000026
.loc 12 289 0
.word 0xf94017a0
.word 0xf90023a0
.word 0xf94023a0
bl _p_304
.word 0xaa0003fa
.loc 12 290 0
.word 0xaa1a03e1
.word 0xeb1f003f
.word 0x10000011
.word 0x5400044b
.word 0xf9402fa0
.word 0xf9401000
bl _p_42
.word 0xaa0003f9
.loc 12 292 0
.word 0xd2a00018
.word 0x14000013

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 12 293 0
.word 0x2a1803e1
.word 0xf9402fa0
.word 0xf940140f
.word 0xf94017a0
bl _p_305
.word 0xaa0003e2
.word 0xaa1903e0
.word 0xaa1803e1
.word 0xf9400323
.word 0xf9404070
.word 0xd63f0200
.loc 12 292 0
.word 0x11000718
.word 0x2a1803e0
.word 0xeb1a001f
.word 0x54fffd83
.loc 12 295 0
.word 0xaa1903e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xd2801820
.word 0xaa1103e1
bl _p_9

Lme_16a:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_UnsafeGetItem_T_REF_ObjCRuntime_NativeHandle_uintptr
Foundation_NSArray_UnsafeGetItem_T_REF_ObjCRuntime_NativeHandle_uintptr:
.loc 12 401 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9002baf
.word 0xf9000ba0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3480]
.word 0xf9402ba0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0x910163a0
.word 0xf90033a0
.word 0xf9400ba0
.word 0xf94013a1
bl _p_306
.word 0xf94033be
.word 0xf90003c0
.loc 12 405 0
.word 0xf9402fa0
.word 0xf9001ba0
bl _p_294
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf9401ba0
.word 0xf90027a0
.word 0xf94017a0
.word 0xf90023a0
.word 0xf94027a0
.word 0xf94023a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 12 406 0
.word 0xd2800000
.word 0x14000008
.loc 12 408 0
.word 0xf9402fa0
.word 0xf9001fa0
.word 0xf9401fa0
.word 0xf9402ba1
.word 0xf940182f
.word 0xd2a00001
bl _p_307
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_16b:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_System_Collections_Generic_IEnumerable_Foundation_NSObject_GetEnumerator
Foundation_NSArray_System_Collections_Generic_IEnumerable_Foundation_NSObject_GetEnumerator:
.loc 12 478 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3488]
.word 0xd2800801
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3496]
.word 0xf90013a0
.word 0xf9400ba1
bl _p_308
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_16c:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_get_ClassHandle
Foundation_NSArray_get_ClassHandle:
.file 13 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSArray.g.cs"
.loc 13 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3504]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_16d:
.text
	.align 4
	.no_dead_strip Foundation_NSArray__ctor
Foundation_NSArray__ctor:
.loc 13 61 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 13 64 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1888]
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_311
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_16e:
.text
	.align 4
	.no_dead_strip Foundation_NSArray__ctor_ObjCRuntime_NativeHandle
Foundation_NSArray__ctor_ObjCRuntime_NativeHandle:
.loc 13 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 13 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_16f:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_Copy_Foundation_NSZone
Foundation_NSArray_Copy_Foundation_NSZone:
.loc 13 129 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 13 132 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 13 136 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 13 137 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 13 138 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_170:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_FromObjects_intptr_intptr
Foundation_NSArray_FromObjects_intptr_intptr:
.loc 13 186 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3504]
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_6@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_6@PAGEOFF
ldr x1, [x1]
.word 0xf9400ba2
.word 0xf9400fa3
bl _p_316
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_171:
.text
	.align 4
	.no_dead_strip Foundation_NSArray__cctor
Foundation_NSArray__cctor:
.loc 13 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3512]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3504]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_172:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_1_TKey_REF__ctor_ObjCRuntime_NativeHandle
Foundation_NSArray_1_TKey_REF__ctor_ObjCRuntime_NativeHandle:
.file 14 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSArray_1.cs"
.loc 14 47 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_317
.loc 14 49 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_173:
.text
	.align 4
	.no_dead_strip Foundation_NSArray_1_TKey_REF_System_Collections_Generic_IEnumerable_TKey_GetEnumerator
Foundation_NSArray_1_TKey_REF_System_Collections_Generic_IEnumerable_TKey_GetEnumerator:
.loc 14 82 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3520]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf9400fa0
.word 0xf9401000
.word 0xd2800801
bl _p_3
.word 0xf94017a1
.word 0xf9400fa2
.word 0xf940144f
.word 0xf90013a0
bl _p_318
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_174:
.text
	.align 4
	.no_dead_strip Foundation_NSBundle_get_ClassHandle
Foundation_NSBundle_get_ClassHandle:
.file 15 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSBundle.g.cs"
.loc 15 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3528]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_175:
.text
	.align 4
	.no_dead_strip Foundation_NSBundle__ctor_ObjCRuntime_NativeHandle
Foundation_NSBundle__ctor_ObjCRuntime_NativeHandle:
.loc 15 77 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 15 79 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_176:
.text
	.align 4
	.no_dead_strip Foundation_NSBundle__cctor
Foundation_NSBundle__cctor:
.loc 15 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3536]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3528]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_177:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_GetCalendarIdentifier_Foundation_NSCalendarType
Foundation_NSCalendar_GetCalendarIdentifier_Foundation_NSCalendarType:
.file 16 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSCalendar.cs"
.loc 16 0 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb98013a0
.word 0xf9000fa0
.word 0xb98013a0
.word 0xd280021e
.word 0x6b1e001f
.word 0x54000542
.word 0xf9400fa0
.word 0xd37df000
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3544]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.loc 16 81 0
bl _p_319
.word 0x14000029
.loc 16 83 0
bl _p_320
.word 0x14000027
.loc 16 85 0
bl _p_321
.word 0x14000025
.loc 16 87 0
bl _p_322
.word 0x14000023
.loc 16 89 0
bl _p_323
.word 0x14000021
.loc 16 91 0
bl _p_324
.word 0x1400001f
.loc 16 93 0
bl _p_325
.word 0x1400001d
.loc 16 97 0
bl _p_326
.word 0x1400001b
.loc 16 99 0
bl _p_327
.word 0x14000019
.loc 16 101 0
bl _p_328
.word 0x14000017
.loc 16 103 0
bl _p_329
.word 0x14000015
.loc 16 105 0
bl _p_330
.word 0x14000013
.loc 16 107 0
bl _p_331
.word 0x14000011
.loc 16 109 0
bl _p_332
.word 0x1400000f
.loc 16 111 0
bl _p_333
.word 0x1400000d
.loc 16 113 0
bl _p_334
.word 0x1400000b
.loc 16 115 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28966e1
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_178:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar__ctor_Foundation_NSCalendarType
Foundation_NSCalendar__ctor_Foundation_NSCalendarType:
.loc 16 119 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801ba0
bl _p_335
.word 0xaa0003e1
.word 0xf9400ba0
bl _p_336
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_179:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_ClassHandle
Foundation_NSCalendar_get_ClassHandle:
.file 17 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSCalendar.g.cs"
.loc 17 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3552]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_17a:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar__ctor_ObjCRuntime_NativeHandle
Foundation_NSCalendar__ctor_ObjCRuntime_NativeHandle:
.loc 17 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 17 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_17b:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar__ctor_Foundation_NSString
Foundation_NSCalendar__ctor_Foundation_NSString:
.loc 17 86 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 17 88 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3560]
.word 0x9100a3a0
.word 0xf9001fa0
.word 0xf9400fa0
bl _p_278
.word 0xf9401fbe
.word 0xf90003c0
.loc 17 90 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_7@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_7@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf9001fa2
.word 0xf94017a2
bl _p_313
.word 0xf9401fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #3568]
.word 0xf9400ba0
.word 0xf94013a1
bl _p_311
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_17c:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_Copy_Foundation_NSZone
Foundation_NSCalendar_Copy_Foundation_NSZone:
.loc 17 173 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 17 176 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 17 180 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 17 181 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 17 182 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_17d:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_set_TimeZone_Foundation_NSTimeZone
Foundation_NSCalendar_set_TimeZone_Foundation_NSTimeZone:
.loc 17 980 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3576]
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_278
.word 0xf9401bbe
.word 0xf90003c0
.loc 17 982 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_8@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_8@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_337
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_17e:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_CopticCalendar
Foundation_NSCalendar_get_CopticCalendar:
.loc 17 1048 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3584]
.word 0xf9400000
.word 0xb5000220
.loc 17 1049 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3600]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3584]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1050 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3584]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_17f:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_EthiopicAmeteAlemCalendar
Foundation_NSCalendar_get_EthiopicAmeteAlemCalendar:
.loc 17 1077 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3608]
.word 0xf9400000
.word 0xb5000220
.loc 17 1078 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3616]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3608]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1079 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3608]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_180:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_EthiopicAmeteMihretCalendar
Foundation_NSCalendar_get_EthiopicAmeteMihretCalendar:
.loc 17 1087 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3624]
.word 0xf9400000
.word 0xb5000220
.loc 17 1088 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3632]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3624]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1089 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3624]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_181:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_IslamicTabularCalendar
Foundation_NSCalendar_get_IslamicTabularCalendar:
.loc 17 1105 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3640]
.word 0xf9400000
.word 0xb5000220
.loc 17 1106 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3648]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3640]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1107 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3640]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_182:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_IslamicUmmAlQuraCalendar
Foundation_NSCalendar_get_IslamicUmmAlQuraCalendar:
.loc 17 1123 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3656]
.word 0xf9400000
.word 0xb5000220
.loc 17 1124 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3664]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3656]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1125 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3656]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_183:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSBuddhistCalendar
Foundation_NSCalendar_get_NSBuddhistCalendar:
.loc 17 1133 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3672]
.word 0xf9400000
.word 0xb5000220
.loc 17 1134 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3680]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3672]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1135 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3672]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_184:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSChineseCalendar
Foundation_NSCalendar_get_NSChineseCalendar:
.loc 17 1143 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3688]
.word 0xf9400000
.word 0xb5000220
.loc 17 1144 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3696]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3688]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1145 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3688]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_185:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSGregorianCalendar
Foundation_NSCalendar_get_NSGregorianCalendar:
.loc 17 1153 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3704]
.word 0xf9400000
.word 0xb5000220
.loc 17 1154 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3712]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3704]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1155 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3704]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_186:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSHebrewCalendar
Foundation_NSCalendar_get_NSHebrewCalendar:
.loc 17 1163 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3720]
.word 0xf9400000
.word 0xb5000220
.loc 17 1164 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3728]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3720]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1165 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3720]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_187:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSISO8601Calendar
Foundation_NSCalendar_get_NSISO8601Calendar:
.loc 17 1173 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3736]
.word 0xf9400000
.word 0xb5000220
.loc 17 1174 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3744]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3736]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1175 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3736]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_188:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSIndianCalendar
Foundation_NSCalendar_get_NSIndianCalendar:
.loc 17 1183 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3752]
.word 0xf9400000
.word 0xb5000220
.loc 17 1184 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3760]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3752]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1185 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3752]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_189:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSIslamicCalendar
Foundation_NSCalendar_get_NSIslamicCalendar:
.loc 17 1193 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3768]
.word 0xf9400000
.word 0xb5000220
.loc 17 1194 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3776]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3768]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1195 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3768]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18a:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSIslamicCivilCalendar
Foundation_NSCalendar_get_NSIslamicCivilCalendar:
.loc 17 1203 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3784]
.word 0xf9400000
.word 0xb5000220
.loc 17 1204 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3792]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3784]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1205 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3784]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18b:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSJapaneseCalendar
Foundation_NSCalendar_get_NSJapaneseCalendar:
.loc 17 1213 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3800]
.word 0xf9400000
.word 0xb5000220
.loc 17 1214 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3808]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3800]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1215 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3800]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18c:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSPersianCalendar
Foundation_NSCalendar_get_NSPersianCalendar:
.loc 17 1223 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3816]
.word 0xf9400000
.word 0xb5000220
.loc 17 1224 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3824]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3816]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1225 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3816]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18d:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar_get_NSRepublicOfChinaCalendar
Foundation_NSCalendar_get_NSRepublicOfChinaCalendar:
.loc 17 1233 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3832]
.word 0xf9400000
.word 0xb5000220
.loc 17 1234 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3592]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3840]
bl _p_338
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3832]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 17 1235 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3832]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18e:
.text
	.align 4
	.no_dead_strip Foundation_NSCalendar__cctor
Foundation_NSCalendar__cctor:
.loc 17 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3848]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3552]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_18f:
.text
	.align 4
	.no_dead_strip Foundation_NSCoder_get_ClassHandle
Foundation_NSCoder_get_ClassHandle:
.file 18 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSCoder.g.cs"
.loc 18 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3856]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_190:
.text
	.align 4
	.no_dead_strip Foundation_NSCoder__ctor_ObjCRuntime_NativeHandle
Foundation_NSCoder__ctor_ObjCRuntime_NativeHandle:
.loc 18 77 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 18 79 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_191:
.text
	.align 4
	.no_dead_strip Foundation_NSCoder__cctor
Foundation_NSCoder__cctor:
.loc 18 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3864]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3856]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_192:
.text
	.align 4
	.no_dead_strip Foundation_NSData_System_Collections_Generic_IEnumerable_System_Byte_GetEnumerator
Foundation_NSData_System_Collections_Generic_IEnumerable_System_Byte_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3872]
.word 0xd2800701
bl _p_3
.word 0xb900181f
.word 0xf90013a0
.word 0x91004002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400ba1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_193:
.text
	.align 4
	.no_dead_strip Foundation_NSData_ToString
Foundation_NSData_ToString:
.file 19 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSData.cs"
.loc 19 234 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9000fbf
.word 0xf90013bf
.word 0xf9400ba0
.word 0xf90037a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3880]
bl _p_290
.word 0xf94037a1
.word 0xf90033a0
.word 0xd2800082
bl _p_339
.word 0xf94033a0
.word 0xf9000fa0
.loc 19 235 0
.word 0xf9400fa1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9403030
.word 0xd63f0200
.word 0xf90013a0
.word 0xf90017bf
.word 0x94000005
.word 0xf94017a0
.word 0xb4000040
bl _p_23
.word 0x14000029
.word 0xf9001fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb4000140
.word 0xf9400fa1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9401fbe
.word 0xd61f03c0
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 19 237 0
.word 0xf9400ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9404430
.word 0xd63f0200
.word 0xf90013a0
bl _p_220
.word 0xf9002fa0
.word 0xf9402fa0
.word 0xb4000060
.word 0xf9402fa0
bl _p_13
.word 0x14000001
.loc 19 239 0
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_194:
.text
	.align 4
	.no_dead_strip Foundation_NSData_get_ClassHandle
Foundation_NSData_get_ClassHandle:
.file 20 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSData.g.cs"
.loc 20 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3888]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_195:
.text
	.align 4
	.no_dead_strip Foundation_NSData__ctor_ObjCRuntime_NativeHandle
Foundation_NSData__ctor_ObjCRuntime_NativeHandle:
.loc 20 90 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 20 92 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_196:
.text
	.align 4
	.no_dead_strip Foundation_NSData_Copy_Foundation_NSZone
Foundation_NSData_Copy_Foundation_NSZone:
.loc 20 175 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 20 178 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 20 182 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 20 183 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 20 184 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_197:
.text
	.align 4
	.no_dead_strip Foundation_NSData_get_Bytes
Foundation_NSData_get_Bytes:
.loc 20 480 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_9@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_9@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_198:
.text
	.align 4
	.no_dead_strip Foundation_NSData_get_Length
Foundation_NSData_get_Length:
.loc 20 491 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_10@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_10@PAGEOFF
ldr x1, [x1]
bl _p_302
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_199:
.text
	.align 4
	.no_dead_strip Foundation_NSData__cctor
Foundation_NSData__cctor:
.loc 20 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3896]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3888]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19a:
.text
	.align 4
	.no_dead_strip Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2__ctor_int
Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9001801
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19b:
.text
	.align 4
	.no_dead_strip Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_System_IDisposable_Dispose
Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19c:
.text
	.align 4
	.no_dead_strip Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_MoveNext
Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_MoveNext:
.loc 19 0 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801b59
.word 0xf9400b58
.word 0x340000d9
.word 0xd280003e
.word 0x6b1e033f
.word 0x54000340
.word 0xd2a00000
.word 0x14000022
.word 0x9280001e
.word 0xb9001b5e
.loc 19 63 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407430
.word 0xd63f0200
.word 0xf9001340
.loc 19 64 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407030
.word 0xd63f0200
.word 0xf9001740
.loc 19 66 0
.word 0xf9001b5f
.word 0x1400000f
.loc 19 67 0
.word 0xf9401340
.word 0xf9401b41
.word 0x93407c21
bl _p_340
.word 0x39007340
.word 0xd280003e
.word 0xb9001b5e
.word 0xd2800020
.word 0x1400000b
.word 0x9280001e
.word 0xb9001b5e
.loc 19 66 0
.word 0xf9401b59
.word 0x91000720
.word 0xf9001b40
.word 0xf9401b40
.word 0xf9401741
.word 0xeb01001f
.word 0x54fffde3
.loc 19 68 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_19d:
.text
	.align 4
	.no_dead_strip Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_System_Collections_Generic_IEnumerator_System_Byte_get_Current
Foundation_NSData__System_Collections_Generic_IEnumerable_System_Byte_GetEnumeratord__2_System_Collections_Generic_IEnumerator_System_Byte_get_Current:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39407000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_19e:
.text
	.align 4
	.no_dead_strip Foundation_NSDate_get_ClassHandle
Foundation_NSDate_get_ClassHandle:
.file 21 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSDate.g.cs"
.loc 21 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3904]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_19f:
.text
	.align 4
	.no_dead_strip Foundation_NSDate__ctor
Foundation_NSDate__ctor:
.loc 21 61 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 21 64 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1888]
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_311
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1a0:
.text
	.align 4
	.no_dead_strip Foundation_NSDate__ctor_ObjCRuntime_NativeHandle
Foundation_NSDate__ctor_ObjCRuntime_NativeHandle:
.loc 21 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 21 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1a1:
.text
	.align 4
	.no_dead_strip Foundation_NSDate_Copy_Foundation_NSZone
Foundation_NSDate_Copy_Foundation_NSZone:
.loc 21 142 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 21 145 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 21 149 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 21 150 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 21 151 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1a2:
.text
	.align 4
	.no_dead_strip Foundation_NSDate__cctor
Foundation_NSDate__cctor:
.loc 21 45 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3912]
bl _p_290
.word 0xf9001fa0
.word 0xd2a00001
bl _p_341
.word 0xf9401fa0
.word 0xf9001ba0
.word 0xf90017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3920]
bl _p_342
.word 0xaa0003e1
.word 0xf9401ba2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406c50
.word 0xd63f0200
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3928]
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000001
.loc 21 55 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3936]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3904]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1a3:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__ctor_Foundation_NSObject_Foundation_NSObject_Foundation_NSObject__
Foundation_NSDictionary__ctor_Foundation_NSObject_Foundation_NSObject_Foundation_NSObject__:
.file 22 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSDictionary.cs"
.loc 22 36 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xf94017a1
bl _p_343
.word 0xf9001ba0
.word 0xf9400fa0
.word 0xf94017a1
bl _p_344
.word 0xaa0003e2
.word 0xf9401ba1
.word 0xf9400ba0
bl _p_345
.loc 22 38 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1a4:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_PickEven_Foundation_NSObject_Foundation_NSObject__
Foundation_NSDictionary_PickEven_Foundation_NSObject_Foundation_NSObject__:
.loc 22 50 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801b40
.word 0xaa0003f8
.loc 22 51 0
.word 0x531f7c01
.word 0xb010000
.word 0xd280003e
.word 0x8a1e0000
.word 0x4b010000
.word 0x35000680
.loc 22 53 0
.word 0x531f7f00
.word 0xb180000
.word 0x13017c00
.word 0x11000401

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3944]
bl _p_42
.word 0xaa0003f7
.loc 22 54 0
.word 0xaa1703e3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xaa1903e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.loc 22 55 0
.word 0xd2a00019
.word 0xd2800036
.word 0x14000017

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 22 56 0
.word 0xaa1603e1
.word 0x110006d6
.word 0x93407f20
.word 0xb9801b42
.word 0xeb00005f
.word 0x10000011
.word 0x540004a9
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400002
.word 0xaa1703e0
.word 0xf94002e3
.word 0xf9404070
.word 0xd63f0200
.loc 22 55 0
.word 0x11000b39
.word 0x6b18033f
.word 0x54fffd2b
.loc 22 57 0
.word 0xaa1703e0
bl _p_346
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.loc 22 52 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a03a1
bl _p_11
.word 0xf90023a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a1221
bl _p_11
.word 0xaa0003e2
.word 0xf94023a1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_2
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1a5:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_PickOdd_Foundation_NSObject_Foundation_NSObject__
Foundation_NSDictionary_PickOdd_Foundation_NSObject_Foundation_NSObject__:
.loc 22 62 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9801b41
.word 0x531f7c20
.word 0xb010000
.word 0x13017c00
.word 0x11000401

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3944]
bl _p_42
.word 0xaa0003f8
.loc 22 63 0
.word 0xaa1803e3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xaa1903e2
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.loc 22 64 0
.word 0xd2800039
.word 0xd2800037
.word 0x14000017

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 22 65 0
.word 0xaa1703e1
.word 0x110006f7
.word 0x93407f20
.word 0xb9801b42
.word 0xeb00005f
.word 0x10000011
.word 0x54000289
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400002
.word 0xaa1803e0
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.loc 22 64 0
.word 0x11000b39
.word 0xb9801b40
.word 0x6b00033f
.word 0x54fffd0b
.loc 22 66 0
.word 0xaa1803e0
bl _p_346
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1a6:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_CopyTo_System_Collections_Generic_KeyValuePair_2_Foundation_NSObject_Foundation_NSObject___int
Foundation_NSDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_CopyTo_System_Collections_Generic_KeyValuePair_2_Foundation_NSObject_Foundation_NSObject___int:
.loc 22 209 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb4001299
.loc 22 211 0
.word 0x6b1f035f
.word 0x54000e8b
.loc 22 214 0
.word 0xb9801b20
.word 0x6b00035f
.word 0x54000f6c
.loc 22 216 0
.word 0xb9801b20
.word 0x4b1a0000
.word 0xf90023a0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94023a0
.word 0x93407c21
.word 0x6b01001f
.word 0x54000f2b
.loc 22 219 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3952]
.word 0xd2800701
bl _p_3
.word 0xb900301f
.word 0xf90023a0
.word 0x91008001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000038
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0003f8
.word 0x1400003f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 22 221 0
.word 0xaa1a03e0
.word 0xf90027a0
.word 0x1100075a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3960]
.word 0x9100a3a0
.word 0xf9001fa0
.word 0xaa1803e0
.word 0xf9400301

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3968]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf90007c1
.word 0xf94027a0
.word 0x93407c00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000ae9
.word 0xd37cec00
.word 0x8b000320
.word 0x91008000
.word 0xf90023a0
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf94017a1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 22 220 0
.word 0xaa1803e0
.word 0xf9400301

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff720
.loc 22 222 0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.loc 22 212 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a14e1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 22 215 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a1661
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 22 217 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a2221
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.loc 22 210 0
.word 0xd28a1361
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1a7:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Count
Foundation_NSDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Count:
.loc 22 230 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1a8:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_GetEnumerator
Foundation_NSDictionary_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3952]
.word 0xd2800701
bl _p_3
.word 0xb900301f
.word 0xf90013a0
.word 0x91008002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400ba1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1a9:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_get_ClassHandle
Foundation_NSDictionary_get_ClassHandle:
.file 23 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSDictionary.g.cs"
.loc 23 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3976]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1aa:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__ctor_ObjCRuntime_NativeHandle
Foundation_NSDictionary__ctor_ObjCRuntime_NativeHandle:
.loc 23 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 23 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1ab:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__ctor_Foundation_NSArray_Foundation_NSArray
Foundation_NSDictionary__ctor_Foundation_NSArray_Foundation_NSArray:
.loc 23 145 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 23 147 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3984]
.word 0x9100e3a0
.word 0xf90027a0
.word 0xf9400fa0
bl _p_278
.word 0xf94027be
.word 0xf90003c0
.loc 23 148 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3992]
.word 0x9100c3a0
.word 0xf90027a0
.word 0xf94013a0
bl _p_278
.word 0xf94027be
.word 0xf90003c0
.loc 23 150 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_11@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_11@PAGEOFF
ldr x1, [x1]
.word 0x9100a3a2
.word 0xf90027a2
.word 0xf9401fa2
.word 0xf9401ba3
bl _p_347
.word 0xf94027be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #4000]
.word 0xf9400ba0
.word 0xf94017a1
bl _p_311
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1ac:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_Copy_Foundation_NSZone
Foundation_NSDictionary_Copy_Foundation_NSZone:
.loc 23 198 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 23 201 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 23 205 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 23 206 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 23 207 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1ad:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_ObjectForKey_Foundation_NSObject
Foundation_NSDictionary_ObjectForKey_Foundation_NSObject:
.loc 23 359 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4008]
.word 0x9100a3a0
.word 0xf9001fa0
.word 0xf9400fa0
bl _p_278
.word 0xf9401fbe
.word 0xf90003c0
.loc 23 361 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_12@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_12@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf9001fa2
.word 0xf94017a2
bl _p_313
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1ae:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__AllKeys
Foundation_NSDictionary__AllKeys:
.loc 23 428 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_13@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_13@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1af:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__ObjectForKey_intptr
Foundation_NSDictionary__ObjectForKey_intptr:
.loc 23 455 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_12@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_12@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa2
bl _p_348
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1b0:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_get_Count
Foundation_NSDictionary_get_Count:
.loc 23 467 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_1@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_1@PAGEOFF
ldr x1, [x1]
bl _p_302
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1b1:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_get_Keys
Foundation_NSDictionary_get_Keys:
.loc 23 488 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4016]
bl _p_290
.word 0xf90033a0
bl _p_349
.word 0xf94033a0
.word 0xf9001ba0
.loc 23 491 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_13@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_13@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf9001fa2
bl _p_350
.word 0xf9401fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #4024]
.word 0xf94013a0
bl _p_351
.word 0xaa0003fa
.loc 23 495 0
.word 0xf90023ba
.word 0xf90027bf
.word 0x94000005
.word 0xf94027a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9002bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401ba0
.word 0xb4000140
.word 0xf9401ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9402bbe
.word 0xd61f03c0
.loc 23 497 0
.word 0xf94023a0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_1b2:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__cctor
Foundation_NSDictionary__cctor:
.loc 23 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4032]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3976]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1b3:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__GetEnumeratord__64__ctor_int
Foundation_NSDictionary__GetEnumeratord__64__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9003001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1b4:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__GetEnumeratord__64_System_IDisposable_Dispose
Foundation_NSDictionary__GetEnumeratord__64_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1b5:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__GetEnumeratord__64_MoveNext
Foundation_NSDictionary__GetEnumeratord__64_MoveNext:
.loc 22 0 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9803359
.word 0xf9401358
.word 0x340000d9
.word 0xd280003e
.word 0x6b1e033f
.word 0x54000ea0
.word 0xd2a00000
.word 0x1400007f
.word 0x9280001e
.word 0xb900335e
.loc 22 397 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407830
.word 0xd63f0200
.word 0xf9002ba0
.word 0x9100a341
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xb900375f
.word 0x14000061
.word 0xf9401740
.word 0xb9803741
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000d29
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400019
.loc 22 398 0
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xf9400302
.word 0xf9408050
.word 0xd63f0200
.word 0xf9002fa0
.word 0xd2800000
.word 0xf9001fa0
.word 0xf90023a0
.word 0x9100e3a0
.word 0xf90033a0
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9001fb9
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0x9100e3a0
.word 0x91002001
.word 0xd5033bbf
.word 0xf9402fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf9401fa0
.word 0xf90017a0
.word 0xf94023a0
.word 0xf9001ba0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000680
.word 0x91004342
.word 0xaa0203e0
.word 0xf9002ba0
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf94017a1
.word 0xf9000041
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xd280003e
.word 0xb900335e
.word 0xd2800020
.word 0x1400000d
.word 0x9280001e
.word 0xb900335e
.word 0xb9803740
.word 0x11000400
.word 0xb9003740
.loc 22 397 0
.word 0xb9803740
.word 0xf9401742
.word 0xb9801841
.word 0x6b01001f
.word 0x54fff38b
.word 0xf900175f
.loc 22 400 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1b6:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary__GetEnumeratord__64_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Current
Foundation_NSDictionary__GetEnumeratord__64_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Current:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400001
.word 0xf9000ba1
.word 0xf9400400
.word 0xf9000fa0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1b7:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF__ctor_ObjCRuntime_NativeHandle
Foundation_NSDictionary_2_TKey_REF_TValue_REF__ctor_ObjCRuntime_NativeHandle:
.file 24 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSDictionary_2.cs"
.loc 24 67 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_352
.loc 24 69 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1b8:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF_ObjectForKey_TKey_REF
Foundation_NSDictionary_2_TKey_REF_TValue_REF_ObjectForKey_TKey_REF:
.loc 24 109 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4040]
.word 0xf94017a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400fa0
.word 0xb4000340
.loc 24 112 0
.word 0xf9400ba0
.word 0xf90023a0
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3416]
.word 0x928012f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9401bbe
.word 0xf90003c0
.word 0xf94023a0
.word 0xf94013a1
bl _p_353
.word 0xf94017a1
.word 0xf940182f
.word 0xd2a00001
bl _p_354
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.loc 24 110 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a3921
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_1b9:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF_get_Keys
Foundation_NSDictionary_2_TKey_REF_TValue_REF_get_Keys:
.loc 24 117 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4048]
.word 0xf94017a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9001bbf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4016]
bl _p_290
.word 0xf90033a0
bl _p_349
.word 0xf94033a0
.word 0xf9001ba0
.loc 24 118 0
.word 0xf9400ba0
bl _p_355
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0
.word 0xf94017a0
.word 0xf940100f
.word 0xf9400fa0
bl _p_356
.word 0xf9001fa0
.word 0xf90023bf
.word 0x94000005
.word 0xf94023a0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90027be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401ba0
.word 0xb4000140
.word 0xf9401ba1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94027be
.word 0xd61f03c0
.loc 24 119 0
.word 0xf9401fa0
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_1ba:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue_CopyTo_System_Collections_Generic_KeyValuePair_2_TKey_REF_TValue_REF___int
Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue_CopyTo_System_Collections_Generic_KeyValuePair_2_TKey_REF_TValue_REF___int:
.loc 24 326 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf9001baf
.word 0xf90017a0
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4056]
.word 0xf9401ba0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf90027bf
.word 0xd2800000
.word 0xf9001fa0
.word 0xf90023a0
.word 0xb4001459
.loc 24 328 0
.word 0x6b1f035f
.word 0x5400104b
.loc 24 330 0
.word 0xb9801b20
.word 0xaa0003f8
.loc 24 331 0
.word 0x6b1f001f
.word 0x5400006d
.word 0x6b18035f
.word 0x540010ca
.loc 24 333 0
.word 0xf94017a1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0x93407c00
.word 0xb000340
.word 0x6b18001f
.word 0x540010ec
.loc 24 336 0
.word 0xaa1a03f8
.loc 24 337 0
.word 0xf94017a1
.word 0xf9401ba0
.word 0xf940100f
.word 0xf9401ba0
.word 0xf940140f
.word 0xaa0103e0
.word 0xf9400021
.word 0x928008f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf90027a0
.word 0x1400003c

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94027a1
.word 0xf9401ba0
.word 0xf940180f
.word 0xf9401ba0
.word 0xf9401c0f
.word 0x9100e3a0
.word 0xf9002ba0
.word 0xaa0103e0
.word 0xf9400021
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9402bbe
.word 0xf90003c0
.word 0xf90007c1
.loc 24 338 0
.word 0xaa1803e0
.word 0x11000718
.word 0x93407c00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000e49
.word 0xd37cec00
.word 0x8b000320
.word 0x91008000
.word 0xf9003ba0
.word 0xd5033bbf
.word 0xf9403ba0
.word 0xf9401fa1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 24 337 0
.word 0xf94027a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff760
.word 0xf9002fbf
.word 0x94000005
.word 0xf9402fa0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf90033be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94027a0
.word 0xb4000140
.word 0xf94027a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf94033be
.word 0xd61f03c0
.loc 24 339 0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.loc 24 329 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a42e1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 24 332 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a45a1
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 24 334 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a52a1
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.loc 24 327 0
.word 0xd28a1361
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1bb:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue_get_Count
Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue_get_Count:
.loc 24 348 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_357
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1bc:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumerator
Foundation_NSDictionary_2_TKey_REF_TValue_REF_System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4064]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400fa0
.word 0xf9401000
.word 0xd2800701
bl _p_3
.word 0xb900301f
.word 0xf9400ba1
.word 0xf90013a0
.word 0x91008002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1bd:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF__ctor_int
Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF__ctor_int:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013af
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xb9801ba1
.word 0xb9003001
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1be:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_System_IDisposable_Dispose
Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1bf:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_MoveNext
Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_MoveNext:
.loc 24 0 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90027af
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #4072]
.word 0xf94027a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf94013a0
.word 0xb980301a
.word 0xf94013a0
.word 0xf9401019
.word 0x340000da
.word 0xd280003e
.word 0x6b1e035f
.word 0x54001000
.word 0xd2a00000
.word 0x14000090
.word 0xf94013a0
.word 0x9280001e
.word 0xb900301e
.loc 24 362 0
.word 0xf94013a0
.word 0xf9002fa0
.word 0xf94027a0
.word 0xf940100f
.word 0xaa1903e0
bl _p_358
.word 0xaa0003e1
.word 0xf9402fa0
.word 0xf9002ba1
.word 0x9100a001
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94013a0
.word 0xb900341f
.word 0x14000069
.word 0xf94013a0
.word 0xf9401400
.word 0xf94013a1
.word 0xb9803421
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000e29
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf940001a
.loc 24 363 0
.word 0xf94013a0
.word 0xf9002fa0
.word 0xf94027a0
.word 0xf940140f
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_359
.word 0xaa0003e1
.word 0xd2800000
.word 0xf9001fa0
.word 0xf90023a0
.word 0x9100e3a0
.word 0xf90033a0
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9001fba
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020000
.word 0xd280003e
.word 0x3900001e
.word 0x9100e3a0
.word 0x91002002
.word 0xd5033bbf
.word 0xf9402fa0
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0xf9401fa1
.word 0xf90017a1
.word 0xf94023a1
.word 0xf9001ba1
.word 0xeb1f001f
.word 0x10000011
.word 0x54000740
.word 0x91004002
.word 0xaa0203e0
.word 0xf9002ba0
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf94017a1
.word 0xf9000041
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94013a0
.word 0xd280003e
.word 0xb900301e
.word 0xd2800020
.word 0x14000013
.word 0xf94013a0
.word 0x9280001e
.word 0xb900301e
.word 0xf94013a0
.word 0xf94013a1
.word 0xb9803421
.word 0x11000421
.word 0xb9003401
.loc 24 362 0
.word 0xf94013a0
.word 0xb9803400
.word 0xf94013a1
.word 0xf9401422
.word 0xb9801841
.word 0x6b01001f
.word 0x54fff24b
.word 0xf94013a0
.word 0xf900141f
.loc 24 365 0
.word 0xd2a00000
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1c0:
.text
	.align 4
	.no_dead_strip Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_TKey_TValue_get_Current
Foundation_NSDictionary_2__System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_TKey_TValue_GetEnumeratord__47_TKey_REF_TValue_REF_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_TKey_TValue_get_Current:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf90013a0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400001
.word 0xf9000ba1
.word 0xf9400400
.word 0xf9000fa0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1c1:
.text
	.align 4
	.no_dead_strip Foundation_NSError_ToString
Foundation_NSError_ToString:
.file 25 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSError.cs"
.loc 25 67 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9406c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1c2:
.text
	.align 4
	.no_dead_strip Foundation_NSError_get_ClassHandle
Foundation_NSError_get_ClassHandle:
.file 26 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSError.g.cs"
.loc 26 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4080]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1c3:
.text
	.align 4
	.no_dead_strip Foundation_NSError__ctor_ObjCRuntime_NativeHandle
Foundation_NSError__ctor_ObjCRuntime_NativeHandle:
.loc 26 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 26 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1c4:
.text
	.align 4
	.no_dead_strip Foundation_NSError_Copy_Foundation_NSZone
Foundation_NSError_Copy_Foundation_NSZone:
.loc 26 101 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 26 104 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 26 108 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 26 109 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 26 110 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1c5:
.text
	.align 4
	.no_dead_strip Foundation_NSError_get_LocalizedDescription
Foundation_NSError_get_LocalizedDescription:
.loc 26 246 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_14@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_14@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1c6:
.text
	.align 4
	.no_dead_strip Foundation_NSError__cctor
Foundation_NSError__cctor:
.loc 26 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4088]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #4080]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1c7:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF__ctor_Foundation_NSObject
Foundation_NSFastEnumerator_1_T_REF__ctor_Foundation_NSObject:
.file 27 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSFastEnumerator.cs"
.loc 27 34 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf90013af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 27 47 0
.word 0xf9400ba0
.word 0xf9001ba0
.word 0xd2801800
bl _p_300
.word 0xaa0003e1
.word 0xf9401ba0
.word 0xf9000c01
.loc 27 49 0
.word 0xf9400ba0
.word 0xf9400c00
.word 0xd2a00001
.word 0xd2801802
bl _p_361
.loc 27 51 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1c9:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF_Fetch
Foundation_NSFastEnumerator_1_T_REF_Fetch:
.loc 27 56 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf90013af
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9001ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_15@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_15@PAGEOFF
ldr x1, [x1]
.word 0xf9400ba2
.word 0xf9400c42
.word 0xf9400ba3
.word 0xf9400c63
.word 0xeb1f007f
.word 0x10000011
.word 0x54000300
.word 0x91010063
.word 0xd2800204
bl _p_362
.word 0xaa0003e1
.word 0xf9401ba0
.word 0xf9001001
.loc 27 57 0
.word 0xf9400ba0
.word 0x3940e000
.word 0x35000140
.loc 27 58 0
.word 0xf9400ba0
.word 0xd280003e
.word 0x3900e01e
.loc 27 59 0
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400c21
.word 0xf9400821
.word 0xf9400021
.word 0xf9001401
.loc 27 62 0
.word 0xf9400ba0
.word 0xf900181f
.loc 27 63 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_1ca:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF_VerifyNonMutated
Foundation_NSFastEnumerator_1_T_REF_VerifyNonMutated:
.loc 27 67 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9401400
.word 0xf9400ba1
.word 0xf9400c21
.word 0xf9400821
.word 0xf9400021
.word 0xeb01001f
.word 0x54000081
.loc 27 69 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.loc 27 68 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a75c1
bl _p_11
.word 0xaa0003e1
.word 0xd2801340
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0x17fffff3

Lme_1cb:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF_System_Collections_IEnumerator_MoveNext
Foundation_NSFastEnumerator_1_T_REF_System_Collections_IEnumerator_MoveNext:
.loc 27 74 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #0]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400ba0
.word 0x3940e000
.word 0x34000100
.word 0xf9400ba0
.word 0xf9401800
.word 0xf9400ba1
.word 0xf9401021
.word 0xd1000421
.word 0xeb01001f
.word 0x54000141
.loc 27 75 0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf940102f
bl _p_363
.loc 27 76 0
.word 0xf9400ba0
.word 0xf9401000
.word 0xb5000100
.loc 27 77 0
.word 0xd2a00000
.word 0x1400000b
.loc 27 79 0
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9401821
.word 0x91000421
.word 0xf9001801
.loc 27 81 0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf940142f
bl _p_364
.loc 27 82 0
.word 0xd2800020
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1cc:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF_System_IDisposable_Dispose
Foundation_NSFastEnumerator_1_T_REF_System_IDisposable_Dispose:
.loc 27 105 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400c00
bl _p_298
.loc 27 106 0
.word 0xf9400ba0
.word 0xd2a00001
.word 0x2a0103e1
.word 0xf9000c01
.loc 27 108 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1cd:
.text
	.align 4
	.no_dead_strip Foundation_NSFastEnumerator_1_T_REF_get_Current
Foundation_NSFastEnumerator_1_T_REF_get_Current:
.loc 27 116 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #8]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400ba0
.word 0xf9400c00
.word 0xf9400400
.word 0xf9400ba1
.word 0xf9401821
.word 0x93407c21
.word 0x93407c21
.word 0xd37df021
.word 0x8b010000
.word 0xf9400000
.word 0xf9400fa1
.loc 27 118 0
.word 0xf940182f
.word 0xd2a00001
bl _p_365
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1ce:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableArray_1_TValue_REF__ctor_ObjCRuntime_NativeHandle
Foundation_NSMutableArray_1_TValue_REF__ctor_ObjCRuntime_NativeHandle:
.file 28 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSMutableArray_1.cs"
.loc 28 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_366
.loc 28 58 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1cf:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableArray_1_TValue_REF_GetEnumerator
Foundation_NSMutableArray_1_TValue_REF_GetEnumerator:
.loc 28 190 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf9400fa0
.word 0xf9401000
.word 0xd2800801
bl _p_3
.word 0xf94017a1
.word 0xf9400fa2
.word 0xf940144f
.word 0xf90013a0
bl _p_367
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1d0:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_CopyTo_System_Collections_Generic_KeyValuePair_2_Foundation_NSObject_Foundation_NSObject___int
Foundation_NSMutableDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_CopyTo_System_Collections_Generic_KeyValuePair_2_Foundation_NSObject_Foundation_NSObject___int:
.file 29 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSMutableDictionary.cs"
.loc 29 125 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb4001299
.loc 29 127 0
.word 0x6b1f035f
.word 0x54000e8b
.loc 29 130 0
.word 0xb9801b20
.word 0x6b00035f
.word 0x54000f6c
.loc 29 132 0
.word 0xb9801b20
.word 0x4b1a0000
.word 0xf90023a0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf94023a0
.word 0x93407c21
.word 0x6b01001f
.word 0x54000f2b
.loc 29 135 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #24]
.word 0xd2800701
bl _p_3
.word 0xb900301f
.word 0xf90023a0
.word 0x91008001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000038
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0003f8
.word 0x1400003f

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 29 137 0
.word 0xaa1a03e0
.word 0xf90027a0
.word 0x1100075a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3960]
.word 0x9100a3a0
.word 0xf9001fa0
.word 0xaa1803e0
.word 0xf9400301

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #3968]
.word 0x92800af0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf90007c1
.word 0xf94027a0
.word 0x93407c00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000ae9
.word 0xd37cec00
.word 0x8b000320
.word 0x91008000
.word 0xf90023a0
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf94017a1
.word 0xf9000001
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 29 136 0
.word 0xaa1803e0
.word 0xf9400301

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1072]
.word 0x92800ef0
.word 0xf8706830
.word 0xd63f0200
.word 0x53001c00
.word 0x35fff720
.loc 29 138 0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.loc 29 128 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a14e1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 29 131 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a1661
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 29 133 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a2221
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.loc 29 126 0
.word 0xd28a1361
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1d1:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Count
Foundation_NSMutableDictionary_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Count:
.loc 29 148 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1d2:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary_GetEnumerator
Foundation_NSMutableDictionary_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #24]
.word 0xd2800701
bl _p_3
.word 0xb900301f
.word 0xf90013a0
.word 0x91008002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400ba1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1d3:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary_get_ClassHandle
Foundation_NSMutableDictionary_get_ClassHandle:
.file 30 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSMutableDictionary.g.cs"
.loc 30 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #32]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1d4:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__ctor_ObjCRuntime_NativeHandle
Foundation_NSMutableDictionary__ctor_ObjCRuntime_NativeHandle:
.loc 30 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_352
.loc 30 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1d5:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__cctor
Foundation_NSMutableDictionary__cctor:
.loc 30 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #40]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #32]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1d6:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__GetEnumeratord__46__ctor_int
Foundation_NSMutableDictionary__GetEnumeratord__46__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9003001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1d7:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__GetEnumeratord__46_System_IDisposable_Dispose
Foundation_NSMutableDictionary__GetEnumeratord__46_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1d8:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__GetEnumeratord__46_MoveNext
Foundation_NSMutableDictionary__GetEnumeratord__46_MoveNext:
.loc 29 0 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9803359
.word 0xf9401358
.word 0x340000d9
.word 0xd280003e
.word 0x6b1e033f
.word 0x54000ea0
.word 0xd2a00000
.word 0x1400007f
.word 0x9280001e
.word 0xb900335e
.loc 29 313 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407830
.word 0xd63f0200
.word 0xf9002ba0
.word 0x9100a341
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xb900375f
.word 0x14000061
.word 0xf9401740
.word 0xb9803741
.word 0x93407c21
.word 0xb9801802
.word 0xeb01005f
.word 0x10000011
.word 0x54000d29
.word 0xd37df021
.word 0x8b010000
.word 0x91008000
.word 0xf9400019
.loc 29 314 0
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xf9400302
.word 0xf9408050
.word 0xd63f0200
.word 0xf9002fa0
.word 0xd2800000
.word 0xf9001fa0
.word 0xf90023a0
.word 0x9100e3a0
.word 0xf90033a0
.word 0xd5033bbf
.word 0xf94033a0
.word 0xf9001fb9
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0x9100e3a0
.word 0x91002001
.word 0xd5033bbf
.word 0xf9402fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf9401fa0
.word 0xf90017a0
.word 0xf94023a0
.word 0xf9001ba0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000680
.word 0x91004342
.word 0xaa0203e0
.word 0xf9002ba0
.word 0xd5033bbf
.word 0xf9402ba0
.word 0xf94017a1
.word 0xf9000041
.word 0xd349fc02
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x91002001
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xd280003e
.word 0xb900335e
.word 0xd2800020
.word 0x1400000d
.word 0x9280001e
.word 0xb900335e
.word 0xb9803740
.word 0x11000400
.word 0xb9003740
.loc 29 313 0
.word 0xb9803740
.word 0xf9401742
.word 0xb9801841
.word 0x6b01001f
.word 0x54fff38b
.word 0xf900175f
.loc 29 316 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_1d9:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableDictionary__GetEnumeratord__46_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Current
Foundation_NSMutableDictionary__GetEnumeratord__46_System_Collections_Generic_IEnumerator_System_Collections_Generic_KeyValuePair_Foundation_NSObject_Foundation_NSObject_get_Current:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400001
.word 0xf9000ba1
.word 0xf9400400
.word 0xf9000fa0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1da:
.text
	.align 4
	.no_dead_strip Foundation_NSNull_get_Null
Foundation_NSNull_get_Null:
.file 31 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSNull.cs"
.loc 31 11 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #48]
.word 0xf9400000
.word 0xb5000140
.loc 31 12 0
bl _p_368
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #48]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 31 13 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #48]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1db:
.text
	.align 4
	.no_dead_strip Foundation_NSNull_get_ClassHandle
Foundation_NSNull_get_ClassHandle:
.file 32 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSNull.g.cs"
.loc 32 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1dc:
.text
	.align 4
	.no_dead_strip Foundation_NSNull__ctor_ObjCRuntime_NativeHandle
Foundation_NSNull__ctor_ObjCRuntime_NativeHandle:
.loc 32 90 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 32 92 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1dd:
.text
	.align 4
	.no_dead_strip Foundation_NSNull_Copy_Foundation_NSZone
Foundation_NSNull_Copy_Foundation_NSZone:
.loc 32 99 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 32 102 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 32 106 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 32 107 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 32 108 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_1de:
.text
	.align 4
	.no_dead_strip Foundation_NSNull_get__Null
Foundation_NSNull_get__Null:
.loc 32 142 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_16@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_16@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90013a2
bl _p_350
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #64]
bl _p_369
.loc 32 143 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1df:
.text
	.align 4
	.no_dead_strip Foundation_NSNull__cctor
Foundation_NSNull__cctor:
.loc 32 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #72]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e0:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_ToString
Foundation_NSNumber_ToString:
.file 33 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSNumber2.cs"
.loc 33 160 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e1:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_CompareTo_object
Foundation_NSNumber_CompareTo_object:
.loc 33 165 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013b8
.word 0xf94013a0
.word 0xeb1f001f
.word 0x54000180
.word 0xf94013a0
.word 0xf9400000
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #80]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xf9400fa0
.word 0xaa1803e1
bl _p_370
.word 0x93407c00
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1e2:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_CompareTo_Foundation_NSNumber
Foundation_NSNumber_CompareTo_Foundation_NSNumber:
.loc 33 172 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb4000160
.loc 33 174 0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9408450
.word 0xd63f0200
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.loc 33 173 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a8281
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_1e3:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_Equals_object
Foundation_NSNumber_Equals_object:
.loc 33 180 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013b8
.word 0xf94013a0
.word 0xeb1f001f
.word 0x54000180
.word 0xf94013a0
.word 0xf9400000
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #80]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xf9400fa0
.word 0xaa1803e1
bl _p_371
.word 0x53001c00
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1e4:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_Equals_Foundation_NSNumber
Foundation_NSNumber_Equals_Foundation_NSNumber:
.loc 33 186 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb5000060
.loc 33 187 0
.word 0xd2a00000
.word 0x14000008
.loc 33 188 0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9408050
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e5:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_GetHashCode
Foundation_NSNumber_GetHashCode:
.loc 33 197 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9402830
.word 0xd63f0200
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e6:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_get_ClassHandle
Foundation_NSNumber_get_ClassHandle:
.file 34 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSNumber.g.cs"
.loc 34 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #88]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1e7:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber__ctor_ObjCRuntime_NativeHandle
Foundation_NSNumber__ctor_ObjCRuntime_NativeHandle:
.loc 34 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_372
.loc 34 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1e8:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_Compare_Foundation_NSNumber
Foundation_NSNumber_Compare_Foundation_NSNumber:
.loc 34 242 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #96]
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_278
.word 0xf9401bbe
.word 0xf90003c0
.loc 34 244 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_17@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_17@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_373
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1e9:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_IsEqualToNumber_Foundation_NSNumber
Foundation_NSNumber_IsEqualToNumber_Foundation_NSNumber:
.loc 34 354 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #104]
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_278
.word 0xf9401bbe
.word 0xf90003c0
.loc 34 357 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_18@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_18@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_374
.word 0x53001c00
.word 0x53001c00
.loc 34 361 0
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1ea:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber_get_StringValue
Foundation_NSNumber_get_StringValue:
.loc 34 520 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_19@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_19@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1eb:
.text
	.align 4
	.no_dead_strip Foundation_NSNumber__cctor
Foundation_NSNumber__cctor:
.loc 34 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3064]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #88]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1ec:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_flags
Foundation_NSObject_get_flags:
.file 35 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSObject2.cs"
.loc 35 125 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xf9401740
.word 0xd2a00001
.word 0x2a0103e1
.word 0xeb01001f
.word 0x54000180
.word 0xf9401740
.word 0x39402000
.word 0xd280021e
.word 0xa1e0000
.word 0xd280021e
.word 0x6b1e001f
.word 0x540000a1
.loc 35 126 0
.word 0x39408340
.word 0xd280021e
.word 0x2a1e0000
.word 0x39008340
.loc 35 128 0
.word 0x39408340
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1ed:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_flags_Foundation_NSObject_Flags
Foundation_NSObject_set_flags_Foundation_NSObject_Flags:
.loc 35 131 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39008001
.loc 35 133 0
.word 0xf9401400
.word 0xd2a00001
.word 0x2a0103e1
.word 0xeb01001f
.word 0x540000a0
.loc 35 134 0
.word 0xf9400ba0
.word 0xf9401400
.word 0x394063a1
.word 0x39002001
.loc 35 135 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1ee:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_disposed
Foundation_NSObject_get_disposed:
.loc 35 167 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_375
.word 0x53001c00
.word 0xd280003e
.word 0xa1e0000
.word 0xd280003e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1ef:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_disposed_bool
Foundation_NSObject_set_disposed_bool:
.loc 35 168 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf90013a0
.word 0x350000fa
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd2801fde
.word 0xa1e001a
.word 0x14000006
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd280003e
.word 0x2a1e001a
.word 0xf94013a0
.word 0xaa1a03e1
bl _p_376
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1f0:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_HasManagedRef_bool
Foundation_NSObject_set_HasManagedRef_bool:
.loc 35 173 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf90013a0
.word 0x350000fa
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd2801bfe
.word 0xa1e001a
.word 0x14000006
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd280041e
.word 0x2a1e001a
.word 0xf94013a0
.word 0xaa1a03e1
bl _p_376
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1f1:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_IsRegisteredToggleRef
Foundation_NSObject_get_IsRegisteredToggleRef:
.loc 35 177 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_375
.word 0x53001c00
.word 0xd280011e
.word 0xa1e0000
.word 0xd280011e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f2:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_IsRegisteredToggleRef_bool
Foundation_NSObject_set_IsRegisteredToggleRef_bool:
.loc 35 178 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf90013a0
.word 0x350000fa
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd2801efe
.word 0xa1e001a
.word 0x14000006
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd280011e
.word 0x2a1e001a
.word 0xf94013a0
.word 0xaa1a03e1
bl _p_376
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1f3:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_IsDirectBinding
Foundation_NSObject_get_IsDirectBinding:
.loc 35 182 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_375
.word 0x53001c00
.word 0xd280009e
.word 0xa1e0000
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f4:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_IsDirectBinding_bool
Foundation_NSObject_set_IsDirectBinding_bool:
.loc 35 183 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf90013a0
.word 0x350000fa
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd2801f7e
.word 0xa1e001a
.word 0x14000006
.word 0xf9400fa0
bl _p_375
.word 0x53001c00
.word 0xd280009e
.word 0x2a1e001a
.word 0xf94013a0
.word 0xaa1a03e1
bl _p_376
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1f5:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_InFinalizerQueue
Foundation_NSObject_get_InFinalizerQueue:
.loc 35 187 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_375
.word 0x53001c00
.word 0xd280021e
.word 0xa1e0000
.word 0xd280021e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f6:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_IsCustomType
Foundation_NSObject_get_IsCustomType:
.loc 35 192 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_375
.word 0x53001c00
.word 0xd280101e
.word 0xa1e0000
.word 0xd280101e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x53001c19
.loc 35 193 0
.word 0xaa1903e0
.word 0x350001e0
.loc 35 194 0
.word 0xf9400340
.word 0xf9400c00
bl _p_377
.word 0x53001c00
.word 0x53001c19
.loc 35 195 0
.word 0xaa1903e0
.word 0x34000100
.loc 35 196 0
.word 0xaa1a03e0
bl _p_375
.word 0x53001c00
.word 0xd280101e
.word 0x2a1e0001
.word 0xaa1a03e0
bl _p_376
.loc 35 198 0
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f7:
.text
	.align 4
	.no_dead_strip Foundation_NSObject__ctor
Foundation_NSObject__ctor:
.loc 35 205 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_378
.word 0x53001c00
.word 0x53001c01
.loc 35 206 0
.word 0xf9400ba0
bl _p_379
.loc 35 207 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f8:
.text
	.align 4
	.no_dead_strip Foundation_NSObject__ctor_Foundation_NSObjectFlag
Foundation_NSObject__ctor_Foundation_NSObjectFlag:
.loc 35 213 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_378
.word 0x53001c00
.word 0x53001c01
.loc 35 214 0
.word 0xf9400ba0
bl _p_379
.loc 35 215 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1f9:
.text
	.align 4
	.no_dead_strip Foundation_NSObject__ctor_ObjCRuntime_NativeHandle
Foundation_NSObject__ctor_ObjCRuntime_NativeHandle:
.loc 35 222 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xd2a00002
bl _p_380
.loc 35 224 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1fa:
.text
	.align 4
	.no_dead_strip Foundation_NSObject__ctor_ObjCRuntime_NativeHandle_bool
Foundation_NSObject__ctor_ObjCRuntime_NativeHandle_bool:
.loc 35 232 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000120
.word 0x91004001
.word 0xf9400fa2
.word 0xf9000022
.loc 35 233 0
.word 0x3940a3a1
bl _p_379
.loc 35 234 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_1fb:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Finalize
Foundation_NSObject_Finalize:
.loc 35 238 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba2
.word 0xaa0203e0
.word 0xd2a00001
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.word 0xf9000fbf
.word 0x94000005
.word 0xf9400fa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90017be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 35 239 0
.word 0xf9400ba0
.word 0xf90013a0
.word 0xf94017be
.word 0xd61f03c0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_1fc:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Dispose
Foundation_NSObject_Dispose:
.loc 35 243 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2800021
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9405450
.word 0xd63f0200
.loc 35 244 0
.word 0xf9400ba0
bl _p_381
.loc 35 245 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1fd:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_CreateNSObject_intptr_intptr_Foundation_NSObject_Flags
Foundation_NSObject_CreateNSObject_intptr_intptr_Foundation_NSObject_Flags:
.loc 35 256 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xaa0003f8
.word 0xf90013a1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90023bf
.word 0xf90027bf
.word 0xaa1803e0
bl _p_382
.word 0xaa0003f8
.word 0xb4000178
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #112]
.word 0xeb01001f
.word 0x10000011
.word 0x54000b21
.word 0xf90023b8
.loc 35 258 0
.word 0xf94023a0
bl _p_383
.word 0xaa0003f8
.word 0xb4000178
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #120]
.word 0xeb01001f
.word 0x10000011
.word 0x54000941
.word 0xf9001fbf
.word 0xf94013a0
.word 0xf9001fa0
.word 0xf9401fa0
.word 0xf9001ba0
.loc 35 259 0
.word 0xeb1f031f
.word 0x10000011
.word 0x540007e0
.word 0x91004300
.word 0xf9401ba1
.word 0xf9000001
.loc 35 260 0
.word 0xaa1803e0
.word 0x3940a3a1
.word 0x3940031e
bl _p_376
.loc 35 261 0
.word 0xaa1803e0
bl _p_105
.word 0xaa0003fa
.word 0x1400002e
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba0
.loc 35 262 0
.word 0xf90027a0
.loc 35 263 0
.word 0xf94027a0
.word 0xf90043a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a9241
bl _p_11
.word 0xf90047a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800021
bl _p_42
.word 0xf90033a0
.word 0xf94033a0
.word 0xf9004ba0
.word 0xf94033a0
.word 0xf9004fa0
.word 0xf94023a1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e2
.word 0xf9404fa3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf94043a1
.word 0xf94047a2
.word 0xf9404ba3
.word 0xd283ed20
bl _p_43
bl _p_13
.loc 35 265 0
.word 0xaa1a03e0
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_1fe:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_GetSuper
Foundation_NSObject_GetSuper:
.loc 35 269 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400f40

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3472]
.word 0xf9400021
.word 0xf9001fa1
.word 0xf9401fa1
.word 0xf90033a1
.word 0xf94033a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340002c0
.loc 35 273 0
.word 0xd2800200
bl _p_300
.word 0xaa0003f9
.loc 35 274 0
.word 0xd2800000
.word 0xf9000320
.word 0xf9000720
.loc 35 277 0
.word 0xeb1f035f
.word 0x10000011
.word 0x540006a0
.word 0x91006340
.word 0xd2800001
.word 0xc85f7c10
.word 0xeb01021f
.word 0x54000061
.word 0xc811fc19
.word 0x35ffff91
.word 0xd5033bbf
.word 0xaa1003e0
.loc 35 278 0
.word 0xb4000060
.loc 35 280 0
.word 0xaa1903e0
bl _p_298
.loc 35 286 0
.word 0xf9400f59
.loc 35 287 0
.word 0xaa1903e0
.word 0xf9400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3472]
.word 0xf9400021
.word 0xf9001ba1
.word 0xf9401ba1
.word 0xf9002fa1
.word 0xf9402fa1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000160
.loc 35 288 0
.word 0x910143a0
.word 0xf90037a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405030
.word 0xd63f0200
.word 0xf94037be
.word 0xf90003c0
.word 0xf9402ba0
.word 0xf9000720
.loc 35 289 0
.word 0x91004340
.word 0xf9400000
.word 0xf90027a0
.word 0xf94027a0
.word 0xf9000320
.loc 35 292 0
.word 0xf9400f40
.word 0xf90023bf
.word 0xf90023a0
.word 0xf94023a0
.word 0xf90013a0
.word 0xa9416bb9
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_1ff:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Initialize
Foundation_NSObject_Initialize:
.loc 35 297 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #128]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_200:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_Foundation_NSObject_RegisterToggleRef_Foundation_NSObject_intptr_bool
wrapper_managed_to_native_Foundation_NSObject_RegisterToggleRef_Foundation_NSObject_intptr_bool:
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #80]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_384

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #48]
.word 0xb9400000
.word 0x350001c0
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0x91022340
.word 0xd280003e
.word 0xb900001e
.word 0xaa1a03e0
bl _p_385
bl _p_386
.word 0xaa0003fa
.word 0xb5ffff20
.word 0x17fffff1

Lme_201:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_RegisterToggleReference_Foundation_NSObject_intptr_bool
Foundation_NSObject_RegisterToggleReference_Foundation_NSObject_intptr_bool:
.loc 35 323 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x394083a2
bl _p_387
.loc 35 328 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_203:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_MarkDirty
Foundation_NSObject_MarkDirty:
.loc 35 344 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_388
.loc 35 345 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_204:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_MarkDirty_bool
Foundation_NSObject_MarkDirty_bool:
.loc 35 349 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
bl _p_389
.word 0x53001c00
.word 0x35000220
.loc 35 352 0
.word 0x394063a0
.word 0x350000a0
.word 0xaa1903e0
bl _p_390
.word 0x53001c00
.word 0x35000160
.loc 35 355 0
.word 0xaa1903e0
.word 0xd2800021
bl _p_391
.loc 35 356 0
.word 0x91004320
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a1
.word 0xaa1903e0
.word 0x394063a2
bl _p_392
.loc 35 357 0
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_205:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_InitializeObject_bool
Foundation_NSObject_InitializeObject_bool:
.loc 35 361 0 prologue_end
.word 0xd2804410
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa9007bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf900f3a0
.word 0xf900f7a0
.word 0xf900fba0
.word 0xf900ffa0
.word 0xf90103a0
.word 0x34003d7a
.word 0x91004320
.word 0xf9400000
.word 0xf90063a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9005fa0
.word 0xf94063a0
.word 0xf900efa0
.word 0xf9405fa0
.word 0xf900eba0
.word 0xf940efa0
.word 0xf940eba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34003b20

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #136]
.word 0x39400000
.word 0x34003a80
.loc 35 362 0
.word 0x9102c3a0
.word 0xf90107a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405030
.word 0xd63f0200
.word 0xf94107be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90057a0
.word 0xf9405ba0
.word 0xf900e7a0
.word 0xf94057a0
.word 0xf900e3a0
.word 0xf940e7a0
.word 0xf940e3a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x350042e0
.word 0x14000202
.word 0xaa1803f7
.word 0xeb1f035f
.word 0x10000011
.word 0x540043c0
.word 0x91004341
.word 0xb9802340
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x54003ec8
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf900dba2
.word 0xf900dfa2
.word 0xf900dba1
.word 0xb901bba0
.word 0xf940dba0
.word 0xf9004fa0
.word 0xf940dfa0
.word 0xf90053a0
.word 0xaa1703f6
.word 0xf9404fa0
.word 0xf900d3a0
.word 0xf94053a0
.word 0xf900d7a0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb981aba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940d3a0
.word 0xeb1f02df
.word 0x10000011
.word 0x54003f00
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf900cfbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802340
.word 0xb9801301
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_261
.loc 35 363 0
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e1
.word 0x910783a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #144]
.word 0x910783ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54003a80
.word 0x91004341
.word 0xb98203a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x540034e8
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf900c7a2
.word 0xf900cba2
.word 0xf900c7a1
.word 0xb90193a0
.word 0xf940c7a0
.word 0xf90047a0
.word 0xf940cba0
.word 0xf9004ba0
.word 0xaa1803f7
.word 0xf94047a0
.word 0xf900bfa0
.word 0xf9404ba0
.word 0xf900c3a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb98183a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940bfa0
.word 0xeb1f02ff
.word 0x10000011
.word 0x540035c0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf900bbbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #152]
.word 0x910783a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0x910783ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x540031c0
.word 0x91004341
.word 0xb98203a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54002c48
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf900b3a2
.word 0xf900b7a2
.word 0xf900b3a1
.word 0xb9016ba0
.word 0xf940b3a0
.word 0xf9003fa0
.word 0xf940b7a0
.word 0xf90043a0
.word 0xaa1803f7
.word 0xf9403fa0
.word 0xf900aba0
.word 0xf94043a0
.word 0xf900afa0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb9815ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940aba0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54002d00
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf900a7bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261
.word 0x14000001
.word 0x910783a0
bl _p_264
.word 0xf9010fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xd2801201
bl _p_3
.word 0xf9410fa1
.word 0xf9010ba0
bl _p_393
.word 0xf9410ba0
bl _p_13
.word 0x14000127
.word 0xb9800ac0
.word 0x6b0002bf
.word 0x54002408
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf9009fa2
.word 0xf900a3a2
.word 0xf9009fa1
.word 0xb90143a0
.word 0xf9409fa0
.word 0xf90037a0
.word 0xf940a3a0
.word 0xf9003ba0
.word 0xaa1703f6
.word 0xf94037a0
.word 0xf90097a0
.word 0xf9403ba0
.word 0xf9009ba0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb98133a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94097a0
.word 0xeb1f02df
.word 0x10000011
.word 0x540024a0
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf90093bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802340
.word 0xb9801301
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_261
.loc 35 364 0
.word 0x910183a0
.word 0xf90107a0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405030
.word 0xd63f0200
.word 0xf94107be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xd2800301
bl _p_3
.word 0xeb1f001f
.word 0x10000011
.word 0x54002060
.word 0x91004001
.word 0xf94033a2
.word 0xf9000022
bl _p_394
.word 0xaa0003e1
.word 0x910783a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #176]
.word 0x910783ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54001e60
.word 0x91004341
.word 0xb98203a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54001928
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf9008ba2
.word 0xf9008fa2
.word 0xf9008ba1
.word 0xb9011ba0
.word 0xf9408ba0
.word 0xf9002ba0
.word 0xf9408fa0
.word 0xf9002fa0
.word 0xaa1803f7
.word 0xf9402ba0
.word 0xf90083a0
.word 0xf9402fa0
.word 0xf90087a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb9810ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94083a0
.word 0xeb1f02ff
.word 0x10000011
.word 0x540019a0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf9007fbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #152]
.word 0x910783a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0x910783ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x540015a0
.word 0x91004341
.word 0xb98203a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54001088
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf90077a2
.word 0xf9007ba2
.word 0xf90077a1
.word 0xb900f3a0
.word 0xf94077a0
.word 0xf90023a0
.word 0xf9407ba0
.word 0xf90027a0
.word 0xaa1803f7
.word 0xf94023a0
.word 0xf9006fa0
.word 0xf94027a0
.word 0xf90073a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb980e3a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9406fa0
.word 0xeb1f02ff
.word 0x10000011
.word 0x540010e0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf9006bbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261
.word 0x14000001
.word 0x910783a0
bl _p_264
.word 0xf9010fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xd2801201
bl _p_3
.word 0xf9410fa1
.word 0xf9010ba0
bl _p_393
.word 0xf9410ba0
bl _p_13
.loc 35 380 0
.word 0xaa1903f8
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416430
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #184]
.word 0xf9400000
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb5000080
.word 0xeb1f02ff
.word 0x9a9f17f7
.word 0x1400000e
.word 0xeb1602ff
.word 0x54000061
.word 0xd2800037
.word 0x1400000a
.word 0xb4000117
.word 0xaa1703e0
.word 0xaa1603e1
.word 0xf94002e2
.word 0xf9402c50
.word 0xd63f0200
.word 0x53001c17
.word 0x14000002
.word 0xd2a00017
.word 0x53001ee1
.word 0xaa1803e0
bl _p_281
.loc 35 381 0
.word 0x91004320
.word 0xf9400000
.word 0xf90067a0
.word 0xf94067a1
.word 0xaa1903e0
bl _p_395
.loc 35 383 0
.word 0xaa1903e0
bl _p_375
.word 0x53001c00
.word 0xd280005e
.word 0xa1e0000
.word 0xd280005e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x53001c18
.loc 35 384 0
.word 0x6b1f035f
.word 0x9a9f17e0
.word 0x2a180001
.word 0xaa1903e0
bl _p_396
.loc 35 385 0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa9407bfd
.word 0xd2804410
.word 0x910003f1
.word 0x8b100231
.word 0x9100023f
.word 0xd65f03c0
bl _p_268
bl _p_268
bl _p_268
bl _p_268
bl _p_268
bl _p_268
.loc 35 364 0
.word 0x910783a0
.word 0xd28006a1
.word 0xd2800042
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a9dc1
bl _p_11
.word 0x910783ba
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f035f
.word 0x10000011
.word 0x54000240
.word 0x91004341
.word 0xb98203a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0x17fffec7
.loc 35 363 0
.word 0x910783a0
.word 0xd2800b41
.word 0xd2800042
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a9dc1
bl _p_11
.word 0x910783ba
.word 0xaa0003f8
.word 0x17fffde0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_206:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_CreateManagedRef_bool
Foundation_NSObject_CreateManagedRef_bool:
.loc 35 393 0 prologue_end
.word 0xa9af7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xaa0003f9
.word 0xf90023a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9007fbf
.word 0xd2800000
.word 0xf9006ba0
.word 0xf9006fa0
.word 0xf90073a0
.word 0xf90077a0
.word 0xf9007ba0
.word 0xaa1903e0
.word 0xd2800021
bl _p_397
.loc 35 394 0
.word 0x91004320
.word 0xf9400000
.word 0xf90067a0
.word 0xf94067a0
bl _p_398
.word 0x53001c00
.loc 35 395 0
.word 0x340014c0
.loc 35 397 0
.word 0x9103e3a0
.word 0xf90083a0
.word 0xaa1903e0
.word 0xd2800021
bl _p_399
.word 0xf94083be
.word 0xf90003c0
.loc 35 398 0
.word 0xf9407fa0
.word 0xf90063a0
.word 0xf94063b8
.loc 35 399 0
.word 0x91004320
.word 0xf9400000
.word 0xf9005fa0
.word 0xf9405fa0
.word 0xaa1803e1
.word 0xd28000e2
bl _p_400
.word 0x53001c00
.word 0x35001260
.loc 35 401 0
.word 0x910343a0
.word 0xd2800c01
.word 0xd2800022
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #192]
.word 0x910343b8
.word 0xaa0003f7
.word 0xaa0003f6
.word 0xeb1f031f
.word 0x10000011
.word 0x54001240
.word 0x91004301
.word 0xb980f3a0
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb9800821
.word 0x6b01001f
.word 0x54001128
.word 0xf94002a0
.word 0x2a1403e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800aa0
.word 0x4b140000
.word 0xd2800002
.word 0xf90057a2
.word 0xf9005ba2
.word 0xf90057a1
.word 0xb900b3a0
.word 0xf94057a0
.word 0xf9002fa0
.word 0xf9405ba0
.word 0xf90033a0
.word 0xaa1603f5
.word 0xf9402fa0
.word 0xf9004fa0
.word 0xf94033a0
.word 0xf90053a0
.word 0x394002de
.word 0xd2a00000
.word 0x53001c16
.word 0xb98012a0
.word 0xb980a3a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9404fa0
.word 0xeb1f02bf
.word 0x10000011
.word 0x54000d80
.word 0x910052a1
.word 0xb98012a2
.word 0x2a0203e2
.word 0xf9004bbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c16
.word 0x53001ec0
.word 0x340000c0
.word 0xb9802300
.word 0xb98012e1
.word 0xb010000
.word 0xb9002300
.word 0x14000004
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_261
.word 0xf9400320
.word 0xf9400c01

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #200]
.word 0x910343a0
bl _p_401

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1136]
.word 0x910343b8
.word 0xaa0003f7
.word 0xaa0003f6
.word 0xeb1f031f
.word 0x10000011
.word 0x54000940
.word 0x91004301
.word 0xb980f3a0
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb9800821
.word 0x6b01001f
.word 0x54000848
.word 0xf94002a0
.word 0x2a1403e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800aa0
.word 0x4b140000
.word 0xd2800002
.word 0xf90043a2
.word 0xf90047a2
.word 0xf90043a1
.word 0xb9008ba0
.word 0xf94043a0
.word 0xf90027a0
.word 0xf94047a0
.word 0xf9002ba0
.word 0xaa1603f5
.word 0xf94027a0
.word 0xf9003ba0
.word 0xf9402ba0
.word 0xf9003fa0
.word 0x394002de
.word 0xd2a00000
.word 0x53001c16
.word 0xb98012a0
.word 0xb9807ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9403ba0
.word 0xeb1f02bf
.word 0x10000011
.word 0x54000480
.word 0x910052a1
.word 0xb98012a2
.word 0x2a0203e2
.word 0xf90037bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c16
.word 0x53001ec0
.word 0x340000c0
.word 0xb9802300
.word 0xb98012e1
.word 0xb010000
.word 0xb9002300
.word 0x14000004
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_261
.word 0x910343a0
bl _p_264
bl _p_59
.loc 35 402 0
.word 0x9103e3a0
bl _p_284
.loc 35 406 0
.word 0x394103a0
.word 0x34000060
.loc 35 407 0
.word 0xaa1903e0
bl _p_402
.loc 35 408 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0x910003bf
.word 0xa8d17bfd
.word 0xd65f03c0
bl _p_268
bl _p_268
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_208:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_ReleaseManagedRef
Foundation_NSObject_ReleaseManagedRef:
.loc 35 412 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x91004340
.word 0xf9400000
.word 0xf9001fa0
.loc 35 413 0
.word 0xf9401fa0
.word 0xf9001ba0
.word 0xf9401ba0
bl _p_398
.word 0x53001c00
.word 0x53001c19
.loc 35 414 0
.word 0xaa1a03e0
.word 0xd2a00001
bl _p_397
.loc 35 415 0
.word 0x350000d9
.loc 35 417 0
.word 0xf9401fa0
.word 0xf90017a0
.word 0xf94017a0
.word 0xaa1a03e1
bl _p_403
.loc 35 419 0
.word 0xf9401fa0
.word 0xf90013a0
.word 0xf94013a0
.word 0xaa1903e1
bl _p_404
.loc 35 420 0
.word 0xaa1a03e0
bl _p_405
.loc 35 421 0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_209:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_IsProtocol_System_Type_intptr
Foundation_NSObject_IsProtocol_System_Type_intptr:
.loc 35 0 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x14000072

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 35 426 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #336]
.word 0xaa1903e0
.word 0xd2a00002
.word 0xf9400323
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003f8
.loc 35 427 0
.word 0xaa1803e1
.word 0xb9801820
.word 0x35000060
.word 0xd2800017
.word 0x14000006
.word 0xb9801b00
.word 0xeb1f001f
.word 0x10000011
.word 0x54000d69
.word 0xf9401317
.word 0xb4000117
.word 0xf94002e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xeb01001f
.word 0x10000011
.word 0x54000be1
.word 0xaa1703f8
.loc 35 428 0
.word 0xb4000957
.word 0x3940031e
.word 0x39408300
.word 0x53001c00
.word 0x350008c0
.loc 35 431 0
.word 0x3940031e
.word 0xf9400f17
.word 0xb40000b7
.word 0xb98012e0
.word 0x6b1f001f
.word 0x9a9f17f7
.word 0x14000002
.word 0xd2800037
.word 0x53001ee0
.word 0x35000080
.loc 35 432 0
.word 0x3940031e
.word 0xf9400f18
.word 0x14000030
.loc 35 434 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #216]
.word 0xaa1903e0
.word 0xd2a00002
.word 0xf9400323
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003f8
.loc 35 435 0
.word 0xaa1803e1
.word 0xb9801820
.word 0x35000060
.word 0xd2800017
.word 0x14000006
.word 0xb9801b00
.word 0xeb1f001f
.word 0x10000011
.word 0x540007a9
.word 0xf9401317
.word 0xb4000117
.word 0xf94002e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #224]
.word 0xeb01001f
.word 0x10000011
.word 0x54000621
.word 0xaa1703f8
.loc 35 436 0
.word 0xb40001d7
.word 0x3940031e
.word 0xf9400b17
.word 0xb40000b7
.word 0xb98012e0
.word 0x6b1f001f
.word 0x9a9f17f7
.word 0x14000002
.word 0xd2800037
.word 0x53001ee0
.word 0x35000080
.loc 35 437 0
.word 0x3940031e
.word 0xf9400b18
.word 0x14000006
.loc 35 439 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405c30
.word 0xd63f0200
.word 0xaa0003f8
.loc 35 443 0
.word 0xaa1803e0
bl _p_406
.word 0xaa0003f8
.loc 35 444 0
.word 0xaa1803e0
.word 0xb40000a0
.word 0xeb1a031f
.word 0x54000061
.loc 35 445 0
.word 0xd2800020
.word 0x1400000f
.loc 35 447 0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940a030
.word 0xd63f0200
.word 0xaa0003f9
.loc 35 425 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xaa1903e0
bl _p_33
.word 0x53001c00
.word 0x34000040
.word 0xb5fff119
.loc 35 450 0
.word 0xd2a00000
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_20a:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_InvokeConformsToProtocol_ObjCRuntime_NativeHandle
Foundation_NSObject_InvokeConformsToProtocol_ObjCRuntime_NativeHandle:
.loc 35 456 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_20b:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_ConformsToProtocol_ObjCRuntime_NativeHandle
Foundation_NSObject_ConformsToProtocol_ObjCRuntime_NativeHandle:
.loc 35 468 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa
.word 0xf9001ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9003bbf
.word 0xf9003fbf
.word 0x390203bf
.word 0x390223bf
.word 0xaa1a03e0
bl _p_407
.word 0x53001c00
.word 0x53001c19
.word 0xaa1903e0
.word 0x340008c0
.loc 35 469 0
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416430
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #184]
.word 0xf9400000
.word 0xaa0103f8
.word 0xaa0003f7
.word 0xb5000080
.word 0xeb1f031f
.word 0x9a9f17f8
.word 0x1400000e
.word 0xeb17031f
.word 0x54000061
.word 0xd2800038
.word 0x1400000a
.word 0xb4000118
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400302
.word 0xf9402c50
.word 0xd63f0200
.word 0x53001c18
.word 0x14000002
.word 0xd2a00018
.word 0x53001f00
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.loc 35 470 0
.word 0x34000460
.loc 35 473 0
.word 0xf9400340
.word 0xf9400c03

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #216]
.word 0xaa0303e0
.word 0xd2a00002
.word 0xf9400063
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003f8
.loc 35 474 0
.word 0xaa1803e0
.word 0xb40002c0
.word 0xb9801b00
.word 0xd280003e
.word 0x6b1e001f
.word 0x54000241
.loc 35 475 0
.word 0xb9801b00
.word 0xeb1f001f
.word 0x10000011
.word 0x54001429
.word 0xf9401319
.word 0xb4000119
.word 0xf9400320

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #224]
.word 0xeb01001f
.word 0x10000011
.word 0x540012a1
.word 0x3940033e
.word 0x39406320
.word 0x53001c00
.word 0x53001c19
.loc 35 486 0
.word 0x34000239
.loc 35 487 0
.word 0x91004340
.word 0xf9400000
.word 0xf90037a0
.word 0xf94037a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_20@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_20@PAGEOFF
ldr x1, [x1]
.word 0xf9401ba2
.word 0xf90033a2
.word 0xf94033a2
bl _p_408
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x53001c19
.word 0x14000013
.loc 35 489 0
.word 0x910163a0
.word 0xf9004ba0
.word 0xaa1a03e0
bl _p_409
.word 0xf9404bbe
.word 0xf90003c0
.word 0xf9402fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_20@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_20@PAGEOFF
ldr x1, [x1]
.word 0xf9401ba2
.word 0xf9002ba2
.word 0xf9402ba2
bl _p_410
.word 0x53001c00
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x53001c19
.loc 35 493 0
.word 0x34000079
.loc 35 494 0
.word 0xd2800020
.word 0x14000066
.loc 35 500 0
.word 0x9101c3a0
.word 0xf9004ba0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9405030
.word 0xd63f0200
.word 0xf9404bbe
.word 0xf90003c0
.loc 35 501 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #232]
.word 0xf9400000
.word 0xf9003fa0
.word 0xd2a00000
.word 0x390203a0
.word 0xf9403fb9
.word 0x910203b8
.word 0xaa1903e0
.word 0x910203a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_21
.loc 35 503 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #232]
.word 0xf9400000
.word 0xf9403ba1
.word 0xf90027a1
.word 0xf94027a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #240]
.word 0x910223a2
bl _p_411
.word 0xaa0003f9
.loc 35 504 0
.word 0x394223a0
.word 0x35000300
.loc 35 505 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #248]
.word 0xd2800901
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #256]
.word 0xf9005ba0
bl _p_412
.word 0xd5033bbf
.word 0xf9405ba0
.word 0xf9000320
.word 0xd349ff21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 35 506 0
.word 0xf9400320
.word 0xf9401ba1
.word 0xf90023a1
.word 0xf94023a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #264]
.word 0x910223a2
bl _p_413
.word 0xaa0003f9
.loc 35 507 0
.word 0x394223a0
.word 0x350000a0
.loc 35 508 0
.word 0xaa1a03e0
.word 0xf9401ba1
bl _p_414
.word 0x39000320
.loc 35 521 0
.word 0x39400320
.word 0x53001c1a
.word 0xf9004fbf
.word 0x94000005
.word 0xf9404fa0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf90053be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394203a0
.word 0x34000060
.word 0xf9403fa0
bl _p_24
.word 0xf94053be
.word 0xd61f03c0
.loc 35 523 0
.word 0xaa1a03e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_20c:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DynamicConformsToProtocol_ObjCRuntime_NativeHandle
Foundation_NSObject_DynamicConformsToProtocol_ObjCRuntime_NativeHandle:
.loc 35 532 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa
.word 0xf9001ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400340
.word 0xf9400c03

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #576]
.word 0xaa0303e0
.word 0xd2800022
.word 0xf9400063
.word 0xf9404470
.word 0xd63f0200
.word 0xaa0003f9
.loc 35 533 0
.word 0xd2a00018
.word 0x14000025

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000a29
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf9400017
.word 0xb4000117
.word 0xf94002e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #272]
.word 0xeb01001f
.word 0x10000011
.word 0x54000901
.loc 35 534 0
.word 0xaa1703e0
.word 0x394002fe
bl _p_415
.word 0xf9401ba1
.word 0xf9002ba1
.word 0xf9402ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 35 535 0
.word 0xd2800020
.word 0x14000034
.word 0x11000718
.loc 35 533 0
.word 0xb9801b20
.word 0x6b00031f
.word 0x54fffb4b
.loc 35 541 0
.word 0xf9400340
.word 0xf9400c00
.word 0xf9401ba1
.word 0xf90027a1
.word 0xf94027a1
bl _p_416
.word 0x53001c00
.word 0x34000060
.loc 35 542 0
.word 0xd2800020
.word 0x14000026
.loc 35 544 0
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9409c30
.word 0xd63f0200
.word 0xaa0003fa
.loc 35 545 0
.word 0xd2a00018
.word 0x14000019

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x540002e9
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0xf9401ba1
.word 0xf90023a1
.word 0xf94023a1
.loc 35 546 0
bl _p_416
.word 0x53001c00
.word 0x34000060
.loc 35 547 0
.word 0xd2800020
.word 0x14000006
.word 0x11000718
.loc 35 545 0
.word 0xb9801b40
.word 0x6b00031f
.word 0x54fffccb
.loc 35 550 0
.word 0xd2a00000
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_20d:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DangerousRelease
Foundation_NSObject_DangerousRelease:
.loc 35 556 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
bl _p_417
.loc 35 557 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_20e:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DangerousRelease_ObjCRuntime_NativeHandle
Foundation_NSObject_DangerousRelease_ObjCRuntime_NativeHandle:
.loc 35 561 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x35000100
.loc 35 566 0
.word 0xf9400ba0
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 35 568 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_20f:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DangerousAutorelease_ObjCRuntime_NativeHandle
Foundation_NSObject_DangerousAutorelease_ObjCRuntime_NativeHandle:
.loc 35 586 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_21@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_21@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 35 588 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_210:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DangerousRetain
Foundation_NSObject_DangerousRetain:
.loc 35 596 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 35 598 0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_211:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_DangerousAutorelease
Foundation_NSObject_DangerousAutorelease:
.loc 35 607 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_21@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_21@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 35 609 0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_212:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_SuperHandle
Foundation_NSObject_get_SuperHandle:
.loc 35 614 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
.word 0xf9001ba0
.word 0xf9401ba0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 35 615 0
.word 0xf94013a0
bl _p_418
.loc 35 617 0
.word 0x910043a0
.word 0xf9001fa0
.word 0xf94013a0
bl _p_419
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_213:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_Handle
Foundation_NSObject_get_Handle:
.loc 35 622 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_214:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_set_Handle_ObjCRuntime_NativeHandle
Foundation_NSObject_set_Handle_ObjCRuntime_NativeHandle:
.loc 35 624 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x91004340
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
.word 0xf9003ba0
.word 0xf9400fa0
.word 0xf90037a0
.word 0xf9403ba0
.word 0xf94037a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x35000680
.loc 35 627 0
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
.word 0xf90033a0
.word 0xf94033a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340000c0
.loc 35 628 0
.word 0x91004340
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9402fa0
bl _p_420
.loc 35 630 0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000480
.word 0x91004340
.word 0xf9400fa1
.word 0xf9000001
.loc 35 634 0
.word 0xf9401740
.word 0xd2a00001
.word 0x2a0103e1
.word 0xeb01001f
.word 0x540000c0
.loc 35 635 0
.word 0xf9401740
.word 0xf9400fa1
.word 0xf9002ba1
.word 0xf9402ba1
.word 0xf9000001
.loc 35 639 0
.word 0x91004340
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
.word 0xf90027a0
.word 0xf94027a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340000e0
.loc 35 640 0
.word 0x91004340
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a1
.word 0xaa1a03e0
bl _p_395
.loc 35 641 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_215:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_InitializeHandle_ObjCRuntime_NativeHandle_string
Foundation_NSObject_InitializeHandle_ObjCRuntime_NativeHandle_string:
.loc 35 653 0 prologue_end
.word 0xd2806610
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa9007bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f9
.word 0xf90027a1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9017ba0
.word 0xf9017fa0
.word 0xf90183a0
.word 0xf90187a0
.word 0xf9018ba0
.word 0x91004320
.word 0xf9400000
.word 0xf90097a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90093a0
.word 0xf94097a0
.word 0xf90177a0
.word 0xf94093a0
.word 0xf90173a0
.word 0xf94177a0
.word 0xf94173a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34003b20

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #136]
.word 0x39400000
.word 0x34003a80
.loc 35 654 0
.word 0x910463a0
.word 0xf9018fa0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405030
.word 0xd63f0200
.word 0xf9418fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9008ba0
.word 0xf9408fa0
.word 0xf9016fa0
.word 0xf9408ba0
.word 0xf9016ba0
.word 0xf9416fa0
.word 0xf9416ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x35006600
.word 0x1400031b
.word 0xaa1803f7
.word 0xeb1f035f
.word 0x10000011
.word 0x540066e0
.word 0x91004341
.word 0xb9802340
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x540061c8
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf90163a2
.word 0xf90167a2
.word 0xf90163a1
.word 0xb902cba0
.word 0xf94163a0
.word 0xf90083a0
.word 0xf94167a0
.word 0xf90087a0
.word 0xaa1703f6
.word 0xf94083a0
.word 0xf9015ba0
.word 0xf94087a0
.word 0xf9015fa0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb982bba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9415ba0
.word 0xeb1f02df
.word 0x10000011
.word 0x54006220
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf90157bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802340
.word 0xb9801301
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_261
.loc 35 655 0
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e1
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #144]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54005da0
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54005508
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf9014fa2
.word 0xf90153a2
.word 0xf9014fa1
.word 0xb902a3a0
.word 0xf9414fa0
.word 0xf9007ba0
.word 0xf94153a0
.word 0xf9007fa0
.word 0xaa1803f7
.word 0xf9407ba0
.word 0xf90147a0
.word 0xf9407fa0
.word 0xf9014ba0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb98293a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94147a0
.word 0xeb1f02ff
.word 0x10000011
.word 0x540058e0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf90143bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #152]
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x540054e0
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54004c68
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf9013ba2
.word 0xf9013fa2
.word 0xf9013ba1
.word 0xb9027ba0
.word 0xf9413ba0
.word 0xf90073a0
.word 0xf9413fa0
.word 0xf90077a0
.word 0xaa1803f7
.word 0xf94073a0
.word 0xf90133a0
.word 0xf94077a0
.word 0xf90137a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb9826ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94133a0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54005020
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf9012fbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261
.word 0x14000001
.word 0x910bc3a0
bl _p_264
.word 0xf90197a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xd2801201
bl _p_3
.word 0xf94197a1
.word 0xf90193a0
bl _p_393
.word 0xf94193a0
bl _p_13
.word 0x14000240
.word 0xb9800ac0
.word 0x6b0002bf
.word 0x54004428
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf90127a2
.word 0xf9012ba2
.word 0xf90127a1
.word 0xb90253a0
.word 0xf94127a0
.word 0xf9006ba0
.word 0xf9412ba0
.word 0xf9006fa0
.word 0xaa1703f6
.word 0xf9406ba0
.word 0xf9011fa0
.word 0xf9406fa0
.word 0xf90123a0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb98243a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9411fa0
.word 0xeb1f02df
.word 0x10000011
.word 0x540047c0
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf9011bbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802340
.word 0xb9801301
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_261
.loc 35 656 0
.word 0x910323a0
.word 0xf9018fa0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9405030
.word 0xd63f0200
.word 0xf9418fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xd2800301
bl _p_3
.word 0xeb1f001f
.word 0x10000011
.word 0x54004380
.word 0x91004001
.word 0xf94067a2
.word 0xf9000022
bl _p_394
.word 0xaa0003e1
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #176]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54004180
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54003948
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf90113a2
.word 0xf90117a2
.word 0xf90113a1
.word 0xb9022ba0
.word 0xf94113a0
.word 0xf9005fa0
.word 0xf94117a0
.word 0xf90063a0
.word 0xaa1803f7
.word 0xf9405fa0
.word 0xf9010ba0
.word 0xf94063a0
.word 0xf9010fa0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb9821ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9410ba0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54003cc0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf90107bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #152]
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x540038c0
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x540030a8
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf900ffa2
.word 0xf90103a2
.word 0xf900ffa1
.word 0xb90203a0
.word 0xf940ffa0
.word 0xf90057a0
.word 0xf94103a0
.word 0xf9005ba0
.word 0xaa1803f7
.word 0xf94057a0
.word 0xf900f7a0
.word 0xf9405ba0
.word 0xf900fba0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb981f3a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940f7a0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54003400
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf900f3bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261
.word 0x14000001
.word 0x910bc3a0
bl _p_264
.word 0xf90197a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xd2801201
bl _p_3
.word 0xf94197a1
.word 0xf90193a0
bl _p_393
.word 0xf94193a0
bl _p_13
.loc 35 659 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90053a0
.word 0xf94027a0
.word 0xf900efa0
.word 0xf94053a0
.word 0xf900eba0
.word 0xf940efa0
.word 0xf940eba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340024a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #136]
.word 0x39400000
.word 0x35002660
.word 0x1400011f
.word 0xaa1703f6
.word 0xeb1f031f
.word 0x10000011
.word 0x54002ce0
.word 0x91004301
.word 0xb9802300
.word 0xaa0103f5
.word 0xaa0003f4
.word 0xb9800821
.word 0x6b01001f
.word 0x540027e8
.word 0xf94002a0
.word 0x2a1403e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800aa0
.word 0x4b140000
.word 0xd2800002
.word 0xf900e3a2
.word 0xf900e7a2
.word 0xf900e3a1
.word 0xb901cba0
.word 0xf940e3a0
.word 0xf9004ba0
.word 0xf940e7a0
.word 0xf9004fa0
.word 0xaa1603f5
.word 0xf9404ba0
.word 0xf900dba0
.word 0xf9404fa0
.word 0xf900dfa0
.word 0x394002de
.word 0xd2a00000
.word 0x53001c16
.word 0xb98012a0
.word 0xb981bba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940dba0
.word 0xeb1f02bf
.word 0x10000011
.word 0x54002820
.word 0x910052a1
.word 0xb98012a2
.word 0x2a0203e2
.word 0xf900d7bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c16
.word 0x53001ec0
.word 0x340000c0
.word 0xb9802300
.word 0xb98012e1
.word 0xb010000
.word 0xb9002300
.word 0x14000004
.word 0xaa1803e0
.word 0xaa1703e1
bl _p_261
.loc 35 661 0
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e1
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #280]
.word 0x910bc3b9
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f033f
.word 0x10000011
.word 0x540023a0
.word 0x91004321
.word 0xb98313a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x54001e28
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf900cfa2
.word 0xf900d3a2
.word 0xf900cfa1
.word 0xb901a3a0
.word 0xf940cfa0
.word 0xf90043a0
.word 0xf940d3a0
.word 0xf90047a0
.word 0xaa1703f6
.word 0xf94043a0
.word 0xf900c7a0
.word 0xf94047a0
.word 0xf900cba0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb98193a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940c7a0
.word 0xeb1f02df
.word 0x10000011
.word 0x54001ee0
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf900c3bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802320
.word 0xb9801301
.word 0xb010000
.word 0xb9002320
.word 0x14000004
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_261
.word 0x910bc3a0
.word 0xaa1a03e1
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #288]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54001b20
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x540015c8
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf900bba2
.word 0xf900bfa2
.word 0xf900bba1
.word 0xb9017ba0
.word 0xf940bba0
.word 0xf9003ba0
.word 0xf940bfa0
.word 0xf9003fa0
.word 0xaa1803f7
.word 0xf9403ba0
.word 0xf900b3a0
.word 0xf9403fa0
.word 0xf900b7a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb9816ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf940b3a0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54001660
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf900afbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000004
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #152]
.word 0x910bc3a0
bl _p_263

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1144]
.word 0x910bc3ba
.word 0xaa0003f9
.word 0xaa0003f8
.word 0xeb1f035f
.word 0x10000011
.word 0x54001260
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f7
.word 0xaa0003f6
.word 0xb9800821
.word 0x6b01001f
.word 0x54000d28
.word 0xf94002e0
.word 0x2a1603e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ae0
.word 0x4b160000
.word 0xd2800002
.word 0xf900a7a2
.word 0xf900aba2
.word 0xf900a7a1
.word 0xb90153a0
.word 0xf940a7a0
.word 0xf90033a0
.word 0xf940aba0
.word 0xf90037a0
.word 0xaa1803f7
.word 0xf94033a0
.word 0xf9009fa0
.word 0xf94037a0
.word 0xf900a3a0
.word 0x3940031e
.word 0xd2a00000
.word 0x53001c18
.word 0xb98012e0
.word 0xb98143a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9409fa0
.word 0xeb1f02ff
.word 0x10000011
.word 0x54000da0
.word 0x910052e1
.word 0xb98012e2
.word 0x2a0203e2
.word 0xf9009bbf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c18
.word 0x53001f00
.word 0x340000c0
.word 0xb9802340
.word 0xb9801321
.word 0xb010000
.word 0xb9002340
.word 0x14000005
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_261
.word 0x14000001
.word 0x910bc3a0
bl _p_264
.word 0xf90197a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #160]
.word 0xd2801201
bl _p_3
.word 0xf94197a1
.word 0xf90193a0
bl _p_393
.word 0xf94193a0
bl _p_13
.loc 35 664 0
.word 0xaa1903e0
.word 0xf94027a1
bl _p_421
.loc 35 665 0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa9407bfd
.word 0xd2806610
.word 0x910003f1
.word 0x8b100231
.word 0x9100023f
.word 0xd65f03c0
bl _p_268
bl _p_268
bl _p_268
bl _p_268
bl _p_268
.loc 35 660 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9002fa0
.word 0xaa1903e0
.word 0xf9402fa1
bl _p_421
.loc 35 661 0
.word 0x910bc3a0
.word 0xd2800aa1
.word 0xd2800062
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28ae901
bl _p_11
.word 0x910bc3b8
.word 0xaa0003f7
.word 0x17fffebc
bl _p_268
bl _p_268
bl _p_268
bl _p_268
bl _p_268
.loc 35 656 0
.word 0x910bc3a0
.word 0xd28006a1
.word 0xd2800042
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a9dc1
bl _p_11
.word 0x910bc3ba
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f035f
.word 0x10000011
.word 0x54000240
.word 0x91004341
.word 0xb98313a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0x17fffdae
.loc 35 655 0
.word 0x910bc3a0
.word 0xd2800b41
.word 0xd2800042
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28a9dc1
bl _p_11
.word 0x910bc3ba
.word 0xaa0003f8
.word 0x17fffcc7
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_216:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_AllocIfNeeded
Foundation_NSObject_AllocIfNeeded:
.loc 35 669 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x91004340
.word 0xf9400000
.word 0xf90017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0xf94017a0
.word 0xf90027a0
.word 0xf94013a0
.word 0xf90023a0
.word 0xf94027a0
.word 0xf94023a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000320
.loc 35 673 0
.word 0xf9400340
.word 0xf9400c00
.word 0x9100e3a1
.word 0xf9002ba1
bl _p_422
.word 0xf9402bbe
.word 0xf90003c0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf9001bbf
.word 0xf9001ba0
.word 0xf9401ba0
.word 0xf9000fa0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000160
.word 0x91004340
.word 0xf9400fa1
.word 0xf9000001
.loc 35 675 0
.word 0xd2800020
.word 0x14000002
.loc 35 677 0
.word 0xd2a00000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_217:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_BeginInvokeOnMainThread_System_Threading_SendOrPostCallback_object
Foundation_NSObject_BeginInvokeOnMainThread_System_Threading_SendOrPostCallback_object:
.loc 35 763 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_290
.word 0xf9002ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_423
.word 0xf9402ba2
.loc 35 765 0
.word 0xaa0203e0
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
adrp x3, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x3, x3, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x3, [x3]
.word 0xf9001fbf
.word 0xf9001fa3
.word 0xf9401fa3
.word 0xf9001ba3
.word 0x3940005e
.word 0x91004042
.word 0xf9400042
.word 0xf90017a2
.word 0xf9401ba2
.word 0xf94017a3
.word 0xd2a00004
bl _p_424
.loc 35 776 0
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_218:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_InvokeOnMainThread_System_Threading_SendOrPostCallback_object
Foundation_NSObject_InvokeOnMainThread_System_Threading_SendOrPostCallback_object:
.loc 35 798 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90027bf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #304]
bl _p_290
.word 0xf9003ba0
.word 0xf9400fa1
.word 0xf94013a2
bl _p_425
.word 0xf9403ba0
.word 0xf90027a0
.loc 35 800 0
.word 0xf94027a0
.word 0xaa0003e1
.word 0x3940003e
.word 0x91004000
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
adrp x2, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x2, x2, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x2, [x2]
.word 0xf9001fbf
.word 0xf9001fa2
.word 0xf9401fa2
.word 0xf9001ba2
.word 0xf94027a2
.word 0xaa0203e3
.word 0x3940007e
.word 0x91004042
.word 0xf9400042
.word 0xf90017a2
.word 0xf9401ba2
.word 0xf94017a3
.word 0xd2800024
bl _p_424
.loc 35 811 0
.word 0xf9002bbf
.word 0x94000005
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x14000015
.word 0xf9002fbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94027a0
.word 0xb4000140
.word 0xf94027a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9402fbe
.word 0xd61f03c0
.loc 35 812 0
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_219:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_GetHashCode
Foundation_NSObject_GetHashCode:
.loc 35 924 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_407
.word 0x53001c00
.word 0x350000a0
.loc 35 925 0
.word 0xaa1a03e0
bl _p_426
.word 0x93407c00
.word 0x1400000c
.loc 35 927 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9404c30
.word 0xd63f0200
.word 0xaa0003fa
.word 0xaa1a03e1
.word 0xaa0103e0
.word 0x93407c00
.word 0xd360fc21
.word 0x93407c21
.word 0x4a010000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_21a:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Equals_object
Foundation_NSObject_Equals_object:
.loc 35 932 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #120]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803fa
.loc 35 933 0
.word 0xb5000078
.loc 35 934 0
.word 0xd2a00000
.word 0x1400001b
.loc 35 936 0
.word 0xaa1903e0
bl _p_407
.word 0x53001c00
.word 0x53001c18
.loc 35 938 0
.word 0xaa1803e0
.word 0xf9001ba0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_407
.word 0xaa0003e1
.word 0xf9401ba0
.word 0x53001c21
.word 0x6b01001f
.word 0x54000060
.loc 35 939 0
.word 0xd2a00000
.word 0x1400000b
.loc 35 942 0
.word 0x35000098
.word 0xeb1a033f
.word 0x9a9f17e0
.word 0x14000007
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9404850
.word 0xd63f0200
.word 0x53001c00
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_21b:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Equals_Foundation_NSObject
Foundation_NSObject_Equals_Foundation_NSObject:
.loc 35 946 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9402c50
.word 0xd63f0200
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_21c:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_ToString
Foundation_NSObject_ToString:
.loc 35 950 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_427
.word 0x53001c00
.word 0x34000080
.loc 35 951 0
.word 0xaa1a03e0
bl _p_428
.word 0x1400000b
.loc 35 952 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9404430
.word 0xd63f0200
.word 0xaa0003f9
.word 0xb5000080
.word 0xaa1a03e0
bl _p_428
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_21d:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_ClearHandle
Foundation_NSObject_ClearHandle:
.loc 35 969 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x540000e0
.word 0x91004000
.word 0xf9400fa1
.word 0xf9000001
.loc 35 970 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_21e:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_Dispose_bool
Foundation_NSObject_Dispose_bool:
.loc 35 974 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1903e0
bl _p_427
.word 0x53001c00
.word 0x35000440
.loc 35 976 0
.word 0xaa1903e0
.word 0xd2800021
bl _p_429
.loc 35 978 0
.word 0x91004320
.word 0xf9400000
.word 0xf90017a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0xf94017a0
.word 0xf9001fa0
.word 0xf94013a0
.word 0xf9001ba0
.word 0xf9401fa0
.word 0xf9401ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000120
.loc 35 979 0
.word 0x394063a0
.word 0x34000080
.loc 35 980 0
.word 0xaa1903e0
bl _p_430
.word 0x14000006
.loc 35 982 0
.word 0xaa1903e0
bl _p_431
.word 0x14000003
.loc 35 985 0
.word 0xaa1903e0
bl _p_405
.loc 35 987 0
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_21f:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_FreeData
Foundation_NSObject_FreeData:
.loc 35 991 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #3472]
.word 0xf9400021
.word 0xf9000fa1
.word 0xf9400fa1
.word 0xf90017a1
.word 0xf94017a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000180
.loc 35 992 0
.word 0xf9400ba0
.word 0xf9400c00
bl _p_298
.loc 35 993 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a1
.word 0xf9400ba0
.word 0xf9000c01
.loc 35 995 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_220:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_ClassHandle
Foundation_NSObject_get_ClassHandle:
.file 36 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSObject.g.cs"
.loc 36 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #128]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_221:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_GetNativeHash
Foundation_NSObject_GetNativeHash:
.loc 36 222 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_407
.word 0x53001c00
.word 0x34000160
.loc 36 223 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_26@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_26@PAGEOFF
ldr x1, [x1]
bl _p_302
.word 0x1400000c
.loc 36 225 0
.word 0x910063a0
.word 0xf90017a0
.word 0xf9400ba0
bl _p_409
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_26@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_26@PAGEOFF
ldr x1, [x1]
bl _p_432
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_222:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_IsEqual_Foundation_NSObject
Foundation_NSObject_IsEqual_Foundation_NSObject:
.loc 36 233 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100c3a0
.word 0xf9001fa0
.word 0xaa1a03e0
bl _p_312
.word 0xf9401fbe
.word 0xf90003c0
.loc 36 235 0
.word 0xf9400fa0
bl _p_407
.word 0x53001c00
.word 0x340001c0
.loc 36 236 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x1, [x1]
.word 0xf9401ba2
bl _p_374
.word 0x53001c00
.word 0x53001c1a
.word 0x1400000f
.loc 36 238 0
.word 0x910083a0
.word 0xf9001fa0
.word 0xf9400fa0
bl _p_409
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x1, [x1]
.word 0xf9401ba2
bl _p_433
.word 0x53001c00
.word 0x53001c1a
.loc 36 240 0
.word 0x6b1f035f
.word 0x9a9f97e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_223:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_get_Description
Foundation_NSObject_get_Description:
.loc 36 751 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_407
.word 0x53001c00
.word 0x34000220
.loc 36 752 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_28@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_28@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf9001fa2
bl _p_350
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf94013a0
bl _p_360
.word 0x14000012
.loc 36 754 0
.word 0x9100a3a0
.word 0xf9001fa0
.word 0xf9400ba0
bl _p_409
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_28@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_28@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf9001fa2
bl _p_434
.word 0xf9401fbe
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_224:
.text
	.align 4
	.no_dead_strip Foundation_NSObject__cctor
Foundation_NSObject__cctor:
.loc 36 109 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416430
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #184]
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000001
.loc 36 55 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1152]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #128]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_225:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_NSObject_Disposer__ctor
Foundation_NSObject_NSObject_Disposer__ctor:
.loc 35 1011 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_280
.loc 35 1014 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_226:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_NSObject_Disposer_Add_Foundation_NSObject
Foundation_NSObject_NSObject_Disposer_Add_Foundation_NSObject:
.loc 35 1019 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9001bbf
.word 0x3900e3bf

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xf9400000
.word 0xf9001ba0
.word 0xd2a00000
.word 0x3900e3a0
.word 0xf9401bb9
.word 0x9100e3b8
.word 0xaa1903e0
.word 0x9100e3a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_21
.loc 35 1020 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9400019
.word 0xaa1a03f8
.word 0x3940033e
.word 0xb9801f20
.word 0x11000400
.word 0xb9001f20
.word 0xf9400b3a
.word 0xb9801b37
.word 0xaa1703e0
.word 0xb9801b41
.word 0x6b01001f
.word 0x54000142
.word 0x110006e0
.word 0xb9001b20
.word 0xaa1a03e0
.word 0xaa1703e1
.word 0xaa1803e2
.word 0xf9400343
.word 0xf9404070
.word 0xd63f0200
.word 0x14000008

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #328]
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_435
.word 0x14000001
.loc 35 1021 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9400000
.word 0xaa0003e1
.word 0x3940003e
.word 0xb9801800
.word 0xd280003e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x53001c1a
.loc 35 1022 0
.word 0xf90023bf
.word 0x94000005
.word 0xf94023a0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf90027be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x3940e3a0
.word 0x34000060
.word 0xf9401ba0
bl _p_24
.word 0xf94027be
.word 0xd61f03c0
.loc 35 1023 0
.word 0x3400005a
.loc 35 1025 0
bl _p_436
.loc 35 1026 0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_227:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_NSObject_Disposer_ScheduleDrain
Foundation_NSObject_NSObject_Disposer_ScheduleDrain:
.loc 35 1031 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #336]
.word 0xf9400000
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
adrp x2, L_OBJC_SELECTOR_REFERENCES_29@PAGE
add x2, x2, L_OBJC_SELECTOR_REFERENCES_29@PAGEOFF
ldr x2, [x2]
.word 0xf90013bf
.word 0xf90013a2
.word 0xf94013a2
.word 0xf9000fa2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #3472]
.word 0xf9400042
.word 0xf9000ba2
.word 0xf9400fa2
.word 0xf9400ba3
.word 0xd2a00004
bl _p_424
.loc 35 1039 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_228:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_NSObject_Disposer_Drain_Foundation_NSObject
Foundation_NSObject_NSObject_Disposer_Drain_Foundation_NSObject:
.loc 35 1048 0 prologue_end
.word 0xa9b57bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90023bf
.word 0x390123bf
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xf9400000
.word 0xf90023a0
.word 0xd2a00000
.word 0x390123a0
.word 0xf94023ba
.word 0x910123b9
.word 0xaa1a03e0
.word 0x910123a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_21
.loc 35 1053 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #344]
.word 0x39400000
.word 0x34000100
.loc 35 1054 0
bl _p_436
.loc 35 1055 0
.word 0xf9002bbf
.word 0x9400003a
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x140000a2
.loc 35 1057 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #344]
.word 0xd280003e
.word 0x3900001e
.loc 35 1059 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf940001a
.loc 35 1060 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #352]
.word 0xf9400021
.word 0xeb01001f
.word 0x54000241
.loc 35 1061 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #360]
.word 0xf9400001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf90053a0
.word 0xd5033bbf
.word 0xf94053a0
.word 0xf9000001
.word 0xf9002bbf
.word 0x94000016
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x1400001f
.loc 35 1063 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf9400001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf90053a0
.word 0xd5033bbf
.word 0xf94053a0
.word 0xf9000001
.loc 35 1064 0
.word 0xf9002bbf
.word 0x94000005
.word 0xf9402ba0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9003bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394123a0
.word 0x34000060
.word 0xf94023a0
bl _p_24
.word 0xf9403bbe
.word 0xd61f03c0
.loc 35 1066 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #368]
.word 0x3940035e
.word 0x9100a3a8
.word 0xaa1a03e0
bl _p_437
.word 0x1400000b

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401fa1
.loc 35 1067 0
.word 0xaa0103e0
.word 0x3940003e
bl _p_430
.loc 35 1066 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #376]
.word 0x9100a3a0
bl _p_438
.word 0x53001c00
.word 0x35fffe00
.word 0xf9002fbf
.word 0x94000005
.word 0xf9402fa0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf90043be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90033a0
.word 0xf94043be
.word 0xd61f03c0
.loc 35 1068 0
.word 0xaa1a03f9
.word 0x3940035e
.word 0xb9801f40
.word 0x11000400
.word 0xb9001f40
.word 0xb9801b5a
.word 0xb9001b3f
.word 0x6b1f035f
.word 0x540000ad
.word 0xf9400b20
.word 0xd2a00001
.word 0xaa1a03e2
bl _p_439
.loc 35 1070 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xf9400000
.word 0xf90023a0
.word 0xd2a00000
.word 0x390123a0
.word 0xf94023ba
.word 0x910123b9
.word 0xaa1a03e0
.word 0x910123a1
bl _mono_monitor_enter_v4_fast
.word 0x93407c00
.word 0x35000080
.word 0xaa1a03e0
.word 0xaa1903e1
bl _p_21
.loc 35 1071 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #344]
.word 0x3900001f
.loc 35 1072 0
.word 0xf90037bf
.word 0x94000005
.word 0xf94037a0
.word 0xb4000040
bl _p_23
.word 0x1400000e
.word 0xf9004bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x394123a0
.word 0x34000060
.word 0xf94023a0
bl _p_24
.word 0xf9404bbe
.word 0xd61f03c0
.loc 35 1073 0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8cb7bfd
.word 0xd65f03c0

Lme_229:
.text
	.align 4
	.no_dead_strip Foundation_NSObject_NSObject_Disposer__cctor
Foundation_NSObject_NSObject_Disposer__cctor:
.loc 35 1000 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #384]
.word 0xd2800401
bl _p_3
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xf9400000
.word 0xf90027a0
.word 0x91004022
.word 0xd5033bbf
.word 0xf94027a0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf90023a0
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000001
.loc 35 1001 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #384]
.word 0xd2800401
bl _p_3
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #392]
.word 0xf9400000
.word 0xf9001fa0
.word 0x91004022
.word 0xd5033bbf
.word 0xf9401fa0
.word 0xf9000040
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #360]
.word 0xf9001ba0
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000001
.loc 35 1002 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf9400001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf90017a0
.word 0xd5033bbf
.word 0xf94017a0
.word 0xf9000001
.loc 35 1004 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #400]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0
.word 0xf9400ba1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #336]
.word 0xf9000001
.loc 35 1009 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #344]
.word 0xd2800201
bl _p_3
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000001
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_22a:
.text
	.align 4
	.no_dead_strip Foundation_NSRunLoop_get_ClassHandle
Foundation_NSRunLoop_get_ClassHandle:
.file 37 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSRunLoop.g.cs"
.loc 37 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #408]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_22b:
.text
	.align 4
	.no_dead_strip Foundation_NSRunLoop__ctor_ObjCRuntime_NativeHandle
Foundation_NSRunLoop__ctor_ObjCRuntime_NativeHandle:
.loc 37 65 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 37 67 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_22c:
.text
	.align 4
	.no_dead_strip Foundation_NSRunLoop_get_Main
Foundation_NSRunLoop_get_Main:
.loc 37 251 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #408]
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_30@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_30@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90013a2
bl _p_350
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #416]
bl _p_440
.loc 37 252 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_22d:
.text
	.align 4
	.no_dead_strip Foundation_NSRunLoop__cctor
Foundation_NSRunLoop__cctor:
.loc 37 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #424]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #408]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_22e:
.text
	.align 4
	.no_dead_strip Foundation_NSSet_GetEnumerator
Foundation_NSSet_GetEnumerator:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #432]
.word 0xd2800601
bl _p_3
.word 0xb900281f
.word 0xf90013a0
.word 0x91006002
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9400ba1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_22f:
.text
	.align 4
	.no_dead_strip Foundation_NSSet_get_ClassHandle
Foundation_NSSet_get_ClassHandle:
.file 38 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSSet.g.cs"
.loc 38 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #440]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_230:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__ctor_ObjCRuntime_NativeHandle
Foundation_NSSet__ctor_ObjCRuntime_NativeHandle:
.loc 38 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 38 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_231:
.text
	.align 4
	.no_dead_strip Foundation_NSSet_Copy_Foundation_NSZone
Foundation_NSSet_Copy_Foundation_NSZone:
.loc 38 137 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 38 140 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 38 144 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 38 145 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 38 146 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_232:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__GetEnumerator
Foundation_NSSet__GetEnumerator:
.loc 38 278 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_31@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_31@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #448]
bl _p_441
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_233:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__cctor
Foundation_NSSet__cctor:
.loc 38 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #456]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #440]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_234:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__GetEnumeratord__5__ctor_int
Foundation_NSSet__GetEnumeratord__5__ctor_int:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9002801
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_235:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__GetEnumeratord__5_System_IDisposable_Dispose
Foundation_NSSet__GetEnumeratord__5_System_IDisposable_Dispose:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_236:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__GetEnumeratord__5_MoveNext
Foundation_NSSet__GetEnumeratord__5_MoveNext:
.file 39 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSSet.cs"
.loc 39 0 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb9802b59
.word 0xf9400f58
.word 0x340000d9
.word 0xd280003e
.word 0x6b1e033f
.word 0x54000580
.word 0xd2a00000
.word 0x14000036
.word 0x9280001e
.word 0xb9002b5e
.loc 39 68 0
.word 0xaa1803e0
.word 0xf9400301
.word 0xf9407030
.word 0xd63f0200
.word 0xf9001ba0
.word 0x91008341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x14000016
.loc 39 72 0
.word 0x91004340
.word 0xf9001ba0
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000019
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xd280003e
.word 0xb9002b5e
.word 0xd2800020
.word 0x1400000d
.word 0x9280001e
.word 0xb9002b5e
.loc 39 71 0
.word 0xf9401341
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9406830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xaa0103f9
.word 0xb5fffc60
.loc 39 73 0
.word 0xd2a00000
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_237:
.text
	.align 4
	.no_dead_strip Foundation_NSSet__GetEnumeratord__5_System_Collections_Generic_IEnumerator_Foundation_NSObject_get_Current
Foundation_NSSet__GetEnumeratord__5_System_Collections_Generic_IEnumerator_Foundation_NSObject_get_Current:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_238:
.text
	.align 4
	.no_dead_strip Foundation_NSSet_1_TKey_REF__ctor_ObjCRuntime_NativeHandle
Foundation_NSSet_1_TKey_REF__ctor_ObjCRuntime_NativeHandle:
.file 40 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSSet_1.cs"
.loc 40 58 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90017af
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_442
.loc 40 60 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_239:
.text
	.align 4
	.no_dead_strip Foundation_NSSet_1_TKey_REF_System_Collections_Generic_IEnumerable_TKey_GetEnumerator
Foundation_NSSet_1_TKey_REF_System_Collections_Generic_IEnumerable_TKey_GetEnumerator:
.loc 40 129 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000faf
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #464]
.word 0xf9400fa0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf9400fa0
.word 0xf9401000
.word 0xd2800801
bl _p_3
.word 0xf94017a1
.word 0xf9400fa2
.word 0xf940144f
.word 0xf90013a0
bl _p_443
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_23a:
.text
	.align 4
	.no_dead_strip Foundation_NSString_CreateWithCharacters_ObjCRuntime_NativeHandle_string_int_int_bool
Foundation_NSString_CreateWithCharacters_ObjCRuntime_NativeHandle_string_int_int_bool:
.file 41 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSString.cs"
.loc 41 74 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xf9001ba0
.word 0xaa0103f7
.word 0xf90023a2
.word 0xf90027a3
.word 0xf9002ba4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb5000097
.word 0xd2a00000
.word 0x2a0003f7
.word 0x14000007
.word 0xeb1f02ff
.word 0x10000011
.word 0x54000420
.word 0x910052e0
.word 0xf90037a0
.word 0xaa0003f7
.word 0xb98043a0
.loc 41 75 0
.word 0x93407c00
.word 0xd37ff800
.word 0x8b0002f8
.loc 41 79 0
.word 0xf9401ba0
.word 0xf90033a0
.word 0xf94033a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_32@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_32@PAGEOFF
ldr x1, [x1]
.word 0xb9804ba2
.word 0x93407c43
.word 0xaa1803e2
bl _p_316
.word 0xf9002fbf
.word 0xf9002fa0
.word 0xf9402fa0
.word 0xf9001ba0
.loc 41 82 0
.word 0x394143a0
.word 0x34000060
.loc 41 83 0
.word 0xf9401ba0
bl _p_444
.loc 41 85 0
.word 0xf9401ba0
.word 0xf90013a0
.word 0xa94163b7
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_23b:
.text
	.align 4
	.no_dead_strip Foundation_NSString_CreateNative_string_bool
Foundation_NSString_CreateNative_string_bool:
.loc 41 99 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf90017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xb50000e0
.loc 41 100 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9000ba0
.word 0x1400000a
.loc 41 102 0
.word 0xf94013a0
.word 0xb9801002
.word 0x910043a1
.word 0xf9001ba1
.word 0xd2a00001
.word 0x3940a3a3
bl _p_445
.word 0xf9401bbe
.word 0xf90003c0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_23c:
.text
	.align 4
	.no_dead_strip Foundation_NSString_CreateNative_string_int_int_bool
Foundation_NSString_CreateNative_string_int_int_bool:
.loc 41 112 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xf9001ba2
.word 0xf9001fa3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb50000f7
.loc 41 113 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0x14000026
.loc 41 115 0
.word 0x6b1f031f
.word 0x5400052b
.word 0xb98012e0
.word 0x6b00031f
.word 0x540004cc
.loc 41 118 0
.word 0xb98033a0
.word 0x6b1f001f
.word 0x540005ab
.word 0xb98012e0
.word 0xb98033a1
.word 0x4b010000
.word 0x6b00031f
.word 0x5400050c
.loc 41 124 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #472]
.word 0xf9400000
.word 0xf9002ba0
.word 0xf9402ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf90027bf
.word 0xf90027a0
.word 0xf94027a0
.word 0xf90023a0
.loc 41 127 0
.word 0x910083a0
.word 0xf9002fa0
.word 0xf94023a0
.word 0xaa1703e1
.word 0xaa1803e2
.word 0xb98033a3
.word 0x3940e3a4
bl _p_446
.word 0xf9402fbe
.word 0xf90003c0
.word 0xa94163b7
.word 0xf94013a0
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.loc 41 116 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28b3241
bl _p_11
.word 0xaa0003e1
.word 0xd2800a20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 41 119 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd289fd61
bl _p_11
.word 0xaa0003e1
.word 0xd2800a20
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_23d:
.text
	.align 4
	.no_dead_strip Foundation_NSString__ctor_string
Foundation_NSString__ctor_string:
.loc 41 135 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_280
.loc 41 137 0
.word 0xf9400fa0
.word 0xb40002a0
.loc 41 140 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf9400fa1
.word 0xb9801023
.word 0x910083a0
.word 0xf9001ba0
.word 0xf94017a0
.word 0xd2a00002
.word 0xd2a00004
bl _p_446
.word 0xf9401bbe
.word 0xf90003c0
.word 0xf9400ba0
.word 0xf94013a1
bl _p_421
.loc 41 141 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.loc 41 138 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28b33c1
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_23e:
.text
	.align 4
	.no_dead_strip Foundation_NSString_ToString
Foundation_NSString_ToString:
.loc 41 159 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
bl _p_447
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_23f:
.text
	.align 4
	.no_dead_strip Foundation_NSString_FromHandle_ObjCRuntime_NativeHandle
Foundation_NSString_FromHandle_ObjCRuntime_NativeHandle:
.loc 41 180 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_448
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_240:
.text
	.align 4
	.no_dead_strip Foundation_NSString_FromHandle_ObjCRuntime_NativeHandle_bool
Foundation_NSString_FromHandle_ObjCRuntime_NativeHandle_bool:
.loc 41 187 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401fa0
.word 0xf9002ba0
.word 0xf9401ba0
.word 0xf90027a0
.word 0xf9402ba0
.word 0xf94027a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 41 188 0
.word 0xd2800000
.word 0x14000020
.loc 41 194 0
.word 0xf9400ba0
.word 0xf90023a0
.word 0xf94023a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_33@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_33@PAGEOFF
ldr x1, [x1]
bl _p_310
bl _p_117
.word 0xf9002fa0
.word 0xf90033bf
.word 0x94000005
.word 0xf94033a0
.word 0xb4000040
bl _p_23
.word 0x14000010
.word 0xf90037be

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 41 197 0
.word 0x394083a0
.word 0x340000a0
.loc 41 198 0
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf94017a0
bl _p_417
.loc 41 199 0
.word 0xf94037be
.word 0xd61f03c0
.loc 41 200 0
.word 0xf9402fa0
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_241:
.text
	.align 4
	.no_dead_strip Foundation_NSString_Equals_Foundation_NSString_Foundation_NSString
Foundation_NSString_Equals_Foundation_NSString_Foundation_NSString:
.loc 41 204 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xeb1a033f
.word 0x54000061
.loc 41 205 0
.word 0xd2800020
.word 0x14000022
.loc 41 207 0
.word 0xb4000059
.word 0xb500007a
.loc 41 208 0
.word 0xd2a00000
.word 0x1400001e
.loc 41 210 0
.word 0x3940033e
.word 0x91004320
.word 0xf9400000
.word 0xf90017a0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf90013a0
.word 0xf94017a0
.word 0xf90023a0
.word 0xf94013a0
.word 0xf9001fa0
.word 0xf94023a0
.word 0xf9401fa1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 41 211 0
.word 0xd2800020
.word 0x1400000a
.loc 41 212 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba1
.word 0xaa1903e0
.word 0x3940033e
bl _p_449
.word 0x53001c00
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_242:
.text
	.align 4
	.no_dead_strip Foundation_NSString_Equals_object
Foundation_NSString_Equals_object:
.loc 41 227 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013b8
.word 0xf94013a0
.word 0xeb1f001f
.word 0x54000180
.word 0xf94013a0
.word 0xf9400000
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xf9400fa0
.word 0xaa1803e1
bl _p_450
.word 0x53001c00
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_243:
.text
	.align 4
	.no_dead_strip Foundation_NSString_GetHashCode
Foundation_NSString_GetHashCode:
.loc 41 302 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
bl _p_451
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_244:
.text
	.align 4
	.no_dead_strip Foundation_NSString_CompareTo_Foundation_NSString
Foundation_NSString_CompareTo_Foundation_NSString:
.file 42 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSString2.cs"
.loc 42 70 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb5000060
.loc 42 71 0
.word 0x92800000
.word 0x14000008
.loc 42 72 0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf9407450
.word 0xd63f0200
.word 0x93407c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_245:
.text
	.align 4
	.no_dead_strip Foundation_NSString_get_ClassHandle
Foundation_NSString_get_ClassHandle:
.file 43 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSString.g.cs"
.loc 43 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #472]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_246:
.text
	.align 4
	.no_dead_strip Foundation_NSString__ctor_ObjCRuntime_NativeHandle
Foundation_NSString__ctor_ObjCRuntime_NativeHandle:
.loc 43 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 43 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_247:
.text
	.align 4
	.no_dead_strip Foundation_NSString__ctor_Foundation_NSData_Foundation_NSStringEncoding
Foundation_NSString__ctor_Foundation_NSData_Foundation_NSStringEncoding:
.loc 43 98 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 43 100 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #488]
.word 0x9100c3a0
.word 0xf90023a0
.word 0xf9400fa0
bl _p_278
.word 0xf94023be
.word 0xf90003c0
.loc 43 102 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_34@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_34@PAGEOFF
ldr x1, [x1]
.word 0x9100a3a2
.word 0xf90023a2
.word 0xf9401ba2
.word 0xf94013a3
bl _p_452
.word 0xf94023be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #496]
.word 0xf9400ba0
.word 0xf94017a1
bl _p_311
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_248:
.text
	.align 4
	.no_dead_strip Foundation_NSString_Compare_Foundation_NSString
Foundation_NSString_Compare_Foundation_NSString:
.loc 43 181 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #504]
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_278
.word 0xf9401bbe
.word 0xf90003c0
.loc 43 184 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_17@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_17@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_373
.loc 43 188 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_249:
.text
	.align 4
	.no_dead_strip Foundation_NSString_Copy_Foundation_NSZone
Foundation_NSString_Copy_Foundation_NSZone:
.loc 43 252 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 43 255 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 43 259 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 43 260 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 43 261 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_24a:
.text
	.align 4
	.no_dead_strip Foundation_NSString_IsEqualTo_intptr
Foundation_NSString_IsEqualTo_intptr:
.loc 43 480 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_35@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_35@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa2
bl _p_408
.word 0x53001c00
.loc 43 481 0
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_24b:
.text
	.align 4
	.no_dead_strip Foundation_NSString__cctor
Foundation_NSString__cctor:
.loc 43 65 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #712]
.word 0xf9400000
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3880]
bl _p_290
.word 0xf9401ba1
.word 0xf90017a0
bl _p_453
.word 0xf94017a1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #512]
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000001
.loc 43 55 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1064]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #472]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_24c:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone_ToString
Foundation_NSTimeZone_ToString:
.file 44 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSTimeZone.cs"
.loc 44 21 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9406c30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_24d:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone_get_ClassHandle
Foundation_NSTimeZone_get_ClassHandle:
.file 45 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSTimeZone.g.cs"
.loc 45 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #520]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_24e:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone__ctor_ObjCRuntime_NativeHandle
Foundation_NSTimeZone__ctor_ObjCRuntime_NativeHandle:
.loc 45 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 45 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_24f:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone_Copy_Foundation_NSZone
Foundation_NSTimeZone_Copy_Foundation_NSZone:
.loc 45 139 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 45 142 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 45 146 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 45 147 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 45 148 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_250:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone_FromName_string
Foundation_NSTimeZone_FromName_string:
.loc 45 194 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90017bf
.word 0xf9400ba0
.word 0xb5000100
.loc 45 195 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #528]
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 45 196 0
.word 0x9100a3a0
.word 0xf9001ba0
.word 0xf9400ba0
bl _p_454
.word 0xf9401bbe
.word 0xf90003c0
.loc 45 198 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #520]
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_36@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_36@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf9001ba2
.word 0xf94017a2
bl _p_313
.word 0xf9401bbe
.word 0xf90003c0
.word 0xf9400fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #536]
bl _p_455
.word 0xf90023a0
.word 0xf94017a0
.loc 45 199 0
bl _p_456
.word 0xf94023a0
.loc 45 200 0
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_251:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone_get_Name
Foundation_NSTimeZone_get_Name:
.loc 45 335 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_37@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_37@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_252:
.text
	.align 4
	.no_dead_strip Foundation_NSTimeZone__cctor
Foundation_NSTimeZone__cctor:
.loc 45 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #544]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #520]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_253:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_Equals_Foundation_NSUrl
Foundation_NSUrl_Equals_Foundation_NSUrl:
.file 46 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSUrl.cs"
.loc 46 43 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xb500007a
.loc 46 44 0
.word 0xd2a00000
.word 0x14000017
.loc 46 46 0
.word 0xaa1903e0
bl _p_407
.word 0x53001c00
.word 0x340000c0
.word 0xaa1a03e0
.word 0x3940035e
bl _p_407
.word 0x53001c00
.word 0x35000100
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9402c50
.word 0xd63f0200
.word 0x53001c00
.word 0x14000007
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xf9400322
.word 0xf9407450
.word 0xd63f0200
.word 0x53001c00
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_254:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_ToString
Foundation_NSUrl_ToString:
.loc 46 85 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xf9400fa1
.word 0xf9400021
.word 0xf9407030
.word 0xd63f0200
.word 0xaa0003f9
.word 0xb5000080
.word 0xf9400fa0
bl _p_457
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_255:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_get_ClassHandle
Foundation_NSUrl_get_ClassHandle:
.file 47 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSUrl.g.cs"
.loc 47 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #552]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_256:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl__ctor_ObjCRuntime_NativeHandle
Foundation_NSUrl__ctor_ObjCRuntime_NativeHandle:
.loc 47 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 47 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_257:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_Copy_Foundation_NSZone
Foundation_NSUrl_Copy_Foundation_NSZone:
.loc 47 252 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 47 255 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 47 259 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 47 260 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 47 261 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_258:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_IsEqual_Foundation_NSUrl
Foundation_NSUrl_IsEqual_Foundation_NSUrl:
.loc 47 521 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_312
.word 0xf9401bbe
.word 0xf90003c0
.loc 47 524 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_374
.word 0x53001c00
.word 0x53001c00
.loc 47 528 0
.word 0x6b1f001f
.word 0x9a9f97e0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_259:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl_get_AbsoluteString
Foundation_NSUrl_get_AbsoluteString:
.loc 47 742 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_38@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_38@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_25a:
.text
	.align 4
	.no_dead_strip Foundation_NSUrl__cctor
Foundation_NSUrl__cctor:
.loc 47 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #560]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #552]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_25b:
.text
	.align 4
	.no_dead_strip Foundation_NSValue_get_ClassHandle
Foundation_NSValue_get_ClassHandle:
.file 48 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSValue.g.cs"
.loc 48 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #568]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_25c:
.text
	.align 4
	.no_dead_strip Foundation_NSValue__ctor_ObjCRuntime_NativeHandle
Foundation_NSValue__ctor_ObjCRuntime_NativeHandle:
.loc 48 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 48 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_25d:
.text
	.align 4
	.no_dead_strip Foundation_NSValue_Copy_Foundation_NSZone
Foundation_NSValue_Copy_Foundation_NSZone:
.loc 48 87 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 48 90 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 48 94 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 48 95 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 48 96 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_25e:
.text
	.align 4
	.no_dead_strip Foundation_NSValue__cctor
Foundation_NSValue__cctor:
.loc 48 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3080]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #568]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_25f:
.text
	.align 4
	.no_dead_strip Foundation_NSZone__ctor_ObjCRuntime_NativeHandle_bool
Foundation_NSZone__ctor_ObjCRuntime_NativeHandle_bool:
.file 49 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/NSZone.cs"
.loc 49 50 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x540000e0
.word 0x91004000
.word 0xf9400fa1
.word 0xf9000001
.loc 49 51 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_261:
.text
	.align 4
	.no_dead_strip Foundation_NSZone_get_Handle
Foundation_NSZone_get_Handle:
.loc 49 53 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_262:
.text
	.align 4
	.no_dead_strip Foundation_NSZone_set_Handle_ObjCRuntime_NativeHandle
Foundation_NSZone_set_Handle_ObjCRuntime_NativeHandle:
.loc 49 53 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xeb1f001f
.word 0x10000011
.word 0x540000e0
.word 0x91004000
.word 0xf9400fa1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_263:
.text
	.align 4
	.no_dead_strip Foundation_NSZone__cctor
Foundation_NSZone__cctor:
.loc 49 71 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_458
.word 0xf9000fbf
.word 0xf9000fa0
.word 0xf9400fa0
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #576]
.word 0xd2800301
bl _p_3
.word 0xaa0003e1
.word 0xeb1f003f
.word 0x10000011
.word 0x540001c0
.word 0x91004020
.word 0xf9400ba2
.word 0xf9000002

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #584]
.word 0xf90013a0
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000001
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_264:
.text
	.align 4
	.no_dead_strip Foundation_PreserveAttribute__ctor
Foundation_PreserveAttribute__ctor:
.file 50 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/PreserveAttribute.cs"
.loc 50 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_265:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute__ctor
Foundation_ProtocolAttribute__ctor:
.file 51 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/ProtocolAttribute.cs"
.loc 51 34 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_266:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute_get_WrapperType
Foundation_ProtocolAttribute_get_WrapperType:
.loc 51 36 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_267:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute_set_WrapperType_System_Type
Foundation_ProtocolAttribute_set_WrapperType_System_Type:
.loc 51 36 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_268:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute_get_Name
Foundation_ProtocolAttribute_get_Name:
.loc 51 37 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_269:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute_set_Name_string
Foundation_ProtocolAttribute_set_Name_string:
.loc 51 37 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91006001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26a:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolAttribute_get_IsInformal
Foundation_ProtocolAttribute_get_IsInformal:
.loc 51 38 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26b:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute__ctor
Foundation_ProtocolMemberAttribute__ctor:
.loc 51 56 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26c:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_IsRequired
Foundation_ProtocolMemberAttribute_get_IsRequired:
.loc 51 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39418000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26d:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_IsRequired_bool
Foundation_ProtocolMemberAttribute_set_IsRequired_bool:
.loc 51 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39018001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26e:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_IsProperty
Foundation_ProtocolMemberAttribute_get_IsProperty:
.loc 51 59 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39418400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26f:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_IsProperty_bool
Foundation_ProtocolMemberAttribute_set_IsProperty_bool:
.loc 51 59 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39018401
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_270:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_IsStatic
Foundation_ProtocolMemberAttribute_get_IsStatic:
.loc 51 60 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39418800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_271:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_IsStatic_bool
Foundation_ProtocolMemberAttribute_set_IsStatic_bool:
.loc 51 60 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39018801
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_272:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_Name
Foundation_ProtocolMemberAttribute_get_Name:
.loc 51 61 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_273:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_Name_string
Foundation_ProtocolMemberAttribute_set_Name_string:
.loc 51 61 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_274:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_Selector
Foundation_ProtocolMemberAttribute_get_Selector:
.loc 51 62 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_275:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_Selector_string
Foundation_ProtocolMemberAttribute_set_Selector_string:
.loc 51 62 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91006001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_276:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ReturnType
Foundation_ProtocolMemberAttribute_get_ReturnType:
.loc 51 63 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_277:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_ReturnType_System_Type
Foundation_ProtocolMemberAttribute_set_ReturnType_System_Type:
.loc 51 63 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91008001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_278:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ReturnTypeDelegateProxy
Foundation_ProtocolMemberAttribute_get_ReturnTypeDelegateProxy:
.loc 51 64 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_279:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ParameterType
Foundation_ProtocolMemberAttribute_get_ParameterType:
.loc 51 65 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27a:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_ParameterType_System_Type__
Foundation_ProtocolMemberAttribute_set_ParameterType_System_Type__:
.loc 51 65 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x9100c001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27b:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ParameterByRef
Foundation_ProtocolMemberAttribute_get_ParameterByRef:
.loc 51 66 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9401c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27c:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_ParameterByRef_bool__
Foundation_ProtocolMemberAttribute_set_ParameterByRef_bool__:
.loc 51 66 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x9100e001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27d:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ParameterBlockProxy
Foundation_ProtocolMemberAttribute_get_ParameterBlockProxy:
.loc 51 67 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27e:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_ParameterBlockProxy_System_Type__
Foundation_ProtocolMemberAttribute_set_ParameterBlockProxy_System_Type__:
.loc 51 67 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91010001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27f:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_IsVariadic
Foundation_ProtocolMemberAttribute_get_IsVariadic:
.loc 51 68 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39418c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_280:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_PropertyType
Foundation_ProtocolMemberAttribute_get_PropertyType:
.loc 51 70 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_281:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_PropertyType_System_Type
Foundation_ProtocolMemberAttribute_set_PropertyType_System_Type:
.loc 51 70 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91012001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_282:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_GetterSelector
Foundation_ProtocolMemberAttribute_get_GetterSelector:
.loc 51 71 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_283:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_GetterSelector_string
Foundation_ProtocolMemberAttribute_set_GetterSelector_string:
.loc 51 71 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91014001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_284:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_SetterSelector
Foundation_ProtocolMemberAttribute_get_SetterSelector:
.loc 51 72 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9402c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_285:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_SetterSelector_string
Foundation_ProtocolMemberAttribute_set_SetterSelector_string:
.loc 51 72 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91016001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_286:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_get_ArgumentSemantic
Foundation_ProtocolMemberAttribute_get_ArgumentSemantic:
.loc 51 73 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xb9806400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_287:
.text
	.align 4
	.no_dead_strip Foundation_ProtocolMemberAttribute_set_ArgumentSemantic_ObjCRuntime_ArgumentSemantic
Foundation_ProtocolMemberAttribute_set_ArgumentSemantic_ObjCRuntime_ArgumentSemantic:
.loc 51 73 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xb9801ba1
.word 0xf9400ba0
.word 0xb9006401
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_288:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute__ctor
Foundation_RegisterAttribute__ctor:
.file 52 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/Foundation/RegisterAttribute.cs"
.loc 52 33 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_289:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute__ctor_string
Foundation_RegisterAttribute__ctor_string:
.loc 52 36 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x91004001
.word 0xd5033bbf
.word 0xf9400fa0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 52 37 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28a:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute__ctor_string_bool
Foundation_RegisterAttribute__ctor_string_bool:
.loc 52 41 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xf9001ba0
.word 0x91004002
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9400fa1
.word 0xf9000041
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e
.loc 52 42 0
.word 0x394083a1
.word 0x39006001
.loc 52 43 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_28b:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute_get_Name
Foundation_RegisterAttribute_get_Name:
.loc 52 46 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28c:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute_get_IsWrapper
Foundation_RegisterAttribute_get_IsWrapper:
.loc 52 51 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39406000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28d:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute_get_SkipRegistration
Foundation_RegisterAttribute_get_SkipRegistration:
.loc 52 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39406400
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28e:
.text
	.align 4
	.no_dead_strip Foundation_RegisterAttribute_set_SkipRegistration_bool
Foundation_RegisterAttribute_set_SkipRegistration_bool:
.loc 52 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0x394063a1
.word 0xf9400ba0
.word 0x39006401
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_28f:
.text
	.align 4
	.no_dead_strip Foundation_NSAutoreleasePool_get_ClassHandle
Foundation_NSAutoreleasePool_get_ClassHandle:
.file 53 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSAutoreleasePool.g.cs"
.loc 53 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_290:
.text
	.align 4
	.no_dead_strip Foundation_NSAutoreleasePool__ctor
Foundation_NSAutoreleasePool__ctor:
.loc 53 60 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_309
.loc 53 63 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1888]
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_311
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_291:
.text
	.align 4
	.no_dead_strip Foundation_NSAutoreleasePool__ctor_ObjCRuntime_NativeHandle
Foundation_NSAutoreleasePool__ctor_ObjCRuntime_NativeHandle:
.loc 53 77 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 53 79 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_292:
.text
	.align 4
	.no_dead_strip Foundation_NSAutoreleasePool__cctor
Foundation_NSAutoreleasePool__cctor:
.loc 53 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #592]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_293:
.text
	.align 4
	.no_dead_strip Foundation_NSCopyingWrapper__ctor_ObjCRuntime_NativeHandle_bool
Foundation_NSCopyingWrapper__ctor_ObjCRuntime_NativeHandle_bool:
.file 54 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSCopying.g.cs"
.loc 54 65 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_277
.loc 54 67 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_295:
.text
	.align 4
	.no_dead_strip Foundation_NSCopyingWrapper_Copy_Foundation_NSZone
Foundation_NSCopyingWrapper_Copy_Foundation_NSZone:
.loc 54 73 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 54 75 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 54 76 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 54 77 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 54 78 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_296:
.text
	.align 4
	.no_dead_strip Foundation_NSEnumerator_get_ClassHandle
Foundation_NSEnumerator_get_ClassHandle:
.file 55 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSEnumerator.g.cs"
.loc 55 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #608]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_297:
.text
	.align 4
	.no_dead_strip Foundation_NSEnumerator__ctor_ObjCRuntime_NativeHandle
Foundation_NSEnumerator__ctor_ObjCRuntime_NativeHandle:
.loc 55 77 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 55 79 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_298:
.text
	.align 4
	.no_dead_strip Foundation_NSEnumerator_NextObject
Foundation_NSEnumerator_NextObject:
.loc 55 86 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_39@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_39@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_314
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_299:
.text
	.align 4
	.no_dead_strip Foundation_NSEnumerator__cctor
Foundation_NSEnumerator__cctor:
.loc 55 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #616]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #608]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_29a:
.text
	.align 4
	.no_dead_strip Foundation_NSException_get_ClassHandle
Foundation_NSException_get_ClassHandle:
.file 56 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSException.g.cs"
.loc 56 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #624]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_29b:
.text
	.align 4
	.no_dead_strip Foundation_NSException__ctor_ObjCRuntime_NativeHandle
Foundation_NSException__ctor_ObjCRuntime_NativeHandle:
.loc 56 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 56 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_29c:
.text
	.align 4
	.no_dead_strip Foundation_NSException_Copy_Foundation_NSZone
Foundation_NSException_Copy_Foundation_NSZone:
.loc 56 108 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 56 111 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 56 115 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 56 116 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 56 117 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_29d:
.text
	.align 4
	.no_dead_strip Foundation_NSException_get_CallStackSymbols
Foundation_NSException_get_CallStackSymbols:
.loc 56 148 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_40@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_40@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_459
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_29e:
.text
	.align 4
	.no_dead_strip Foundation_NSException_get_Name
Foundation_NSException_get_Name:
.loc 56 159 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_37@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_37@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_29f:
.text
	.align 4
	.no_dead_strip Foundation_NSException_get_Reason
Foundation_NSException_get_Reason:
.loc 56 170 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_41@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_41@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a0:
.text
	.align 4
	.no_dead_strip Foundation_NSException__cctor
Foundation_NSException__cctor:
.loc 56 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #632]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #624]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a1:
.text
	.align 4
	.no_dead_strip Foundation_NSInvocation_get_ClassHandle
Foundation_NSInvocation_get_ClassHandle:
.file 57 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSInvocation.g.cs"
.loc 57 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #640]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a2:
.text
	.align 4
	.no_dead_strip Foundation_NSInvocation__ctor_ObjCRuntime_NativeHandle
Foundation_NSInvocation__ctor_ObjCRuntime_NativeHandle:
.loc 57 65 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 57 67 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a3:
.text
	.align 4
	.no_dead_strip Foundation_NSInvocation_Dispose_bool
Foundation_NSInvocation_Dispose_bool:
.loc 57 194 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 57 195 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 57 198 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a4:
.text
	.align 4
	.no_dead_strip Foundation_NSInvocation__cctor
Foundation_NSInvocation__cctor:
.loc 57 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #648]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #640]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a5:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableArray_get_ClassHandle
Foundation_NSMutableArray_get_ClassHandle:
.file 58 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSMutableArray.g.cs"
.loc 58 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #656]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a6:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableArray__ctor_ObjCRuntime_NativeHandle
Foundation_NSMutableArray__ctor_ObjCRuntime_NativeHandle:
.loc 58 91 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_317
.loc 58 93 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a7:
.text
	.align 4
	.no_dead_strip Foundation_NSMutableArray__cctor
Foundation_NSMutableArray__cctor:
.loc 58 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #664]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #656]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a8:
.text
	.align 4
	.no_dead_strip Foundation_NSUserActivity_get_ClassHandle
Foundation_NSUserActivity_get_ClassHandle:
.file 59 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/Foundation/NSUserActivity.g.cs"
.loc 59 60 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #672]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2a9:
.text
	.align 4
	.no_dead_strip Foundation_NSUserActivity__ctor_ObjCRuntime_NativeHandle
Foundation_NSUserActivity__ctor_ObjCRuntime_NativeHandle:
.loc 59 69 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 59 71 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2aa:
.text
	.align 4
	.no_dead_strip Foundation_NSUserActivity_Dispose_bool
Foundation_NSUserActivity_Dispose_bool:
.loc 59 952 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 59 953 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 59 956 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2ab:
.text
	.align 4
	.no_dead_strip Foundation_NSUserActivity__cctor
Foundation_NSUserActivity__cctor:
.loc 59 59 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #680]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #672]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2ac:
.text
ut_685:
add x0, x0, 16
b CoreLocation_CLLocationCoordinate2D_ToString
ut_end:
.section __TEXT, __const
_unbox_trampoline_p:

	.long 0
LDIFF_SYM3=ut_end - ut_685
	.long LDIFF_SYM3
.text
	.align 4
	.no_dead_strip CoreLocation_CLLocationCoordinate2D_ToString
CoreLocation_CLLocationCoordinate2D_ToString:
.file 60 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreLocation/CoreLocation.cs"
.loc 60 77 0 prologue_end
.word 0xa9b27bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xf9001bb9
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9005ba0
.word 0xf9005fa0
.word 0xf90063a0
.word 0xf90067a0
.word 0xf9006ba0
.word 0x9102c3a0
.word 0xd28002c1
.word 0xd2800042
bl _p_267

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #688]
.word 0x9102c3b9
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54001240
.word 0x91004321
.word 0xb980d3a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x54001148
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf90053a2
.word 0xf90057a2
.word 0xf90053a1
.word 0xb900aba0
.word 0xf94053a0
.word 0xf9002ba0
.word 0xf94057a0
.word 0xf9002fa0
.word 0xaa1703f6
.word 0xf9402ba0
.word 0xf9004ba0
.word 0xf9402fa0
.word 0xf9004fa0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb9809ba1
.word 0x6b01001f
.word 0x540001a8
.word 0xf9404ba0
.word 0xeb1f02df
.word 0x10000011
.word 0x54000d80
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf90047bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802320
.word 0xb9801301
.word 0xb010000
.word 0xb9002320
.word 0x14000004
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_261
.word 0xf9401fa0
.word 0xfd400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #696]
.word 0x9102c3a0
bl _p_460

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #704]
.word 0x9102c3b9
.word 0xaa0003f8
.word 0xaa0003f7
.word 0xeb1f033f
.word 0x10000011
.word 0x54000940
.word 0x91004321
.word 0xb980d3a0
.word 0xaa0103f6
.word 0xaa0003f5
.word 0xb9800821
.word 0x6b01001f
.word 0x54000828
.word 0xf94002c0
.word 0x2a1503e1
.word 0xd37ff821
.word 0x8b010001
.word 0xb9800ac0
.word 0x4b150000
.word 0xd2800002
.word 0xf9003fa2
.word 0xf90043a2
.word 0xf9003fa1
.word 0xb90083a0
.word 0xf9403fa0
.word 0xf90023a0
.word 0xf94043a0
.word 0xf90027a0
.word 0xaa1703f6
.word 0xf94023a0
.word 0xf90037a0
.word 0xf94027a0
.word 0xf9003ba0
.word 0x394002fe
.word 0xd2a00000
.word 0x53001c17
.word 0xb98012c0
.word 0xb98073a1
.word 0x6b01001f
.word 0x540001a8
.word 0xf94037a0
.word 0xeb1f02df
.word 0x10000011
.word 0x54000480
.word 0x910052c1
.word 0xb98012c2
.word 0x2a0203e2
.word 0xf90033bf
.word 0xd37ff842
bl _p_260
.word 0xd2800020
.word 0x53001c17
.word 0x53001ee0
.word 0x340000c0
.word 0xb9802320
.word 0xb9801301
.word 0xb010000
.word 0xb9002320
.word 0x14000004
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_261
.word 0xf9401fa0
.word 0xfd400400

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #696]
.word 0x9102c3a0
bl _p_460
.word 0x9102c3a0
bl _p_264
.word 0xa9415bb5
.word 0xa94263b7
.word 0xf9401bb9
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0
bl _p_268
bl _p_268
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_2ad:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor__ctor_ObjCRuntime_NativeHandle_bool
CoreGraphics_CGColor__ctor_ObjCRuntime_NativeHandle_bool:
.file 61 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreGraphics/CGColor.cs"
.loc 61 63 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_461
.loc 61 65 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2ae:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_Retain
CoreGraphics_CGColor_Retain:
.loc 61 69 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910063a0
.word 0xf90013a0
.word 0xf9400ba0
bl _p_462
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_463
.loc 61 70 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2af:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_Release
CoreGraphics_CGColor_Release:
.loc 61 74 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910063a0
.word 0xf90013a0
.word 0xf9400ba0
bl _p_462
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_464
.loc 61 75 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2b0:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_GetHashCode
CoreGraphics_CGColor_GetHashCode:
.loc 61 236 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xd2a00000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2b2:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_Equals_object
CoreGraphics_CGColor_Equals_object:
.loc 61 241 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #712]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803fa
.loc 61 242 0
.word 0xb5000078
.loc 61 243 0
.word 0xd2a00000
.word 0x1400000d
.loc 61 245 0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
.word 0x3940035e
.word 0x91004341
.word 0xf9400021
.word 0xf90017a1
.word 0xf94017a1
bl _p_465
.word 0x53001c00
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2b3:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_get_NumberOfComponents
CoreGraphics_CGColor_get_NumberOfComponents:
.loc 61 253 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
bl _p_466
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2b5:
.text
	.align 4
	.no_dead_strip CoreGraphics_CGColor_get_Components
CoreGraphics_CGColor_get_Components:
.loc 61 262 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
bl _p_467
.word 0x93407c19
.loc 61 263 0
.word 0xaa1903e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #720]
bl _p_42
.word 0xaa0003f8
.loc 61 265 0
.word 0x91004340
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
bl _p_468
.word 0xaa0003fa
.loc 61 267 0
.word 0xd2a00017
.word 0x14000017

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 61 268 0
.word 0x93407ee0
.word 0xd37df000
.word 0x8b000340
.word 0xf9400000
.word 0xf9001ba0
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x540001e9
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9401ba1
.word 0xf9000001
.loc 61 267 0
.word 0x110006f7
.word 0x6b1902ff
.word 0x54fffd2b
.loc 61 271 0
.word 0xaa1803e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2b7:
.text
ut_698:
add x0, x0, 16
b CoreGraphics_CGPoint_GetHashCode
.text
	.align 4
	.no_dead_strip CoreGraphics_CGPoint_GetHashCode
CoreGraphics_CGPoint_GetHashCode:
.file 62 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreGraphics/CGPoint.cs"
.loc 62 25 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xaa0003e1
.word 0xf9400021
.word 0xf90013a1
.word 0x91002000
.word 0xf9400000
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #728]
.word 0xfd4013a0
.word 0xfd400fa1
bl _p_469
.word 0x93407c00
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2ba:
.text
ut_700:
add x0, x0, 16
b CoreGraphics_CGPoint_ToString
.text
	.align 4
	.no_dead_strip CoreGraphics_CGPoint_ToString
CoreGraphics_CGPoint_ToString:
.loc 62 41 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400001
.word 0xf90013a1
.word 0xf9400400
.word 0xf90017a0
.word 0xfd4013a0
.word 0xfd4017a1
bl _p_470
.word 0xf9001bbf
.word 0xf9001ba0
.word 0xf9401ba0
.word 0xf9000fa0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2bc:
.text
ut_701:
add x0, x0, 16
b CoreGraphics_CGPoint_Equals_object
.text
	.align 4
	.no_dead_strip CoreGraphics_CGPoint_Equals_object
CoreGraphics_CGPoint_Equals_object:
.file 63 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/common/NativeTypes/Drawing.cs"
.loc 63 152 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000100
.word 0xf9400340

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #736]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xb4000338
.word 0xf9400340
.word 0x3940d001
.word 0xeb1f003f
.word 0x10000011
.word 0x54000341
.word 0xf9400000
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #744]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0x91004340
.word 0xf9400001
.word 0xf90017a1
.word 0xf9400400
.word 0xf9001ba0
.word 0xf94013a0
.word 0xfd4017a0
.word 0xfd401ba1
bl _p_471
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_2bd:
.text
ut_702:
add x0, x0, 16
b CoreGraphics_CGPoint_Equals_CoreGraphics_CGPoint
.text
	.align 4
	.no_dead_strip CoreGraphics_CGPoint_Equals_CoreGraphics_CGPoint
CoreGraphics_CGPoint_Equals_CoreGraphics_CGPoint:
.loc 63 157 0 prologue_end
.word 0xa9b67bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xfd0013a1
.word 0x910063a0
.word 0xf9400000
.word 0xf9003ba0
.word 0xf9400ba0
.word 0xf9400000
.word 0xf90037a0
.word 0xf9403ba0
.word 0xf9004ba0
.word 0xf94037a0
.word 0xf90047a0
.word 0xfd404ba0
.word 0xfd4047a1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000260
.word 0x910063a0
.word 0x91002000
.word 0xf9400000
.word 0xf90033a0
.word 0xf9400ba0
.word 0x91002000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf94033a0
.word 0xf90043a0
.word 0xf9402fa0
.word 0xf9003fa0
.word 0xfd4043a0
.word 0xfd403fa1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0

Lme_2be:
.text
ut_703:
add x0, x0, 16
b CoreGraphics_CGRect_GetHashCode
.text
	.align 4
	.no_dead_strip CoreGraphics_CGRect_GetHashCode
CoreGraphics_CGRect_GetHashCode:
.file 64 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreGraphics/CGRect.cs"
.loc 64 17 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400340
.word 0xf9001ba0
.word 0x91002340
.word 0xf9400000
.word 0xf90017a0
.word 0x91004340
.word 0xf9400000
.word 0xf90013a0
.word 0x91006340
.word 0xf9400000
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #752]
.word 0xfd401ba0
.word 0xfd4017a1
.word 0xfd4013a2
.word 0xfd400fa3
bl _p_472
.word 0x93407c00
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2bf:
.text
ut_705:
add x0, x0, 16
b CoreGraphics_CGRect_ToString
.text
	.align 4
	.no_dead_strip CoreGraphics_CGRect_ToString
CoreGraphics_CGRect_ToString:
.loc 64 33 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400001
.word 0xf90013a1
.word 0xf9400401
.word 0xf90017a1
.word 0xf9400801
.word 0xf9001ba1
.word 0xf9400c00
.word 0xf9001fa0
.word 0xfd4013a0
.word 0xfd4017a1
.word 0xfd401ba2
.word 0xfd401fa3
bl _p_473
.word 0xf90023bf
.word 0xf90023a0
.word 0xf94023a0
.word 0xf9000fa0
.word 0xf9400fa0
bl _p_360
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2c1:
.text
ut_706:
add x0, x0, 16
b CoreGraphics_CGRect_Equals_object
.text
	.align 4
	.no_dead_strip CoreGraphics_CGRect_Equals_object
CoreGraphics_CGRect_Equals_object:
.loc 63 666 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000100
.word 0xf9400340

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #760]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xb40003f8
.word 0xf9400340
.word 0x3940d001
.word 0xeb1f003f
.word 0x10000011
.word 0x54000401
.word 0xf9400000
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #768]
.word 0xeb01001f
.word 0x10000011
.word 0x54000301
.word 0x91004340
.word 0xf9400001
.word 0xf90017a1
.word 0xf9400401
.word 0xf9001ba1
.word 0xf9400801
.word 0xf9001fa1
.word 0xf9400c00
.word 0xf90023a0
.word 0xf94013a0
.word 0xfd4017a0
.word 0xfd401ba1
.word 0xfd401fa2
.word 0xfd4023a3
bl _p_474
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801320
.word 0xaa1103e1
bl _p_9

Lme_2c2:
.text
ut_707:
add x0, x0, 16
b CoreGraphics_CGRect_Equals_CoreGraphics_CGRect
.text
	.align 4
	.no_dead_strip CoreGraphics_CGRect_Equals_CoreGraphics_CGRect
CoreGraphics_CGRect_Equals_CoreGraphics_CGRect:
.loc 63 671 0 prologue_end
.word 0xa9b27bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xfd000fa0
.word 0xfd0013a1
.word 0xfd0017a2
.word 0xfd001ba3
.word 0xf9400340
.word 0xf9004ba0
.word 0x910063a0
.word 0xf9400000
.word 0xf90047a0
.word 0xf9404ba0
.word 0xf9006ba0
.word 0xf94047a0
.word 0xf90067a0
.word 0xfd406ba0
.word 0xfd4067a1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000680
.word 0x91002340
.word 0xf9400000
.word 0xf90043a0
.word 0x910063a0
.word 0x91002000
.word 0xf9400000
.word 0xf9003fa0
.word 0xf94043a0
.word 0xf90063a0
.word 0xf9403fa0
.word 0xf9005fa0
.word 0xfd4063a0
.word 0xfd405fa1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000460
.word 0x91004340
.word 0xf9400000
.word 0xf9003ba0
.word 0x910063a0
.word 0x91004000
.word 0xf9400000
.word 0xf90037a0
.word 0xf9403ba0
.word 0xf9005ba0
.word 0xf94037a0
.word 0xf90057a0
.word 0xfd405ba0
.word 0xfd4057a1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000240
.word 0x91006340
.word 0xf9400000
.word 0xf90033a0
.word 0x910063a0
.word 0x91006000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf94033a0
.word 0xf90053a0
.word 0xf9402fa0
.word 0xf9004fa0
.word 0xfd4053a0
.word 0xfd404fa1
.word 0x1e612000
.word 0x9a9f17e0
.word 0x53001c00
.word 0x14000002
.word 0xd2a00000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8ce7bfd
.word 0xd65f03c0

Lme_2c3:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray__ctor_ObjCRuntime_NativeHandle_bool
CoreFoundation_CFArray__ctor_ObjCRuntime_NativeHandle_bool:
.file 65 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreFoundation/CFArray.cs"
.loc 65 68 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_461
.loc 65 70 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2c4:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray_StringArrayFromHandle_ObjCRuntime_NativeHandle
CoreFoundation_CFArray_StringArrayFromHandle_ObjCRuntime_NativeHandle:
.loc 65 166 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #776]
.word 0xf9400000
.word 0xaa0003e1
.word 0xf9400fa2
.word 0xf90017a2
.word 0xaa0103fa
.word 0xb5000380

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #784]
.word 0xd2801001
bl _p_3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #792]
.word 0xf9002001

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #800]
.word 0xf9001402
.word 0xf9401822
.word 0xf9000c02
.word 0xf9401421
.word 0xf9000801
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #776]
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xf94017a1
.word 0xf90017a1
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #808]
.word 0xf94017a0
.word 0xaa1a03e1
bl _p_475
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2c7:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray_ArrayFromHandle_T_REF_ObjCRuntime_NativeHandle
CoreFoundation_CFArray_ArrayFromHandle_T_REF_ObjCRuntime_NativeHandle:
.loc 65 180 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9001baf
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #816]
.word 0xf9401ba0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xf9401ba0
.word 0xf9401000
.word 0xf9400000
.word 0xaa0003e1
.word 0xf9400fa2
.word 0xf90017a2
.word 0xaa0103fa
.word 0xb50002e0
.word 0xf9401ba0
.word 0xf9401400
.word 0xd2801001
bl _p_3
.word 0xf9401ba1
.word 0xf9401821
.word 0xf9002001
.word 0xf9400822
.word 0xf9001402
.word 0xf9401822
.word 0xf9000c02
.word 0xf9401421
.word 0xf9000801
.word 0xf90023a0
.word 0xf9401ba0
.word 0xf9401001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xf94017a1
.word 0xf90017a1
.word 0xaa0003fa
.word 0xf9401ba0
.word 0xf9401c0f
.word 0xf94017a0
.word 0xaa1a03e1
bl _p_476
.loc 65 181 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2c8:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray_DefaultConvert_T_REF_ObjCRuntime_NativeHandle
CoreFoundation_CFArray_DefaultConvert_T_REF_ObjCRuntime_NativeHandle:
.loc 65 194 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf90023af
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #824]
.word 0xf94023a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #832]
.word 0xf9400000
.word 0xf90013a0
.word 0xf9400ba0
.word 0xf9001fa0
.word 0xf94013a0
.word 0xf9001ba0
.word 0xf9401fa0
.word 0xf9401ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000140
.loc 65 195 0
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf94017a0
.word 0xf94023a1
.word 0xf940142f
.word 0xd2a00001
.word 0xd2a00002
bl _p_477
.word 0x14000002
.loc 65 196 0
.word 0xd2800000
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2c9:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray_ArrayFromHandleFunc_T_REF_ObjCRuntime_NativeHandle_System_Func_2_ObjCRuntime_NativeHandle_T_REF
CoreFoundation_CFArray_ArrayFromHandleFunc_T_REF_ObjCRuntime_NativeHandle_System_Func_2_ObjCRuntime_NativeHandle_T_REF:
.loc 65 202 0 prologue_end
.word 0xa9b17bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xf90063af
.word 0xf9001fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #840]
.word 0xf94063a0
.word 0xf9400c10
.word 0xb5000050
bl _mini_init_method_rgctx
.word 0xd2800000
.word 0xf9006fa0
.word 0xf90073a0
.word 0xd2800000
.word 0xf90067a0
.word 0xf9006ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90033a0
.word 0xf9401fa0
.word 0xf9005fa0
.word 0xf94033a0
.word 0xf9005ba0
.word 0xf9405fa0
.word 0xf9405ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 65 203 0
.word 0xd2800000
.word 0x14000099
.loc 65 205 0
.word 0xf9401fa0
.word 0xf90057a0
.word 0xf94057a0
bl _p_478
.word 0x93407c19
.loc 65 206 0
.word 0xaa1903e0
.word 0x35000140
.loc 65 207 0
.word 0xf94063a0
.word 0xf9401000
.word 0x3980d410
.word 0xb5000050
bl _p_31
.word 0xf94063a0
.word 0xf9401400
.word 0xf9400000
.word 0x14000089
.loc 65 209 0
.word 0xd280201e
.word 0x6b1e033f
.word 0x540004cc
.word 0xaa1903f8
.word 0x2a1903e0
.word 0xd2800101
bl _p_479
.word 0xaa0003f7
.word 0xb5000077
.word 0xd2800016
.word 0x1400000e
.word 0x91003ef0
.word 0x928001f1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f6
.word 0xd2800000
.word 0xf9004fa0
.word 0xf90053a0
.word 0x910263b7
.word 0xf90077b6
.word 0xaa1803f6
.word 0x6b1f031f
.word 0x54000deb
.word 0xf94077a0
.word 0xf90002e0
.word 0xb9000af6
.word 0xf9404fa0
.word 0xf90067a0
.word 0xf94053a0
.word 0xf9006ba0
.word 0x14000019

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #848]
.word 0xaa1903e1
bl _p_42
.word 0xd2800001
.word 0xf90047a1
.word 0xf9004ba1
.word 0x910223b8
.word 0xaa0003f7
.word 0xb50000a0
.word 0xd2800000
.word 0xf9000300
.word 0xf9000700
.word 0x14000006
.word 0x394002fe
.word 0x910082e0
.word 0xf9000300
.word 0xb9801ae0
.word 0xb9000b00
.word 0xf94047a0
.word 0xf90067a0
.word 0xf9404ba0
.word 0xf9006ba0
.word 0xf94067a0
.word 0xf9006fa0
.word 0xf9406ba0
.word 0xf90073a0
.loc 65 211 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #856]
.word 0x910363a0
bl _p_480
.word 0xaa0003f8
.word 0xaa1803f7
.loc 65 212 0
.word 0xf9401fa0
.word 0xf90043a0
.word 0xf94043a0
.word 0xd2800001
.word 0xf9003ba1
.word 0xf9003fa1
.word 0xf9003bbf
.word 0x93407f21
.word 0xf9003fa1
.word 0xf9403ba1
.word 0xf9002ba1
.word 0xf9403fa1
.word 0xf9002fa1
.word 0xf9402ba1
.word 0xf9402fa2
.word 0xaa1703e3
bl _p_481
.word 0xd2a00000
.word 0x2a0003f8
.loc 65 215 0
.word 0xf94063a0
.word 0xf9401800
.word 0xaa1903e1
bl _p_42
.word 0xaa0003f8
.loc 65 216 0
.word 0xd2a00017
.word 0x14000021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 65 217 0
.word 0xf9406fa0
.word 0x93407ee1
.word 0xb980e3a2
.word 0xeb01005f
.word 0x10000011
.word 0x540003e9
.word 0xd37df021
.word 0x8b010000
.word 0xf9400000
.word 0xf90037bf
.word 0xf90037a0
.word 0xf94037a0
.word 0xf90027a0
.word 0xf94063a0
.word 0xf9401c00
.word 0xaa1a03e0
.word 0xf94027a1
.word 0xf9400f50
.word 0xd63f0200
.word 0xaa0003e2
.word 0xaa1803e0
.word 0xaa1703e1
.word 0xf9400303
.word 0xf9404070
.word 0xd63f0200
.loc 65 216 0
.word 0x110006f7
.word 0x6b1902ff
.word 0x54fffbeb
.loc 65 219 0
.word 0xaa1803e0
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8cf7bfd
.word 0xd65f03c0
bl _p_268
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2ca:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray_get__CFNullHandle
CoreFoundation_CFArray_get__CFNullHandle:
.file 66 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/CoreFoundation/CFArray.g.cs"
.loc 66 56 0 prologue_end
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #864]
.word 0xf9400000

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #872]
bl _p_482
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_2cb:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFArray__cctor
CoreFoundation_CFArray__cctor:
.loc 65 57 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_483
.word 0xf9000fbf
.word 0xf9000fa0
.word 0xf9400fa0
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #832]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2cc:
.text
ut_717:
add x0, x0, 16
b CoreFoundation_CFRange__ctor_int_int
.text
	.align 4
	.no_dead_strip CoreFoundation_CFRange__ctor_int_int
CoreFoundation_CFRange__ctor_int_int:
.file 67 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreFoundation/CFString.cs"
.loc 67 80 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xb9801ba0
.word 0x93407c01
.word 0xf9400ba0
.word 0xf9000001
.loc 67 81 0
.word 0xb98023a1
.word 0x93407c21
.word 0xf9000401
.loc 67 82 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2cd:
.text
ut_718:
add x0, x0, 16
b CoreFoundation_CFRange_ToString
.text
	.align 4
	.no_dead_strip CoreFoundation_CFRange_ToString
CoreFoundation_CFRange_ToString:
.loc 67 98 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #880]
.word 0xf90013a0
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9001fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xd2800301
bl _p_3
.word 0xf9401fa1
.word 0xf9000801
.word 0xf90017a0
.word 0xf9400ba0
.word 0xf9400400
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #888]
.word 0xd2800301
bl _p_3
.word 0xaa0003e2
.word 0xf94013a0
.word 0xf94017a1
.word 0xf9401ba3
.word 0xf9000843
bl _p_12
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2ce:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFString_CreateNative_string
CoreFoundation_CFString_CreateNative_string:
.loc 67 146 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90023bf
.word 0xf9001fbf
.word 0xf94013a0
.word 0xb50000e0
.loc 67 147 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9000ba0
.word 0x14000024
.loc 67 149 0
.word 0x910103a0
.word 0xf94013a1
.word 0xd2800062
bl _p_484
.loc 67 150 0
.word 0xf94023a0
.word 0xf9001ba0
.word 0xf9401ba1
.word 0xf94013a0
.word 0xb9801000
.word 0x93407c02
.word 0xd2800000
bl _p_485
.word 0xf90017bf
.word 0xf90017a0
.word 0xf94017a0
.word 0xf9001fa0
.word 0xf90027bf
.word 0x94000005
.word 0xf94027a0
.word 0xb4000040
bl _p_23
.word 0x1400000c
.word 0xf9002bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910103a0
bl _p_486
.word 0xf9402bbe
.word 0xd61f03c0
.loc 67 151 0
.word 0xf9401fa0
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_2d5:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFString_ReleaseNative_ObjCRuntime_NativeHandle
CoreFoundation_CFString_ReleaseNative_ObjCRuntime_NativeHandle:
.loc 67 155 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0xf9400ba0
.word 0xf9001fa0
.word 0xf94013a0
.word 0xf9001ba0
.word 0xf9401fa0
.word 0xf9401ba1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340000a0
.loc 67 156 0
.word 0xf9400ba0
.word 0xf90017a0
.word 0xf94017a0
bl _p_487
.loc 67 157 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2d6:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFString__ctor_ObjCRuntime_NativeHandle_bool
CoreFoundation_CFString__ctor_ObjCRuntime_NativeHandle_bool:
.loc 67 185 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_461
.loc 67 187 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2d7:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFString_FromHandle_ObjCRuntime_NativeHandle
CoreFoundation_CFString_FromHandle_ObjCRuntime_NativeHandle:
.loc 67 192 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800000
.word 0xf9003ba0
.word 0xf9003fa0
.word 0xf9401ba0
.word 0xf90037a0
.word 0xf94037a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x34000060
.loc 67 193 0
.word 0xd2800000
.word 0x14000050
.loc 67 195 0
.word 0xf9401ba0
.word 0xf90033a0
.word 0xf94033a0
bl _p_488
.word 0x93407c1a
.loc 67 196 0
.word 0xaa1a03e0
.word 0x350000c0
.loc 67 197 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #712]
.word 0xf9400000
.word 0x14000044
.loc 67 200 0
.word 0xd2a00000
.word 0x53001c19
.loc 67 201 0
.word 0xf9003bbf
.word 0x93407f40
.word 0xf9003fa0
.loc 67 204 0
.word 0xf9401ba0
.word 0xf9002fa0
.word 0xf9402fa0
bl _p_489
.word 0xaa0003f8
.loc 67 205 0
.word 0xaa1803e0
.word 0xd2a00001
.word 0x2a0103e1
.word 0xeb01001f
.word 0x54000561
.loc 67 207 0
.word 0xd280101e
.word 0x6b1e035f
.word 0x9a9fd7e0
.word 0x53001c19
.loc 67 210 0
.word 0xaa1903e0
.word 0x340000a0
.loc 67 211 0
.word 0x531f7b40
bl _p_300
.word 0xaa0003f8
.word 0x14000016
.loc 67 214 0
.word 0x2a1a03e0
.word 0xd2800041
bl _p_479
.word 0xaa0003f8
.word 0xb5000078
.word 0xd2800017
.word 0x1400000e
.word 0x91003f10
.word 0x928001f1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f7
.loc 67 215 0
.word 0xaa1703f8
.loc 67 217 0
.word 0xf9401ba0
.word 0xf9002ba0
.word 0xf9402ba0
.word 0xf9403ba1
.word 0xf90023a1
.word 0xf9403fa1
.word 0xf90027a1
.word 0xf94023a1
.word 0xf94027a2
.word 0xaa1803e3
bl _p_490
.loc 67 219 0
.word 0xd2800000
.word 0xaa1803e1
.word 0xd2a00002
.word 0xaa1a03e3
bl _p_491
.word 0xaa0003fa
.loc 67 220 0
.word 0x34000079
.loc 67 221 0
.word 0xaa1803e0
bl _p_298
.loc 67 223 0
.word 0xaa1a03e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_2d8:
.text
	.align 4
	.no_dead_strip CoreFoundation_CFString_ToString
CoreFoundation_CFString_ToString:
.loc 67 279 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9401340
.word 0xb50002a0
.loc 67 280 0
.word 0x91004340
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
bl _p_360
.word 0xf9001ba0
.word 0x91008341
.word 0xd5033bbf
.word 0xf9401ba0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 67 281 0
.word 0xf9401340
.word 0xaa0003f9
.word 0xb5000080
.word 0xaa1a03e0
bl _p_428
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_2d9:
.text
	.align 4
	.no_dead_strip CoreFoundation_NativeObject__ctor_ObjCRuntime_NativeHandle_bool
CoreFoundation_NativeObject__ctor_ObjCRuntime_NativeHandle_bool:
.file 68 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/CoreFoundation/NativeObject.cs"
.loc 68 48 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
.word 0xd2800023
bl _p_492
.loc 68 50 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2da:
.text
	.align 4
	.no_dead_strip CoreFoundation_NativeObject__ctor_ObjCRuntime_NativeHandle_bool_bool
CoreFoundation_NativeObject__ctor_ObjCRuntime_NativeHandle_bool_bool:
.loc 68 53 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2
.word 0xf9001ba3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
.word 0x3940c3a3
bl _p_493
.loc 68 55 0
.word 0x3940a3a0
.word 0x350002e0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9400fa0
.word 0xf90027a0
.word 0xf9401fa0
.word 0xf90023a0
.word 0xf94027a0
.word 0xf94023a1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340000c0
.loc 68 56 0
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf9404830
.word 0xd63f0200
.loc 68 57 0
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2db:
.text
	.align 4
	.no_dead_strip CoreFoundation_NativeObject_Dispose_bool
CoreFoundation_NativeObject_Dispose_bool:
.loc 68 61 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90017a0
.word 0xf9401ba0
.word 0xf90023a0
.word 0xf94017a0
.word 0xf9001fa0
.word 0xf94023a0
.word 0xf9401fa1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x6b1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x340000a0
.loc 68 62 0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9404430
.word 0xd63f0200
.loc 68 63 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90013a0
.word 0xeb1f035f
.word 0x10000011
.word 0x54000100
.word 0x91004340
.word 0xf94013a1
.word 0xf9000001
.loc 68 64 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801620
.word 0xaa1103e1
bl _p_9

Lme_2dc:
.text
	.align 4
	.no_dead_strip CoreFoundation_NativeObject_Retain
CoreFoundation_NativeObject_Retain:
.loc 68 68 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910063a0
.word 0xf90013a0
.word 0xf9400ba0
bl _p_462
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_494
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2dd:
.text
	.align 4
	.no_dead_strip CoreFoundation_NativeObject_Release
CoreFoundation_NativeObject_Release:
.loc 68 72 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x910063a0
.word 0xf90013a0
.word 0xf9400ba0
bl _p_462
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400fa0
bl _p_487
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2de:
.text
	.align 4
	.no_dead_strip CloudKit_CKShareMetadata_get_ClassHandle
CloudKit_CKShareMetadata_get_ClassHandle:
.file 69 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/CloudKit/CKShareMetadata.g.cs"
.loc 69 60 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #896]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2df:
.text
	.align 4
	.no_dead_strip CloudKit_CKShareMetadata__ctor_ObjCRuntime_NativeHandle
CloudKit_CKShareMetadata__ctor_ObjCRuntime_NativeHandle:
.loc 69 82 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 69 84 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2e0:
.text
	.align 4
	.no_dead_strip CloudKit_CKShareMetadata_Copy_Foundation_NSZone
CloudKit_CKShareMetadata_Copy_Foundation_NSZone:
.loc 69 108 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 69 111 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 69 115 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 69 116 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 69 117 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2e1:
.text
	.align 4
	.no_dead_strip CloudKit_CKShareMetadata__cctor
CloudKit_CKShareMetadata__cctor:
.loc 69 59 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #904]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #896]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2e2:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_Equals_object
UIKit_UIAppearance_Equals_object:
.file 70 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIAppearance.cs"
.loc 70 26 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xf90013a0
.word 0xaa0103fa
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #912]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803fa
.loc 70 27 0
.word 0xb5000078
.loc 70 28 0
.word 0xd2a00000
.word 0x14000012
.loc 70 29 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf94013a0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf9401ba0
.word 0xf90023a0
.word 0xf94017a0
.word 0xf9001fa0
.word 0xf94023a0
.word 0xf9401fa1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2e3:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_GetHashCode
UIKit_UIAppearance_GetHashCode:
.loc 70 34 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fbf
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa1
.word 0xaa0103e0
.word 0x93407c00
.word 0x9360fc21
.word 0x93407c21
.word 0x4a010000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2e4:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_TypesToPointers_System_Type__
UIKit_UIAppearance_TypesToPointers_System_Type__:
.loc 70 57 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90027bf
.word 0xb9801b40
.word 0xd280009e
.word 0x6b1e001f
.word 0x540013cc
.loc 70 60 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #920]
.word 0xd28000a1
bl _p_42
.word 0xaa0003f9
.loc 70 62 0
.word 0xd2a00018
.word 0x1400004d

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 70 63 0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x540012a9
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0xb40008c0
.loc 70 65 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #608]
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54001109
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400001
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9406450
.word 0xd63f0200
.word 0x53001c00
.word 0x340008a0
.loc 70 68 0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000f29
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400000
.word 0x910123a1
.word 0xf9002ba1
bl _p_422
.word 0xf9402bbe
.word 0xf90003c0
.loc 70 69 0
.word 0xf94027a0
.word 0xf9001ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90017a0
.word 0xf9401ba0
.word 0xf90023a0
.word 0xf94017a0
.word 0xf9001fa0
.word 0xf94023a0
.word 0xf9401fa1
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x35000740
.loc 70 72 0
.word 0x93407f00
.word 0xb9801b21
.word 0xeb00003f
.word 0x10000011
.word 0x54000b49
.word 0xd37df000
.word 0x8b000320
.word 0x91008000
.word 0xf94027a1
.word 0xf9000001
.loc 70 62 0
.word 0x11000718
.word 0xb9801b40
.word 0x6b00031f
.word 0x54fff64b
.loc 70 74 0
.word 0xaa1903e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0
.loc 70 64 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28b9101
bl _p_11
.word 0xf9005ba0
.word 0xd28012a0
bl _p_130
.word 0xaa0003e1
.word 0xf9405ba0
.word 0xb9001038
bl _p_495
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 70 66 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28b9d81
bl _p_11
.word 0x93407f01
.word 0xb9801b42
.word 0xeb01005f
.word 0x10000011
.word 0x54000609
.word 0xd37df021
.word 0x8b010341
.word 0x91008021
.word 0xf9400021
bl _p_495
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.loc 70 70 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28ba741
bl _p_11
.word 0xf9005ba0
.word 0x93407f00
.word 0xb9801b41
.word 0xeb00003f
.word 0x10000011
.word 0x54000369
.word 0xd37df000
.word 0x8b000340
.word 0x91008000
.word 0xf9400001
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9416830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9405ba0
bl _p_495
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.loc 70 58 0
.word 0xd28b8781
bl _p_11
.word 0xaa0003e1
.word 0xd28009e0
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2e5:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_GetAppearance_intptr_System_Type__
UIKit_UIAppearance_GetAppearance_intptr_System_Type__:
.loc 70 111 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xd2800610
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
bl _p_496
.loc 70 120 0
adrp x1, L_OBJC_SELECTOR_REFERENCES_42@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_42@PAGEOFF
ldr x1, [x1]
.word 0xb9801802
.word 0xeb1f005f
.word 0x10000011
.word 0x54000709
.word 0x91008002
.word 0xf9400042
.word 0xf90023a2
.word 0xf94023a2
.word 0xb9801803
.word 0xd280003e
.word 0xeb1e007f
.word 0x10000011
.word 0x540005e9
.word 0x9100a003
.word 0xf9400063
.word 0xf9001fa3
.word 0xf9401fac
.word 0xb9801803
.word 0xd280005e
.word 0xeb1e007f
.word 0x10000011
.word 0x540004c9
.word 0x9100c003
.word 0xf9400063
.word 0xf9001ba3
.word 0xf9401bab
.word 0xb9801803
.word 0xd280007e
.word 0xeb1e007f
.word 0x10000011
.word 0x540003a9
.word 0x9100e003
.word 0xf9400063
.word 0xf90017a3
.word 0xf94017aa
.word 0xb9801803
.word 0xd280009e
.word 0xeb1e007f
.word 0x10000011
.word 0x54000289
.word 0x91010000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a9
.word 0xf9400ba0
.word 0xd2800003
.word 0xd2800004
.word 0xd2800005
.word 0xd2800006
.word 0xd2800007
.word 0xf90003ec
.word 0xf90007eb
.word 0xf9000bea
.word 0xf9000fe9
.word 0xf90013ff
bl _p_497
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2e6:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_GetAppearance_intptr_UIKit_UITraitCollection_System_Type__
UIKit_UIAppearance_GetAppearance_intptr_UIKit_UITraitCollection_System_Type__:
.loc 70 145 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xd2800610
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xf9000bba
.word 0xf9000fa0
.word 0xf90013a1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94013a0
.word 0xb4000900
.loc 70 148 0
.word 0xaa1a03e0
bl _p_496
.word 0xaa0003fa
.loc 70 157 0
adrp x1, L_OBJC_SELECTOR_REFERENCES_43@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_43@PAGEOFF
ldr x1, [x1]
.word 0xf94013a0
.word 0x3940001e
.word 0x91004000
.word 0xf9400000
.word 0xf9002ba0
.word 0xf9402ba2
.word 0xb9801b40
.word 0xeb1f001f
.word 0x10000011
.word 0x54000849
.word 0x91008340
.word 0xf9400000
.word 0xf90027a0
.word 0xf94027a3
.word 0xb9801b40
.word 0xd280003e
.word 0xeb1e001f
.word 0x10000011
.word 0x54000729
.word 0x9100a340
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023ac
.word 0xb9801b40
.word 0xd280005e
.word 0xeb1e001f
.word 0x10000011
.word 0x54000609
.word 0x9100c340
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fab
.word 0xb9801b40
.word 0xd280007e
.word 0xeb1e001f
.word 0x10000011
.word 0x540004e9
.word 0x9100e340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401baa
.word 0xb9801b40
.word 0xd280009e
.word 0xeb1e001f
.word 0x10000011
.word 0x540003c9
.word 0x91010340
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a9
.word 0xf9400fa0
.word 0xd2800004
.word 0xd2800005
.word 0xd2800006
.word 0xd2800007
.word 0xf90003ec
.word 0xf90007eb
.word 0xf9000bea
.word 0xf9000fe9
.word 0xf90013ff
bl _p_497
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.loc 70 146 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28bb941
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2e7:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance_GetAppearance_intptr_UIKit_UITraitCollection
UIKit_UIAppearance_GetAppearance_intptr_UIKit_UITraitCollection:
.loc 70 186 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fa0
.word 0xb40001e0
.loc 70 189 0
adrp x1, L_OBJC_SELECTOR_REFERENCES_44@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_44@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa0
.word 0x3940001e
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a2
.word 0xf9400ba0
bl _p_348
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.loc 70 187 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28bb941
bl _p_11
.word 0xaa0003e1
.word 0xd2800a00
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13

Lme_2e9:
.text
	.align 4
	.no_dead_strip UIKit_UIAppearance__ctor_ObjCRuntime_NativeHandle
UIKit_UIAppearance__ctor_ObjCRuntime_NativeHandle:
.file 71 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIAppearance.g.cs"
.loc 71 84 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 71 86 0
.word 0xf9400ba0
.word 0xd2a00001
bl _p_281
.loc 71 87 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2ea:
.text
	.align 4
	.no_dead_strip UIKit_UIKitThreadAccessException__ctor
UIKit_UIKitThreadAccessException__ctor:
.file 72 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIApplication.cs"
.loc 72 28 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #928]
.word 0xf90013a0
.word 0xf9400ba0
.word 0x929d5ffe
.word 0xf2b0027e
.word 0xb900601e
.word 0x91006001
.word 0xd5033bbf
.word 0xf94013a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.loc 72 30 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2eb:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_UIApplicationMain_int_string___intptr_intptr
UIKit_UIApplication_UIApplicationMain_int_string___intptr_intptr:
.loc 72 57 0 prologue_end
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xf90017a0
.word 0xaa0103f8
.word 0xf9001ba2
.word 0xf9001fa3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90023bf
.word 0xaa1803e0
.word 0xd2a00001
bl _p_498
.word 0xaa0003e1
.loc 72 58 0
.word 0xb9802ba0
.word 0xf9002ba1
.word 0xf9401ba2
.word 0xf9401fa3
.word 0x910103a4
bl _p_499
.word 0x93407c00
.word 0xaa0003fa
.word 0xf9402ba0
.loc 72 59 0
.word 0xaa0003f9
.word 0xb5000078
.word 0xd2a00018
.word 0x14000003
.word 0xb9801b00
.word 0xaa0003f8
.word 0xaa1903e0
.word 0xaa1803e1
bl _p_500
.word 0xf94023a0
.loc 72 60 0
bl _p_501
.loc 72 61 0
.word 0xaa1a03e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

Lme_2ed:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_Initialize
UIKit_UIApplication_Initialize:
.loc 72 69 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xf9400000
.word 0xb5000200
.loc 72 72 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #944]
.word 0xd2800221
bl _p_3
bl _p_502
.loc 72 73 0
bl _p_503
.word 0xaa0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xf9000ba0
.word 0xd5033bbf
.word 0xf9400ba0
.word 0xf9000001
.loc 72 74 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2ee:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_Main_string___System_Type_System_Type
UIKit_UIApplication_Main_string___System_Type_System_Type:
.loc 72 91 0 prologue_end
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xaa0003f8
.word 0xf90013a1
.word 0xaa0203fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9002bbf
.word 0xf90027bf
.word 0xf94013a0
.word 0xb4000220

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xd2800301
bl _p_3
.word 0xf9003ba0
.word 0xf94013a1
bl _p_504
.word 0xf9403ba0
bl _p_394
.word 0x910103a1
.word 0xf9002fa1
bl _p_454
.word 0xf9402fbe
.word 0xf90003c0
.word 0x14000006

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf90023a0
.word 0xf94023a0
.word 0xf9002ba0
.loc 72 92 0
.word 0xb400023a

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #168]
.word 0xd2800301
bl _p_3
.word 0xf9003ba0
.word 0xaa1a03e1
bl _p_504
.word 0xf9403ba0
bl _p_394
.word 0x9100e3a1
.word 0xf9002fa1
bl _p_454
.word 0xf9402fbe
.word 0xf90003c0
.word 0x14000006

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #3472]
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
.word 0xf90027a0
.loc 72 93 0
bl _p_505
.loc 72 94 0
.word 0xb5000078
.word 0xd2a0001a
.word 0x14000003
.word 0xb9801b00
.word 0xaa0003fa
.word 0xf9402ba0
.word 0xf9001ba0
.word 0xf9401ba2
.word 0xf94027a0
.word 0xf90017a0
.word 0xf94017a3
.word 0xaa1a03e0
.word 0xaa1803e1
bl _p_506
.word 0x93407c00
.loc 72 95 0
.word 0xf94027a0
bl _p_456
.loc 72 96 0
.word 0xf9402ba0
bl _p_456
.loc 72 97 0
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_2ef:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_EnsureUIThread
UIKit_UIApplication_EnsureUIThread:
.loc 72 110 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #952]
.word 0x39400000
.word 0x34000200

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xf9400000
.word 0xb4000160

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #936]
.word 0xf9400000
.word 0xf9000ba0
bl _p_503
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xeb01001f
.word 0x54000081
.loc 72 112 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.loc 72 111 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #960]
.word 0xd2801201
bl _p_3
.word 0xf9000ba0
bl _p_507
.word 0xf9400ba0
bl _p_13

Lme_2f0:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_get_ClassHandle
UIKit_UIApplication_get_ClassHandle:
.file 73 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIApplication.g.cs"
.loc 73 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #968]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2f1:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication__ctor_ObjCRuntime_NativeHandle
UIKit_UIApplication__ctor_ObjCRuntime_NativeHandle:
.loc 73 81 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_508
.loc 73 83 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2f2:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication_Dispose_bool
UIKit_UIApplication_Dispose_bool:
.loc 73 2001 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 73 2002 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 73 2005 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2f3:
.text
	.align 4
	.no_dead_strip UIKit_UIApplication__cctor
UIKit_UIApplication__cctor:
.loc 72 46 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #952]
.word 0xd280003e
.word 0x3900001e
.loc 73 47 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #976]
.word 0xd280003e
.word 0x3900001e
.loc 73 58 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #984]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #968]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2f4:
.text
	.align 4
	.no_dead_strip UIKit_UIButton_get_ClassHandle
UIKit_UIButton_get_ClassHandle:
.file 74 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIButton.g.cs"
.loc 74 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #992]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2f5:
.text
	.align 4
	.no_dead_strip UIKit_UIButton__ctor_ObjCRuntime_NativeHandle
UIKit_UIButton__ctor_ObjCRuntime_NativeHandle:
.loc 74 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_509
.loc 74 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2f6:
.text
	.align 4
	.no_dead_strip UIKit_UIButton__cctor
UIKit_UIButton__cctor:
.loc 74 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1000]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #992]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2f7:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_GetRGBA_System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat_
UIKit_UIColor_GetRGBA_System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat__System_Runtime_InteropServices_NFloat_:
.file 75 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIColor.cs"
.loc 75 53 0 prologue_end
.word 0xa9b17bfd
.word 0x910003fd
.word 0xf9000bb4
.word 0xf9000fb6
.word 0xaa0003f6
.word 0xf90013a1
.word 0xf90017a2
.word 0xf9001ba3
.word 0xf9001fa4

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90057bf
.word 0xb900b3bf
.word 0xaa1603e0
.word 0xf94002c1
.word 0xf9406c30
.word 0xd63f0200
.word 0xf90057a0
.loc 75 54 0
.word 0xf94057a1
.word 0xaa0103e0
.word 0x3940003e
bl _p_510
.word 0xaa0003f6
.loc 75 56 0
.word 0xaa1603e1
.word 0xb9801820
.word 0xb900bba0
.word 0x51000814
.word 0xd280007e
.word 0x6b1e029f
.word 0x54000122
.word 0xd37df280
.word 0x2a0003e1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1008]
.word 0x8b010000
.word 0xf9400000
.word 0xd61f0000
.word 0x14000093
.loc 75 58 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x54001749
.word 0x910082c0
.word 0xf9400000
.word 0xf9004fa0
.word 0xf94013a0
.word 0xf9404fa1
.word 0xf9000001
.loc 75 59 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x54001609
.word 0x910082c0
.word 0xf9400000
.word 0xf9004ba0
.word 0xf94017a0
.word 0xf9404ba1
.word 0xf9000001
.loc 75 60 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x540014c9
.word 0x910082c0
.word 0xf9400000
.word 0xf90047a0
.word 0xf9401ba0
.word 0xf94047a1
.word 0xf9000001
.loc 75 61 0
.word 0xb9801ac0
.word 0xd280003e
.word 0xeb1e001f
.word 0x10000011
.word 0x54001369
.word 0x9100a2c0
.word 0xf9400000
.word 0xf90043a0
.word 0xf9401fa0
.word 0xf94043a1
.word 0xf9000001
.loc 75 62 0
.word 0xf90063bf
.word 0x9400007a
.word 0xf94063a0
.word 0xb4000040
bl _p_23
.word 0x1400008a
.loc 75 64 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x54001169
.word 0x910082c0
.word 0xf9400000
.word 0xf9003fa0
.word 0xf94013a0
.word 0xf9403fa1
.word 0xf9000001
.loc 75 65 0
.word 0xb9801ac0
.word 0xd280003e
.word 0xeb1e001f
.word 0x10000011
.word 0x54001009
.word 0x9100a2c0
.word 0xf9400000
.word 0xf9003ba0
.word 0xf94017a0
.word 0xf9403ba1
.word 0xf9000001
.loc 75 66 0
.word 0xb9801ac0
.word 0xd280005e
.word 0xeb1e001f
.word 0x10000011
.word 0x54000ea9
.word 0x9100c2c0
.word 0xf9400000
.word 0xf90037a0
.word 0xf9401ba0
.word 0xf94037a1
.word 0xf9000001
.loc 75 67 0
.word 0xd2a7f01e
.word 0x9e6703c0
.word 0xbd00cba0
.word 0xbd40cba0
.word 0x1e22c000
.word 0xf90053bf
.word 0xfd0053a0
.word 0xf94053a0
.word 0xf90033a0
.word 0xf9401fa0
.word 0xf94033a1
.word 0xf9000001
.loc 75 68 0
.word 0xf90063bf
.word 0x94000048
.word 0xf94063a0
.word 0xb4000040
bl _p_23
.word 0x14000058
.loc 75 70 0
.word 0xb9801ac0
.word 0xeb1f001f
.word 0x10000011
.word 0x54000b29
.word 0x910082c0
.word 0xf9400000
.word 0xf9002fa0
.word 0xf94013a0
.word 0xf9402fa1
.word 0xf9000001
.loc 75 71 0
.word 0xb9801ac0
.word 0xd280003e
.word 0xeb1e001f
.word 0x10000011
.word 0x540009c9
.word 0x9100a2c0
.word 0xf9400000
.word 0xf9002ba0
.word 0xf94017a0
.word 0xf9402ba1
.word 0xf9000001
.loc 75 72 0
.word 0xb9801ac0
.word 0xd280005e
.word 0xeb1e001f
.word 0x10000011
.word 0x54000869
.word 0x9100c2c0
.word 0xf9400000
.word 0xf90027a0
.word 0xf9401ba0
.word 0xf94027a1
.word 0xf9000001
.loc 75 73 0
.word 0xb9801ac0
.word 0xd280007e
.word 0xeb1e001f
.word 0x10000011
.word 0x54000709
.word 0x9100e2c0
.word 0xf9400000
.word 0xf90023a0
.word 0xf9401fa0
.word 0xf94023a1
.word 0xf9000001
.loc 75 74 0
.word 0xf90063bf
.word 0x94000017
.word 0xf94063a0
.word 0xb4000040
bl _p_23
.word 0x14000027
.loc 75 76 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28bed21
bl _p_11
.word 0xf90073a0
.word 0xb9801ac0
.word 0xb900b3a0
.word 0x9102c3a0
bl _p_511
.word 0xaa0003e1
.word 0xf94073a0
bl _p_76
.word 0xaa0003e1
.word 0xd2800540
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_13
.word 0xf9006bbe

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf94057a0
.word 0xb4000140
.word 0xf94057a1
.word 0xaa0103e0
.word 0xf9400021

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1080]
.word 0x928004f0
.word 0xf8706830
.word 0xd63f0200
.word 0xf9406bbe
.word 0xd61f03c0
.loc 75 79 0
.word 0xf9400bb4
.word 0xf9400fb6
.word 0x910003bf
.word 0xa8cf7bfd
.word 0xd65f03c0
.word 0xd2801260
.word 0xaa1103e1
bl _p_9

Lme_2f8:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_ToString
UIKit_UIColor_ToString:
.loc 75 154 0 prologue_end
.word 0xa9a57bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9008bbf
.word 0xf90087bf
.word 0xf90083bf
.word 0xf9007fbf
.word 0xf9008fbf
.word 0xf9400ba0
.word 0x910443a1
.word 0x910423a2
.word 0x910403a3
.word 0x9103e3a4
bl _p_512
.loc 75 155 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1016]
.word 0xf900a3a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #600]
.word 0xd2800081
bl _p_42
.word 0xf900d3a0
.word 0xf900cba0
.word 0xf9407fa0
.word 0xf9002ba0
.word 0xd2801fe0
.word 0x1e620000
.word 0xf9007bbf
.word 0xfd007ba0
.word 0xf9407ba0
.word 0xf90027a0
.word 0xf9402ba0
.word 0xf90077a0
.word 0xf94027a0
.word 0xf90073a0
.word 0xfd4077a0
.word 0xfd4073a1
.word 0x1e610800
.word 0xf9006fbf
.word 0xfd006fa0
.word 0xf9406fa0
.word 0xf9006ba0
.word 0xfd406ba0
.word 0x9e790000
.word 0x53001c00
.word 0xf900cfa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1024]
.word 0xd2800221
bl _p_3
.word 0xaa0003e2
.word 0xf940cfa0
.word 0xf940d3a3
.word 0x39004040
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940cba0
.word 0xf900c7a0
.word 0xf900bfa0
.word 0xf9408ba0
.word 0xf90023a0
.word 0xd2801fe0
.word 0x1e620000
.word 0xf90067bf
.word 0xfd0067a0
.word 0xf94067a0
.word 0xf9001fa0
.word 0xf94023a0
.word 0xf90063a0
.word 0xf9401fa0
.word 0xf9005fa0
.word 0xfd4063a0
.word 0xfd405fa1
.word 0x1e610800
.word 0xf9005bbf
.word 0xfd005ba0
.word 0xf9405ba0
.word 0xf90057a0
.word 0xfd4057a0
.word 0x9e790000
.word 0x53001c00
.word 0xf900c3a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1024]
.word 0xd2800221
bl _p_3
.word 0xaa0003e2
.word 0xf940c3a0
.word 0xf940c7a3
.word 0x39004040
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940bfa0
.word 0xf900bba0
.word 0xf900b3a0
.word 0xf94087a0
.word 0xf9001ba0
.word 0xd2801fe0
.word 0x1e620000
.word 0xf90053bf
.word 0xfd0053a0
.word 0xf94053a0
.word 0xf90017a0
.word 0xf9401ba0
.word 0xf9004fa0
.word 0xf94017a0
.word 0xf9004ba0
.word 0xfd404fa0
.word 0xfd404ba1
.word 0x1e610800
.word 0xf90047bf
.word 0xfd0047a0
.word 0xf94047a0
.word 0xf90043a0
.word 0xfd4043a0
.word 0x9e790000
.word 0x53001c00
.word 0xf900b7a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1024]
.word 0xd2800221
bl _p_3
.word 0xaa0003e2
.word 0xf940b7a0
.word 0xf940bba3
.word 0x39004040
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940b3a0
.word 0xf900afa0
.word 0xf900a7a0
.word 0xf94083a0
.word 0xf90013a0
.word 0xd2801fe0
.word 0x1e620000
.word 0xf9003fbf
.word 0xfd003fa0
.word 0xf9403fa0
.word 0xf9000fa0
.word 0xf94013a0
.word 0xf9003ba0
.word 0xf9400fa0
.word 0xf90037a0
.word 0xfd403ba0
.word 0xfd4037a1
.word 0x1e610800
.word 0xf90033bf
.word 0xfd0033a0
.word 0xf94033a0
.word 0xf9002fa0
.word 0xfd402fa0
.word 0x9e790000
.word 0x53001c00
.word 0xf900aba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1024]
.word 0xd2800221
bl _p_3
.word 0xaa0003e2
.word 0xf940aba0
.word 0xf940afa3
.word 0x39004040
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940a3a0
.word 0xf940a7a1
bl _p_58
.word 0xf9008fa0
.word 0x14000015
.word 0xf90093a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.loc 75 159 0
.word 0xf9400ba1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9404430
.word 0xd63f0200
.word 0xf9008fa0
bl _p_220
.word 0xf9009fa0
.word 0xf9409fa0
.word 0xb4000060
.word 0xf9409fa0
bl _p_13
.word 0x14000001
.loc 75 161 0
.word 0xf9408fa0
.word 0x910003bf
.word 0xa8db7bfd
.word 0xd65f03c0

Lme_2f9:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_get_ClassHandle
UIKit_UIColor_get_ClassHandle:
.file 76 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIColor.g.cs"
.loc 76 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1032]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2fa:
.text
	.align 4
	.no_dead_strip UIKit_UIColor__ctor_ObjCRuntime_NativeHandle
UIKit_UIColor__ctor_ObjCRuntime_NativeHandle:
.loc 76 78 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 76 80 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2fb:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_Copy_Foundation_NSZone
UIKit_UIColor_Copy_Foundation_NSZone:
.loc 76 180 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 76 183 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 76 187 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 76 188 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 76 189 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_2fc:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_get_CGColor
UIKit_UIColor_get_CGColor:
.loc 76 507 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_45@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_45@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1040]
.word 0xd2a00001
bl _p_513
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2fd:
.text
	.align 4
	.no_dead_strip UIKit_UIColor_get_SystemBackground
UIKit_UIColor_get_SystemBackground:
.loc 76 868 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1032]
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_46@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_46@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90013a2
bl _p_350
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1048]
bl _p_514
.loc 76 869 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2fe:
.text
	.align 4
	.no_dead_strip UIKit_UIColor__cctor
UIKit_UIColor__cctor:
.loc 76 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1056]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1032]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2ff:
.text
	.align 4
	.no_dead_strip UIKit_UIControl_get_ClassHandle
UIKit_UIControl_get_ClassHandle:
.file 77 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIControl.g.cs"
.loc 77 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1064]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_300:
.text
	.align 4
	.no_dead_strip UIKit_UIControl__ctor_ObjCRuntime_NativeHandle
UIKit_UIControl__ctor_ObjCRuntime_NativeHandle:
.loc 77 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_515
.loc 77 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_301:
.text
	.align 4
	.no_dead_strip UIKit_UIControl__cctor
UIKit_UIControl__cctor:
.loc 77 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1072]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1064]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_302:
.text
	.align 4
	.no_dead_strip UIKit_UIImage_get_ClassHandle
UIKit_UIImage_get_ClassHandle:
.file 78 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIImage.g.cs"
.loc 78 56 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1080]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_303:
.text
	.align 4
	.no_dead_strip UIKit_UIImage__ctor_ObjCRuntime_NativeHandle
UIKit_UIImage__ctor_ObjCRuntime_NativeHandle:
.loc 78 92 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 78 94 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_304:
.text
	.align 4
	.no_dead_strip UIKit_UIImage__cctor
UIKit_UIImage__cctor:
.loc 78 55 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1088]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1080]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_305:
.text
	.align 4
	.no_dead_strip UIKit_UIKitSynchronizationContext_Post_System_Threading_SendOrPostCallback_object
UIKit_UIKitSynchronizationContext_Post_System_Threading_SendOrPostCallback_object:
.file 79 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIKitSynchronizationContext.cs"
.loc 79 24 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_516
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9400fa1
.word 0xf94013a2
.word 0x3940007e
bl _p_517
.loc 79 25 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_306:
.text
	.align 4
	.no_dead_strip UIKit_UIKitSynchronizationContext_Send_System_Threading_SendOrPostCallback_object
UIKit_UIKitSynchronizationContext_Send_System_Threading_SendOrPostCallback_object:
.loc 79 29 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_516
.word 0xaa0003e3
.word 0xaa0303e0
.word 0xf9400fa1
.word 0xf94013a2
.word 0x3940007e
bl _p_518
.loc 79 30 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_307:
.text
	.align 4
	.no_dead_strip UIKit_UIKitSynchronizationContext__ctor
UIKit_UIKitSynchronizationContext__ctor:
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_308:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen_get_ClassHandle
UIKit_UIScreen_get_ClassHandle:
.file 80 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIScreen.g.cs"
.loc 80 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1096]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_309:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen__ctor_ObjCRuntime_NativeHandle
UIKit_UIScreen__ctor_ObjCRuntime_NativeHandle:
.loc 80 81 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 80 83 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_30a:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen_get_Bounds
UIKit_UIScreen_get_Bounds:
.loc 80 185 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 80 187 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9402fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_47@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_47@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90033a2
bl _p_520
.word 0xf94033be
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 80 206 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_30b:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen_get_MainScreen
UIKit_UIScreen_get_MainScreen:
.loc 80 401 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 80 403 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1096]
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_48@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_48@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90013a2
bl _p_350
.word 0xf94013be
.word 0xf90003c0
.word 0xf9400ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1104]
bl _p_521
.loc 80 404 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_30c:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen_Dispose_bool
UIKit_UIScreen_Dispose_bool:
.loc 80 766 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 80 767 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 80 771 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_30d:
.text
	.align 4
	.no_dead_strip UIKit_UIScreen__cctor
UIKit_UIScreen__cctor:
.loc 80 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1112]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1096]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_30e:
.text
	.align 4
	.no_dead_strip UIKit_UITraitCollection_get_ClassHandle
UIKit_UITraitCollection_get_ClassHandle:
.file 81 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UITraitCollection.g.cs"
.loc 81 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1120]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_30f:
.text
	.align 4
	.no_dead_strip UIKit_UITraitCollection__ctor_ObjCRuntime_NativeHandle
UIKit_UITraitCollection__ctor_ObjCRuntime_NativeHandle:
.loc 81 94 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 81 96 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_310:
.text
	.align 4
	.no_dead_strip UIKit_UITraitCollection_Copy_Foundation_NSZone
UIKit_UITraitCollection_Copy_Foundation_NSZone:
.loc 81 126 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 81 129 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 81 133 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 81 134 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 81 135 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_311:
.text
	.align 4
	.no_dead_strip UIKit_UITraitCollection__cctor
UIKit_UITraitCollection__cctor:
.loc 81 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1128]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1120]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_312:
.text
	.align 4
	.no_dead_strip UIKit_UIView_get_ClassHandle
UIKit_UIView_get_ClassHandle:
.file 82 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIView.g.cs"
.loc 82 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1136]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_313:
.text
	.align 4
	.no_dead_strip UIKit_UIView__ctor_Foundation_NSObjectFlag
UIKit_UIView__ctor_Foundation_NSObjectFlag:
.loc 82 89 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
bl _p_522
.loc 82 91 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_314:
.text
	.align 4
	.no_dead_strip UIKit_UIView__ctor_ObjCRuntime_NativeHandle
UIKit_UIView__ctor_ObjCRuntime_NativeHandle:
.loc 82 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_508
.loc 82 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_315:
.text
	.align 4
	.no_dead_strip UIKit_UIView_AddSubview_UIKit_UIView
UIKit_UIView_AddSubview_UIKit_UIView:
.loc 82 250 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 82 251 0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1144]
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_278
.word 0xf9401bbe
.word 0xf90003c0
.loc 82 253 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_49@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_49@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_337
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_316:
.text
	.align 4
	.no_dead_strip UIKit_UIView_ConvertPointFromCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace
UIKit_UIView_ConvertPointFromCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace:
.loc 82 500 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 82 504 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_50@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_50@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xf94053a2
bl _p_523
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.loc 82 523 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_317:
.text
	.align 4
	.no_dead_strip UIKit_UIView_ConvertPointToCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace
UIKit_UIView_ConvertPointToCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace:
.loc 82 563 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 82 567 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_51@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_51@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xf94053a2
bl _p_523
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.loc 82 586 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_318:
.text
	.align 4
	.no_dead_strip UIKit_UIView_ConvertRectFromCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace
UIKit_UIView_ConvertRectFromCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace:
.loc 82 626 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xfd0037a2
.word 0xfd003ba3
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 82 630 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_52@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_52@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xfd4037a2
.word 0xfd403ba3
.word 0xf94053a2
bl _p_524
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 82 649 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_319:
.text
	.align 4
	.no_dead_strip UIKit_UIView_ConvertRectToCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace
UIKit_UIView_ConvertRectToCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace:
.loc 82 689 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xfd0037a2
.word 0xfd003ba3
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 82 693 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_53@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_53@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xfd4037a2
.word 0xfd403ba3
.word 0xf94053a2
bl _p_524
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 82 712 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_31a:
.text
	.align 4
	.no_dead_strip UIKit_UIView_set_AutoresizingMask_UIKit_UIViewAutoresizing
UIKit_UIView_set_AutoresizingMask_UIKit_UIViewAutoresizing:
.loc 82 2996 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 82 2998 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_54@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_54@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa2
bl _p_525
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_31b:
.text
	.align 4
	.no_dead_strip UIKit_UIView_set_BackgroundColor_UIKit_UIColor
UIKit_UIView_set_BackgroundColor_UIKit_UIColor:
.loc 82 3042 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 82 3043 0
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_312
.word 0xf9401bbe
.word 0xf90003c0
.loc 82 3045 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_55@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_55@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_337
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_31c:
.text
	.align 4
	.no_dead_strip UIKit_UIView_get_Bounds
UIKit_UIView_get_Bounds:
.loc 82 3076 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9402fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_47@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_47@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90033a2
bl _p_520
.word 0xf94033be
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 82 3095 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_31d:
.text
	.align 4
	.no_dead_strip UIKit_UIView_get_Frame
UIKit_UIView_get_Frame:
.loc 82 3661 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 82 3663 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9402fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_56@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_56@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90033a2
bl _p_520
.word 0xf94033be
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 82 3682 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_31e:
.text
	.align 4
	.no_dead_strip UIKit_UIView_Dispose_bool
UIKit_UIView_Dispose_bool:
.loc 82 6028 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 82 6029 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 82 6033 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_31f:
.text
	.align 4
	.no_dead_strip UIKit_UIView__cctor
UIKit_UIView__cctor:
.loc 82 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1160]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1136]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_320:
.text
	.align 4
	.no_dead_strip UIKit_UIView_UIViewAppearance__ctor_intptr
UIKit_UIView_UIViewAppearance__ctor_intptr:
.loc 82 6035 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf90017bf
.word 0xf9400fa0
.word 0xf90017a0
.word 0xf94017a0
.word 0xf90013a0
.word 0xf9400ba0
.word 0xf94013a1
bl _p_526
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_321:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController_get_ClassHandle
UIKit_UIViewController_get_ClassHandle:
.file 83 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIViewController.g.cs"
.loc 83 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1168]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_322:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController__ctor
UIKit_UIViewController__ctor:
.loc 83 63 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_522
.loc 83 65 0
bl _p_519
.loc 83 67 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_310
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1888]
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_311
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_323:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController__ctor_Foundation_NSObjectFlag
UIKit_UIViewController__ctor_Foundation_NSObjectFlag:
.loc 83 89 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
bl _p_522
.loc 83 91 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_324:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController__ctor_ObjCRuntime_NativeHandle
UIKit_UIViewController__ctor_ObjCRuntime_NativeHandle:
.loc 83 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_508
.loc 83 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_325:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController_get_View
UIKit_UIViewController_get_View:
.loc 83 3288 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 83 3291 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_57@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_57@PAGEOFF
ldr x1, [x1]
.word 0x910063a2
.word 0xf90017a2
bl _p_350
.word 0xf94017be
.word 0xf90003c0
.word 0xf9400fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x15, [x16, #1176]
bl _p_527
.loc 83 3295 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_326:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController_Dispose_bool
UIKit_UIViewController_Dispose_bool:
.loc 83 3439 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_276
.loc 83 3440 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 83 3445 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_327:
.text
	.align 4
	.no_dead_strip UIKit_UIViewController__cctor
UIKit_UIViewController__cctor:
.loc 83 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1184]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1168]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_328:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow_get_ClassHandle
UIKit_UIWindow_get_ClassHandle:
.file 84 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIWindow.g.cs"
.loc 84 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1192]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_329:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow__ctor_Foundation_NSObjectFlag
UIKit_UIWindow__ctor_Foundation_NSObjectFlag:
.loc 84 89 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xb9801ba1
bl _p_528
.loc 84 91 0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_32a:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow__ctor_ObjCRuntime_NativeHandle
UIKit_UIWindow__ctor_ObjCRuntime_NativeHandle:
.loc 84 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_515
.loc 84 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_32b:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow__ctor_CoreGraphics_CGRect
UIKit_UIWindow__ctor_CoreGraphics_CGRect:
.loc 84 122 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xfd0013a1
.word 0xfd0017a2
.word 0xfd001ba3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_528
.loc 84 124 0
bl _p_519
.loc 84 126 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90033a0
.word 0xf94033a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_58@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_58@PAGEOFF
ldr x1, [x1]
.word 0x910163a2
.word 0xf90037a2
.word 0xfd400fa0
.word 0xfd4013a1
.word 0xfd4017a2
.word 0xfd401ba3
bl _p_529
.word 0xf94037be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1200]
.word 0xf9400ba0
.word 0xf9402fa1
bl _p_311
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_32c:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow_MakeKeyAndVisible
UIKit_UIWindow_MakeKeyAndVisible:
.loc 84 266 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 84 268 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9000fa0
.word 0xf9400fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_59@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_59@PAGEOFF
ldr x1, [x1]
bl _p_315
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_32d:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow_set_RootViewController_UIKit_UIViewController
UIKit_UIWindow_set_RootViewController_UIKit_UIViewController:
.loc 84 391 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 84 392 0
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_312
.word 0xf9401bbe
.word 0xf90003c0
.loc 84 394 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_60@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_60@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_337
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_32e:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow_Dispose_bool
UIKit_UIWindow_Dispose_bool:
.loc 84 560 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0x394063a1
bl _p_530
.loc 84 561 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90013a0
.word 0xf94013a0
.word 0xf90017a0
.word 0xf94017a0
.word 0xeb1f001f
.word 0x9a9f17e0
.word 0x53001c00
.word 0x6b1f001f
.loc 84 564 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_32f:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow__cctor
UIKit_UIWindow__cctor:
.loc 84 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1208]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1192]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_330:
.text
	.align 4
	.no_dead_strip UIKit_UIWindow_UIWindowAppearance__ctor_intptr
UIKit_UIWindow_UIWindowAppearance__ctor_intptr:
.loc 84 566 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_531
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_331:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationDelegate__ctor
UIKit_UIApplicationDelegate__ctor:
.file 85 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIApplicationDelegate.g.cs"
.loc 85 884 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xaa1a03e0
.word 0xd2a00001
bl _p_309
.loc 85 886 0
bl _p_519
.loc 85 887 0
.word 0xaa1a03e0
.word 0xd2a00001
bl _p_281
.loc 85 888 0
.word 0x9100a3a0
.word 0xf9001ba0
.word 0xaa1a03e0
bl _p_409
.word 0xf9401bbe
.word 0xf90003c0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_532
.word 0xf90013bf
.word 0xf90013a0
.word 0xf94013a0
.word 0xf9000fa0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1888]
.word 0xaa1a03e0
.word 0xf9400fa1
bl _p_311
.loc 85 889 0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_332:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationDelegate__ctor_ObjCRuntime_NativeHandle
UIKit_UIApplicationDelegate__ctor_ObjCRuntime_NativeHandle:
.loc 85 900 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 85 902 0
.word 0xf9400ba0
.word 0xd2a00001
bl _p_281
.loc 85 903 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_333:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
UIKit_UIApplicationDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary:
.loc 85 1029 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1216]
.word 0xd2801201
bl _p_3
.word 0xf9001ba0
bl _p_533
.word 0xf9401ba0
bl _p_13
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_334:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationDelegate_get_Window
UIKit_UIApplicationDelegate_get_Window:
.loc 85 1448 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1224]
.word 0xd2801201
bl _p_3
.word 0xf90013a0
bl _p_534
.word 0xf94013a0
bl _p_13
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_335:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationDelegate_set_Window_UIKit_UIWindow
UIKit_UIApplicationDelegate_set_Window_UIKit_UIWindow:
.loc 85 1452 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1224]
.word 0xd2801201
bl _p_3
.word 0xf90013a0
bl _p_534
.word 0xf94013a0
bl _p_13
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_336:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationShortcutItem_get_ClassHandle
UIKit_UIApplicationShortcutItem_get_ClassHandle:
.file 86 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UIApplicationShortcutItem.g.cs"
.loc 86 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1232]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_337:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationShortcutItem__ctor_ObjCRuntime_NativeHandle
UIKit_UIApplicationShortcutItem__ctor_ObjCRuntime_NativeHandle:
.loc 86 68 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_275
.loc 86 70 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_338:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationShortcutItem_Copy_Foundation_NSZone
UIKit_UIApplicationShortcutItem_Copy_Foundation_NSZone:
.loc 86 126 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 86 127 0
.word 0x9100a3a0
.word 0xf90023a0
.word 0xaa1a03e0
bl _p_312
.word 0xf94023be
.word 0xf90003c0
.loc 86 130 0
.word 0xf9400fa0
.word 0x91004000
.word 0xf9400000
.word 0xf9001fa0
.word 0xf9401fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0x910083a2
.word 0xf90023a2
.word 0xf94017a2
bl _p_313
.word 0xf94023be
.word 0xf90003c0
.word 0xf94013a0
bl _p_314
.word 0xaa0003fa
.loc 86 134 0
.word 0xaa1a03e0
.word 0xb4000140
.loc 86 135 0
.word 0x3940035e
.word 0x91004340
.word 0xf9400000
.word 0xf9001ba0
.word 0xf9401ba0
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_315
.loc 86 136 0
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_339:
.text
	.align 4
	.no_dead_strip UIKit_UIApplicationShortcutItem__cctor
UIKit_UIApplicationShortcutItem__cctor:
.loc 86 58 0 prologue_end
.word 0xa9be7bfd
.word 0x910003fd

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1240]
.word 0x910043a1
.word 0xf9000fa1
bl _p_88
.word 0xf9400fbe
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1232]
.word 0xf9400ba1
.word 0xf9000001
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_33a:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper__ctor_ObjCRuntime_NativeHandle_bool
UIKit_UICoordinateSpaceWrapper__ctor_ObjCRuntime_NativeHandle_bool:
.file 87 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UICoordinateSpace.g.cs"
.loc 87 88 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90017a2

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x3940a3a2
bl _p_277
.loc 87 90 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_340:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper_ConvertPointToCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace
UIKit_UICoordinateSpaceWrapper_ConvertPointToCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace:
.loc 87 96 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 87 99 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_51@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_51@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xf94053a2
bl _p_523
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.loc 87 107 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_341:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper_ConvertPointFromCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace
UIKit_UICoordinateSpaceWrapper_ConvertPointFromCoordinateSpace_CoreGraphics_CGPoint_UIKit_IUICoordinateSpace:
.loc 87 114 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 87 117 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_50@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_50@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xf94053a2
bl _p_523
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.loc 87 125 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_342:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper_ConvertRectToCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace
UIKit_UICoordinateSpaceWrapper_ConvertRectToCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace:
.loc 87 132 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xfd0037a2
.word 0xfd003ba3
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 87 135 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_53@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_53@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xfd4037a2
.word 0xfd403ba3
.word 0xf94053a2
bl _p_524
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 87 143 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_343:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper_ConvertRectFromCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace
UIKit_UICoordinateSpaceWrapper_ConvertRectFromCoordinateSpace_CoreGraphics_CGRect_UIKit_IUICoordinateSpace:
.loc 87 150 0 prologue_end
.word 0xa9b47bfd
.word 0x910003fd
.word 0xf9002ba0
.word 0xfd002fa0
.word 0xfd0033a1
.word 0xfd0037a2
.word 0xfd003ba3
.word 0xf9004fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x1, [x16, #1152]
.word 0x910283a0
.word 0xf9005ba0
.word 0xf9404fa0
bl _p_278
.word 0xf9405bbe
.word 0xf90003c0
.loc 87 153 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90057a0
.word 0xf94057a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_52@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_52@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf9005ba2
.word 0xfd402fa0
.word 0xfd4033a1
.word 0xfd4037a2
.word 0xfd403ba3
.word 0xf94053a2
bl _p_524
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 87 161 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8cc7bfd
.word 0xd65f03c0

Lme_344:
.text
	.align 4
	.no_dead_strip UIKit_UICoordinateSpaceWrapper_get_Bounds
UIKit_UICoordinateSpaceWrapper_get_Bounds:
.loc 87 169 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9002ba0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 87 170 0
.word 0xf9402ba0
.word 0x91004000
.word 0xf9400000
.word 0xf9002fa0
.word 0xf9402fa0
adrp x1, L_OBJC_SELECTOR_REFERENCES_47@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_47@PAGEOFF
ldr x1, [x1]
.word 0x910043a2
.word 0xf90033a2
bl _p_520
.word 0xf94033be
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.loc 87 178 0
.word 0xfd400ba0
.word 0xfd400fa1
.word 0xfd4013a2
.word 0xfd4017a3
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_345:
.text
	.align 4
	.no_dead_strip UIKit_UILabel_get_ClassHandle
UIKit_UILabel_get_ClassHandle:
.file 88 "/Users/builder/azdo/_work/1/s/xamarin-macios/src/build/dotnet/ios/generated-sources/UIKit/UILabel.g.cs"
.loc 88 59 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf90013a0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #1248]
.word 0xf9400000
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_346:
.text
	.align 4
	.no_dead_strip UIKit_UILabel__ctor_ObjCRuntime_NativeHandle
UIKit_UILabel__ctor_ObjCRuntime_NativeHandle:
.loc 88 95 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_515
.loc 88 97 0
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_347:
.text
	.align 4
	.no_dead_strip UIKit_UILabel__ctor_CoreGraphics_CGRect
UIKit_UILabel__ctor_CoreGraphics_CGRect:
.loc 88 102 0 prologue_end
.word 0xa9b97bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xfd0013a1
.word 0xfd0017a2
.word 0xfd001ba3

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400ba0
.word 0xd2a00001
bl _p_528
.loc 88 104 0
bl _p_519
.loc 88 106 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90033a0
.word 0xf94033a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_58@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_58@PAGEOFF
ldr x1, [x1]
.word 0x910163a2
.word 0xf90037a2
.word 0xfd400fa0
.word 0xfd4013a1
.word 0xfd4017a2
.word 0xfd401ba3
bl _p_529
.word 0xf94037be
.word 0xf90003c0

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+4096
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x2, [x16, #1200]
.word 0xf9400ba0
.word 0xf9402fa1
bl _p_311
.word 0x910003bf
.word 0xa8c77bfd
.word 0xd65f03c0

Lme_348:
.text
	.align 4
	.no_dead_strip UIKit_UILabel_set_Text_string
UIKit_UILabel_set_Text_string:
.loc 88 731 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
bl _p_519
.loc 88 732 0
.word 0x910083a0
.word 0xf9001ba0
.word 0xf9400fa0
bl _p_454
.word 0xf9401bbe
.word 0xf90003c0
.loc 88 734 0
.word 0xf9400ba0
.word 0x91004000
.word 0xf9400000
.word 0xf90017a0
.word 0xf94017a0
adrp x1, L_OBJC_SELECTOR_REFERENCES_61@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_61@PAGEOFF
ldr x1, [x1]
.word 0xf94013a2
bl _p_337
.loc 88 738 0
.word 0xf94013a0
bl _p_456
.loc 88 739 0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_349:
.text
	.align 4
	.no_dead_strip UIKit_UILabel_set_TextAlignment_UIKit_UITextAlignment
UIKit_UILabel_set_TextAlignment_UIKit_UITextAlignment:
.loc 88 756 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_Microsoft_iOS_got@PAGE+0
add x16, x16, mono_aot_Microsoft_iOS_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
bl _p_1

