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

#if !NO_GAS_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Gas {
	public sealed class GasFormatterTest64_ForceSuffix_002 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_ForceSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_002.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_002.AllInfos_Length] {
			"vcvtpd2psx xmm3,xmm2{k3}",
			"vcvtpd2psx 0x10(rax),xmm2",
			"vcvtpd2psx 8(rax){1to2},xmm2{k3}{z}",
			"vcvtpd2psy ymm3,xmm2{k3}",
			"vcvtpd2psy 0x20(rax),xmm2",
			"vcvtpd2psy 8(rax){1to4},xmm2{k3}{z}",
			"vcvtpd2ps zmm3,ymm2{k3}",
			"vcvtpd2ps 0x40(rax),ymm2",
			"vcvtpd2ps 8(rax){1to8},ymm2{k3}{z}",
			"cvtss2sd xmm5,xmm1",
			"cvtss2sd (rax),xmm1",
			"vcvtss2sd xmm3,xmm6,xmm2",
			"vcvtss2sd (rax),xmm6,xmm2",
			"vcvtss2sd xmm3,xmm6,xmm2",
			"vcvtss2sd 4(rax),xmm6,xmm2",
			"cvtsd2ss xmm5,xmm1",
			"cvtsd2ss (rax),xmm1",
			"vcvtsd2ss xmm3,xmm6,xmm2",
			"vcvtsd2ss (rax),xmm6,xmm2",
			"vcvtsd2ss xmm3,xmm6,xmm2",
			"vcvtsd2ss 8(rax),xmm6,xmm2",
			"cvtdq2ps xmm5,xmm1",
			"cvtdq2ps (rax),xmm1",
			"vcvtdq2ps xmm5,xmm1",
			"vcvtdq2ps (rax),xmm2",
			"vcvtdq2ps ymm5,ymm1",
			"vcvtdq2ps (rax),ymm2",
			"vcvtdq2ps xmm3,xmm2{k3}",
			"vcvtdq2ps 0x10(rax),xmm2",
			"vcvtdq2ps 4(rax){1to4},xmm2{k3}{z}",
			"vcvtdq2ps ymm3,ymm2{k3}",
			"vcvtdq2ps 0x20(rax),ymm2",
			"vcvtdq2ps 4(rax){1to8},ymm2{k3}{z}",
			"vcvtdq2ps zmm3,zmm2{k3}",
			"vcvtdq2ps 0x40(rax),zmm2",
			"vcvtdq2ps 4(rax){1to16},zmm2{k3}{z}",
			"vcvtqq2psx xmm3,xmm2{k3}",
			"vcvtqq2psx 0x10(rax),xmm2",
			"vcvtqq2psx 8(rax){1to2},xmm2{k3}{z}",
			"vcvtqq2psy ymm3,xmm2{k3}",
			"vcvtqq2psy 0x20(rax),xmm2",
			"vcvtqq2psy 8(rax){1to4},xmm2{k3}{z}",
			"vcvtqq2ps zmm3,ymm2{k3}",
			"vcvtqq2ps 0x40(rax),ymm2",
			"vcvtqq2ps 8(rax){1to8},ymm2{k3}{z}",
			"cvtps2dq xmm5,xmm1",
			"cvtps2dq (rax),xmm1",
			"vcvtps2dq xmm5,xmm1",
			"vcvtps2dq (rax),xmm2",
			"vcvtps2dq ymm5,ymm1",
			"vcvtps2dq (rax),ymm2",
			"vcvtps2dq xmm3,xmm2{k3}",
			"vcvtps2dq 0x10(rax),xmm2",
			"vcvtps2dq 4(rax){1to4},xmm2{k3}{z}",
			"vcvtps2dq ymm3,ymm2{k3}",
			"vcvtps2dq 0x20(rax),ymm2",
			"vcvtps2dq 4(rax){1to8},ymm2{k3}{z}",
			"vcvtps2dq zmm3,zmm2{k3}",
			"vcvtps2dq 0x40(rax),zmm2",
			"vcvtps2dq 4(rax){1to16},zmm2{k3}{z}",
			"cvttps2dq xmm5,xmm1",
			"cvttps2dq (rax),xmm1",
			"vcvttps2dq xmm5,xmm1",
			"vcvttps2dq (rax),xmm2",
			"vcvttps2dq ymm5,ymm1",
			"vcvttps2dq (rax),ymm2",
			"vcvttps2dq xmm3,xmm2{k3}",
			"vcvttps2dq 0x10(rax),xmm2",
			"vcvttps2dq 4(rax){1to4},xmm2{k3}{z}",
			"vcvttps2dq ymm3,ymm2{k3}",
			"vcvttps2dq 0x20(rax),ymm2",
			"vcvttps2dq 4(rax){1to8},ymm2{k3}{z}",
			"vcvttps2dq zmm3,zmm2{k3}",
			"vcvttps2dq 0x40(rax),zmm2",
			"vcvttps2dq 4(rax){1to16},zmm2{k3}{z}",
			"subps xmm5,xmm1",
			"subps (rax),xmm1",
			"vsubps xmm3,xmm6,xmm2",
			"vsubps (rax),xmm6,xmm2",
			"vsubps ymm3,ymm6,ymm2",
			"vsubps (rax),ymm6,ymm2",
			"vsubps xmm3,xmm6,xmm2{k3}",
			"vsubps 0x10(rax),xmm6,xmm2{k3}",
			"vsubps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vsubps ymm3,ymm6,ymm2{k3}",
			"vsubps 0x20(rax),ymm6,ymm2{k3}",
			"vsubps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vsubps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vsubps 0x40(rax),zmm6,zmm2{k3}",
			"vsubps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"subpd xmm5,xmm1",
			"subpd (rax),xmm1",
			"vsubpd xmm3,xmm6,xmm2",
			"vsubpd (rax),xmm6,xmm2",
			"vsubpd ymm3,ymm6,ymm2",
			"vsubpd (rax),ymm6,ymm2",
			"vsubpd xmm3,xmm6,xmm2{k3}{z}",
			"vsubpd 0x10(rax),xmm6,xmm2{k3}",
			"vsubpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vsubpd ymm3,ymm6,ymm2{k3}{z}",
			"vsubpd 0x20(rax),ymm6,ymm2{k3}",
			"vsubpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vsubpd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vsubpd 0x40(rax),zmm6,zmm2{k3}",
			"vsubpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"subss xmm5,xmm1",
			"subss (rax),xmm1",
			"vsubss xmm3,xmm6,xmm2",
			"vsubss (rax),xmm6,xmm2",
			"vsubss xmm3,xmm6,xmm2{k3}",
			"vsubss 4(rax),xmm6,xmm2{k3}",
			"subsd xmm5,xmm1",
			"subsd (rax),xmm1",
			"vsubsd xmm3,xmm6,xmm2",
			"vsubsd (rax),xmm6,xmm2",
			"vsubsd xmm3,xmm6,xmm2{k3}{z}",
			"vsubsd 8(rax),xmm6,xmm2{k3}",
			"minps xmm5,xmm1",
			"minps (rax),xmm1",
			"vminps xmm3,xmm6,xmm2",
			"vminps (rax),xmm6,xmm2",
			"vminps ymm3,ymm6,ymm2",
			"vminps (rax),ymm6,ymm2",
			"vminps xmm3,xmm6,xmm2{k3}",
			"vminps 0x10(rax),xmm6,xmm2{k3}",
			"vminps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vminps ymm3,ymm6,ymm2{k3}",
			"vminps 0x20(rax),ymm6,ymm2{k3}",
			"vminps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vminps {sae},zmm3,zmm6,zmm2{k3}{z}",
			"vminps 0x40(rax),zmm6,zmm2{k3}",
			"vminps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"minpd xmm5,xmm1",
			"minpd (rax),xmm1",
			"vminpd xmm3,xmm6,xmm2",
			"vminpd (rax),xmm6,xmm2",
			"vminpd ymm3,ymm6,ymm2",
			"vminpd (rax),ymm6,ymm2",
			"vminpd xmm3,xmm6,xmm2{k3}{z}",
			"vminpd 0x10(rax),xmm6,xmm2{k3}",
			"vminpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vminpd ymm3,ymm6,ymm2{k3}{z}",
			"vminpd 0x20(rax),ymm6,ymm2{k3}",
			"vminpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vminpd {sae},zmm3,zmm6,zmm2{k3}{z}",
			"vminpd 0x40(rax),zmm6,zmm2{k3}",
			"vminpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"minss xmm5,xmm1",
			"minss (rax),xmm1",
			"vminss xmm3,xmm6,xmm2",
			"vminss (rax),xmm6,xmm2",
			"vminss xmm3,xmm6,xmm2{k3}",
			"vminss 4(rax),xmm6,xmm2{k3}",
			"minsd xmm5,xmm1",
			"minsd (rax),xmm1",
			"vminsd xmm3,xmm6,xmm2",
			"vminsd (rax),xmm6,xmm2",
			"vminsd xmm3,xmm6,xmm2{k3}{z}",
			"vminsd 8(rax),xmm6,xmm2{k3}",
			"divps xmm5,xmm1",
			"divps (rax),xmm1",
			"vdivps xmm3,xmm6,xmm2",
			"vdivps (rax),xmm6,xmm2",
			"vdivps ymm3,ymm6,ymm2",
			"vdivps (rax),ymm6,ymm2",
			"vdivps xmm3,xmm6,xmm2{k3}",
			"vdivps 0x10(rax),xmm6,xmm2{k3}",
			"vdivps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vdivps ymm3,ymm6,ymm2{k3}",
			"vdivps 0x20(rax),ymm6,ymm2{k3}",
			"vdivps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vdivps {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vdivps 0x40(rax),zmm6,zmm2{k3}",
			"vdivps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"divpd xmm5,xmm1",
			"divpd (rax),xmm1",
			"vdivpd xmm3,xmm6,xmm2",
			"vdivpd (rax),xmm6,xmm2",
			"vdivpd ymm3,ymm6,ymm2",
			"vdivpd (rax),ymm6,ymm2",
			"vdivpd xmm3,xmm6,xmm2{k3}{z}",
			"vdivpd 0x10(rax),xmm6,xmm2{k3}",
			"vdivpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vdivpd ymm3,ymm6,ymm2{k3}{z}",
			"vdivpd 0x20(rax),ymm6,ymm2{k3}",
			"vdivpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vdivpd {ru-sae},zmm3,zmm6,zmm2{k3}{z}",
			"vdivpd 0x40(rax),zmm6,zmm2{k3}",
			"vdivpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"divss xmm5,xmm1",
			"divss (rax),xmm1",
			"vdivss xmm3,xmm6,xmm2",
			"vdivss (rax),xmm6,xmm2",
			"vdivss xmm3,xmm6,xmm2{k3}",
			"vdivss 4(rax),xmm6,xmm2{k3}",
			"divsd xmm5,xmm1",
			"divsd (rax),xmm1",
			"vdivsd xmm3,xmm6,xmm2",
			"vdivsd (rax),xmm6,xmm2",
			"vdivsd xmm3,xmm6,xmm2{k3}{z}",
			"vdivsd 8(rax),xmm6,xmm2{k3}",
			"maxps xmm5,xmm1",
			"maxps (rax),xmm1",
			"vmaxps xmm3,xmm6,xmm2",
			"vmaxps (rax),xmm6,xmm2",
			"vmaxps ymm3,ymm6,ymm2",
			"vmaxps (rax),ymm6,ymm2",
			"vmaxps xmm3,xmm6,xmm2{k3}",
			"vmaxps 0x10(rax),xmm6,xmm2{k3}",
			"vmaxps 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vmaxps ymm3,ymm6,ymm2{k3}",
			"vmaxps 0x20(rax),ymm6,ymm2{k3}",
			"vmaxps 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vmaxps {sae},zmm3,zmm6,zmm2{k3}{z}",
			"vmaxps 0x40(rax),zmm6,zmm2{k3}",
			"vmaxps 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"maxpd xmm5,xmm1",
			"maxpd (rax),xmm1",
			"vmaxpd xmm3,xmm6,xmm2",
			"vmaxpd (rax),xmm6,xmm2",
			"vmaxpd ymm3,ymm6,ymm2",
			"vmaxpd (rax),ymm6,ymm2",
			"vmaxpd xmm3,xmm6,xmm2{k3}{z}",
			"vmaxpd 0x10(rax),xmm6,xmm2{k3}",
			"vmaxpd 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vmaxpd ymm3,ymm6,ymm2{k3}{z}",
			"vmaxpd 0x20(rax),ymm6,ymm2{k3}",
			"vmaxpd 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vmaxpd {sae},zmm3,zmm6,zmm2{k3}{z}",
			"vmaxpd 0x40(rax),zmm6,zmm2{k3}",
			"vmaxpd 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"maxss xmm5,xmm1",
			"maxss (rax),xmm1",
			"vmaxss xmm3,xmm6,xmm2",
			"vmaxss (rax),xmm6,xmm2",
			"vmaxss xmm3,xmm6,xmm2{k3}",
			"vmaxss 4(rax),xmm6,xmm2{k3}",
			"maxsd xmm5,xmm1",
			"maxsd (rax),xmm1",
			"vmaxsd xmm3,xmm6,xmm2",
			"vmaxsd (rax),xmm6,xmm2",
			"vmaxsd xmm3,xmm6,xmm2{k3}{z}",
			"vmaxsd 8(rax),xmm6,xmm2{k3}",
			"punpcklbw mm5,mm1",
			"punpcklbw (rax),mm1",
			"punpcklbw xmm5,xmm1",
			"punpcklbw (rax),xmm1",
			"vpunpcklbw xmm3,xmm6,xmm2",
			"vpunpcklbw (rax),xmm6,xmm2",
			"vpunpcklbw ymm3,ymm6,ymm2",
			"vpunpcklbw (rax),ymm6,ymm2",
			"vpunpcklbw xmm3,xmm6,xmm2{k3}",
			"vpunpcklbw 0x10(rax),xmm6,xmm2{k3}",
			"vpunpcklbw ymm3,ymm6,ymm2{k3}",
			"vpunpcklbw 0x20(rax),ymm6,ymm2{k3}",
			"vpunpcklbw zmm3,zmm6,zmm2{k3}",
			"vpunpcklbw 0x40(rax),zmm6,zmm2{k3}",
			"punpcklwd mm5,mm1",
			"punpcklwd (rax),mm1",
			"punpcklwd xmm5,xmm1",
			"punpcklwd (rax),xmm1",
			"vpunpcklwd xmm3,xmm6,xmm2",
			"vpunpcklwd (rax),xmm6,xmm2",
			"vpunpcklwd ymm3,ymm6,ymm2",
			"vpunpcklwd (rax),ymm6,ymm2",
			"vpunpcklwd xmm3,xmm6,xmm2{k3}",
			"vpunpcklwd 0x10(rax),xmm6,xmm2{k3}",
			"vpunpcklwd ymm3,ymm6,ymm2{k3}",
			"vpunpcklwd 0x20(rax),ymm6,ymm2{k3}",
			"vpunpcklwd zmm3,zmm6,zmm2{k3}",
			"vpunpcklwd 0x40(rax),zmm6,zmm2{k3}",
			"punpckldq mm5,mm1",
			"punpckldq (rax),mm1",
			"punpckldq xmm5,xmm1",
			"punpckldq (rax),xmm1",
			"vpunpckldq xmm3,xmm6,xmm2",
			"vpunpckldq (rax),xmm6,xmm2",
			"vpunpckldq ymm3,ymm6,ymm2",
			"vpunpckldq (rax),ymm6,ymm2",
			"vpunpckldq xmm3,xmm6,xmm2{k3}{z}",
			"vpunpckldq 0x10(rax),xmm6,xmm2{k3}",
			"vpunpckldq 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpunpckldq ymm3,ymm6,ymm2{k3}{z}",
			"vpunpckldq 0x20(rax),ymm6,ymm2{k3}",
			"vpunpckldq 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpunpckldq zmm3,zmm6,zmm2{k3}{z}",
			"vpunpckldq 0x40(rax),zmm6,zmm2{k3}",
			"vpunpckldq 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"packsswb mm5,mm1",
			"packsswb (rax),mm1",
			"packsswb xmm5,xmm1",
			"packsswb (rax),xmm1",
			"vpacksswb xmm3,xmm6,xmm2",
			"vpacksswb (rax),xmm6,xmm2",
			"vpacksswb ymm3,ymm6,ymm2",
			"vpacksswb (rax),ymm6,ymm2",
			"vpacksswb xmm3,xmm6,xmm2{k3}",
			"vpacksswb 0x10(rax),xmm6,xmm2{k3}",
			"vpacksswb ymm3,ymm6,ymm2{k3}",
			"vpacksswb 0x20(rax),ymm6,ymm2{k3}",
			"vpacksswb zmm3,zmm6,zmm2{k3}",
			"vpacksswb 0x40(rax),zmm6,zmm2{k3}",
			"pcmpgtb mm5,mm1",
			"pcmpgtb (rax),mm1",
			"pcmpgtb xmm5,xmm1",
			"pcmpgtb (rax),xmm1",
			"vpcmpgtb xmm3,xmm6,xmm2",
			"vpcmpgtb (rax),xmm6,xmm2",
			"vpcmpgtb ymm3,ymm6,ymm2",
			"vpcmpgtb (rax),ymm6,ymm2",
			"vpcmpgtb xmm3,xmm6,k2{k3}",
			"vpcmpgtb 0x10(rax),xmm6,k2{k3}",
			"vpcmpgtb ymm3,ymm6,k2{k3}",
			"vpcmpgtb 0x20(rax),ymm6,k2{k3}",
			"vpcmpgtb zmm3,zmm6,k2{k3}",
			"vpcmpgtb 0x40(rax),zmm6,k2{k3}",
			"pcmpgtw mm5,mm1",
			"pcmpgtw (rax),mm1",
			"pcmpgtw xmm5,xmm1",
			"pcmpgtw (rax),xmm1",
			"vpcmpgtw xmm3,xmm6,xmm2",
			"vpcmpgtw (rax),xmm6,xmm2",
			"vpcmpgtw ymm3,ymm6,ymm2",
			"vpcmpgtw (rax),ymm6,ymm2",
			"vpcmpgtw xmm3,xmm6,k2{k3}",
			"vpcmpgtw 0x10(rax),xmm6,k2{k3}",
			"vpcmpgtw ymm3,ymm6,k2{k3}",
			"vpcmpgtw 0x20(rax),ymm6,k2{k3}",
			"vpcmpgtw zmm3,zmm6,k2{k3}",
			"vpcmpgtw 0x40(rax),zmm6,k2{k3}",
			"pcmpgtd mm5,mm1",
			"pcmpgtd (rax),mm1",
			"pcmpgtd xmm5,xmm1",
			"pcmpgtd (rax),xmm1",
			"vpcmpgtd xmm3,xmm6,xmm2",
			"vpcmpgtd (rax),xmm6,xmm2",
			"vpcmpgtd ymm3,ymm6,ymm2",
			"vpcmpgtd (rax),ymm6,ymm2",
			"vpcmpgtd xmm3,xmm6,k2{k3}",
			"vpcmpgtd 0x10(rax),xmm6,k2{k3}",
			"vpcmpgtd 4(rax){1to4},xmm6,k2{k5}",
			"vpcmpgtd ymm3,ymm6,k2{k3}",
			"vpcmpgtd 0x20(rax),ymm6,k2{k3}",
			"vpcmpgtd 4(rax){1to8},ymm6,k2{k5}",
			"vpcmpgtd zmm3,zmm6,k2{k3}",
			"vpcmpgtd 0x40(rax),zmm6,k2{k3}",
			"vpcmpgtd 4(rax){1to16},zmm6,k2{k5}",
			"packuswb mm5,mm1",
			"packuswb (rax),mm1",
			"packuswb xmm5,xmm1",
			"packuswb (rax),xmm1",
			"vpackuswb xmm3,xmm6,xmm2",
			"vpackuswb (rax),xmm6,xmm2",
			"vpackuswb ymm3,ymm6,ymm2",
			"vpackuswb (rax),ymm6,ymm2",
			"vpackuswb xmm3,xmm6,xmm2{k3}",
			"vpackuswb 0x10(rax),xmm6,xmm2{k3}",
			"vpackuswb ymm3,ymm6,ymm2{k3}",
			"vpackuswb 0x20(rax),ymm6,ymm2{k3}",
			"vpackuswb zmm3,zmm6,zmm2{k3}",
			"vpackuswb 0x40(rax),zmm6,zmm2{k3}",
			"punpckhbw mm5,mm1",
			"punpckhbw (rax),mm1",
			"punpckhbw xmm5,xmm1",
			"punpckhbw (rax),xmm1",
			"vpunpckhbw xmm3,xmm6,xmm2",
			"vpunpckhbw (rax),xmm6,xmm2",
			"vpunpckhbw ymm3,ymm6,ymm2",
			"vpunpckhbw (rax),ymm6,ymm2",
			"vpunpckhbw xmm3,xmm6,xmm2{k3}",
			"vpunpckhbw 0x10(rax),xmm6,xmm2{k3}",
			"vpunpckhbw ymm3,ymm6,ymm2{k3}",
			"vpunpckhbw 0x20(rax),ymm6,ymm2{k3}",
			"vpunpckhbw zmm3,zmm6,zmm2{k3}",
			"vpunpckhbw 0x40(rax),zmm6,zmm2{k3}",
			"punpckhwd mm5,mm1",
			"punpckhwd (rax),mm1",
			"punpckhwd xmm5,xmm1",
			"punpckhwd (rax),xmm1",
			"vpunpckhwd xmm3,xmm6,xmm2",
			"vpunpckhwd (rax),xmm6,xmm2",
			"vpunpckhwd ymm3,ymm6,ymm2",
			"vpunpckhwd (rax),ymm6,ymm2",
			"vpunpckhwd xmm3,xmm6,xmm2{k3}",
			"vpunpckhwd 0x10(rax),xmm6,xmm2{k3}",
			"vpunpckhwd ymm3,ymm6,ymm2{k3}",
			"vpunpckhwd 0x20(rax),ymm6,ymm2{k3}",
			"vpunpckhwd zmm3,zmm6,zmm2{k3}",
			"vpunpckhwd 0x40(rax),zmm6,zmm2{k3}",
			"punpckhdq mm5,mm1",
			"punpckhdq (rax),mm1",
			"punpckhdq xmm5,xmm1",
			"punpckhdq (rax),xmm1",
			"vpunpckhdq xmm3,xmm6,xmm2",
			"vpunpckhdq (rax),xmm6,xmm2",
			"vpunpckhdq ymm3,ymm6,ymm2",
			"vpunpckhdq (rax),ymm6,ymm2",
			"vpunpckhdq xmm3,xmm6,xmm2{k3}{z}",
			"vpunpckhdq 0x10(rax),xmm6,xmm2{k3}",
			"vpunpckhdq 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpunpckhdq ymm3,ymm6,ymm2{k3}{z}",
			"vpunpckhdq 0x20(rax),ymm6,ymm2{k3}",
			"vpunpckhdq 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpunpckhdq zmm3,zmm6,zmm2{k3}{z}",
			"vpunpckhdq 0x40(rax),zmm6,zmm2{k3}",
			"vpunpckhdq 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"packssdw mm5,mm1",
			"packssdw (rax),mm1",
			"packssdw xmm5,xmm1",
			"packssdw (rax),xmm1",
			"vpackssdw xmm3,xmm6,xmm2",
			"vpackssdw (rax),xmm6,xmm2",
			"vpackssdw ymm3,ymm6,ymm2",
			"vpackssdw (rax),ymm6,ymm2",
			"vpackssdw xmm3,xmm6,xmm2{k3}{z}",
			"vpackssdw 0x10(rax),xmm6,xmm2{k3}",
			"vpackssdw 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpackssdw ymm3,ymm6,ymm2{k3}{z}",
			"vpackssdw 0x20(rax),ymm6,ymm2{k3}",
			"vpackssdw 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpackssdw zmm3,zmm6,zmm2{k3}{z}",
			"vpackssdw 0x40(rax),zmm6,zmm2{k3}",
			"vpackssdw 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"punpcklqdq xmm5,xmm1",
			"punpcklqdq (rax),xmm1",
			"vpunpcklqdq xmm3,xmm6,xmm2",
			"vpunpcklqdq (rax),xmm6,xmm2",
			"vpunpcklqdq ymm3,ymm6,ymm2",
			"vpunpcklqdq (rax),ymm6,ymm2",
			"vpunpcklqdq xmm3,xmm6,xmm2{k3}{z}",
			"vpunpcklqdq 0x10(rax),xmm6,xmm2{k3}",
			"vpunpcklqdq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpunpcklqdq ymm3,ymm6,ymm2{k3}{z}",
			"vpunpcklqdq 0x20(rax),ymm6,ymm2{k3}",
			"vpunpcklqdq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpunpcklqdq zmm3,zmm6,zmm2{k3}{z}",
			"vpunpcklqdq 0x40(rax),zmm6,zmm2{k3}",
			"vpunpcklqdq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"punpckhqdq xmm5,xmm1",
			"punpckhqdq (rax),xmm1",
			"vpunpckhqdq xmm3,xmm6,xmm2",
			"vpunpckhqdq (rax),xmm6,xmm2",
			"vpunpckhqdq ymm3,ymm6,ymm2",
			"vpunpckhqdq (rax),ymm6,ymm2",
			"vpunpckhqdq xmm3,xmm6,xmm2{k3}{z}",
			"vpunpckhqdq 0x10(rax),xmm6,xmm2{k3}",
			"vpunpckhqdq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpunpckhqdq ymm3,ymm6,ymm2{k3}{z}",
			"vpunpckhqdq 0x20(rax),ymm6,ymm2{k3}",
			"vpunpckhqdq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpunpckhqdq zmm3,zmm6,zmm2{k3}{z}",
			"vpunpckhqdq 0x40(rax),zmm6,zmm2{k3}",
			"vpunpckhqdq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"movd ebp,mm1",
			"movd (rax),mm1",
			"movq rbp,mm1",
			"movq (rax),mm1",
			"movd ebp,xmm1",
			"movd (rax),xmm1",
			"movq rbp,xmm1",
			"movq (rax),xmm1",
			"vmovd ebp,xmm1",
			"vmovd (rax),xmm1",
			"vmovq rbp,xmm1",
			"vmovq (rax),xmm1",
			"vmovd ebx,xmm2",
			"vmovd 4(rax),xmm2",
			"vmovq rbx,xmm2",
			"vmovq 8(rax),xmm2",
			"movq mm5,mm1",
			"movq (rax),mm1",
			"movdqa xmm5,xmm1",
			"movdqa (rax),xmm1",
			"vmovdqa xmm5,xmm1",
			"vmovdqa (rax),xmm2",
			"vmovdqa ymm5,ymm1",
			"vmovdqa (rax),ymm2",
			"vmovdqa32 xmm3,xmm2",
			"vmovdqa32 0x10(rax),xmm2",
			"vmovdqa32 ymm3,ymm2",
			"vmovdqa32 0x20(rax),ymm2",
			"vmovdqa32 zmm3,zmm2",
			"vmovdqa32 0x40(rax),zmm2",
			"vmovdqa64 xmm3,xmm2",
			"vmovdqa64 0x10(rax),xmm2",
			"vmovdqa64 ymm3,ymm2",
			"vmovdqa64 0x20(rax),ymm2",
			"vmovdqa64 zmm3,zmm2",
			"vmovdqa64 0x40(rax),zmm2",
			"movdqu xmm5,xmm1",
			"movdqu (rax),xmm1",
			"vmovdqu xmm5,xmm1",
			"vmovdqu (rax),xmm2",
			"vmovdqu ymm5,ymm1",
			"vmovdqu (rax),ymm2",
			"vmovdqu32 xmm3,xmm2",
			"vmovdqu32 0x10(rax),xmm2",
			"vmovdqu32 ymm3,ymm2",
			"vmovdqu32 0x20(rax),ymm2",
			"vmovdqu32 zmm3,zmm2",
			"vmovdqu32 0x40(rax),zmm2",
			"vmovdqu64 xmm3,xmm2",
			"vmovdqu64 0x10(rax),xmm2",
			"vmovdqu64 ymm3,ymm2",
			"vmovdqu64 0x20(rax),ymm2",
			"vmovdqu64 zmm3,zmm2",
			"vmovdqu64 0x40(rax),zmm2",
			"vmovdqu8 xmm3,xmm2",
			"vmovdqu8 0x10(rax),xmm2",
			"vmovdqu8 ymm3,ymm2",
			"vmovdqu8 0x20(rax),ymm2",
			"vmovdqu8 zmm3,zmm2",
			"vmovdqu8 0x40(rax),zmm2",
			"vmovdqu16 xmm3,xmm2",
			"vmovdqu16 0x10(rax),xmm2",
			"vmovdqu16 ymm3,ymm2",
			"vmovdqu16 0x20(rax),ymm2",
			"vmovdqu16 zmm3,zmm2",
			"vmovdqu16 0x40(rax),zmm2",
			"pshufw $-0x5b,mm5,mm1",
			"pshufw $-0x5b,(rax),mm1",
			"pshufd $-0x5b,xmm5,xmm1",
			"pshufd $-0x5b,(rax),xmm1",
			"vpshufd $-0x5b,xmm3,xmm2",
			"vpshufd $-0x5b,(rax),xmm2",
			"vpshufd $-0x5b,ymm3,ymm2",
			"vpshufd $-0x5b,(rax),ymm2",
			"vpshufd $-0x5b,xmm3,xmm2{k3}{z}",
			"vpshufd $-0x5b,0x10(rax),xmm2{k3}{z}",
			"vpshufd $-0x5b,4(rax){1to4},xmm2{k5}",
			"vpshufd $-0x5b,ymm3,ymm2{k3}{z}",
			"vpshufd $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpshufd $-0x5b,4(rax){1to8},ymm2{k5}",
			"vpshufd $-0x5b,zmm3,zmm2{k3}{z}",
			"vpshufd $-0x5b,0x40(rax),zmm2{k3}{z}",
			"vpshufd $-0x5b,4(rax){1to16},zmm2{k5}",
			"pshufhw $-0x5b,xmm5,xmm1",
			"pshufhw $-0x5b,(rax),xmm1",
			"vpshufhw $-0x5b,xmm3,xmm2",
			"vpshufhw $-0x5b,(rax),xmm2",
			"vpshufhw $-0x5b,ymm3,ymm2",
			"vpshufhw $-0x5b,(rax),ymm2",
			"vpshufhw $-0x5b,xmm3,xmm2{k3}{z}",
			"vpshufhw $-0x5b,0x10(rax),xmm2{k3}{z}",
			"vpshufhw $-0x5b,ymm3,ymm2{k3}{z}",
			"vpshufhw $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpshufhw $-0x5b,zmm3,zmm2{k3}{z}",
			"vpshufhw $-0x5b,0x40(rax),zmm2{k3}{z}",
			"pshuflw $-0x5b,xmm5,xmm1",
			"pshuflw $-0x5b,(rax),xmm1",
			"vpshuflw $-0x5b,xmm3,xmm2",
			"vpshuflw $-0x5b,(rax),xmm2",
			"vpshuflw $-0x5b,ymm3,ymm2",
			"vpshuflw $-0x5b,(rax),ymm2",
			"vpshuflw $-0x5b,xmm3,xmm2{k3}{z}",
			"vpshuflw $-0x5b,0x10(rax),xmm2{k3}{z}",
			"vpshuflw $-0x5b,ymm3,ymm2{k3}{z}",
			"vpshuflw $-0x5b,0x20(rax),ymm2{k3}{z}",
			"vpshuflw $-0x5b,zmm3,zmm2{k3}{z}",
			"vpshuflw $-0x5b,0x40(rax),zmm2{k3}{z}",
			"psrlw $-0x5b,mm5",
			"psrlw $-0x5b,xmm5",
			"vpsrlw $-0x5b,xmm5,xmm6",
			"vpsrlw $-0x5b,ymm5,ymm6",
			"vpsrlw $-0x5b,xmm5,xmm6{k3}",
			"vpsrlw $-0x5b,0x10(rax),xmm6{k3}",
			"vpsrlw $-0x5b,ymm5,ymm6{k3}",
			"vpsrlw $-0x5b,0x20(rax),ymm6{k3}",
			"vpsrlw $-0x5b,zmm5,zmm6{k3}",
			"vpsrlw $-0x5b,0x40(rax),zmm6{k3}",
			"psraw $-0x5b,mm5",
			"psraw $-0x5b,xmm5",
			"vpsraw $-0x5b,xmm5,xmm6",
			"vpsraw $-0x5b,ymm5,ymm6",
			"vpsraw $-0x5b,xmm5,xmm6{k3}",
			"vpsraw $-0x5b,0x10(rax),xmm6{k3}",
			"vpsraw $-0x5b,ymm5,ymm6{k3}",
			"vpsraw $-0x5b,0x20(rax),ymm6{k3}",
			"vpsraw $-0x5b,zmm5,zmm6{k3}",
			"vpsraw $-0x5b,0x40(rax),zmm6{k3}",
			"psllw $-0x5b,mm5",
			"psllw $-0x5b,xmm5",
			"vpsllw $-0x5b,xmm5,xmm6",
			"vpsllw $-0x5b,ymm5,ymm6",
			"vpsllw $-0x5b,xmm5,xmm6{k3}",
			"vpsllw $-0x5b,0x10(rax),xmm6{k3}",
			"vpsllw $-0x5b,ymm5,ymm6{k3}",
			"vpsllw $-0x5b,0x20(rax),ymm6{k3}",
			"vpsllw $-0x5b,zmm5,zmm6{k3}",
			"vpsllw $-0x5b,0x40(rax),zmm6{k3}",
			"vprord $-0x5b,xmm5,xmm6{k3}",
			"vprord $-0x5b,0x10(rax),xmm6{k3}",
			"vprord $-0x5b,4(rax){1to4},xmm6{k5}{z}",
			"vprord $-0x5b,ymm5,ymm6{k3}",
			"vprord $-0x5b,0x20(rax),ymm6{k3}",
			"vprord $-0x5b,4(rax){1to8},ymm6{k5}{z}",
			"vprord $-0x5b,zmm5,zmm6{k3}",
			"vprord $-0x5b,0x40(rax),zmm6{k3}",
			"vprord $-0x5b,4(rax){1to16},zmm6{k5}{z}",
			"vprorq $-0x5b,xmm5,xmm6{k3}",
			"vprorq $-0x5b,0x10(rax),xmm6{k3}",
			"vprorq $-0x5b,8(rax){1to2},xmm6{k5}{z}",
			"vprorq $-0x5b,ymm5,ymm6{k3}",
			"vprorq $-0x5b,0x20(rax),ymm6{k3}",
			"vprorq $-0x5b,8(rax){1to4},ymm6{k5}{z}",
			"vprorq $-0x5b,zmm5,zmm6{k3}",
			"vprorq $-0x5b,0x40(rax),zmm6{k3}",
			"vprorq $-0x5b,8(rax){1to8},zmm6{k5}{z}",
			"vprold $-0x5b,xmm5,xmm6{k3}",
			"vprold $-0x5b,0x10(rax),xmm6{k3}",
			"vprold $-0x5b,4(rax){1to4},xmm6{k5}{z}",
			"vprold $-0x5b,ymm5,ymm6{k3}",
			"vprold $-0x5b,0x20(rax),ymm6{k3}",
			"vprold $-0x5b,4(rax){1to8},ymm6{k5}{z}",
			"vprold $-0x5b,zmm5,zmm6{k3}",
			"vprold $-0x5b,0x40(rax),zmm6{k3}",
			"vprold $-0x5b,4(rax){1to16},zmm6{k5}{z}",
			"vprolq $-0x5b,xmm5,xmm6{k3}",
			"vprolq $-0x5b,0x10(rax),xmm6{k3}",
			"vprolq $-0x5b,8(rax){1to2},xmm6{k5}{z}",
			"vprolq $-0x5b,ymm5,ymm6{k3}",
			"vprolq $-0x5b,0x20(rax),ymm6{k3}",
			"vprolq $-0x5b,8(rax){1to4},ymm6{k5}{z}",
			"vprolq $-0x5b,zmm5,zmm6{k3}",
			"vprolq $-0x5b,0x40(rax),zmm6{k3}",
			"vprolq $-0x5b,8(rax){1to8},zmm6{k5}{z}",
			"psrld $-0x5b,mm5",
			"psrld $-0x5b,xmm5",
			"vpsrld $-0x5b,xmm5,xmm6",
			"vpsrld $-0x5b,ymm5,ymm6",
			"vpsrld $-0x5b,xmm5,xmm6{k3}",
			"vpsrld $-0x5b,0x10(rax),xmm6{k3}",
			"vpsrld $-0x5b,4(rax){1to4},xmm6{k5}{z}",
			"vpsrld $-0x5b,ymm5,ymm6{k3}",
			"vpsrld $-0x5b,0x20(rax),ymm6{k3}",
			"vpsrld $-0x5b,4(rax){1to8},ymm6{k5}{z}",
			"vpsrld $-0x5b,zmm5,zmm6{k3}",
			"vpsrld $-0x5b,0x40(rax),zmm6{k3}",
			"vpsrld $-0x5b,4(rax){1to16},zmm6{k5}{z}",
			"psrad $-0x5b,mm5",
			"psrad $-0x5b,xmm5",
			"vpsrad $-0x5b,xmm5,xmm6",
			"vpsrad $-0x5b,ymm5,ymm6",
			"vpsrad $-0x5b,xmm5,xmm6{k3}",
			"vpsrad $-0x5b,0x10(rax),xmm6{k3}",
			"vpsrad $-0x5b,4(rax){1to4},xmm6{k5}{z}",
			"vpsrad $-0x5b,ymm5,ymm6{k3}",
			"vpsrad $-0x5b,0x20(rax),ymm6{k3}",
			"vpsrad $-0x5b,4(rax){1to8},ymm6{k5}{z}",
			"vpsrad $-0x5b,zmm5,zmm6{k3}",
			"vpsrad $-0x5b,0x40(rax),zmm6{k3}",
			"vpsrad $-0x5b,4(rax){1to16},zmm6{k5}{z}",
			"vpsraq $-0x5b,xmm5,xmm6{k3}",
			"vpsraq $-0x5b,0x10(rax),xmm6{k3}",
			"vpsraq $-0x5b,8(rax){1to2},xmm6{k5}{z}",
			"vpsraq $-0x5b,ymm5,ymm6{k3}",
			"vpsraq $-0x5b,0x20(rax),ymm6{k3}",
			"vpsraq $-0x5b,8(rax){1to4},ymm6{k5}{z}",
			"vpsraq $-0x5b,zmm5,zmm6{k3}",
			"vpsraq $-0x5b,0x40(rax),zmm6{k3}",
			"vpsraq $-0x5b,8(rax){1to8},zmm6{k5}{z}",
			"pslld $-0x5b,mm5",
			"pslld $-0x5b,xmm5",
			"vpslld $-0x5b,xmm5,xmm6",
			"vpslld $-0x5b,ymm5,ymm6",
			"vpslld $-0x5b,xmm5,xmm6{k3}",
			"vpslld $-0x5b,0x10(rax),xmm6{k3}",
			"vpslld $-0x5b,4(rax){1to4},xmm6{k5}{z}",
			"vpslld $-0x5b,ymm5,ymm6{k3}",
			"vpslld $-0x5b,0x20(rax),ymm6{k3}",
			"vpslld $-0x5b,4(rax){1to8},ymm6{k5}{z}",
			"vpslld $-0x5b,zmm5,zmm6{k3}",
			"vpslld $-0x5b,0x40(rax),zmm6{k3}",
			"vpslld $-0x5b,4(rax){1to16},zmm6{k5}{z}",
			"psrlq $-0x5b,mm5",
			"psrlq $-0x5b,xmm5",
			"vpsrlq $-0x5b,xmm5,xmm6",
			"vpsrlq $-0x5b,ymm5,ymm6",
			"vpsrlq $-0x5b,xmm5,xmm6{k3}",
			"vpsrlq $-0x5b,0x10(rax),xmm6{k3}",
			"vpsrlq $-0x5b,8(rax){1to2},xmm6{k5}{z}",
			"vpsrlq $-0x5b,ymm5,ymm6{k3}",
			"vpsrlq $-0x5b,0x20(rax),ymm6{k3}",
			"vpsrlq $-0x5b,8(rax){1to4},ymm6{k5}{z}",
			"vpsrlq $-0x5b,zmm5,zmm6{k3}",
			"vpsrlq $-0x5b,0x40(rax),zmm6{k3}",
			"vpsrlq $-0x5b,8(rax){1to8},zmm6{k5}{z}",
			"psrldq $-0x5b,xmm5",
			"vpsrldq $-0x5b,xmm5,xmm6",
			"vpsrldq $-0x5b,ymm5,ymm6",
			"vpsrldq $-0x5b,xmm5,xmm6",
			"vpsrldq $-0x5b,0x10(rax),xmm6",
			"vpsrldq $-0x5b,ymm5,ymm6",
			"vpsrldq $-0x5b,0x20(rax),ymm6",
			"vpsrldq $-0x5b,zmm5,zmm6",
			"vpsrldq $-0x5b,0x40(rax),zmm6",
			"psllq $-0x5b,mm5",
			"psllq $-0x5b,xmm5",
			"vpsllq $-0x5b,xmm5,xmm6",
			"vpsllq $-0x5b,ymm5,ymm6",
			"vpsllq $-0x5b,xmm5,xmm6{k3}",
			"vpsllq $-0x5b,0x10(rax),xmm6{k3}",
			"vpsllq $-0x5b,8(rax){1to2},xmm6{k5}{z}",
			"vpsllq $-0x5b,ymm5,ymm6{k3}",
			"vpsllq $-0x5b,0x20(rax),ymm6{k3}",
			"vpsllq $-0x5b,8(rax){1to4},ymm6{k5}{z}",
			"vpsllq $-0x5b,zmm5,zmm6{k3}",
			"vpsllq $-0x5b,0x40(rax),zmm6{k3}",
			"vpsllq $-0x5b,8(rax){1to8},zmm6{k5}{z}",
			"pslldq $-0x5b,xmm5",
			"vpslldq $-0x5b,xmm5,xmm6",
			"vpslldq $-0x5b,ymm5,ymm6",
			"vpslldq $-0x5b,xmm5,xmm6",
			"vpslldq $-0x5b,0x10(rax),xmm6",
			"vpslldq $-0x5b,ymm5,ymm6",
			"vpslldq $-0x5b,0x20(rax),ymm6",
			"vpslldq $-0x5b,zmm5,zmm6",
			"vpslldq $-0x5b,0x40(rax),zmm6",
			"pcmpeqb mm5,mm1",
			"pcmpeqb (rax),mm1",
			"pcmpeqb xmm5,xmm1",
			"pcmpeqb (rax),xmm1",
			"vpcmpeqb xmm3,xmm6,xmm2",
			"vpcmpeqb (rax),xmm6,xmm2",
			"vpcmpeqb ymm3,ymm6,ymm2",
			"vpcmpeqb (rax),ymm6,ymm2",
			"vpcmpeqb xmm3,xmm6,k2{k3}",
			"vpcmpeqb 0x10(rax),xmm6,k2{k3}",
			"vpcmpeqb ymm3,ymm6,k2{k3}",
			"vpcmpeqb 0x20(rax),ymm6,k2{k3}",
			"vpcmpeqb zmm3,zmm6,k2{k3}",
			"vpcmpeqb 0x40(rax),zmm6,k2{k3}",
			"pcmpeqw mm5,mm1",
			"pcmpeqw (rax),mm1",
			"pcmpeqw xmm5,xmm1",
			"pcmpeqw (rax),xmm1",
			"vpcmpeqw xmm3,xmm6,xmm2",
			"vpcmpeqw (rax),xmm6,xmm2",
			"vpcmpeqw ymm3,ymm6,ymm2",
			"vpcmpeqw (rax),ymm6,ymm2",
			"vpcmpeqw xmm3,xmm6,k2{k3}",
			"vpcmpeqw 0x10(rax),xmm6,k2{k3}",
			"vpcmpeqw ymm3,ymm6,k2{k3}",
			"vpcmpeqw 0x20(rax),ymm6,k2{k3}",
			"vpcmpeqw zmm3,zmm6,k2{k3}",
			"vpcmpeqw 0x40(rax),zmm6,k2{k3}",
			"pcmpeqd mm5,mm1",
			"pcmpeqd (rax),mm1",
			"pcmpeqd xmm5,xmm1",
			"pcmpeqd (rax),xmm1",
			"vpcmpeqd xmm3,xmm6,xmm2",
			"vpcmpeqd (rax),xmm6,xmm2",
			"vpcmpeqd ymm3,ymm6,ymm2",
			"vpcmpeqd (rax),ymm6,ymm2",
			"vpcmpeqd xmm3,xmm6,k2{k3}",
			"vpcmpeqd 0x10(rax),xmm6,k2{k3}",
			"vpcmpeqd 4(rax){1to4},xmm6,k2{k5}",
			"vpcmpeqd ymm3,ymm6,k2{k3}",
			"vpcmpeqd 0x20(rax),ymm6,k2{k3}",
			"vpcmpeqd 4(rax){1to8},ymm6,k2{k5}",
			"vpcmpeqd zmm3,zmm6,k2{k3}",
			"vpcmpeqd 0x40(rax),zmm6,k2{k3}",
			"vpcmpeqd 4(rax){1to16},zmm6,k2{k5}",
			"emms",
			"vzeroupper",
			"vzeroall",
			"vmreadq rcx,rsi",
			"vmreadq rbx,(rax)",
			"vmwriteq rsi,rcx",
			"vmwriteq (rax),rbx",
			"vcvttps2udq xmm3,xmm2{k3}",
			"vcvttps2udq 0x10(rax),xmm2",
			"vcvttps2udq 4(rax){1to4},xmm2{k3}{z}",
			"vcvttps2udq ymm3,ymm2{k3}",
			"vcvttps2udq 0x20(rax),ymm2",
			"vcvttps2udq 4(rax){1to8},ymm2{k3}{z}",
			"vcvttps2udq zmm3,zmm2{k3}",
			"vcvttps2udq 0x40(rax),zmm2",
			"vcvttps2udq 4(rax){1to16},zmm2{k3}{z}",
			"vcvttpd2udqx xmm3,xmm2{k3}",
			"vcvttpd2udqx 0x10(rax),xmm2",
			"vcvttpd2udqx 8(rax){1to2},xmm2{k3}{z}",
			"vcvttpd2udqy ymm3,xmm2{k3}",
			"vcvttpd2udqy 0x20(rax),xmm2",
			"vcvttpd2udqy 8(rax){1to4},xmm2{k3}{z}",
			"vcvttpd2udq zmm3,ymm2{k3}",
			"vcvttpd2udq 0x40(rax),ymm2",
			"vcvttpd2udq 8(rax){1to8},ymm2{k3}{z}",
			"vcvttps2uqq xmm3,xmm2{k3}",
			"vcvttps2uqq 8(rax),xmm2",
			"vcvttps2uqq 4(rax){1to2},xmm2{k3}{z}",
			"vcvttps2uqq xmm3,ymm2{k3}",
			"vcvttps2uqq 0x10(rax),ymm2",
			"vcvttps2uqq 4(rax){1to4},ymm2{k3}{z}",
			"vcvttps2uqq ymm3,zmm2{k3}",
			"vcvttps2uqq 0x20(rax),zmm2",
			"vcvttps2uqq 4(rax){1to8},zmm2{k3}{z}",
			"vcvttpd2uqq xmm3,xmm2{k3}",
			"vcvttpd2uqq 0x10(rax),xmm2",
			"vcvttpd2uqq 8(rax){1to2},xmm2{k3}{z}",
			"vcvttpd2uqq ymm3,ymm2{k3}",
			"vcvttpd2uqq 0x20(rax),ymm2",
			"vcvttpd2uqq 8(rax){1to4},ymm2{k3}{z}",
			"vcvttpd2uqq zmm3,zmm2{k3}",
			"vcvttpd2uqq 0x40(rax),zmm2",
			"vcvttpd2uqq 8(rax){1to8},zmm2{k3}{z}",
			"vcvttss2usi xmm3,edx",
			"vcvttss2usi 4(rax),edx",
			"vcvttss2usi xmm3,rdx",
			"vcvttss2usi 4(rax),rdx",
			"vcvttsd2usi xmm3,edx",
			"vcvttsd2usi 8(rax),edx",
			"vcvttsd2usi xmm3,rdx",
			"vcvttsd2usi 8(rax),rdx",
			"vcvtps2udq xmm3,xmm2{k3}",
			"vcvtps2udq 0x10(rax),xmm2",
			"vcvtps2udq 4(rax){1to4},xmm2{k3}{z}",
			"vcvtps2udq ymm3,ymm2{k3}",
			"vcvtps2udq 0x20(rax),ymm2",
			"vcvtps2udq 4(rax){1to8},ymm2{k3}{z}",
			"vcvtps2udq zmm3,zmm2{k3}",
			"vcvtps2udq 0x40(rax),zmm2",
			"vcvtps2udq 4(rax){1to16},zmm2{k3}{z}",
			"vcvtpd2udqx xmm3,xmm2{k3}",
			"vcvtpd2udqx 0x10(rax),xmm2",
			"vcvtpd2udqx 8(rax){1to2},xmm2{k3}{z}",
			"vcvtpd2udqy ymm3,xmm2{k3}",
			"vcvtpd2udqy 0x20(rax),xmm2",
			"vcvtpd2udqy 8(rax){1to4},xmm2{k3}{z}",
			"vcvtpd2udq zmm3,ymm2{k3}",
			"vcvtpd2udq 0x40(rax),ymm2",
			"vcvtpd2udq 8(rax){1to8},ymm2{k3}{z}",
			"vcvtps2uqq xmm3,xmm2{k3}",
			"vcvtps2uqq 8(rax),xmm2",
			"vcvtps2uqq 4(rax){1to2},xmm2{k3}{z}",
			"vcvtps2uqq xmm3,ymm2{k3}",
			"vcvtps2uqq 0x10(rax),ymm2",
			"vcvtps2uqq 4(rax){1to4},ymm2{k3}{z}",
			"vcvtps2uqq ymm3,zmm2{k3}",
			"vcvtps2uqq 0x20(rax),zmm2",
			"vcvtps2uqq 4(rax){1to8},zmm2{k3}{z}",
			"vcvtpd2uqq xmm3,xmm2{k3}",
			"vcvtpd2uqq 0x10(rax),xmm2",
			"vcvtpd2uqq 8(rax){1to2},xmm2{k3}{z}",
			"vcvtpd2uqq ymm3,ymm2{k3}",
			"vcvtpd2uqq 0x20(rax),ymm2",
			"vcvtpd2uqq 8(rax){1to4},ymm2{k3}{z}",
			"vcvtpd2uqq zmm3,zmm2{k3}",
			"vcvtpd2uqq 0x40(rax),zmm2",
			"vcvtpd2uqq 8(rax){1to8},zmm2{k3}{z}",
			"vcvtss2usi xmm3,edx",
			"vcvtss2usi 4(rax),edx",
			"vcvtss2usi xmm3,rdx",
			"vcvtss2usi 4(rax),rdx",
			"vcvtsd2usi xmm3,edx",
			"vcvtsd2usi 8(rax),edx",
			"vcvtsd2usi xmm3,rdx",
			"vcvtsd2usi 8(rax),rdx",
			"vcvttps2qq xmm3,xmm2{k3}",
			"vcvttps2qq 8(rax),xmm2",
			"vcvttps2qq 4(rax){1to2},xmm2{k3}{z}",
			"vcvttps2qq xmm3,ymm2{k3}",
			"vcvttps2qq 0x10(rax),ymm2",
			"vcvttps2qq 4(rax){1to4},ymm2{k3}{z}",
			"vcvttps2qq ymm3,zmm2{k3}",
			"vcvttps2qq 0x20(rax),zmm2",
			"vcvttps2qq 4(rax){1to8},zmm2{k3}{z}",
			"vcvttpd2qq xmm3,xmm2{k3}",
			"vcvttpd2qq 0x10(rax),xmm2",
			"vcvttpd2qq 8(rax){1to2},xmm2{k3}{z}",
			"vcvttpd2qq ymm3,ymm2{k3}",
			"vcvttpd2qq 0x20(rax),ymm2",
			"vcvttpd2qq 8(rax){1to4},ymm2{k3}{z}",
			"vcvttpd2qq zmm3,zmm2{k3}",
			"vcvttpd2qq 0x40(rax),zmm2",
			"vcvttpd2qq 8(rax){1to8},zmm2{k3}{z}",
			"vcvtudq2pd xmm3,xmm2{k3}",
			"vcvtudq2pd 8(rax),xmm2",
			"vcvtudq2pd 4(rax){1to2},xmm2{k3}{z}",
			"vcvtudq2pd xmm3,ymm2{k3}",
			"vcvtudq2pd 0x10(rax),ymm2",
			"vcvtudq2pd 4(rax){1to4},ymm2{k3}{z}",
			"vcvtudq2pd ymm3,zmm2{k3}",
			"vcvtudq2pd 0x20(rax),zmm2",
			"vcvtudq2pd 4(rax){1to8},zmm2{k3}{z}",
			"vcvtuqq2pd xmm3,xmm2{k3}",
			"vcvtuqq2pd 0x10(rax),xmm2",
			"vcvtuqq2pd 8(rax){1to2},xmm2{k3}{z}",
			"vcvtuqq2pd ymm3,ymm2{k3}",
			"vcvtuqq2pd 0x20(rax),ymm2",
			"vcvtuqq2pd 8(rax){1to4},ymm2{k3}{z}",
			"vcvtuqq2pd zmm3,zmm2{k3}",
			"vcvtuqq2pd 0x40(rax),zmm2",
			"vcvtuqq2pd 8(rax){1to8},zmm2{k3}{z}",
			"vcvtudq2ps xmm3,xmm2{k3}",
			"vcvtudq2ps 0x10(rax),xmm2",
			"vcvtudq2ps 4(rax){1to4},xmm2{k3}{z}",
			"vcvtudq2ps ymm3,ymm2{k3}",
			"vcvtudq2ps 0x20(rax),ymm2",
			"vcvtudq2ps 4(rax){1to8},ymm2{k3}{z}",
			"vcvtudq2ps zmm3,zmm2{k3}",
			"vcvtudq2ps 0x40(rax),zmm2",
			"vcvtudq2ps 4(rax){1to16},zmm2{k3}{z}",
			"vcvtuqq2psx xmm3,xmm2{k3}",
			"vcvtuqq2psx 0x10(rax),xmm2",
			"vcvtuqq2psx 8(rax){1to2},xmm2{k3}{z}",
			"vcvtuqq2psy ymm3,xmm2{k3}",
			"vcvtuqq2psy 0x20(rax),xmm2",
			"vcvtuqq2psy 8(rax){1to4},xmm2{k3}{z}",
			"vcvtuqq2ps zmm3,ymm2{k3}",
			"vcvtuqq2ps 0x40(rax),ymm2",
			"vcvtuqq2ps 8(rax){1to8},ymm2{k3}{z}",
			"vcvtps2qq xmm3,xmm2{k3}",
			"vcvtps2qq 8(rax),xmm2",
			"vcvtps2qq 4(rax){1to2},xmm2{k3}{z}",
			"vcvtps2qq xmm3,ymm2{k3}",
			"vcvtps2qq 0x10(rax),ymm2",
			"vcvtps2qq 4(rax){1to4},ymm2{k3}{z}",
			"vcvtps2qq ymm3,zmm2{k3}",
			"vcvtps2qq 0x20(rax),zmm2",
			"vcvtps2qq 4(rax){1to8},zmm2{k3}{z}",
			"vcvtpd2qq xmm3,xmm2{k3}",
			"vcvtpd2qq 0x10(rax),xmm2",
			"vcvtpd2qq 8(rax){1to2},xmm2{k3}{z}",
			"vcvtpd2qq ymm3,ymm2{k3}",
			"vcvtpd2qq 0x20(rax),ymm2",
			"vcvtpd2qq 8(rax){1to4},ymm2{k3}{z}",
			"vcvtpd2qq zmm3,zmm2{k3}",
			"vcvtpd2qq 0x40(rax),zmm2",
			"vcvtpd2qq 8(rax){1to8},zmm2{k3}{z}",
			"vcvtusi2ssl ebx,xmm6,xmm2",
			"vcvtusi2ssl 4(rax),xmm6,xmm2",
			"vcvtusi2ssq rbx,xmm6,xmm2",
			"vcvtusi2ssq 8(rax),xmm6,xmm2",
			"vcvtusi2sdl ebx,xmm6,xmm2",
			"vcvtusi2sdl 4(rax),xmm6,xmm2",
			"vcvtusi2sdq rbx,xmm6,xmm2",
			"vcvtusi2sdq 8(rax),xmm6,xmm2",
			"haddpd xmm5,xmm1",
			"haddpd (rax),xmm1",
			"vhaddpd xmm3,xmm6,xmm2",
			"vhaddpd (rax),xmm6,xmm2",
			"vhaddpd ymm3,ymm6,ymm2",
			"vhaddpd (rax),ymm6,ymm2",
			"haddps xmm5,xmm1",
			"haddps (rax),xmm1",
			"vhaddps xmm3,xmm6,xmm2",
			"vhaddps (rax),xmm6,xmm2",
			"vhaddps ymm3,ymm6,ymm2",
			"vhaddps (rax),ymm6,ymm2",
			"hsubpd xmm5,xmm1",
			"hsubpd (rax),xmm1",
			"vhsubpd xmm3,xmm6,xmm2",
			"vhsubpd (rax),xmm6,xmm2",
			"vhsubpd ymm3,ymm6,ymm2",
			"vhsubpd (rax),ymm6,ymm2",
			"hsubps xmm5,xmm1",
			"hsubps (rax),xmm1",
			"vhsubps xmm3,xmm6,xmm2",
			"vhsubps (rax),xmm6,xmm2",
			"vhsubps ymm3,ymm6,ymm2",
			"vhsubps (rax),ymm6,ymm2",
			"movd mm1,ebp",
			"movd mm1,(rax)",
			"movq mm1,rbp",
			"movq mm1,(rax)",
			"movd xmm1,ebp",
			"movd xmm1,(rax)",
			"movq xmm1,rbp",
			"movq xmm1,(rax)",
			"vmovd xmm1,ebp",
			"vmovd xmm1,(rax)",
			"vmovq xmm1,rbp",
			"vmovq xmm1,(rax)",
			"vmovd xmm2,ebx",
			"vmovd xmm2,4(rax)",
			"vmovq xmm2,rbx",
			"vmovq xmm2,8(rax)",
			"movq xmm5,xmm1",
			"movq (rax),xmm1",
			"vmovq xmm5,xmm1",
			"vmovq (rax),xmm2",
			"vmovq xmm3,xmm2",
			"vmovq 8(rax),xmm2",
			"movq mm1,mm5",
			"movq mm1,(rax)",
			"movdqa xmm1,xmm5",
			"movdqa xmm1,(rax)",
			"vmovdqa xmm1,xmm5",
			"vmovdqa xmm2,(rax)",
			"vmovdqa ymm1,ymm5",
			"vmovdqa ymm2,(rax)",
			"vmovdqa32 xmm2,xmm3",
			"vmovdqa32 xmm2,0x10(rax)",
			"vmovdqa32 ymm2,ymm3",
			"vmovdqa32 ymm2,0x20(rax)",
			"vmovdqa32 zmm2,zmm3",
			"vmovdqa32 zmm2,0x40(rax)",
			"vmovdqa64 xmm2,xmm3",
			"vmovdqa64 xmm2,0x10(rax)",
			"vmovdqa64 ymm2,ymm3",
			"vmovdqa64 ymm2,0x20(rax)",
		};
	}
}
#endif
