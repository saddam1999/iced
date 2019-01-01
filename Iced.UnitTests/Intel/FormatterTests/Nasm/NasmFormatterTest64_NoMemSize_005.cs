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

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest64_NoMemSize_005 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_005.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_005.AllInfos_Length] {
			"pminuw xmm1,[rax]",
			"vpminuw xmm2,xmm6,xmm3",
			"vpminuw xmm2,xmm6,[rax]",
			"vpminuw ymm2,ymm6,ymm3",
			"vpminuw ymm2,ymm6,[rax]",
			"vpminuw xmm2{k3},xmm6,xmm3",
			"vpminuw xmm2{k3},xmm6,[rax+0x10]",
			"vpminuw ymm2{k3},ymm6,ymm3",
			"vpminuw ymm2{k3},ymm6,[rax+0x20]",
			"vpminuw zmm2{k3},zmm6,zmm3",
			"vpminuw zmm2{k3},zmm6,[rax+0x40]",
			"vpbroadcastmw2d xmm2,k3",
			"vpbroadcastmw2d ymm2,k3",
			"vpbroadcastmw2d zmm2,k3",
			"pminud xmm1,xmm5",
			"pminud xmm1,[rax]",
			"vpminud xmm2,xmm6,xmm3",
			"vpminud xmm2,xmm6,[rax]",
			"vpminud ymm2,ymm6,ymm3",
			"vpminud ymm2,ymm6,[rax]",
			"vpminud xmm2{k3}{z},xmm6,xmm3",
			"vpminud xmm2{k3},xmm6,[rax+0x10]",
			"vpminud xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpminud ymm2{k3}{z},ymm6,ymm3",
			"vpminud ymm2{k3},ymm6,[rax+0x20]",
			"vpminud ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpminud zmm2{k3}{z},zmm6,zmm3",
			"vpminud zmm2{k3},zmm6,[rax+0x40]",
			"vpminud zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpminuq xmm2{k3}{z},xmm6,xmm3",
			"vpminuq xmm2{k3},xmm6,[rax+0x10]",
			"vpminuq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpminuq ymm2{k3}{z},ymm6,ymm3",
			"vpminuq ymm2{k3},ymm6,[rax+0x20]",
			"vpminuq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpminuq zmm2{k3}{z},zmm6,zmm3",
			"vpminuq zmm2{k3},zmm6,[rax+0x40]",
			"vpminuq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"pmaxsb xmm1,xmm5",
			"pmaxsb xmm1,[rax]",
			"vpmaxsb xmm2,xmm6,xmm3",
			"vpmaxsb xmm2,xmm6,[rax]",
			"vpmaxsb ymm2,ymm6,ymm3",
			"vpmaxsb ymm2,ymm6,[rax]",
			"vpmaxsb xmm2{k3},xmm6,xmm3",
			"vpmaxsb xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxsb ymm2{k3},ymm6,ymm3",
			"vpmaxsb ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxsb zmm2{k3},zmm6,zmm3",
			"vpmaxsb zmm2{k3},zmm6,[rax+0x40]",
			"pmaxsd xmm1,xmm5",
			"pmaxsd xmm1,[rax]",
			"vpmaxsd xmm2,xmm6,xmm3",
			"vpmaxsd xmm2,xmm6,[rax]",
			"vpmaxsd ymm2,ymm6,ymm3",
			"vpmaxsd ymm2,ymm6,[rax]",
			"vpmaxsd xmm2{k3}{z},xmm6,xmm3",
			"vpmaxsd xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxsd xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpmaxsd ymm2{k3}{z},ymm6,ymm3",
			"vpmaxsd ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxsd ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpmaxsd zmm2{k3}{z},zmm6,zmm3",
			"vpmaxsd zmm2{k3},zmm6,[rax+0x40]",
			"vpmaxsd zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpmaxsq xmm2{k3}{z},xmm6,xmm3",
			"vpmaxsq xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxsq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmaxsq ymm2{k3}{z},ymm6,ymm3",
			"vpmaxsq ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxsq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmaxsq zmm2{k3}{z},zmm6,zmm3",
			"vpmaxsq zmm2{k3},zmm6,[rax+0x40]",
			"vpmaxsq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"pmaxuw xmm1,xmm5",
			"pmaxuw xmm1,[rax]",
			"vpmaxuw xmm2,xmm6,xmm3",
			"vpmaxuw xmm2,xmm6,[rax]",
			"vpmaxuw ymm2,ymm6,ymm3",
			"vpmaxuw ymm2,ymm6,[rax]",
			"vpmaxuw xmm2{k3},xmm6,xmm3",
			"vpmaxuw xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxuw ymm2{k3},ymm6,ymm3",
			"vpmaxuw ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxuw zmm2{k3},zmm6,zmm3",
			"vpmaxuw zmm2{k3},zmm6,[rax+0x40]",
			"pmaxud xmm1,xmm5",
			"pmaxud xmm1,[rax]",
			"vpmaxud xmm2,xmm6,xmm3",
			"vpmaxud xmm2,xmm6,[rax]",
			"vpmaxud ymm2,ymm6,ymm3",
			"vpmaxud ymm2,ymm6,[rax]",
			"vpmaxud xmm2{k3}{z},xmm6,xmm3",
			"vpmaxud xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxud xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpmaxud ymm2{k3}{z},ymm6,ymm3",
			"vpmaxud ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxud ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpmaxud zmm2{k3}{z},zmm6,zmm3",
			"vpmaxud zmm2{k3},zmm6,[rax+0x40]",
			"vpmaxud zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpmaxuq xmm2{k3}{z},xmm6,xmm3",
			"vpmaxuq xmm2{k3},xmm6,[rax+0x10]",
			"vpmaxuq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmaxuq ymm2{k3}{z},ymm6,ymm3",
			"vpmaxuq ymm2{k3},ymm6,[rax+0x20]",
			"vpmaxuq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmaxuq zmm2{k3}{z},zmm6,zmm3",
			"vpmaxuq zmm2{k3},zmm6,[rax+0x40]",
			"vpmaxuq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"pmulld xmm1,xmm5",
			"pmulld xmm1,[rax]",
			"vpmulld xmm2,xmm6,xmm3",
			"vpmulld xmm2,xmm6,[rax]",
			"vpmulld ymm2,ymm6,ymm3",
			"vpmulld ymm2,ymm6,[rax]",
			"vpmulld xmm2{k3}{z},xmm6,xmm3",
			"vpmulld xmm2{k3},xmm6,[rax+0x10]",
			"vpmulld xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpmulld ymm2{k3}{z},ymm6,ymm3",
			"vpmulld ymm2{k3},ymm6,[rax+0x20]",
			"vpmulld ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpmulld zmm2{k3}{z},zmm6,zmm3",
			"vpmulld zmm2{k3},zmm6,[rax+0x40]",
			"vpmulld zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpmullq xmm2{k3}{z},xmm6,xmm3",
			"vpmullq xmm2{k3},xmm6,[rax+0x10]",
			"vpmullq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmullq ymm2{k3}{z},ymm6,ymm3",
			"vpmullq ymm2{k3},ymm6,[rax+0x20]",
			"vpmullq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmullq zmm2{k3}{z},zmm6,zmm3",
			"vpmullq zmm2{k3},zmm6,[rax+0x40]",
			"vpmullq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"phminposuw xmm1,xmm5",
			"phminposuw xmm1,[rax]",
			"vphminposuw xmm1,xmm5",
			"vphminposuw xmm2,[rax]",
			"vgetexpps xmm2{k3},xmm3",
			"vgetexpps xmm2,[rax+0x10]",
			"vgetexpps xmm2{k3}{z},[rax+4]{1to4}",
			"vgetexpps ymm2{k3},ymm3",
			"vgetexpps ymm2,[rax+0x20]",
			"vgetexpps ymm2{k3}{z},[rax+4]{1to8}",
			"vgetexpps zmm2{k3},zmm3",
			"vgetexpps zmm2,[rax+0x40]",
			"vgetexpps zmm2{k3}{z},[rax+4]{1to16}",
			"vgetexppd xmm2{k3},xmm3",
			"vgetexppd xmm2,[rax+0x10]",
			"vgetexppd xmm2{k3}{z},[rax+8]{1to2}",
			"vgetexppd ymm2{k3},ymm3",
			"vgetexppd ymm2,[rax+0x20]",
			"vgetexppd ymm2{k3}{z},[rax+8]{1to4}",
			"vgetexppd zmm2{k3},zmm3",
			"vgetexppd zmm2,[rax+0x40]",
			"vgetexppd zmm2{k3}{z},[rax+8]{1to8}",
			"vgetexpss xmm2{k3},xmm6,xmm3",
			"vgetexpss xmm2{k3},xmm6,[rax+4]",
			"vgetexpsd xmm2{k3}{z},xmm6,xmm3",
			"vgetexpsd xmm2{k3},xmm6,[rax+8]",
			"vplzcntd xmm2{k3}{z},xmm3",
			"vplzcntd xmm2{k3},[rax+0x10]",
			"vplzcntd xmm2{k5}{z},[rax+4]{1to4}",
			"vplzcntd ymm2{k3}{z},ymm3",
			"vplzcntd ymm2{k3},[rax+0x20]",
			"vplzcntd ymm2{k5}{z},[rax+4]{1to8}",
			"vplzcntd zmm2{k3}{z},zmm3",
			"vplzcntd zmm2{k3},[rax+0x40]",
			"vplzcntd zmm2{k5}{z},[rax+4]{1to16}",
			"vplzcntq xmm2{k3}{z},xmm3",
			"vplzcntq xmm2{k3},[rax+0x10]",
			"vplzcntq xmm2{k5}{z},[rax+8]{1to2}",
			"vplzcntq ymm2{k3}{z},ymm3",
			"vplzcntq ymm2{k3},[rax+0x20]",
			"vplzcntq ymm2{k5}{z},[rax+8]{1to4}",
			"vplzcntq zmm2{k3}{z},zmm3",
			"vplzcntq zmm2{k3},[rax+0x40]",
			"vplzcntq zmm2{k5}{z},[rax+8]{1to8}",
			"vpsrlvd xmm2,xmm6,xmm3",
			"vpsrlvd xmm2,xmm6,[rax]",
			"vpsrlvd ymm2,ymm6,ymm3",
			"vpsrlvd ymm2,ymm6,[rax]",
			"vpsrlvq xmm2,xmm6,xmm3",
			"vpsrlvq xmm2,xmm6,[rax]",
			"vpsrlvq ymm2,ymm6,ymm3",
			"vpsrlvq ymm2,ymm6,[rax]",
			"vpsrlvd xmm2{k3}{z},xmm6,xmm3",
			"vpsrlvd xmm2{k3},xmm6,[rax+0x10]",
			"vpsrlvd xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpsrlvd ymm2{k3}{z},ymm6,ymm3",
			"vpsrlvd ymm2{k3},ymm6,[rax+0x20]",
			"vpsrlvd ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpsrlvd zmm2{k3}{z},zmm6,zmm3",
			"vpsrlvd zmm2{k3},zmm6,[rax+0x40]",
			"vpsrlvd zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpsrlvq xmm2{k3}{z},xmm6,xmm3",
			"vpsrlvq xmm2{k3},xmm6,[rax+0x10]",
			"vpsrlvq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpsrlvq ymm2{k3}{z},ymm6,ymm3",
			"vpsrlvq ymm2{k3},ymm6,[rax+0x20]",
			"vpsrlvq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpsrlvq zmm2{k3}{z},zmm6,zmm3",
			"vpsrlvq zmm2{k3},zmm6,[rax+0x40]",
			"vpsrlvq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpsravd xmm2,xmm6,xmm3",
			"vpsravd xmm2,xmm6,[rax]",
			"vpsravd ymm2,ymm6,ymm3",
			"vpsravd ymm2,ymm6,[rax]",
			"vpsravd xmm2{k3}{z},xmm6,xmm3",
			"vpsravd xmm2{k3},xmm6,[rax+0x10]",
			"vpsravd xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpsravd ymm2{k3}{z},ymm6,ymm3",
			"vpsravd ymm2{k3},ymm6,[rax+0x20]",
			"vpsravd ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpsravd zmm2{k3}{z},zmm6,zmm3",
			"vpsravd zmm2{k3},zmm6,[rax+0x40]",
			"vpsravd zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpsravq xmm2{k3}{z},xmm6,xmm3",
			"vpsravq xmm2{k3},xmm6,[rax+0x10]",
			"vpsravq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpsravq ymm2{k3}{z},ymm6,ymm3",
			"vpsravq ymm2{k3},ymm6,[rax+0x20]",
			"vpsravq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpsravq zmm2{k3}{z},zmm6,zmm3",
			"vpsravq zmm2{k3},zmm6,[rax+0x40]",
			"vpsravq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpsllvd xmm2,xmm6,xmm3",
			"vpsllvd xmm2,xmm6,[rax]",
			"vpsllvd ymm2,ymm6,ymm3",
			"vpsllvd ymm2,ymm6,[rax]",
			"vpsllvq xmm2,xmm6,xmm3",
			"vpsllvq xmm2,xmm6,[rax]",
			"vpsllvq ymm2,ymm6,ymm3",
			"vpsllvq ymm2,ymm6,[rax]",
			"vpsllvd xmm2{k3}{z},xmm6,xmm3",
			"vpsllvd xmm2{k3},xmm6,[rax+0x10]",
			"vpsllvd xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpsllvd ymm2{k3}{z},ymm6,ymm3",
			"vpsllvd ymm2{k3},ymm6,[rax+0x20]",
			"vpsllvd ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpsllvd zmm2{k3}{z},zmm6,zmm3",
			"vpsllvd zmm2{k3},zmm6,[rax+0x40]",
			"vpsllvd zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpsllvq xmm2{k3}{z},xmm6,xmm3",
			"vpsllvq xmm2{k3},xmm6,[rax+0x10]",
			"vpsllvq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpsllvq ymm2{k3}{z},ymm6,ymm3",
			"vpsllvq ymm2{k3},ymm6,[rax+0x20]",
			"vpsllvq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpsllvq zmm2{k3}{z},zmm6,zmm3",
			"vpsllvq zmm2{k3},zmm6,[rax+0x40]",
			"vpsllvq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vrcp14ps xmm2{k3}{z},xmm3",
			"vrcp14ps xmm2{k3},[rax+0x10]",
			"vrcp14ps xmm2{k5}{z},[rax+4]{1to4}",
			"vrcp14ps ymm2{k3}{z},ymm3",
			"vrcp14ps ymm2{k3},[rax+0x20]",
			"vrcp14ps ymm2{k5}{z},[rax+4]{1to8}",
			"vrcp14ps zmm2{k3}{z},zmm3",
			"vrcp14ps zmm2{k3},[rax+0x40]",
			"vrcp14ps zmm2{k5}{z},[rax+4]{1to16}",
			"vrcp14pd xmm2{k3}{z},xmm3",
			"vrcp14pd xmm2{k3},[rax+0x10]",
			"vrcp14pd xmm2{k5}{z},[rax+8]{1to2}",
			"vrcp14pd ymm2{k3}{z},ymm3",
			"vrcp14pd ymm2{k3},[rax+0x20]",
			"vrcp14pd ymm2{k5}{z},[rax+8]{1to4}",
			"vrcp14pd zmm2{k3}{z},zmm3",
			"vrcp14pd zmm2{k3},[rax+0x40]",
			"vrcp14pd zmm2{k5}{z},[rax+8]{1to8}",
			"vrcp14ss xmm2{k3},xmm6,xmm3",
			"vrcp14ss xmm2{k3},xmm6,[rax+4]",
			"vrcp14sd xmm2{k3},xmm6,xmm3",
			"vrcp14sd xmm2{k3},xmm6,[rax+8]",
			"vrsqrt14ps xmm2{k3}{z},xmm3",
			"vrsqrt14ps xmm2{k3},[rax+0x10]",
			"vrsqrt14ps xmm2{k5}{z},[rax+4]{1to4}",
			"vrsqrt14ps ymm2{k3}{z},ymm3",
			"vrsqrt14ps ymm2{k3},[rax+0x20]",
			"vrsqrt14ps ymm2{k5}{z},[rax+4]{1to8}",
			"vrsqrt14ps zmm2{k3}{z},zmm3",
			"vrsqrt14ps zmm2{k3},[rax+0x40]",
			"vrsqrt14ps zmm2{k5}{z},[rax+4]{1to16}",
			"vrsqrt14pd xmm2{k3}{z},xmm3",
			"vrsqrt14pd xmm2{k3},[rax+0x10]",
			"vrsqrt14pd xmm2{k5}{z},[rax+8]{1to2}",
			"vrsqrt14pd ymm2{k3}{z},ymm3",
			"vrsqrt14pd ymm2{k3},[rax+0x20]",
			"vrsqrt14pd ymm2{k5}{z},[rax+8]{1to4}",
			"vrsqrt14pd zmm2{k3}{z},zmm3",
			"vrsqrt14pd zmm2{k3},[rax+0x40]",
			"vrsqrt14pd zmm2{k5}{z},[rax+8]{1to8}",
			"vrsqrt14ss xmm2{k3},xmm6,xmm3",
			"vrsqrt14ss xmm2{k3},xmm6,[rax+4]",
			"vrsqrt14sd xmm2{k3},xmm6,xmm3",
			"vrsqrt14sd xmm2{k3},xmm6,[rax+8]",
			"vp4dpwssd zmm2{k3},zmm6,[rax+0x10]",
			"vp4dpwssds zmm2{k3},zmm6,[rax+0x10]",
			"vpbroadcastd xmm1,xmm5",
			"vpbroadcastd xmm2,[rax]",
			"vpbroadcastd ymm1,xmm5",
			"vpbroadcastd ymm2,[rax]",
			"vpbroadcastd xmm2,xmm3",
			"vpbroadcastd xmm2,[rax+4]",
			"vpbroadcastd ymm2,xmm3",
			"vpbroadcastd ymm2,[rax+4]",
			"vpbroadcastd zmm2,xmm3",
			"vpbroadcastd zmm2,[rax+4]",
			"vpbroadcastq xmm1,xmm5",
			"vpbroadcastq xmm2,[rax]",
			"vpbroadcastq ymm1,xmm5",
			"vpbroadcastq ymm2,[rax]",
			"vbroadcasti32x2 xmm2,xmm3",
			"vbroadcasti32x2 xmm2,[rax+8]",
			"vbroadcasti32x2 ymm2,xmm3",
			"vbroadcasti32x2 ymm2,[rax+8]",
			"vbroadcasti32x2 zmm2,xmm3",
			"vbroadcasti32x2 zmm2,[rax+8]",
			"vpbroadcastq xmm2,xmm3",
			"vpbroadcastq xmm2,[rax+8]",
			"vpbroadcastq ymm2,xmm3",
			"vpbroadcastq ymm2,[rax+8]",
			"vpbroadcastq zmm2,xmm3",
			"vpbroadcastq zmm2,[rax+8]",
			"vbroadcasti128 ymm2,[rax]",
			"vbroadcasti32x4 ymm2,[rax+0x10]",
			"vbroadcasti32x4 zmm2,[rax+0x10]",
			"vbroadcasti64x2 ymm2,[rax+0x10]",
			"vbroadcasti64x2 zmm2,[rax+0x10]",
			"vbroadcasti32x8 zmm2,[rax+0x20]",
			"vbroadcasti64x4 zmm2,[rax+0x20]",
			"vpblendmd xmm2{k3}{z},xmm6,xmm3",
			"vpblendmd xmm2{k3},xmm6,[rax+0x10]",
			"vpblendmd xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpblendmd ymm2{k3}{z},ymm6,ymm3",
			"vpblendmd ymm2{k3},ymm6,[rax+0x20]",
			"vpblendmd ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpblendmd zmm2{k3}{z},zmm6,zmm3",
			"vpblendmd zmm2{k3},zmm6,[rax+0x40]",
			"vpblendmd zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpblendmq xmm2{k3}{z},xmm6,xmm3",
			"vpblendmq xmm2{k3},xmm6,[rax+0x10]",
			"vpblendmq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpblendmq ymm2{k3}{z},ymm6,ymm3",
			"vpblendmq ymm2{k3},ymm6,[rax+0x20]",
			"vpblendmq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpblendmq zmm2{k3}{z},zmm6,zmm3",
			"vpblendmq zmm2{k3},zmm6,[rax+0x40]",
			"vpblendmq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vblendmps xmm2{k3}{z},xmm6,xmm3",
			"vblendmps xmm2{k3},xmm6,[rax+0x10]",
			"vblendmps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vblendmps ymm2{k3}{z},ymm6,ymm3",
			"vblendmps ymm2{k3},ymm6,[rax+0x20]",
			"vblendmps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vblendmps zmm2{k3}{z},zmm6,zmm3",
			"vblendmps zmm2{k3},zmm6,[rax+0x40]",
			"vblendmps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vblendmpd xmm2{k3}{z},xmm6,xmm3",
			"vblendmpd xmm2{k3},xmm6,[rax+0x10]",
			"vblendmpd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vblendmpd ymm2{k3}{z},ymm6,ymm3",
			"vblendmpd ymm2{k3},ymm6,[rax+0x20]",
			"vblendmpd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vblendmpd zmm2{k3}{z},zmm6,zmm3",
			"vblendmpd zmm2{k3},zmm6,[rax+0x40]",
			"vblendmpd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpblendmb xmm2{k3},xmm6,xmm3",
			"vpblendmb xmm2{k3},xmm6,[rax+0x10]",
			"vpblendmb ymm2{k3},ymm6,ymm3",
			"vpblendmb ymm2{k3},ymm6,[rax+0x20]",
			"vpblendmb zmm2{k3},zmm6,zmm3",
			"vpblendmb zmm2{k3},zmm6,[rax+0x40]",
			"vpblendmw xmm2{k3},xmm6,xmm3",
			"vpblendmw xmm2{k3},xmm6,[rax+0x10]",
			"vpblendmw ymm2{k3},ymm6,ymm3",
			"vpblendmw ymm2{k3},ymm6,[rax+0x20]",
			"vpblendmw zmm2{k3},zmm6,zmm3",
			"vpblendmw zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2b xmm2{k3},xmm6,xmm3",
			"vpermi2b xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2b ymm2{k3},ymm6,ymm3",
			"vpermi2b ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2b zmm2{k3},zmm6,zmm3",
			"vpermi2b zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2w xmm2{k3},xmm6,xmm3",
			"vpermi2w xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2w ymm2{k3},ymm6,ymm3",
			"vpermi2w ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2w zmm2{k3},zmm6,zmm3",
			"vpermi2w zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2d xmm2{k3}{z},xmm6,xmm3",
			"vpermi2d xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2d xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpermi2d ymm2{k3}{z},ymm6,ymm3",
			"vpermi2d ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2d ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpermi2d zmm2{k3}{z},zmm6,zmm3",
			"vpermi2d zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2d zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpermi2q xmm2{k3}{z},xmm6,xmm3",
			"vpermi2q xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2q xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpermi2q ymm2{k3}{z},ymm6,ymm3",
			"vpermi2q ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2q ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpermi2q zmm2{k3}{z},zmm6,zmm3",
			"vpermi2q zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2q zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpermi2ps xmm2{k3}{z},xmm6,xmm3",
			"vpermi2ps xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpermi2ps ymm2{k3}{z},ymm6,ymm3",
			"vpermi2ps ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpermi2ps zmm2{k3}{z},zmm6,zmm3",
			"vpermi2ps zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpermi2pd xmm2{k3}{z},xmm6,xmm3",
			"vpermi2pd xmm2{k3},xmm6,[rax+0x10]",
			"vpermi2pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpermi2pd ymm2{k3}{z},ymm6,ymm3",
			"vpermi2pd ymm2{k3},ymm6,[rax+0x20]",
			"vpermi2pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpermi2pd zmm2{k3}{z},zmm6,zmm3",
			"vpermi2pd zmm2{k3},zmm6,[rax+0x40]",
			"vpermi2pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpbroadcastb xmm1,xmm5",
			"vpbroadcastb xmm2,[rax]",
			"vpbroadcastb ymm1,xmm5",
			"vpbroadcastb ymm2,[rax]",
			"vpbroadcastb xmm2,xmm3",
			"vpbroadcastb xmm2,[rax+1]",
			"vpbroadcastb ymm2,xmm3",
			"vpbroadcastb ymm2,[rax+1]",
			"vpbroadcastb zmm2,xmm3",
			"vpbroadcastb zmm2,[rax+1]",
			"vpbroadcastw xmm1,xmm5",
			"vpbroadcastw xmm2,[rax]",
			"vpbroadcastw ymm1,xmm5",
			"vpbroadcastw ymm2,[rax]",
			"vpbroadcastw xmm2,xmm3",
			"vpbroadcastw xmm2,[rax+2]",
			"vpbroadcastw ymm2,xmm3",
			"vpbroadcastw ymm2,[rax+2]",
			"vpbroadcastw zmm2,xmm3",
			"vpbroadcastw zmm2,[rax+2]",
			"vpbroadcastb xmm2,ebx",
			"vpbroadcastb ymm2,ebx",
			"vpbroadcastb zmm2,ebx",
			"vpbroadcastw xmm2,ebx",
			"vpbroadcastw ymm2,ebx",
			"vpbroadcastw zmm2,ebx",
			"vpbroadcastd xmm2,ebx",
			"vpbroadcastd ymm2,ebx",
			"vpbroadcastd zmm2,ebx",
			"vpbroadcastq xmm2,rbx",
			"vpbroadcastq ymm2,rbx",
			"vpbroadcastq zmm2,rbx",
			"vpermt2b xmm2{k3},xmm6,xmm3",
			"vpermt2b xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2b ymm2{k3},ymm6,ymm3",
			"vpermt2b ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2b zmm2{k3},zmm6,zmm3",
			"vpermt2b zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2w xmm2{k3},xmm6,xmm3",
			"vpermt2w xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2w ymm2{k3},ymm6,ymm3",
			"vpermt2w ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2w zmm2{k3},zmm6,zmm3",
			"vpermt2w zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2d xmm2{k3}{z},xmm6,xmm3",
			"vpermt2d xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2d xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpermt2d ymm2{k3}{z},ymm6,ymm3",
			"vpermt2d ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2d ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpermt2d zmm2{k3}{z},zmm6,zmm3",
			"vpermt2d zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2d zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpermt2q xmm2{k3}{z},xmm6,xmm3",
			"vpermt2q xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2q xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpermt2q ymm2{k3}{z},ymm6,ymm3",
			"vpermt2q ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2q ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpermt2q zmm2{k3}{z},zmm6,zmm3",
			"vpermt2q zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2q zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpermt2ps xmm2{k3}{z},xmm6,xmm3",
			"vpermt2ps xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vpermt2ps ymm2{k3}{z},ymm6,ymm3",
			"vpermt2ps ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vpermt2ps zmm2{k3}{z},zmm6,zmm3",
			"vpermt2ps zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vpermt2pd xmm2{k3}{z},xmm6,xmm3",
			"vpermt2pd xmm2{k3},xmm6,[rax+0x10]",
			"vpermt2pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpermt2pd ymm2{k3}{z},ymm6,ymm3",
			"vpermt2pd ymm2{k3},ymm6,[rax+0x20]",
			"vpermt2pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpermt2pd zmm2{k3}{z},zmm6,zmm3",
			"vpermt2pd zmm2{k3},zmm6,[rax+0x40]",
			"vpermt2pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"invept rdx,[rax]",
			"invvpid rdx,[rax]",
			"invpcid rdx,[rax]",
			"vpmultishiftqb xmm2{k3}{z},xmm6,xmm3",
			"vpmultishiftqb xmm2{k3},xmm6,[rax+0x10]",
			"vpmultishiftqb xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmultishiftqb ymm2{k3}{z},ymm6,ymm3",
			"vpmultishiftqb ymm2{k3},ymm6,[rax+0x20]",
			"vpmultishiftqb ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmultishiftqb zmm2{k3}{z},zmm6,zmm3",
			"vpmultishiftqb zmm2{k3},zmm6,[rax+0x40]",
			"vpmultishiftqb zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vexpandps xmm2,xmm3",
			"vexpandps xmm2,[rax+4]",
			"vexpandps ymm2,ymm3",
			"vexpandps ymm2,[rax+4]",
			"vexpandps zmm2,zmm3",
			"vexpandps zmm2,[rax+4]",
			"vexpandpd xmm2,xmm3",
			"vexpandpd xmm2,[rax+8]",
			"vexpandpd ymm2,ymm3",
			"vexpandpd ymm2,[rax+8]",
			"vexpandpd zmm2,zmm3",
			"vexpandpd zmm2,[rax+8]",
			"vpexpandd xmm2,xmm3",
			"vpexpandd xmm2,[rax+4]",
			"vpexpandd ymm2,ymm3",
			"vpexpandd ymm2,[rax+4]",
			"vpexpandd zmm2,zmm3",
			"vpexpandd zmm2,[rax+4]",
			"vpexpandq xmm2,xmm3",
			"vpexpandq xmm2,[rax+8]",
			"vpexpandq ymm2,ymm3",
			"vpexpandq ymm2,[rax+8]",
			"vpexpandq zmm2,zmm3",
			"vpexpandq zmm2,[rax+8]",
			"vcompressps xmm3,xmm2",
			"vcompressps [rax+4],xmm2",
			"vcompressps ymm3,ymm2",
			"vcompressps [rax+4],ymm2",
			"vcompressps zmm3,zmm2",
			"vcompressps [rax+4],zmm2",
			"vcompresspd xmm3,xmm2",
			"vcompresspd [rax+8],xmm2",
			"vcompresspd ymm3,ymm2",
			"vcompresspd [rax+8],ymm2",
			"vcompresspd zmm3,zmm2",
			"vcompresspd [rax+8],zmm2",
			"vpcompressd xmm3,xmm2",
			"vpcompressd [rax+4],xmm2",
			"vpcompressd ymm3,ymm2",
			"vpcompressd [rax+4],ymm2",
			"vpcompressd zmm3,zmm2",
			"vpcompressd [rax+4],zmm2",
			"vpcompressq xmm3,xmm2",
			"vpcompressq [rax+8],xmm2",
			"vpcompressq ymm3,ymm2",
			"vpcompressq [rax+8],ymm2",
			"vpcompressq zmm3,zmm2",
			"vpcompressq [rax+8],zmm2",
			"vpmaskmovd xmm2,xmm6,[rax]",
			"vpmaskmovd ymm2,ymm6,[rax]",
			"vpmaskmovq xmm2,xmm6,[rax]",
			"vpmaskmovq ymm2,ymm6,[rax]",
			"vpermb xmm2{k3},xmm6,xmm3",
			"vpermb xmm2{k3},xmm6,[rax+0x10]",
			"vpermb ymm2{k3},ymm6,ymm3",
			"vpermb ymm2{k3},ymm6,[rax+0x20]",
			"vpermb zmm2{k3},zmm6,zmm3",
			"vpermb zmm2{k3},zmm6,[rax+0x40]",
			"vpermw xmm2{k3},xmm6,xmm3",
			"vpermw xmm2{k3},xmm6,[rax+0x10]",
			"vpermw ymm2{k3},ymm6,ymm3",
			"vpermw ymm2{k3},ymm6,[rax+0x20]",
			"vpermw zmm2{k3},zmm6,zmm3",
			"vpermw zmm2{k3},zmm6,[rax+0x40]",
			"vpmaskmovd [rax],xmm6,xmm2",
			"vpmaskmovd [rax],ymm6,ymm2",
			"vpmaskmovq [rax],xmm6,xmm2",
			"vpmaskmovq [rax],ymm6,ymm2",
			"vpgatherdd xmm2,[rcx+xmm4*4+1],xmm6",
			"vpgatherdd ymm2,[rcx+ymm4*4+1],ymm6",
			"vpgatherdq xmm2,[rcx+xmm4*4+1],xmm6",
			"vpgatherdq ymm2,[rcx+xmm4*4+1],ymm6",
			"vpgatherdd xmm2{k3},[rcx+xmm4*4+4]",
			"vpgatherdd ymm2{k3},[rcx+ymm4*4+4]",
			"vpgatherdd zmm2{k3},[rcx+zmm4*4+4]",
			"vpgatherdq xmm2{k3},[rcx+xmm4*4+8]",
			"vpgatherdq ymm2{k3},[rcx+xmm4*4+8]",
			"vpgatherdq zmm2{k3},[rcx+ymm4*4+8]",
			"vpgatherqd xmm2,[rcx+xmm4*4+1],xmm6",
			"vpgatherqd xmm2,[rcx+ymm4*4+1],xmm6",
			"vpgatherqq xmm2,[rcx+xmm4*4+1],xmm6",
			"vpgatherqq ymm2,[rcx+ymm4*4+1],ymm6",
			"vpgatherqd xmm2{k3},[rcx+xmm4*4+4]",
			"vpgatherqd xmm2{k3},[rcx+ymm4*4+4]",
			"vpgatherqd ymm2{k3},[rcx+zmm4*4+4]",
			"vpgatherqq xmm2{k3},[rcx+xmm4*4+8]",
			"vpgatherqq ymm2{k3},[rcx+ymm4*4+8]",
			"vpgatherqq zmm2{k3},[rcx+zmm4*4+8]",
			"vgatherdps xmm2,[rcx+xmm4*4+1],xmm6",
			"vgatherdps ymm2,[rcx+ymm4*4+1],ymm6",
			"vgatherdpd xmm2,[rcx+xmm4*4+1],xmm6",
			"vgatherdpd ymm2,[rcx+xmm4*4+1],ymm6",
			"vgatherdps xmm2{k3},[rcx+xmm4*4+4]",
			"vgatherdps ymm2{k3},[rcx+ymm4*4+4]",
			"vgatherdps zmm2{k3},[rcx+zmm4*4+4]",
			"vgatherdpd xmm2{k3},[rcx+xmm4*4+8]",
			"vgatherdpd ymm2{k3},[rcx+xmm4*4+8]",
			"vgatherdpd zmm2{k3},[rcx+ymm4*4+8]",
			"vgatherqps xmm2,[rcx+xmm4*4+1],xmm6",
			"vgatherqps xmm2,[rcx+ymm4*4+1],xmm6",
			"vgatherqpd xmm2,[rcx+xmm4*4+1],xmm6",
			"vgatherqpd ymm2,[rcx+ymm4*4+1],ymm6",
			"vgatherqps xmm2{k3},[rcx+xmm4*4+4]",
			"vgatherqps xmm2{k3},[rcx+ymm4*4+4]",
			"vgatherqps ymm2{k3},[rcx+zmm4*4+4]",
			"vgatherqpd xmm2{k3},[rcx+xmm4*4+8]",
			"vgatherqpd ymm2{k3},[rcx+ymm4*4+8]",
			"vgatherqpd zmm2{k3},[rcx+zmm4*4+8]",
			"vfmaddsub132ps xmm2,xmm6,xmm3",
			"vfmaddsub132ps xmm2,xmm6,[rax]",
			"vfmaddsub132ps ymm2,ymm6,ymm3",
			"vfmaddsub132ps ymm2,ymm6,[rax]",
			"vfmaddsub132pd xmm2,xmm6,xmm3",
			"vfmaddsub132pd xmm2,xmm6,[rax]",
			"vfmaddsub132pd ymm2,ymm6,ymm3",
			"vfmaddsub132pd ymm2,ymm6,[rax]",
			"vfmaddsub132ps xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmaddsub132ps ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmaddsub132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmaddsub132pd xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmaddsub132pd ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmaddsub132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmsubadd132ps xmm2,xmm6,xmm3",
			"vfmsubadd132ps xmm2,xmm6,[rax]",
			"vfmsubadd132ps ymm2,ymm6,ymm3",
			"vfmsubadd132ps ymm2,ymm6,[rax]",
			"vfmsubadd132pd xmm2,xmm6,xmm3",
			"vfmsubadd132pd xmm2,xmm6,[rax]",
			"vfmsubadd132pd ymm2,ymm6,ymm3",
			"vfmsubadd132pd ymm2,ymm6,[rax]",
			"vfmsubadd132ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsubadd132ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsubadd132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsubadd132pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsubadd132pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsubadd132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd132ps xmm2,xmm6,xmm3",
			"vfmadd132ps xmm2,xmm6,[rax]",
			"vfmadd132ps ymm2,ymm6,ymm3",
			"vfmadd132ps ymm2,ymm6,[rax]",
			"vfmadd132pd xmm2,xmm6,xmm3",
			"vfmadd132pd xmm2,xmm6,[rax]",
			"vfmadd132pd ymm2,ymm6,ymm3",
			"vfmadd132pd ymm2,ymm6,[rax]",
			"vfmadd132ps xmm2{k3}{z},xmm6,xmm3",
			"vfmadd132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmadd132ps ymm2{k3}{z},ymm6,ymm3",
			"vfmadd132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmadd132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmadd132pd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmadd132pd ymm2{k3}{z},ymm6,ymm3",
			"vfmadd132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmadd132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd132ss xmm2,xmm6,xmm3",
			"vfmadd132ss xmm2,xmm6,[rax]",
			"vfmadd132sd xmm2,xmm6,xmm3",
			"vfmadd132sd xmm2,xmm6,[rax]",
			"vfmadd132ss xmm2{k3}{z},xmm6,xmm3",
			"vfmadd132ss xmm2{k3},xmm6,[rax+4]",
			"vfmadd132sd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd132sd xmm2{k3},xmm6,[rax+8]",
			"vfmsub132ps xmm2,xmm6,xmm3",
			"vfmsub132ps xmm2,xmm6,[rax]",
			"vfmsub132ps ymm2,ymm6,ymm3",
			"vfmsub132ps ymm2,ymm6,[rax]",
			"vfmsub132pd xmm2,xmm6,xmm3",
			"vfmsub132pd xmm2,xmm6,[rax]",
			"vfmsub132pd ymm2,ymm6,ymm3",
			"vfmsub132pd ymm2,ymm6,[rax]",
			"vfmsub132ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsub132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsub132ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsub132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsub132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsub132pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsub132pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsub132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsub132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"v4fmaddps zmm2{k3},zmm6,[rax+0x10]",
			"vfmsub132ss xmm2,xmm6,xmm3",
			"vfmsub132ss xmm2,xmm6,[rax]",
			"vfmsub132sd xmm2,xmm6,xmm3",
			"vfmsub132sd xmm2,xmm6,[rax]",
			"vfmsub132ss xmm2{k3}{z},xmm6,xmm3",
			"vfmsub132ss xmm2{k3},xmm6,[rax+4]",
			"vfmsub132sd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub132sd xmm2{k3},xmm6,[rax+8]",
			"v4fmaddss xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd132ps xmm2,xmm6,xmm3",
			"vfnmadd132ps xmm2,xmm6,[rax]",
			"vfnmadd132ps ymm2,ymm6,ymm3",
			"vfnmadd132ps ymm2,ymm6,[rax]",
			"vfnmadd132pd xmm2,xmm6,xmm3",
			"vfnmadd132pd xmm2,xmm6,[rax]",
			"vfnmadd132pd ymm2,ymm6,ymm3",
			"vfnmadd132pd ymm2,ymm6,[rax]",
			"vfnmadd132ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmadd132ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmadd132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmadd132pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmadd132pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmadd132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmadd132ss xmm2,xmm6,xmm3",
			"vfnmadd132ss xmm2,xmm6,[rax]",
			"vfnmadd132sd xmm2,xmm6,xmm3",
			"vfnmadd132sd xmm2,xmm6,[rax]",
			"vfnmadd132ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd132ss xmm2{k3},xmm6,[rax+4]",
			"vfnmadd132sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd132sd xmm2{k3},xmm6,[rax+8]",
			"vfnmsub132ps xmm2,xmm6,xmm3",
			"vfnmsub132ps xmm2,xmm6,[rax]",
			"vfnmsub132ps ymm2,ymm6,ymm3",
			"vfnmsub132ps ymm2,ymm6,[rax]",
			"vfnmsub132pd xmm2,xmm6,xmm3",
			"vfnmsub132pd xmm2,xmm6,[rax]",
			"vfnmsub132pd ymm2,ymm6,ymm3",
			"vfnmsub132pd ymm2,ymm6,[rax]",
			"vfnmsub132ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub132ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub132ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmsub132ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub132ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub132ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmsub132ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub132ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub132ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmsub132pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub132pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub132pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmsub132pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub132pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub132pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmsub132pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub132pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub132pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmsub132ss xmm2,xmm6,xmm3",
			"vfnmsub132ss xmm2,xmm6,[rax]",
			"vfnmsub132sd xmm2,xmm6,xmm3",
			"vfnmsub132sd xmm2,xmm6,[rax]",
			"vfnmsub132ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub132ss xmm2{k3},xmm6,[rax+4]",
			"vfnmsub132sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub132sd xmm2{k3},xmm6,[rax+8]",
			"vpscatterdd [rcx+xmm4*4+4]{k3},xmm2",
			"vpscatterdd [rcx+ymm4*4+4]{k3},ymm2",
			"vpscatterdd [rcx+zmm4*4+4]{k3},zmm2",
			"vpscatterdq [rcx+xmm4*4+8]{k3},xmm2",
			"vpscatterdq [rcx+xmm4*4+8]{k3},ymm2",
			"vpscatterdq [rcx+ymm4*4+8]{k3},zmm2",
			"vpscatterqd [rcx+xmm4*4+4]{k3},xmm2",
			"vpscatterqd [rcx+ymm4*4+4]{k3},xmm2",
			"vpscatterqd [rcx+zmm4*4+4]{k3},ymm2",
			"vpscatterqq [rcx+xmm4*4+8]{k3},xmm2",
			"vpscatterqq [rcx+ymm4*4+8]{k3},ymm2",
			"vpscatterqq [rcx+zmm4*4+8]{k3},zmm2",
			"vscatterdps [rcx+xmm4*4+4]{k3},xmm2",
			"vscatterdps [rcx+ymm4*4+4]{k3},ymm2",
			"vscatterdps [rcx+zmm4*4+4]{k3},zmm2",
			"vscatterdpd [rcx+xmm4*4+8]{k3},xmm2",
			"vscatterdpd [rcx+xmm4*4+8]{k3},ymm2",
			"vscatterdpd [rcx+ymm4*4+8]{k3},zmm2",
			"vscatterqps [rcx+xmm4*4+4]{k3},xmm2",
			"vscatterqps [rcx+ymm4*4+4]{k3},xmm2",
			"vscatterqps [rcx+zmm4*4+4]{k3},ymm2",
			"vscatterqpd [rcx+xmm4*4+8]{k3},xmm2",
			"vscatterqpd [rcx+ymm4*4+8]{k3},ymm2",
			"vscatterqpd [rcx+zmm4*4+8]{k3},zmm2",
			"vfmaddsub213ps xmm2,xmm6,xmm3",
			"vfmaddsub213ps xmm2,xmm6,[rax]",
			"vfmaddsub213ps ymm2,ymm6,ymm3",
			"vfmaddsub213ps ymm2,ymm6,[rax]",
			"vfmaddsub213pd xmm2,xmm6,xmm3",
			"vfmaddsub213pd xmm2,xmm6,[rax]",
			"vfmaddsub213pd ymm2,ymm6,ymm3",
			"vfmaddsub213pd ymm2,ymm6,[rax]",
			"vfmaddsub213ps xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmaddsub213ps ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmaddsub213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmaddsub213pd xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmaddsub213pd ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmaddsub213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmsubadd213ps xmm2,xmm6,xmm3",
			"vfmsubadd213ps xmm2,xmm6,[rax]",
			"vfmsubadd213ps ymm2,ymm6,ymm3",
			"vfmsubadd213ps ymm2,ymm6,[rax]",
			"vfmsubadd213pd xmm2,xmm6,xmm3",
			"vfmsubadd213pd xmm2,xmm6,[rax]",
			"vfmsubadd213pd ymm2,ymm6,ymm3",
			"vfmsubadd213pd ymm2,ymm6,[rax]",
			"vfmsubadd213ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsubadd213ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsubadd213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsubadd213pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsubadd213pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsubadd213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd213ps xmm2,xmm6,xmm3",
			"vfmadd213ps xmm2,xmm6,[rax]",
			"vfmadd213ps ymm2,ymm6,ymm3",
			"vfmadd213ps ymm2,ymm6,[rax]",
			"vfmadd213pd xmm2,xmm6,xmm3",
			"vfmadd213pd xmm2,xmm6,[rax]",
			"vfmadd213pd ymm2,ymm6,ymm3",
			"vfmadd213pd ymm2,ymm6,[rax]",
			"vfmadd213ps xmm2{k3}{z},xmm6,xmm3",
			"vfmadd213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmadd213ps ymm2{k3}{z},ymm6,ymm3",
			"vfmadd213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmadd213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmadd213pd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmadd213pd ymm2{k3}{z},ymm6,ymm3",
			"vfmadd213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmadd213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd213ss xmm2,xmm6,xmm3",
			"vfmadd213ss xmm2,xmm6,[rax]",
			"vfmadd213sd xmm2,xmm6,xmm3",
			"vfmadd213sd xmm2,xmm6,[rax]",
			"vfmadd213ss xmm2{k3}{z},xmm6,xmm3",
			"vfmadd213ss xmm2{k3},xmm6,[rax+4]",
			"vfmadd213sd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd213sd xmm2{k3},xmm6,[rax+8]",
			"vfmsub213ps xmm2,xmm6,xmm3",
			"vfmsub213ps xmm2,xmm6,[rax]",
			"vfmsub213ps ymm2,ymm6,ymm3",
			"vfmsub213ps ymm2,ymm6,[rax]",
			"vfmsub213pd xmm2,xmm6,xmm3",
			"vfmsub213pd xmm2,xmm6,[rax]",
			"vfmsub213pd ymm2,ymm6,ymm3",
			"vfmsub213pd ymm2,ymm6,[rax]",
			"vfmsub213ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsub213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsub213ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsub213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsub213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsub213pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsub213pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsub213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsub213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"v4fnmaddps zmm2{k3},zmm6,[rax+0x10]",
			"vfmsub213ss xmm2,xmm6,xmm3",
			"vfmsub213ss xmm2,xmm6,[rax]",
			"vfmsub213sd xmm2,xmm6,xmm3",
			"vfmsub213sd xmm2,xmm6,[rax]",
			"vfmsub213ss xmm2{k3}{z},xmm6,xmm3",
			"vfmsub213ss xmm2{k3},xmm6,[rax+4]",
			"vfmsub213sd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub213sd xmm2{k3},xmm6,[rax+8]",
			"v4fnmaddss xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd213ps xmm2,xmm6,xmm3",
			"vfnmadd213ps xmm2,xmm6,[rax]",
			"vfnmadd213ps ymm2,ymm6,ymm3",
			"vfnmadd213ps ymm2,ymm6,[rax]",
			"vfnmadd213pd xmm2,xmm6,xmm3",
			"vfnmadd213pd xmm2,xmm6,[rax]",
			"vfnmadd213pd ymm2,ymm6,ymm3",
			"vfnmadd213pd ymm2,ymm6,[rax]",
			"vfnmadd213ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmadd213ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmadd213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmadd213pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmadd213pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmadd213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmadd213ss xmm2,xmm6,xmm3",
			"vfnmadd213ss xmm2,xmm6,[rax]",
			"vfnmadd213sd xmm2,xmm6,xmm3",
			"vfnmadd213sd xmm2,xmm6,[rax]",
			"vfnmadd213ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd213ss xmm2{k3},xmm6,[rax+4]",
			"vfnmadd213sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd213sd xmm2{k3},xmm6,[rax+8]",
			"vfnmsub213ps xmm2,xmm6,xmm3",
			"vfnmsub213ps xmm2,xmm6,[rax]",
			"vfnmsub213ps ymm2,ymm6,ymm3",
		};
	}
}
#endif
