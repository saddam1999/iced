/*
    Copyright (C) 2018-2019 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest64_NoMemSize_001 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_001.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_001.AllInfos_Length] {
			"idiv byte ptr [rax]",
			"test cx, 0xa55a",
			"test word ptr [rax], 0xa55a",
			"test ecx, 0x3412a55a",
			"test dword ptr [rax], 0x3412a55a",
			"test rcx, 0xffffffff8412a55a",
			"test qword ptr [rax], 0xffffffff8412a55a",
			"not cx",
			"not word ptr [rax]",
			"not ecx",
			"not dword ptr [rax]",
			"not rcx",
			"not qword ptr [rax]",
			"neg si",
			"neg word ptr [rax]",
			"neg esi",
			"neg dword ptr [rax]",
			"neg rsi",
			"neg qword ptr [rax]",
			"mul bp",
			"mul word ptr [rax]",
			"mul ebp",
			"mul dword ptr [rax]",
			"mul rbp",
			"mul qword ptr [rax]",
			"imul si",
			"imul word ptr [rax]",
			"imul esi",
			"imul dword ptr [rax]",
			"imul rsi",
			"imul qword ptr [rax]",
			"div di",
			"div word ptr [rax]",
			"div edi",
			"div dword ptr [rax]",
			"div rdi",
			"div qword ptr [rax]",
			"idiv ax",
			"idiv word ptr [rax]",
			"idiv eax",
			"idiv dword ptr [rax]",
			"idiv r8",
			"idiv qword ptr [rax]",
			"clc",
			"stc",
			"cli",
			"sti",
			"cld",
			"std",
			"inc cl",
			"inc byte ptr [rax]",
			"dec dh",
			"dec byte ptr [rax]",
			"inc cx",
			"inc word ptr [rax]",
			"inc ecx",
			"inc dword ptr [rax]",
			"inc rcx",
			"inc qword ptr [rax]",
			"dec si",
			"dec word ptr [rax]",
			"dec esi",
			"dec dword ptr [rax]",
			"dec rsi",
			"dec qword ptr [rax]",
			"call rcx",
			"call qword ptr [rax]",
			"call far dword ptr [rax]",
			"call far fword ptr [rax]",
			"call far tbyte ptr [rax]",
			"jmp rsi",
			"jmp qword ptr [rax]",
			"jmp far dword ptr [rax]",
			"jmp far fword ptr [rax]",
			"jmp far tbyte ptr [rax]",
			"push si",
			"push word ptr [rax]",
			"push rsi",
			"push qword ptr [rax]",
			"sldt cx",
			"sldt [rax]",
			"sldt ecx",
			"sldt [rax]",
			"sldt rcx",
			"sldt [rax]",
			"str dx",
			"str [rax]",
			"str edx",
			"str [rax]",
			"str rdx",
			"str [rax]",
			"lldt bx",
			"lldt [rax]",
			"lldt ebx",
			"lldt [rax]",
			"lldt rbx",
			"lldt [rax]",
			"ltr sp",
			"ltr [rax]",
			"ltr esp",
			"ltr [rax]",
			"ltr rsp",
			"ltr [rax]",
			"verr bp",
			"verr [rax]",
			"verr ebp",
			"verr [rax]",
			"verr rbp",
			"verr [rax]",
			"verw si",
			"verw [rax]",
			"verw esi",
			"verw [rax]",
			"verw rsi",
			"verw [rax]",
			"sgdt [rax]",
			"sidt [rax]",
			"lgdt [rax]",
			"lidt [rax]",
			"smsw bp",
			"smsw [rax]",
			"smsw ebp",
			"smsw [rax]",
			"smsw rbp",
			"smsw [rax]",
			"lmsw si",
			"lmsw [rax]",
			"lmsw esi",
			"lmsw [rax]",
			"lmsw rsi",
			"lmsw [rax]",
			"invlpg [rax]",
			"enclv",
			"vmcall",
			"vmlaunch",
			"vmresume",
			"vmxoff",
			"monitor",
			"mwait",
			"clac",
			"stac",
			"encls",
			"xgetbv",
			"xsetbv",
			"vmfunc",
			"xend",
			"xtest",
			"enclu",
			"rdpkru",
			"wrpkru",
			"swapgs",
			"rdtscp",
			"lar cx, si",
			"lar bx, [rax]",
			"lar ecx, esi",
			"lar ebx, [rax]",
			"lar rcx, rsi",
			"lar rbx, [rax]",
			"lsl cx, si",
			"lsl bx, [rax]",
			"lsl ecx, esi",
			"lsl ebx, [rax]",
			"lsl rcx, rsi",
			"lsl rbx, [rax]",
			"syscall",
			"clts",
			"sysret",
			"sysretq",
			"invd",
			"wbinvd",
			"ud2",
			"prefetchw [rax]",
			"prefetchwt1 [rax]",
			"movups xmm1, xmm5",
			"movups xmm1, [rax]",
			"vmovups xmm1, xmm5",
			"vmovups xmm2, [rax]",
			"vmovups ymm1, ymm5",
			"vmovups ymm2, [rax]",
			"vmovups xmm2, xmm3",
			"vmovups xmm2, [rax+0x10]",
			"vmovups ymm2, ymm3",
			"vmovups ymm2, [rax+0x20]",
			"vmovups zmm2, zmm3",
			"vmovups zmm2, [rax+0x40]",
			"movupd xmm1, xmm5",
			"movupd xmm1, [rax]",
			"vmovupd xmm1, xmm5",
			"vmovupd xmm2, [rax]",
			"vmovupd ymm1, ymm5",
			"vmovupd ymm2, [rax]",
			"vmovupd xmm2, xmm3",
			"vmovupd xmm2, [rax+0x10]",
			"vmovupd ymm2, ymm3",
			"vmovupd ymm2, [rax+0x20]",
			"vmovupd zmm2, zmm3",
			"vmovupd zmm2, [rax+0x40]",
			"movss xmm1, xmm5",
			"movss xmm1, dword ptr [rax]",
			"vmovss xmm1, xmm6, xmm5",
			"vmovss xmm2, dword ptr [rax]",
			"vmovss xmm2, xmm6, xmm3",
			"vmovss xmm2, dword ptr [rax+4]",
			"movsd xmm1, xmm5",
			"movsd xmm1, qword ptr [rax]",
			"vmovsd xmm1, xmm6, xmm5",
			"vmovsd xmm2, qword ptr [rax]",
			"vmovsd xmm2, xmm6, xmm3",
			"vmovsd xmm2, qword ptr [rax+8]",
			"movups xmm5, xmm1",
			"movups [rax], xmm1",
			"vmovups xmm5, xmm1",
			"vmovups [rax], xmm2",
			"vmovups ymm5, ymm1",
			"vmovups [rax], ymm2",
			"vmovups xmm3, xmm2",
			"vmovups [rax+0x10], xmm2",
			"vmovups ymm3, ymm2",
			"vmovups [rax+0x20], ymm2",
			"vmovups zmm3, zmm2",
			"vmovups [rax+0x40], zmm2",
			"movupd xmm5, xmm1",
			"movupd [rax], xmm1",
			"vmovupd xmm5, xmm1",
			"vmovupd [rax], xmm2",
			"vmovupd ymm5, ymm1",
			"vmovupd [rax], ymm2",
			"vmovupd xmm3, xmm2",
			"vmovupd [rax+0x10], xmm2",
			"vmovupd ymm3, ymm2",
			"vmovupd [rax+0x20], ymm2",
			"vmovupd zmm3, zmm2",
			"vmovupd [rax+0x40], zmm2",
			"movss xmm5, xmm1",
			"movss dword ptr [rax], xmm1",
			"vmovss xmm5, xmm6, xmm1",
			"vmovss dword ptr [rax], xmm2",
			"vmovss xmm3, xmm6, xmm2",
			"vmovss dword ptr [rax+4], xmm2",
			"movsd xmm5, xmm1",
			"movsd qword ptr [rax], xmm1",
			"vmovsd xmm5, xmm6, xmm1",
			"vmovsd qword ptr [rax], xmm2",
			"vmovsd xmm3, xmm6, xmm2",
			"vmovsd qword ptr [rax+8], xmm2",
			"movhlps xmm1, xmm5",
			"movlps xmm1, qword ptr [rax]",
			"vmovhlps xmm2, xmm6, xmm3",
			"vmovlps xmm2, xmm6, qword ptr [rax]",
			"vmovhlps xmm2, xmm6, xmm3",
			"vmovlps xmm2, xmm6, qword ptr [rax+8]",
			"movlpd xmm1, qword ptr [rax]",
			"vmovlpd xmm2, xmm6, qword ptr [rax]",
			"vmovlpd xmm2, xmm6, qword ptr [rax+8]",
			"movsldup xmm1, xmm5",
			"movsldup xmm1, [rax]",
			"vmovsldup xmm1, xmm5",
			"vmovsldup xmm2, xmmword ptr [rax]",
			"vmovsldup ymm1, ymm5",
			"vmovsldup ymm2, ymmword ptr [rax]",
			"vmovsldup xmm2, xmm3",
			"vmovsldup xmm2, xmmword ptr [rax+0x10]",
			"vmovsldup ymm2, ymm3",
			"vmovsldup ymm2, ymmword ptr [rax+0x20]",
			"vmovsldup zmm2, zmm3",
			"vmovsldup zmm2, zmmword ptr [rax+0x40]",
			"movddup xmm1, xmm5",
			"movddup xmm1, qword ptr [rax]",
			"vmovddup xmm1, xmm5",
			"vmovddup xmm2, qword ptr [rax]",
			"vmovddup ymm1, ymm5",
			"vmovddup ymm2, ymmword ptr [rax]",
			"vmovddup xmm2, xmm3",
			"vmovddup xmm2, qword ptr [rax+8]",
			"vmovddup ymm2, ymm3",
			"vmovddup ymm2, ymmword ptr [rax+0x20]",
			"vmovddup zmm2, zmm3",
			"vmovddup zmm2, zmmword ptr [rax+0x40]",
			"movlps qword ptr [rax], xmm1",
			"vmovlps qword ptr [rax], xmm2",
			"vmovlps qword ptr [rax+8], xmm2",
			"movlpd qword ptr [rax], xmm1",
			"vmovlpd qword ptr [rax], xmm2",
			"vmovlpd qword ptr [rax+8], xmm2",
			"unpcklps xmm1, xmm5",
			"unpcklps xmm1, [rax]",
			"vunpcklps xmm2, xmm6, xmm3",
			"vunpcklps xmm2, xmm6, [rax]",
			"vunpcklps ymm2, ymm6, ymm3",
			"vunpcklps ymm2, ymm6, [rax]",
			"vunpcklps xmm2{k3}, xmm6, xmm3",
			"vunpcklps xmm2{k3}, xmm6, [rax+0x10]",
			"vunpcklps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vunpcklps ymm2{k3}, ymm6, ymm3",
			"vunpcklps ymm2{k3}, ymm6, [rax+0x20]",
			"vunpcklps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vunpcklps zmm2{k3}, zmm6, zmm3",
			"vunpcklps zmm2{k3}, zmm6, [rax+0x40]",
			"vunpcklps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"unpcklpd xmm1, xmm5",
			"unpcklpd xmm1, [rax]",
			"vunpcklpd xmm2, xmm6, xmm3",
			"vunpcklpd xmm2, xmm6, [rax]",
			"vunpcklpd ymm2, ymm6, ymm3",
			"vunpcklpd ymm2, ymm6, [rax]",
			"vunpcklpd xmm2{k3}{z}, xmm6, xmm3",
			"vunpcklpd xmm2{k3}, xmm6, [rax+0x10]",
			"vunpcklpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vunpcklpd ymm2{k3}{z}, ymm6, ymm3",
			"vunpcklpd ymm2{k3}, ymm6, [rax+0x20]",
			"vunpcklpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vunpcklpd zmm2{k3}{z}, zmm6, zmm3",
			"vunpcklpd zmm2{k3}, zmm6, [rax+0x40]",
			"vunpcklpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"unpckhps xmm1, xmm5",
			"unpckhps xmm1, [rax]",
			"vunpckhps xmm2, xmm6, xmm3",
			"vunpckhps xmm2, xmm6, [rax]",
			"vunpckhps ymm2, ymm6, ymm3",
			"vunpckhps ymm2, ymm6, [rax]",
			"vunpckhps xmm2{k3}, xmm6, xmm3",
			"vunpckhps xmm2{k3}, xmm6, [rax+0x10]",
			"vunpckhps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vunpckhps ymm2{k3}, ymm6, ymm3",
			"vunpckhps ymm2{k3}, ymm6, [rax+0x20]",
			"vunpckhps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vunpckhps zmm2{k3}, zmm6, zmm3",
			"vunpckhps zmm2{k3}, zmm6, [rax+0x40]",
			"vunpckhps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"unpckhpd xmm1, xmm5",
			"unpckhpd xmm1, [rax]",
			"vunpckhpd xmm2, xmm6, xmm3",
			"vunpckhpd xmm2, xmm6, [rax]",
			"vunpckhpd ymm2, ymm6, ymm3",
			"vunpckhpd ymm2, ymm6, [rax]",
			"vunpckhpd xmm2{k3}{z}, xmm6, xmm3",
			"vunpckhpd xmm2{k3}, xmm6, [rax+0x10]",
			"vunpckhpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vunpckhpd ymm2{k3}{z}, ymm6, ymm3",
			"vunpckhpd ymm2{k3}, ymm6, [rax+0x20]",
			"vunpckhpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vunpckhpd zmm2{k3}{z}, zmm6, zmm3",
			"vunpckhpd zmm2{k3}, zmm6, [rax+0x40]",
			"vunpckhpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"movlhps xmm1, xmm5",
			"vmovlhps xmm2, xmm6, xmm3",
			"vmovlhps xmm2, xmm6, xmm3",
			"movhps xmm1, qword ptr [rax]",
			"vmovhps xmm2, xmm6, qword ptr [rax]",
			"vmovhps xmm2, xmm6, qword ptr [rax+8]",
			"movhpd xmm1, qword ptr [rax]",
			"vmovhpd xmm2, xmm6, qword ptr [rax]",
			"vmovhpd xmm2, xmm6, qword ptr [rax+8]",
			"movshdup xmm1, xmm5",
			"movshdup xmm1, [rax]",
			"vmovshdup xmm1, xmm5",
			"vmovshdup xmm2, xmmword ptr [rax]",
			"vmovshdup ymm1, ymm5",
			"vmovshdup ymm2, ymmword ptr [rax]",
			"vmovshdup xmm2, xmm3",
			"vmovshdup xmm2, xmmword ptr [rax+0x10]",
			"vmovshdup ymm2, ymm3",
			"vmovshdup ymm2, ymmword ptr [rax+0x20]",
			"vmovshdup zmm2, zmm3",
			"vmovshdup zmm2, zmmword ptr [rax+0x40]",
			"movhps qword ptr [rax], xmm1",
			"vmovhps qword ptr [rax], xmm2",
			"vmovhps qword ptr [rax+8], xmm2",
			"movhpd qword ptr [rax], xmm1",
			"vmovhpd qword ptr [rax], xmm2",
			"vmovhpd qword ptr [rax+8], xmm2",
			"prefetchnta [rax]",
			"prefetcht0 [rax]",
			"prefetcht1 [rax]",
			"prefetcht2 [rax]",
			"bndldx bnd1, qword ptr [rax]",
			"bndmov bnd1, bnd2",
			"bndmov bnd1, xmmword ptr [rax]",
			"bndcl bnd1, rdx",
			"bndcl bnd1, [rax]",
			"bndcu bnd1, rdx",
			"bndcu bnd1, [rax]",
			"bndstx qword ptr [rax], bnd1",
			"bndmov bnd2, bnd1",
			"bndmov xmmword ptr [rax], bnd1",
			"bndmk bnd1, qword ptr [rax]",
			"bndcn bnd1, rdx",
			"bndcn bnd1, [rax]",
			"nop cx, ax",
			"nop [rax], ax",
			"nop ecx, eax",
			"nop [rax], eax",
			"nop rcx, rax",
			"nop [rax], rax",
			"mov rsi, cr3",
			"mov rsi, dr3",
			"mov cr3, rsi",
			"mov dr3, rsi",
			"movaps xmm1, xmm5",
			"movaps xmm1, [rax]",
			"vmovaps xmm1, xmm5",
			"vmovaps xmm2, [rax]",
			"vmovaps ymm1, ymm5",
			"vmovaps ymm2, [rax]",
			"vmovaps xmm2, xmm3",
			"vmovaps xmm2, [rax+0x10]",
			"vmovaps ymm2, ymm3",
			"vmovaps ymm2, [rax+0x20]",
			"vmovaps zmm2, zmm3",
			"vmovaps zmm2, [rax+0x40]",
			"movapd xmm1, xmm5",
			"movapd xmm1, [rax]",
			"vmovapd xmm1, xmm5",
			"vmovapd xmm2, [rax]",
			"vmovapd ymm1, ymm5",
			"vmovapd ymm2, [rax]",
			"vmovapd xmm2, xmm3",
			"vmovapd xmm2, [rax+0x10]",
			"vmovapd ymm2, ymm3",
			"vmovapd ymm2, [rax+0x20]",
			"vmovapd zmm2, zmm3",
			"vmovapd zmm2, [rax+0x40]",
			"movaps xmm5, xmm1",
			"movaps [rax], xmm1",
			"vmovaps xmm5, xmm1",
			"vmovaps [rax], xmm2",
			"vmovaps ymm5, ymm1",
			"vmovaps [rax], ymm2",
			"vmovaps xmm3, xmm2",
			"vmovaps [rax+0x10], xmm2",
			"vmovaps ymm3, ymm2",
			"vmovaps [rax+0x20], ymm2",
			"vmovaps zmm3, zmm2",
			"vmovaps [rax+0x40], zmm2",
			"movapd xmm5, xmm1",
			"movapd [rax], xmm1",
			"vmovapd xmm5, xmm1",
			"vmovapd [rax], xmm2",
			"vmovapd ymm5, ymm1",
			"vmovapd [rax], ymm2",
			"vmovapd xmm3, xmm2",
			"vmovapd [rax+0x10], xmm2",
			"vmovapd ymm3, ymm2",
			"vmovapd [rax+0x20], ymm2",
			"vmovapd zmm3, zmm2",
			"vmovapd [rax+0x40], zmm2",
			"cvtpi2ps xmm1, mmx5",
			"cvtpi2ps xmm1, qword ptr [rax]",
			"cvtpi2pd xmm1, mmx5",
			"cvtpi2pd xmm1, qword ptr [rax]",
			"cvtsi2ss xmm1, ebp",
			"cvtsi2ss xmm1, dword ptr [rax]",
			"cvtsi2ss xmm1, rbp",
			"cvtsi2ss xmm1, qword ptr [rax]",
			"vcvtsi2ss xmm2, xmm6, ebx",
			"vcvtsi2ss xmm2, xmm6, dword ptr [rax]",
			"vcvtsi2ss xmm2, xmm6, rbx",
			"vcvtsi2ss xmm2, xmm6, qword ptr [rax]",
			"vcvtsi2ss xmm2, xmm6, ebx",
			"vcvtsi2ss xmm2, xmm6, dword ptr [rax+4]",
			"vcvtsi2ss xmm2, xmm6, rbx",
			"vcvtsi2ss xmm2, xmm6, qword ptr [rax+8]",
			"cvtsi2sd xmm1, ebp",
			"cvtsi2sd xmm1, dword ptr [rax]",
			"cvtsi2sd xmm1, rbp",
			"cvtsi2sd xmm1, qword ptr [rax]",
			"vcvtsi2sd xmm2, xmm6, ebx",
			"vcvtsi2sd xmm2, xmm6, dword ptr [rax]",
			"vcvtsi2sd xmm2, xmm6, rbx",
			"vcvtsi2sd xmm2, xmm6, qword ptr [rax]",
			"vcvtsi2sd xmm2, xmm6, ebx",
			"vcvtsi2sd xmm2, xmm6, dword ptr [rax+4]",
			"vcvtsi2sd xmm2, xmm6, rbx",
			"vcvtsi2sd xmm2, xmm6, qword ptr [rax+8]",
			"movntps [rax], xmm1",
			"vmovntps xmmword ptr [rax], xmm2",
			"vmovntps ymmword ptr [rax], ymm2",
			"vmovntps xmmword ptr [rax+0x10], xmm2",
			"vmovntps ymmword ptr [rax+0x20], ymm2",
			"vmovntps zmmword ptr [rax+0x40], zmm2",
			"movntpd [rax], xmm1",
			"vmovntpd xmmword ptr [rax], xmm2",
			"vmovntpd ymmword ptr [rax], ymm2",
			"vmovntpd xmmword ptr [rax+0x10], xmm2",
			"vmovntpd ymmword ptr [rax+0x20], ymm2",
			"vmovntpd zmmword ptr [rax+0x40], zmm2",
			"cvttps2pi mmx1, xmm5",
			"cvttps2pi mmx1, qword ptr [rax]",
			"cvttpd2pi mmx1, xmm5",
			"cvttpd2pi mmx1, [rax]",
			"cvttss2si ecx, xmm5",
			"cvttss2si ecx, dword ptr [rax]",
			"cvttss2si rcx, xmm5",
			"cvttss2si rcx, dword ptr [rax]",
			"vcvttss2si ecx, xmm5",
			"vcvttss2si edx, dword ptr [rax]",
			"vcvttss2si rcx, xmm5",
			"vcvttss2si rdx, dword ptr [rax]",
			"vcvttss2si edx, xmm3",
			"vcvttss2si edx, dword ptr [rax+4]",
			"vcvttss2si rdx, xmm3",
			"vcvttss2si rdx, dword ptr [rax+4]",
			"cvttsd2si ecx, xmm5",
			"cvttsd2si ecx, qword ptr [rax]",
			"cvttsd2si rcx, xmm5",
			"cvttsd2si rcx, qword ptr [rax]",
			"vcvttsd2si ecx, xmm5",
			"vcvttsd2si edx, qword ptr [rax]",
			"vcvttsd2si rcx, xmm5",
			"vcvttsd2si rdx, qword ptr [rax]",
			"vcvttsd2si edx, xmm3",
			"vcvttsd2si edx, qword ptr [rax+8]",
			"vcvttsd2si rdx, xmm3",
			"vcvttsd2si rdx, qword ptr [rax+8]",
			"cvtps2pi mmx1, xmm5",
			"cvtps2pi mmx1, qword ptr [rax]",
			"cvtpd2pi mmx1, xmm5",
			"cvtpd2pi mmx1, [rax]",
			"cvtss2si ecx, xmm5",
			"cvtss2si ecx, dword ptr [rax]",
			"cvtss2si rcx, xmm5",
			"cvtss2si rcx, dword ptr [rax]",
			"vcvtss2si ecx, xmm5",
			"vcvtss2si edx, dword ptr [rax]",
			"vcvtss2si rcx, xmm5",
			"vcvtss2si rdx, dword ptr [rax]",
			"vcvtss2si edx, xmm3",
			"vcvtss2si edx, dword ptr [rax+4]",
			"vcvtss2si rdx, xmm3",
			"vcvtss2si rdx, dword ptr [rax+4]",
			"cvtsd2si ecx, xmm5",
			"cvtsd2si ecx, qword ptr [rax]",
			"cvtsd2si rcx, xmm5",
			"cvtsd2si rcx, qword ptr [rax]",
			"vcvtsd2si ecx, xmm5",
			"vcvtsd2si edx, qword ptr [rax]",
			"vcvtsd2si rcx, xmm5",
			"vcvtsd2si rdx, qword ptr [rax]",
			"vcvtsd2si edx, xmm3",
			"vcvtsd2si edx, qword ptr [rax+8]",
			"vcvtsd2si rdx, xmm3",
			"vcvtsd2si rdx, qword ptr [rax+8]",
			"ucomiss xmm1, xmm5",
			"ucomiss xmm1, dword ptr [rax]",
			"vucomiss xmm2, xmm3",
			"vucomiss xmm2, dword ptr [rax]",
			"vucomiss xmm2, xmm3",
			"vucomiss xmm2, dword ptr [rax+4]",
			"ucomisd xmm1, xmm5",
			"ucomisd xmm1, qword ptr [rax]",
			"vucomisd xmm2, xmm3",
			"vucomisd xmm2, qword ptr [rax]",
			"vucomisd xmm2, xmm3",
			"vucomisd xmm2, qword ptr [rax+8]",
			"comiss xmm1, xmm5",
			"comiss xmm1, dword ptr [rax]",
			"comisd xmm1, xmm5",
			"comisd xmm1, qword ptr [rax]",
			"vcomiss xmm2, xmm3",
			"vcomiss xmm2, dword ptr [rax]",
			"vcomisd xmm2, xmm3",
			"vcomisd xmm2, qword ptr [rax]",
			"vcomiss xmm2, xmm3",
			"vcomiss xmm2, dword ptr [rax+4]",
			"vcomisd xmm2, xmm3",
			"vcomisd xmm2, qword ptr [rax+8]",
			"wrmsr",
			"rdtsc",
			"rdmsr",
			"rdpmc",
			"sysenter",
			"sysexit",
			"sysexitq",
			"getsec",
			"cmovo cx, si",
			"cmovo bx, [rax]",
			"cmovo ecx, esi",
			"cmovo ebx, [rax]",
			"cmovo rcx, rsi",
			"cmovo rbx, [rax]",
			"cmovno cx, si",
			"cmovno bx, [rax]",
			"cmovno ecx, esi",
			"cmovno ebx, [rax]",
			"cmovno rcx, rsi",
			"cmovno rbx, [rax]",
			"cmovb cx, si",
			"cmovb bx, [rax]",
			"cmovb ecx, esi",
			"cmovb ebx, [rax]",
			"cmovb rcx, rsi",
			"cmovb rbx, [rax]",
			"cmovae cx, si",
			"cmovae bx, [rax]",
			"cmovae ecx, esi",
			"cmovae ebx, [rax]",
			"cmovae rcx, rsi",
			"cmovae rbx, [rax]",
			"cmove cx, si",
			"cmove bx, [rax]",
			"cmove ecx, esi",
			"cmove ebx, [rax]",
			"cmove rcx, rsi",
			"cmove rbx, [rax]",
			"cmovne cx, si",
			"cmovne bx, [rax]",
			"cmovne ecx, esi",
			"cmovne ebx, [rax]",
			"cmovne rcx, rsi",
			"cmovne rbx, [rax]",
			"cmovbe cx, si",
			"cmovbe bx, [rax]",
			"cmovbe ecx, esi",
			"cmovbe ebx, [rax]",
			"cmovbe rcx, rsi",
			"cmovbe rbx, [rax]",
			"cmova cx, si",
			"cmova bx, [rax]",
			"cmova ecx, esi",
			"cmova ebx, [rax]",
			"cmova rcx, rsi",
			"cmova rbx, [rax]",
			"cmovs cx, si",
			"cmovs bx, [rax]",
			"cmovs ecx, esi",
			"cmovs ebx, [rax]",
			"cmovs rcx, rsi",
			"cmovs rbx, [rax]",
			"cmovns cx, si",
			"cmovns bx, [rax]",
			"cmovns ecx, esi",
			"cmovns ebx, [rax]",
			"cmovns rcx, rsi",
			"cmovns rbx, [rax]",
			"cmovp cx, si",
			"cmovp bx, [rax]",
			"cmovp ecx, esi",
			"cmovp ebx, [rax]",
			"cmovp rcx, rsi",
			"cmovp rbx, [rax]",
			"cmovnp cx, si",
			"cmovnp bx, [rax]",
			"cmovnp ecx, esi",
			"cmovnp ebx, [rax]",
			"cmovnp rcx, rsi",
			"cmovnp rbx, [rax]",
			"cmovl cx, si",
			"cmovl bx, [rax]",
			"cmovl ecx, esi",
			"cmovl ebx, [rax]",
			"cmovl rcx, rsi",
			"cmovl rbx, [rax]",
			"cmovge cx, si",
			"cmovge bx, [rax]",
			"cmovge ecx, esi",
			"cmovge ebx, [rax]",
			"cmovge rcx, rsi",
			"cmovge rbx, [rax]",
			"cmovle cx, si",
			"cmovle bx, [rax]",
			"cmovle ecx, esi",
			"cmovle ebx, [rax]",
			"cmovle rcx, rsi",
			"cmovle rbx, [rax]",
			"cmovg cx, si",
			"cmovg bx, [rax]",
			"cmovg ecx, esi",
			"cmovg ebx, [rax]",
			"cmovg rcx, rsi",
			"cmovg rbx, [rax]",
			"kandw k2, k6, k3",
			"kandq k2, k6, k3",
			"kandb k2, k6, k3",
			"kandd k2, k6, k3",
			"kandnw k2, k6, k3",
			"kandnq k2, k6, k3",
			"kandnb k2, k6, k3",
			"kandnd k2, k6, k3",
			"knotw k2, k3",
			"knotq k2, k3",
			"knotb k2, k3",
			"knotd k2, k3",
			"korw k2, k6, k3",
			"korq k2, k6, k3",
			"korb k2, k6, k3",
			"kord k2, k6, k3",
			"kxnorw k2, k6, k3",
			"kxnorq k2, k6, k3",
			"kxnorb k2, k6, k3",
			"kxnord k2, k6, k3",
			"kxorw k2, k6, k3",
			"kxorq k2, k6, k3",
			"kxorb k2, k6, k3",
			"kxord k2, k6, k3",
			"kaddw k2, k6, k3",
			"kaddq k2, k6, k3",
			"kaddb k2, k6, k3",
			"kaddd k2, k6, k3",
			"kunpckwd k2, k6, k3",
			"kunpckdq k2, k6, k3",
			"kunpckbw k2, k6, k3",
			"movmskps ecx, xmm5",
			"movmskps rcx, xmm5",
			"vmovmskps edx, xmm3",
			"vmovmskps rdx, xmm3",
			"vmovmskps edx, ymm3",
			"vmovmskps rdx, ymm3",
			"movmskpd ecx, xmm5",
			"movmskpd rcx, xmm5",
			"vmovmskpd edx, xmm3",
			"vmovmskpd rdx, xmm3",
			"vmovmskpd edx, ymm3",
			"vmovmskpd rdx, ymm3",
			"sqrtps xmm1, xmm5",
			"sqrtps xmm1, [rax]",
			"vsqrtps xmm2, xmm3",
			"vsqrtps xmm2, [rax]",
			"vsqrtps ymm2, ymm3",
			"vsqrtps ymm2, [rax]",
			"vsqrtps xmm2{k3}, xmm3",
			"vsqrtps xmm2{k3}, [rax+0x10]",
			"vsqrtps xmm2{k5}{z}, dword ptr [rax+4]{1to4}",
			"vsqrtps ymm2{k3}, ymm3",
			"vsqrtps ymm2{k3}, [rax+0x20]",
			"vsqrtps ymm2{k5}{z}, dword ptr [rax+4]{1to8}",
			"vsqrtps zmm2{k3}{z}{ru-sae}, zmm3",
			"vsqrtps zmm2{k3}, [rax+0x40]",
			"vsqrtps zmm2{k5}{z}, dword ptr [rax+4]{1to16}",
			"sqrtpd xmm1, xmm5",
			"sqrtpd xmm1, [rax]",
			"vsqrtpd xmm2, xmm3",
			"vsqrtpd xmm2, [rax]",
			"vsqrtpd ymm2, ymm3",
			"vsqrtpd ymm2, [rax]",
			"vsqrtpd xmm2{k3}{z}, xmm3",
			"vsqrtpd xmm2{k3}, [rax+0x10]",
			"vsqrtpd xmm2{k5}{z}, qword ptr [rax+8]{1to2}",
			"vsqrtpd ymm2{k3}{z}, ymm3",
			"vsqrtpd ymm2{k3}, [rax+0x20]",
			"vsqrtpd ymm2{k5}{z}, qword ptr [rax+8]{1to4}",
			"vsqrtpd zmm2{k3}{z}{ru-sae}, zmm3",
			"vsqrtpd zmm2{k3}, [rax+0x40]",
			"vsqrtpd zmm2{k5}{z}, qword ptr [rax+8]{1to8}",
			"sqrtss xmm1, xmm5",
			"sqrtss xmm1, dword ptr [rax]",
			"vsqrtss xmm2, xmm6, xmm3",
			"vsqrtss xmm2, xmm6, dword ptr [rax]",
			"vsqrtss xmm2{k3}, xmm6, xmm3",
			"vsqrtss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"sqrtsd xmm1, xmm5",
			"sqrtsd xmm1, qword ptr [rax]",
			"vsqrtsd xmm2, xmm6, xmm3",
			"vsqrtsd xmm2, xmm6, qword ptr [rax]",
			"vsqrtsd xmm2{k3}{z}, xmm6, xmm3",
			"vsqrtsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"rsqrtps xmm1, xmm5",
			"rsqrtps xmm1, [rax]",
			"vrsqrtps xmm2, xmm3",
			"vrsqrtps xmm2, [rax]",
			"vrsqrtps ymm2, ymm3",
			"vrsqrtps ymm2, [rax]",
			"rsqrtss xmm1, xmm5",
			"rsqrtss xmm1, dword ptr [rax]",
			"vrsqrtss xmm2, xmm6, xmm3",
			"vrsqrtss xmm2, xmm6, dword ptr [rax]",
			"rcpps xmm1, xmm5",
			"rcpps xmm1, [rax]",
			"vrcpps xmm2, xmm3",
			"vrcpps xmm2, [rax]",
			"vrcpps ymm2, ymm3",
			"vrcpps ymm2, [rax]",
			"rcpss xmm1, xmm5",
			"rcpss xmm1, dword ptr [rax]",
			"vrcpss xmm2, xmm6, xmm3",
			"vrcpss xmm2, xmm6, [rax]",
			"andps xmm1, xmm5",
			"andps xmm1, [rax]",
			"vandps xmm2, xmm6, xmm3",
			"vandps xmm2, xmm6, [rax]",
			"vandps ymm2, ymm6, ymm3",
			"vandps ymm2, ymm6, [rax]",
			"vandps xmm2{k3}, xmm6, xmm3",
			"vandps xmm2{k3}, xmm6, [rax+0x10]",
			"vandps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vandps ymm2{k3}, ymm6, ymm3",
			"vandps ymm2{k3}, ymm6, [rax+0x20]",
			"vandps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vandps zmm2{k3}, zmm6, zmm3",
			"vandps zmm2{k3}, zmm6, [rax+0x40]",
			"vandps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"andpd xmm1, xmm5",
			"andpd xmm1, [rax]",
			"vandpd xmm2, xmm6, xmm3",
			"vandpd xmm2, xmm6, [rax]",
			"vandpd ymm2, ymm6, ymm3",
			"vandpd ymm2, ymm6, [rax]",
			"vandpd xmm2{k3}{z}, xmm6, xmm3",
			"vandpd xmm2{k3}, xmm6, [rax+0x10]",
			"vandpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vandpd ymm2{k3}{z}, ymm6, ymm3",
			"vandpd ymm2{k3}, ymm6, [rax+0x20]",
			"vandpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vandpd zmm2{k3}{z}, zmm6, zmm3",
			"vandpd zmm2{k3}, zmm6, [rax+0x40]",
			"vandpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"andnps xmm1, xmm5",
			"andnps xmm1, [rax]",
			"vandnps xmm2, xmm6, xmm3",
			"vandnps xmm2, xmm6, [rax]",
			"vandnps ymm2, ymm6, ymm3",
			"vandnps ymm2, ymm6, [rax]",
			"vandnps xmm2{k3}, xmm6, xmm3",
			"vandnps xmm2{k3}, xmm6, [rax+0x10]",
			"vandnps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vandnps ymm2{k3}, ymm6, ymm3",
			"vandnps ymm2{k3}, ymm6, [rax+0x20]",
			"vandnps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vandnps zmm2{k3}, zmm6, zmm3",
			"vandnps zmm2{k3}, zmm6, [rax+0x40]",
			"vandnps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"andnpd xmm1, xmm5",
			"andnpd xmm1, [rax]",
			"vandnpd xmm2, xmm6, xmm3",
			"vandnpd xmm2, xmm6, [rax]",
			"vandnpd ymm2, ymm6, ymm3",
			"vandnpd ymm2, ymm6, [rax]",
			"vandnpd xmm2{k3}{z}, xmm6, xmm3",
			"vandnpd xmm2{k3}, xmm6, [rax+0x10]",
			"vandnpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vandnpd ymm2{k3}{z}, ymm6, ymm3",
			"vandnpd ymm2{k3}, ymm6, [rax+0x20]",
			"vandnpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vandnpd zmm2{k3}{z}, zmm6, zmm3",
			"vandnpd zmm2{k3}, zmm6, [rax+0x40]",
			"vandnpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"orps xmm1, xmm5",
			"orps xmm1, [rax]",
			"vorps xmm2, xmm6, xmm3",
			"vorps xmm2, xmm6, [rax]",
			"vorps ymm2, ymm6, ymm3",
			"vorps ymm2, ymm6, [rax]",
			"vorps xmm2{k3}, xmm6, xmm3",
			"vorps xmm2{k3}, xmm6, [rax+0x10]",
			"vorps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vorps ymm2{k3}, ymm6, ymm3",
			"vorps ymm2{k3}, ymm6, [rax+0x20]",
			"vorps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vorps zmm2{k3}, zmm6, zmm3",
			"vorps zmm2{k3}, zmm6, [rax+0x40]",
			"vorps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"orpd xmm1, xmm5",
			"orpd xmm1, [rax]",
			"vorpd xmm2, xmm6, xmm3",
			"vorpd xmm2, xmm6, [rax]",
			"vorpd ymm2, ymm6, ymm3",
			"vorpd ymm2, ymm6, [rax]",
			"vorpd xmm2{k3}{z}, xmm6, xmm3",
			"vorpd xmm2{k3}, xmm6, [rax+0x10]",
			"vorpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vorpd ymm2{k3}{z}, ymm6, ymm3",
			"vorpd ymm2{k3}, ymm6, [rax+0x20]",
			"vorpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vorpd zmm2{k3}{z}, zmm6, zmm3",
			"vorpd zmm2{k3}, zmm6, [rax+0x40]",
			"vorpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"xorps xmm1, xmm5",
			"xorps xmm1, [rax]",
			"vxorps xmm2, xmm6, xmm3",
			"vxorps xmm2, xmm6, [rax]",
			"vxorps ymm2, ymm6, ymm3",
			"vxorps ymm2, ymm6, [rax]",
			"vxorps xmm2{k3}, xmm6, xmm3",
			"vxorps xmm2{k3}, xmm6, [rax+0x10]",
			"vxorps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vxorps ymm2{k3}, ymm6, ymm3",
			"vxorps ymm2{k3}, ymm6, [rax+0x20]",
			"vxorps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vxorps zmm2{k3}, zmm6, zmm3",
			"vxorps zmm2{k3}, zmm6, [rax+0x40]",
			"vxorps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"xorpd xmm1, xmm5",
			"xorpd xmm1, [rax]",
			"vxorpd xmm2, xmm6, xmm3",
			"vxorpd xmm2, xmm6, [rax]",
			"vxorpd ymm2, ymm6, ymm3",
			"vxorpd ymm2, ymm6, [rax]",
			"vxorpd xmm2{k3}{z}, xmm6, xmm3",
			"vxorpd xmm2{k3}, xmm6, [rax+0x10]",
			"vxorpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vxorpd ymm2{k3}{z}, ymm6, ymm3",
			"vxorpd ymm2{k3}, ymm6, [rax+0x20]",
			"vxorpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vxorpd zmm2{k3}{z}, zmm6, zmm3",
			"vxorpd zmm2{k3}, zmm6, [rax+0x40]",
			"vxorpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"addps xmm1, xmm5",
			"addps xmm1, [rax]",
			"vaddps xmm2, xmm6, xmm3",
			"vaddps xmm2, xmm6, [rax]",
			"vaddps ymm2, ymm6, ymm3",
			"vaddps ymm2, ymm6, [rax]",
			"vaddps xmm2{k3}, xmm6, xmm3",
			"vaddps xmm2{k3}, xmm6, [rax+0x10]",
			"vaddps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vaddps ymm2{k3}, ymm6, ymm3",
			"vaddps ymm2{k3}, ymm6, [rax+0x20]",
			"vaddps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vaddps zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vaddps zmm2{k3}, zmm6, [rax+0x40]",
			"vaddps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"addpd xmm1, xmm5",
			"addpd xmm1, [rax]",
			"vaddpd xmm2, xmm6, xmm3",
			"vaddpd xmm2, xmm6, [rax]",
			"vaddpd ymm2, ymm6, ymm3",
			"vaddpd ymm2, ymm6, [rax]",
			"vaddpd xmm2{k3}{z}, xmm6, xmm3",
			"vaddpd xmm2{k3}, xmm6, [rax+0x10]",
			"vaddpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vaddpd ymm2{k3}{z}, ymm6, ymm3",
			"vaddpd ymm2{k3}, ymm6, [rax+0x20]",
			"vaddpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vaddpd zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vaddpd zmm2{k3}, zmm6, [rax+0x40]",
			"vaddpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"addss xmm1, xmm5",
			"addss xmm1, dword ptr [rax]",
			"vaddss xmm2, xmm6, xmm3",
			"vaddss xmm2, xmm6, dword ptr [rax]",
			"vaddss xmm2{k3}, xmm6, xmm3",
			"vaddss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"addsd xmm1, xmm5",
			"addsd xmm1, qword ptr [rax]",
			"vaddsd xmm2, xmm6, xmm3",
			"vaddsd xmm2, xmm6, qword ptr [rax]",
			"vaddsd xmm2{k3}{z}, xmm6, xmm3",
			"vaddsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"mulps xmm1, xmm5",
			"mulps xmm1, [rax]",
			"vmulps xmm2, xmm6, xmm3",
			"vmulps xmm2, xmm6, [rax]",
			"vmulps ymm2, ymm6, ymm3",
			"vmulps ymm2, ymm6, [rax]",
			"vmulps xmm2{k3}, xmm6, xmm3",
			"vmulps xmm2{k3}, xmm6, [rax+0x10]",
			"vmulps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vmulps ymm2{k3}, ymm6, ymm3",
			"vmulps ymm2{k3}, ymm6, [rax+0x20]",
			"vmulps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vmulps zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vmulps zmm2{k3}, zmm6, [rax+0x40]",
			"vmulps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"mulpd xmm1, xmm5",
			"mulpd xmm1, [rax]",
			"vmulpd xmm2, xmm6, xmm3",
			"vmulpd xmm2, xmm6, [rax]",
			"vmulpd ymm2, ymm6, ymm3",
			"vmulpd ymm2, ymm6, [rax]",
			"vmulpd xmm2{k3}{z}, xmm6, xmm3",
			"vmulpd xmm2{k3}, xmm6, [rax+0x10]",
			"vmulpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vmulpd ymm2{k3}{z}, ymm6, ymm3",
			"vmulpd ymm2{k3}, ymm6, [rax+0x20]",
			"vmulpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vmulpd zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vmulpd zmm2{k3}, zmm6, [rax+0x40]",
			"vmulpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"mulss xmm1, xmm5",
			"mulss xmm1, dword ptr [rax]",
			"vmulss xmm2, xmm6, xmm3",
			"vmulss xmm2, xmm6, dword ptr [rax]",
			"vmulss xmm2{k3}, xmm6, xmm3",
			"vmulss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"mulsd xmm1, xmm5",
			"mulsd xmm1, qword ptr [rax]",
			"vmulsd xmm2, xmm6, xmm3",
			"vmulsd xmm2, xmm6, qword ptr [rax]",
			"vmulsd xmm2{k3}{z}, xmm6, xmm3",
			"vmulsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"cvtps2pd xmm1, xmm5",
			"cvtps2pd xmm1, qword ptr [rax]",
			"vcvtps2pd xmm1, xmm5",
			"vcvtps2pd xmm2, qword ptr [rax]",
			"vcvtps2pd ymm1, xmm5",
			"vcvtps2pd ymm2, xmmword ptr [rax]",
			"vcvtps2pd xmm2{k3}, xmm3",
			"vcvtps2pd xmm2, qword ptr [rax+8]",
			"vcvtps2pd xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvtps2pd ymm2{k3}, xmm3",
			"vcvtps2pd ymm2, xmmword ptr [rax+0x10]",
			"vcvtps2pd ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtps2pd zmm2{k3}, ymm3",
			"vcvtps2pd zmm2, ymmword ptr [rax+0x20]",
			"vcvtps2pd zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"cvtpd2ps xmm1, xmm5",
			"cvtpd2ps xmm1, [rax]",
			"vcvtpd2ps xmm1, xmm5",
			"vcvtpd2ps xmm2, xmmword ptr [rax]",
			"vcvtpd2ps xmm1, ymm5",
			"vcvtpd2ps xmm2, ymmword ptr [rax]",
		};
	}
}
#endif
