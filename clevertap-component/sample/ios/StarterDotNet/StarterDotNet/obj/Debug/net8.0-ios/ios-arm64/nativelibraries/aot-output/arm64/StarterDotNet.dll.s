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
	.asciz "StarterDotNet.dll"
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
	.no_dead_strip Program__Main__string__
Program__Main__string__:
.file 1 "/Users/nishant.kumar/clevertap-xamarin/clevertap-component/sample/ios/StarterDotNet/StarterDotNet/Main.cs"
.loc 1 6 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #192]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fb1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xd2800001

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x2, [x16, #200]
.word 0xd2800001
bl _p_2
.word 0xf9400fb1
.word 0xf9408e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9409e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip Program__ctor
Program__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #208]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9402a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fb1
.word 0xf9403e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_1:
.text
	.align 4
	.no_dead_strip StarterDotNet_AppDelegate_get_Window
StarterDotNet_AppDelegate_get_Window:
.file 2 "/Users/nishant.kumar/clevertap-xamarin/clevertap-component/sample/ios/StarterDotNet/StarterDotNet/AppDelegate.cs"
.loc 2 7 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #216]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9402a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9404a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9401800
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_2:
.text
	.align 4
	.no_dead_strip StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow
StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow:
.loc 2 8 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #224]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf90023a1
.word 0x9100c001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94013b1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary:
.loc 2 12 0 prologue_end
.word 0xa9ad7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003fa
.word 0xf90027a1
.word 0xf9002ba2

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #232]
.word 0xf9002fb0
.word 0xf9400211
.word 0xf90033b1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd2800019
.word 0xd2a00018
.word 0xf9402fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94033b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.loc 2 13 0
.word 0xf9402fb1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800080
.word 0xd2800080
bl _p_3
.word 0xf9402fb1
.word 0xf940ae31
.word 0xb4000051
.word 0xd63f0220
.loc 2 14 0
.word 0xf9402fb1
.word 0xf940be31
.word 0xb4000051
.word 0xd63f0220
bl _p_4
.word 0xf9402fb1
.word 0xf940d231
.word 0xb4000051
.word 0xd63f0220
.loc 2 17 0
.word 0xf9402fb1
.word 0xf940e231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
bl _p_5
.word 0xf90097a0
.word 0xf9402fb1
.word 0xf940fe31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94097a1
.word 0x910243a0
.word 0xf9005ba0
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9406830
.word 0xd63f0200
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.word 0xf9402fb1
.word 0xf9413e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #240]
bl _p_6
.word 0xf90093a0
.word 0x910243a1
.word 0xfd404ba0
.word 0xfd404fa1
.word 0xfd4053a2
.word 0xfd4057a3
bl _p_7
.word 0xf9402fb1
.word 0xf9417a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94093a1
.word 0xaa1a03e0
.word 0xf9400342
.word 0xf9406850
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf9419e31
.word 0xb4000051
.word 0xd63f0220
.loc 2 20 0
.word 0xf9402fb1
.word 0xf941ae31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #248]
bl _p_6
.word 0xf9008fa0
bl _p_8
.word 0xf9402fb1
.word 0xf941d631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9408fa0
.word 0xaa0003f9
.loc 2 21 0
.word 0xf9402fb1
.word 0xf941ee31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1903e0
.word 0xaa1903e0
.word 0xf9400321
.word 0xf9406830
.word 0xd63f0200
.word 0xf9006fa0
.word 0xf9402fb1
.word 0xf9421631
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9406c30
.word 0xd63f0200
.word 0xf9008ba0
.word 0xf9402fb1
.word 0xf9423e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9408ba1
.word 0x9101c3a0
.word 0xf9005ba0
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9407c30
.word 0xd63f0200
.word 0xf9405bbe
.word 0xfd0003c0
.word 0xfd0007c1
.word 0xfd000bc2
.word 0xfd000fc3
.word 0xf9402fb1
.word 0xf9427e31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #256]
bl _p_6
.word 0xf90087a0
.word 0x9101c3a1
.word 0xfd403ba0
.word 0xfd403fa1
.word 0xfd4043a2
.word 0xfd4047a3
bl _p_9
.word 0xf9402fb1
.word 0xf942ba31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94087a0
.word 0xaa0003f7
.word 0xaa1703e0
.word 0xf9007ba0
.word 0xaa1703e0
.word 0xf90083a0
bl _p_10
.word 0xf9007fa0
.word 0xf9402fb1
.word 0xf942ea31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9407fa1
.word 0xf94083a2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9408450
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf9431231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9407ba0
.word 0xaa0003f6
.word 0xaa1603e0
.word 0xf90077a0
.word 0xaa1603e0
.word 0xd2800020
.word 0xaa1603e0
.word 0xd2800021
.word 0xf94002c2
.word 0xf940a050
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf9434e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94077a0
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xf90073a0
.word 0xaa1503e0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x1, [x16, #264]
.word 0xaa1503e0
.word 0xf94002a2
.word 0xf940a450
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf9438e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94073a0
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xf9006ba0
.word 0xaa1403e0
.word 0xd28007e0
.word 0xaa1403e0
.word 0xd28007e1
.word 0xf9400282
.word 0xf9408850
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf943ca31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9406ba1
.word 0xf9406fa2
.word 0xaa0203e0
.word 0xf9400042
.word 0xf9409c50
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf943f231
.word 0xb4000051
.word 0xd63f0220
.loc 2 29 0
.word 0xf9402fb1
.word 0xf9440231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9406c30
.word 0xd63f0200
.word 0xf90067a0
.word 0xf9402fb1
.word 0xf9442a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94067a2
.word 0xaa1903e1
.word 0xaa0203e0
.word 0xf9400042
.word 0xf940a050
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf9445231
.word 0xb4000051
.word 0xd63f0220
.loc 2 32 0
.word 0xf9402fb1
.word 0xf9446231
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1a03e0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf9406c30
.word 0xd63f0200
.word 0xf90063a0
.word 0xf9402fb1
.word 0xf9448a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94063a1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf940a430
.word 0xd63f0200
.word 0xf9402fb1
.word 0xf944ae31
.word 0xb4000051
.word 0xd63f0220
.loc 2 34 0
.word 0xf9402fb1
.word 0xf944be31
.word 0xb4000051
.word 0xd63f0220
bl _p_11
.word 0xf9402fb1
.word 0xf944d231
.word 0xb4000051
.word 0xd63f0220
.loc 2 36 0
.word 0xf9402fb1
.word 0xf944e231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800020
.word 0x53001c00
.word 0xaa0003f8
.loc 2 37 0
.word 0xf9402fb1
.word 0xf944fe31
.word 0xb4000051
.word 0xd63f0220
.word 0xaa1803e0
.word 0xaa1803e0
.word 0xf9402fb1
.word 0xf9451631
.word 0xb4000051
.word 0xd63f0220
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8d37bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip StarterDotNet_AppDelegate_CallCleverTapMethods
StarterDotNet_AppDelegate_CallCleverTapMethods:
.loc 2 40 0 prologue_end
.word 0xd2804210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0xa9007bfd
.word 0x910003fd
.word 0xa90153b3
.word 0xa9025bb5
.word 0xa90363b7
.word 0xa9046bb9

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #272]
.word 0xf9002bb0
.word 0xf9400211
.word 0xf9002fb1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xd280001a
.word 0xf9402bb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9408231
.word 0xb4000051
.word 0xd63f0220
.loc 2 42 0
.word 0xf9402bb1
.word 0xf9409231
.word 0xb4000051
.word 0xd63f0220
bl _p_12
.word 0xf90053a0
.word 0xf9402bb1
.word 0xf940aa31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94053a0
.word 0xaa0003f9
.word 0xaa0003e1
.word 0xaa0003e1
.word 0xaa0003f8
.word 0xb5000060
.word 0xaa1803e0
.word 0x1400000d
.word 0xaa1803e0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x1, [x16, #280]
.word 0xaa1803e0
.word 0xf9400302
.word 0xf940ec50
.word 0xd63f0200
.word 0xf9402bb1
.word 0xf940fa31
.word 0xb4000051
.word 0xd63f0220
.loc 2 45 0
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf9411a31
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #288]
.word 0xf90103a0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf94103a1
.word 0xf9005ba0
bl _p_13
.word 0xf9402bb1
.word 0xf9415631
.word 0xb4000051
.word 0xd63f0220

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #304]
.word 0xf900ffa0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940ffa1
.word 0xf9005fa0
bl _p_13
.word 0xf9402bb1
.word 0xf9419231
.word 0xb4000051
.word 0xd63f0220
.word 0xd2800140

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #312]
.word 0xd2800141
bl _p_14
.word 0xaa0003f7
.word 0xaa1703e0
.word 0xf900efa0
.word 0xaa1703e0
.word 0xf900f7a0
.word 0xd2a00000

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #320]
.word 0xf900fba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940fba1
.word 0xf900f3a0
bl _p_13
.word 0xf9402bb1
.word 0xf941fe31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940f3a2
.word 0xf940f7a3
.word 0xaa0303e0
.word 0xd2a00001
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940efa0
.word 0xaa0003f6
.word 0xaa1603e0
.word 0xf900dfa0
.word 0xaa1603e0
.word 0xf900e7a0
.word 0xd2800020

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xf900eba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940eba1
.word 0xf900e3a0
bl _p_13
.word 0xf9402bb1
.word 0xf9427231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940e3a2
.word 0xf940e7a3
.word 0xaa0303e0
.word 0xd2800021
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940dfa0
.word 0xaa0003f5
.word 0xaa1503e0
.word 0xf900cfa0
.word 0xaa1503e0
.word 0xf900d7a0
.word 0xd2800040

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #336]
.word 0xf900dba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940dba1
.word 0xf900d3a0
bl _p_13
.word 0xf9402bb1
.word 0xf942e631
.word 0xb4000051
.word 0xd63f0220
.word 0xf940d3a2
.word 0xf940d7a3
.word 0xaa0303e0
.word 0xd2800041
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940cfa0
.word 0xaa0003f4
.word 0xaa1403e0
.word 0xf900bfa0
.word 0xaa1403e0
.word 0xf900c7a0
.word 0xd2800060

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #344]
.word 0xf900cba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940cba1
.word 0xf900c3a0
bl _p_13
.word 0xf9402bb1
.word 0xf9435a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940c3a2
.word 0xf940c7a3
.word 0xaa0303e0
.word 0xd2800061
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940bfa0
.word 0xaa0003f3
.word 0xaa1303e0
.word 0xf900afa0
.word 0xaa1303e0
.word 0xf900b7a0
.word 0xd2800080

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf900bba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940bba1
.word 0xf900b3a0
bl _p_13
.word 0xf9402bb1
.word 0xf943ce31
.word 0xb4000051
.word 0xd63f0220
.word 0xf940b3a2
.word 0xf940b7a3
.word 0xaa0303e0
.word 0xd2800081
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf940afa0
.word 0xf90037a0
.word 0xf94037a0
.word 0xf9009fa0
.word 0xf94037a0
.word 0xf900a7a0
.word 0xd28000a0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #360]
.word 0xf900aba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf940aba1
.word 0xf900a3a0
bl _p_13
.word 0xf9402bb1
.word 0xf9444231
.word 0xb4000051
.word 0xd63f0220
.word 0xf940a3a2
.word 0xf940a7a3
.word 0xaa0303e0
.word 0xd28000a1
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9409fa0
.word 0xf9003ba0
.word 0xf9403ba0
.word 0xf9008fa0
.word 0xf9403ba0
.word 0xf90097a0
.word 0xd28000c0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #368]
.word 0xf9009ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf9409ba1
.word 0xf90093a0
bl _p_13
.word 0xf9402bb1
.word 0xf944b631
.word 0xb4000051
.word 0xd63f0220
.word 0xf94093a2
.word 0xf94097a3
.word 0xaa0303e0
.word 0xd28000c1
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9408fa0
.word 0xf9003fa0
.word 0xf9403fa0
.word 0xf9007fa0
.word 0xf9403fa0
.word 0xf90087a0
.word 0xd28000e0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #376]
.word 0xf9008ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf9408ba1
.word 0xf90083a0
bl _p_13
.word 0xf9402bb1
.word 0xf9452a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94083a2
.word 0xf94087a3
.word 0xaa0303e0
.word 0xd28000e1
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9407fa0
.word 0xf90043a0
.word 0xf94043a0
.word 0xf9006fa0
.word 0xf94043a0
.word 0xf90077a0
.word 0xd2800100

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #384]
.word 0xf9007ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #296]
bl _p_6
.word 0xf9407ba1
.word 0xf90073a0
bl _p_13
.word 0xf9402bb1
.word 0xf9459e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94073a2
.word 0xf94077a3
.word 0xaa0303e0
.word 0xd2800101
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200
.word 0xf9406fa0
.word 0xf90047a0
.word 0xf94047a0
.word 0xf90063a0
.word 0xf94047a0
.word 0xf9006ba0
.word 0xd2800120

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #392]
bl _p_6
.word 0xf90067a0
bl _p_15
.word 0xf9402bb1
.word 0xf945fe31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94067a2
.word 0xf9406ba3
.word 0xaa0303e0
.word 0xd2800121
.word 0xf9400063
.word 0xf9404070
.word 0xd63f0200

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #400]
bl _p_6
.word 0xf9405ba1
.word 0xf9405fa2
.word 0xf94063a3
.word 0xf90057a0
bl _p_16
.word 0xf9402bb1
.word 0xf9464e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94057a0
.word 0xaa0003fa
.loc 2 53 0
.word 0xf9402bb1
.word 0xf9466631
.word 0xb4000051
.word 0xd63f0220
bl _p_12
.word 0xf90053a0
.word 0xf9402bb1
.word 0xf9467e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94053a0
.word 0xf9004ba0
.word 0xf9404ba1
.word 0xf9404ba0
.word 0xaa0103f8
.word 0xb5000060
.word 0xaa1803e0
.word 0x1400000c
.word 0xaa1803e0
.word 0xaa1a03e0
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xf9400302
.word 0xf9410c50
.word 0xd63f0200
.word 0xf9402bb1
.word 0xf946ca31
.word 0xb4000051
.word 0xd63f0220
.loc 2 54 0
.word 0xf9402fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf946ea31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9402bb1
.word 0xf946fa31
.word 0xb4000051
.word 0xd63f0220
.word 0xa94153b3
.word 0xa9425bb5
.word 0xa94363b7
.word 0xa9446bb9
.word 0x910003bf
.word 0xa9407bfd
.word 0xd2804210
.word 0x910003f1
.word 0x8b100231
.word 0x9100023f
.word 0xd65f03c0

Lme_5:
.text
	.align 4
	.no_dead_strip StarterDotNet_AppDelegate__ctor
StarterDotNet_AppDelegate__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #408]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fb1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
bl _p_17
.word 0xf9400fb1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_6:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_get_Window
StarterDotNet_SceneDelegate_get_Window:
.file 3 "/Users/nishant.kumar/clevertap-xamarin/clevertap-component/sample/ios/StarterDotNet/StarterDotNet/SceneDelegate.cs"
.loc 3 7 0 prologue_end
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #416]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1
.word 0xf9400fb1
.word 0xf9402a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9404a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9401800
.word 0xf9400fb1
.word 0xf9406231
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow
StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow:
.loc 3 7 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #424]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf90023a1
.word 0x9100c001
.word 0xd5033bbf
.word 0xf94023a0
.word 0xf9000020
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0xf94013b1
.word 0xf940a231
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_8:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions
StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions:
.loc 3 11 0 prologue_end
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #432]
.word 0xf9001bb0
.word 0xf9400211
.word 0xf9001fb1
.word 0xf9401bb1
.word 0xf9403631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401fb1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9405631
.word 0xb4000051
.word 0xd63f0220
.loc 3 15 0
.word 0xf9401bb1
.word 0xf9406631
.word 0xb4000051
.word 0xd63f0220
.word 0xf9401bb1
.word 0xf9407631
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_9:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene
StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene:
.loc 3 19 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #440]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 24 0
.word 0xf94013b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_a:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene
StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene:
.loc 3 28 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #448]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 31 0
.word 0xf94013b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_b:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene
StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene:
.loc 3 35 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #456]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 38 0
.word 0xf94013b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_c:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene
StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene:
.loc 3 42 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #464]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 45 0
.word 0xf94013b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene
StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene:
.loc 3 49 0 prologue_end
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #472]
.word 0xf90013b0
.word 0xf9400211
.word 0xf90017b1
.word 0xf94013b1
.word 0xf9402e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94017b1
.word 0xf9400231
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9404e31
.word 0xb4000051
.word 0xd63f0220
.loc 3 53 0
.word 0xf94013b1
.word 0xf9405e31
.word 0xb4000051
.word 0xd63f0220
.word 0xf94013b1
.word 0xf9406e31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e:
.text
	.align 4
	.no_dead_strip StarterDotNet_SceneDelegate__ctor
StarterDotNet_SceneDelegate__ctor:
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #480]
.word 0xf9000fb0
.word 0xf9400211
.word 0xf90013b1

adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x0, [x16, #56]
.word 0xf9400011
.word 0xb4000051
bl _p_1
.word 0xf9400fb1
.word 0xf9404231
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400ba0
bl _p_18
.word 0xf9400fb1
.word 0xf9405a31
.word 0xb4000051
.word 0xd63f0220
.word 0xf9400fb1
.word 0xf9406a31
.word 0xb4000051
.word 0xd63f0220
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl Program__Main__string__
bl Program__ctor
bl StarterDotNet_AppDelegate_get_Window
bl StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow
bl StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
bl StarterDotNet_AppDelegate_CallCleverTapMethods
bl StarterDotNet_AppDelegate__ctor
bl StarterDotNet_SceneDelegate_get_Window
bl StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow
bl StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions
bl StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene
bl StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene
bl StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene
bl StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene
bl StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene
bl StarterDotNet_SceneDelegate__ctor
bl method_addresses
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 13,12,31,0,68,14,48,157,6,158,5,68,13,29,13,12,31,0,68,14,80,157,10,158,9,68,13,29,32,12,31,0
	.byte 68,14,176,2,157,38,158,37,68,13,29,68,148,36,149,35,68,150,34,151,33,68,152,32,153,31,68,154,30,34,12,31
	.byte 0,84,14,144,4,157,66,158,65,68,13,29,68,147,64,148,63,68,149,62,150,61,68,151,60,152,59,68,153,58,154,57
	.byte 13,12,31,0,68,14,64,157,8,158,7,68,13,29

.text
	.align 4
plt:
mono_aot_StarterDotNet_plt:
	.no_dead_strip plt__jit_icall_mono_threads_state_poll
plt__jit_icall_mono_threads_state_poll:
_p_1:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #496]
br x16
.word 273
	.no_dead_strip plt_UIKit_UIApplication_Main_string___System_Type_System_Type
plt_UIKit_UIApplication_Main_string___System_Type_System_Type:
_p_2:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #504]
br x16
.word 276
	.no_dead_strip plt_CleverTapSDK_CleverTap_SetDebugLevel_int
plt_CleverTapSDK_CleverTap_SetDebugLevel_int:
_p_3:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #512]
br x16
.word 281
	.no_dead_strip plt_CleverTapSDK_CleverTap_AutoIntegrate
plt_CleverTapSDK_CleverTap_AutoIntegrate:
_p_4:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #520]
br x16
.word 286
	.no_dead_strip plt_UIKit_UIScreen_get_MainScreen
plt_UIKit_UIScreen_get_MainScreen:
_p_5:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #528]
br x16
.word 291
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_6:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #536]
br x16
.word 296
	.no_dead_strip plt_UIKit_UIWindow__ctor_CoreGraphics_CGRect
plt_UIKit_UIWindow__ctor_CoreGraphics_CGRect:
_p_7:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #544]
br x16
.word 299
	.no_dead_strip plt_UIKit_UIViewController__ctor
plt_UIKit_UIViewController__ctor:
_p_8:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #552]
br x16
.word 304
	.no_dead_strip plt_UIKit_UILabel__ctor_CoreGraphics_CGRect
plt_UIKit_UILabel__ctor_CoreGraphics_CGRect:
_p_9:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #560]
br x16
.word 309
	.no_dead_strip plt_UIKit_UIColor_get_SystemBackground
plt_UIKit_UIColor_get_SystemBackground:
_p_10:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #568]
br x16
.word 314
	.no_dead_strip plt_StarterDotNet_AppDelegate_CallCleverTapMethods
plt_StarterDotNet_AppDelegate_CallCleverTapMethods:
_p_11:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #576]
br x16
.word 319
	.no_dead_strip plt_CleverTapSDK_CleverTap_SharedInstance
plt_CleverTapSDK_CleverTap_SharedInstance:
_p_12:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #584]
br x16
.word 321
	.no_dead_strip plt_Foundation_NSString__ctor_string
plt_Foundation_NSString__ctor_string:
_p_13:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #592]
br x16
.word 326
	.no_dead_strip plt_wrapper_alloc_object_AllocVector_intptr_intptr
plt_wrapper_alloc_object_AllocVector_intptr_intptr:
_p_14:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #600]
br x16
.word 331
	.no_dead_strip plt_Foundation_NSDate__ctor
plt_Foundation_NSDate__ctor:
_p_15:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #608]
br x16
.word 339
	.no_dead_strip plt_Foundation_NSDictionary__ctor_Foundation_NSObject_Foundation_NSObject_Foundation_NSObject__
plt_Foundation_NSDictionary__ctor_Foundation_NSObject_Foundation_NSObject_Foundation_NSObject__:
_p_16:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #616]
br x16
.word 344
	.no_dead_strip plt_UIKit_UIApplicationDelegate__ctor
plt_UIKit_UIApplicationDelegate__ctor:
_p_17:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #624]
br x16
.word 349
	.no_dead_strip plt_UIKit_UIResponder__ctor
plt_UIKit_UIResponder__ctor:
_p_18:
adrp x16, mono_aot_StarterDotNet_got@PAGE+0
add x16, x16, mono_aot_StarterDotNet_got@PAGEOFF
ldr x16, [x16, #632]
br x16
.word 354
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_StarterDotNet_got, 640
got_end:
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 3
	.quad Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "ED79D0AB-A224-47AF-9DD2-46080756F4D1"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "StarterDotNet"
.data
	.align 3
_mono_aot_file_info:

	.long 185,0
	.align 3
	.quad mono_aot_StarterDotNet_got
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad jit_code_start
	.align 3
	.quad jit_code_end
	.align 3
	.quad method_addresses
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad mem_end
	.align 3
	.quad assembly_guid
	.align 3
	.quad runtime_version
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad globals
	.align 3
	.quad assembly_name
	.align 3
	.quad plt
	.align 3
	.quad plt_end
	.align 3
	.quad unwind_info
	.align 3
	.quad unbox_trampolines
	.align 3
	.quad unbox_trampolines_end
	.align 3
	.quad unbox_trampoline_addresses

	.long 61,61,640,192,19,17,0,102
	.long 391195135,0,1969,128,8,8,7,9
	.long 8388607,0,4,24,2792,0,0,0
	.long 0,816,192,408,0,352,184,72
	.long 248,0,432,808,48,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0
	.byte 77,44,108,49,103,64,142,123,130,224,79,252,189,94,226,44
	.globl _mono_aot_module_StarterDotNet_info
	.align 3
_mono_aot_module_StarterDotNet_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Program:<Main>_"
	.asciz "Program__Main__string__"

	.byte 1,6
	.quad Program__Main__string__
	.quad Lme_0

	.byte 2,118,16,3
	.asciz "args"

LDIFF_SYM3=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM3
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM4=Lfde0_end - Lfde0_start
	.long LDIFF_SYM4
Lfde0_start:

	.long 0
	.align 3
	.quad Program__Main__string__

LDIFF_SYM5=Lme_0 - Program__Main__string__
	.long LDIFF_SYM5
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
	.asciz "System_Object"

LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM7=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM8=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0:

	.byte 5
	.asciz "_Program"

	.byte 16,16
LDIFF_SYM9=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2,35,0,0,7
	.asciz "_Program"

LDIFF_SYM10=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM10
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM11=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM11
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM12=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM12
	.byte 2
	.asciz "Program:.ctor"
	.asciz "Program__ctor"

	.byte 0,0
	.quad Program__ctor
	.quad Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM13=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM14=Lfde1_end - Lfde1_start
	.long LDIFF_SYM14
Lfde1_start:

	.long 0
	.align 3
	.quad Program__ctor

LDIFF_SYM15=Lme_1 - Program__ctor
	.long LDIFF_SYM15
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM16=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM16
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,9
	.asciz "HasManagedRef"

	.byte 32,9
	.asciz "IsCustomType"

	.byte 128,127,0,7
	.asciz "_Flags"

LDIFF_SYM17=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM18=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM19=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_4:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 48,16
LDIFF_SYM20=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM20
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM21=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM21
	.byte 2,35,16,6
	.asciz "super"

LDIFF_SYM22=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,24,6
	.asciz "actual_flags"

LDIFF_SYM23=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,32,6
	.asciz "tracked_object_info"

LDIFF_SYM24=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,35,40,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM25=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM26=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM27=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_3:

	.byte 5
	.asciz "UIKit_UIApplicationDelegate"

	.byte 48,16
LDIFF_SYM28=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplicationDelegate"

LDIFF_SYM29=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM29
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM30=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM30
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM31=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM31
LTDIE_8:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 48,16
LDIFF_SYM32=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,35,0,0,7
	.asciz "UIKit_UIResponder"

LDIFF_SYM33=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM34=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM35=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_7:

	.byte 5
	.asciz "UIKit_UIView"

	.byte 48,16
LDIFF_SYM36=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,0,0,7
	.asciz "UIKit_UIView"

LDIFF_SYM37=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM37
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM38=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM38
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM39=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM39
LTDIE_6:

	.byte 5
	.asciz "UIKit_UIWindow"

	.byte 48,16
LDIFF_SYM40=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,35,0,0,7
	.asciz "UIKit_UIWindow"

LDIFF_SYM41=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM41
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM42=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM43=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_2:

	.byte 5
	.asciz "StarterDotNet_AppDelegate"

	.byte 56,16
LDIFF_SYM44=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM44
	.byte 2,35,0,6
	.asciz "<Window>k__BackingField"

LDIFF_SYM45=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,35,48,0,7
	.asciz "StarterDotNet_AppDelegate"

LDIFF_SYM46=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM46
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM47=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM47
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM48=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2
	.asciz "StarterDotNet.AppDelegate:get_Window"
	.asciz "StarterDotNet_AppDelegate_get_Window"

	.byte 2,7
	.quad StarterDotNet_AppDelegate_get_Window
	.quad Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM49=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM50=Lfde2_end - Lfde2_start
	.long LDIFF_SYM50
Lfde2_start:

	.long 0
	.align 3
	.quad StarterDotNet_AppDelegate_get_Window

LDIFF_SYM51=Lme_2 - StarterDotNet_AppDelegate_get_Window
	.long LDIFF_SYM51
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.AppDelegate:set_Window"
	.asciz "StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow"

	.byte 2,8
	.quad StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow
	.quad Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM52=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM53=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde3_end - Lfde3_start
	.long LDIFF_SYM54
Lfde3_start:

	.long 0
	.align 3
	.quad StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow

LDIFF_SYM55=Lme_3 - StarterDotNet_AppDelegate_set_Window_UIKit_UIWindow
	.long LDIFF_SYM55
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_9:

	.byte 5
	.asciz "UIKit_UIApplication"

	.byte 48,16
LDIFF_SYM56=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,0,0,7
	.asciz "UIKit_UIApplication"

LDIFF_SYM57=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM57
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM58=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM58
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM59=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM59
LTDIE_10:

	.byte 5
	.asciz "Foundation_NSDictionary"

	.byte 48,16
LDIFF_SYM60=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDictionary"

LDIFF_SYM61=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM62=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM63=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_11:

	.byte 5
	.asciz "UIKit_UIViewController"

	.byte 48,16
LDIFF_SYM64=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,0,0,7
	.asciz "UIKit_UIViewController"

LDIFF_SYM65=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM65
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM66=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM67=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM67
LTDIE_13:

	.byte 5
	.asciz "System_ValueType"

	.byte 16,16
LDIFF_SYM68=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM69=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM69
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM70=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM70
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM71=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM71
LTDIE_12:

	.byte 5
	.asciz "System_Boolean"

	.byte 17,16
LDIFF_SYM72=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM73=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,35,16,0,7
	.asciz "System_Boolean"

LDIFF_SYM74=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM74
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM75=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM76=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2
	.asciz "StarterDotNet.AppDelegate:FinishedLaunching"
	.asciz "StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary"

	.byte 2,12
	.quad StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.quad Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM77=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 1,106,3
	.asciz "application"

LDIFF_SYM78=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 3,141,200,0,3
	.asciz "launchOptions"

LDIFF_SYM79=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 3,141,208,0,11
	.asciz "vc"

LDIFF_SYM80=LTDIE_11_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM81=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM82=Lfde4_end - Lfde4_start
	.long LDIFF_SYM82
Lfde4_start:

	.long 0
	.align 3
	.quad StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary

LDIFF_SYM83=Lme_4 - StarterDotNet_AppDelegate_FinishedLaunching_UIKit_UIApplication_Foundation_NSDictionary
	.long LDIFF_SYM83
	.long 0
	.byte 12,31,0,68,14,176,2,157,38,158,37,68,13,29,68,148,36,149,35,68,150,34,151,33,68,152,32,153,31,68,154,30
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.AppDelegate:CallCleverTapMethods"
	.asciz "StarterDotNet_AppDelegate_CallCleverTapMethods"

	.byte 2,40
	.quad StarterDotNet_AppDelegate_CallCleverTapMethods
	.quad Lme_5

	.byte 2,118,16,11
	.asciz "profileData"

LDIFF_SYM84=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM85=Lfde5_end - Lfde5_start
	.long LDIFF_SYM85
Lfde5_start:

	.long 0
	.align 3
	.quad StarterDotNet_AppDelegate_CallCleverTapMethods

LDIFF_SYM86=Lme_5 - StarterDotNet_AppDelegate_CallCleverTapMethods
	.long LDIFF_SYM86
	.long 0
	.byte 12,31,0,84,14,144,4,157,66,158,65,68,13,29,68,147,64,148,63,68,149,62,150,61,68,151,60,152,59,68,153,58
	.byte 154,57
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.AppDelegate:.ctor"
	.asciz "StarterDotNet_AppDelegate__ctor"

	.byte 0,0
	.quad StarterDotNet_AppDelegate__ctor
	.quad Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM87=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM88=Lfde6_end - Lfde6_start
	.long LDIFF_SYM88
Lfde6_start:

	.long 0
	.align 3
	.quad StarterDotNet_AppDelegate__ctor

LDIFF_SYM89=Lme_6 - StarterDotNet_AppDelegate__ctor
	.long LDIFF_SYM89
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_14:

	.byte 5
	.asciz "StarterDotNet_SceneDelegate"

	.byte 56,16
LDIFF_SYM90=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,0,6
	.asciz "<Window>k__BackingField"

LDIFF_SYM91=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,48,0,7
	.asciz "StarterDotNet_SceneDelegate"

LDIFF_SYM92=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM92
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM93=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM93
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM94=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2
	.asciz "StarterDotNet.SceneDelegate:get_Window"
	.asciz "StarterDotNet_SceneDelegate_get_Window"

	.byte 3,7
	.quad StarterDotNet_SceneDelegate_get_Window
	.quad Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM95=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM96=Lfde7_end - Lfde7_start
	.long LDIFF_SYM96
Lfde7_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_get_Window

LDIFF_SYM97=Lme_7 - StarterDotNet_SceneDelegate_get_Window
	.long LDIFF_SYM97
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:set_Window"
	.asciz "StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow"

	.byte 3,7
	.quad StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow
	.quad Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM98=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM99=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM100=Lfde8_end - Lfde8_start
	.long LDIFF_SYM100
Lfde8_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow

LDIFF_SYM101=Lme_8 - StarterDotNet_SceneDelegate_set_Window_UIKit_UIWindow
	.long LDIFF_SYM101
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_15:

	.byte 5
	.asciz "UIKit_UIScene"

	.byte 48,16
LDIFF_SYM102=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 2,35,0,0,7
	.asciz "UIKit_UIScene"

LDIFF_SYM103=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM103
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM104=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM104
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM105=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_16:

	.byte 5
	.asciz "UIKit_UISceneSession"

	.byte 48,16
LDIFF_SYM106=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM106
	.byte 2,35,0,0,7
	.asciz "UIKit_UISceneSession"

LDIFF_SYM107=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM107
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM108=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM108
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM109=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_17:

	.byte 5
	.asciz "UIKit_UISceneConnectionOptions"

	.byte 48,16
LDIFF_SYM110=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM110
	.byte 2,35,0,0,7
	.asciz "UIKit_UISceneConnectionOptions"

LDIFF_SYM111=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM111
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM112=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM112
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM113=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2
	.asciz "StarterDotNet.SceneDelegate:WillConnect"
	.asciz "StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions"

	.byte 3,11
	.quad StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions
	.quad Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM114=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM114
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM115=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM115
	.byte 2,141,24,3
	.asciz "session"

LDIFF_SYM116=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,141,32,3
	.asciz "connectionOptions"

LDIFF_SYM117=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,141,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM118=Lfde9_end - Lfde9_start
	.long LDIFF_SYM118
Lfde9_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions

LDIFF_SYM119=Lme_9 - StarterDotNet_SceneDelegate_WillConnect_UIKit_UIScene_UIKit_UISceneSession_UIKit_UISceneConnectionOptions
	.long LDIFF_SYM119
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:DidDisconnect"
	.asciz "StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene"

	.byte 3,19
	.quad StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene
	.quad Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM120=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM121=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM122=Lfde10_end - Lfde10_start
	.long LDIFF_SYM122
Lfde10_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene

LDIFF_SYM123=Lme_a - StarterDotNet_SceneDelegate_DidDisconnect_UIKit_UIScene
	.long LDIFF_SYM123
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:DidBecomeActive"
	.asciz "StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene"

	.byte 3,28
	.quad StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene
	.quad Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM124=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM124
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM125=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM126=Lfde11_end - Lfde11_start
	.long LDIFF_SYM126
Lfde11_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene

LDIFF_SYM127=Lme_b - StarterDotNet_SceneDelegate_DidBecomeActive_UIKit_UIScene
	.long LDIFF_SYM127
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:WillResignActive"
	.asciz "StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene"

	.byte 3,35
	.quad StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene
	.quad Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM128=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM129=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM130=Lfde12_end - Lfde12_start
	.long LDIFF_SYM130
Lfde12_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene

LDIFF_SYM131=Lme_c - StarterDotNet_SceneDelegate_WillResignActive_UIKit_UIScene
	.long LDIFF_SYM131
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:WillEnterForeground"
	.asciz "StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene"

	.byte 3,42
	.quad StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene
	.quad Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM132=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM133=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM134=Lfde13_end - Lfde13_start
	.long LDIFF_SYM134
Lfde13_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene

LDIFF_SYM135=Lme_d - StarterDotNet_SceneDelegate_WillEnterForeground_UIKit_UIScene
	.long LDIFF_SYM135
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:DidEnterBackground"
	.asciz "StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene"

	.byte 3,49
	.quad StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene
	.quad Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM136=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,141,16,3
	.asciz "scene"

LDIFF_SYM137=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM138=Lfde14_end - Lfde14_start
	.long LDIFF_SYM138
Lfde14_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene

LDIFF_SYM139=Lme_e - StarterDotNet_SceneDelegate_DidEnterBackground_UIKit_UIScene
	.long LDIFF_SYM139
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "StarterDotNet.SceneDelegate:.ctor"
	.asciz "StarterDotNet_SceneDelegate__ctor"

	.byte 0,0
	.quad StarterDotNet_SceneDelegate__ctor
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM140=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM141=Lfde15_end - Lfde15_start
	.long LDIFF_SYM141
Lfde15_start:

	.long 0
	.align 3
	.quad StarterDotNet_SceneDelegate__ctor

LDIFF_SYM142=Lme_f - StarterDotNet_SceneDelegate__ctor
	.long LDIFF_SYM142
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
