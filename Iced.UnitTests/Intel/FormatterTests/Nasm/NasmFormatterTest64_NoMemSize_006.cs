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
	public sealed class NasmFormatterTest64_NoMemSize_006 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_006.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_006.AllInfos_Length] {
			"vfnmsub213ps ymm2,ymm6,[rax]",
			"vfnmsub213pd xmm2,xmm6,xmm3",
			"vfnmsub213pd xmm2,xmm6,[rax]",
			"vfnmsub213pd ymm2,ymm6,ymm3",
			"vfnmsub213pd ymm2,ymm6,[rax]",
			"vfnmsub213ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub213ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub213ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmsub213ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub213ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub213ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmsub213ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub213ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub213ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmsub213pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub213pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub213pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmsub213pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub213pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub213pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmsub213pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub213pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub213pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmsub213ss xmm2,xmm6,xmm3",
			"vfnmsub213ss xmm2,xmm6,[rax]",
			"vfnmsub213sd xmm2,xmm6,xmm3",
			"vfnmsub213sd xmm2,xmm6,[rax]",
			"vfnmsub213ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub213ss xmm2{k3},xmm6,[rax+4]",
			"vfnmsub213sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub213sd xmm2{k3},xmm6,[rax+8]",
			"vpmadd52luq xmm2{k3}{z},xmm6,xmm3",
			"vpmadd52luq xmm2{k3},xmm6,[rax+0x10]",
			"vpmadd52luq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmadd52luq ymm2{k3}{z},ymm6,ymm3",
			"vpmadd52luq ymm2{k3},ymm6,[rax+0x20]",
			"vpmadd52luq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmadd52luq zmm2{k3}{z},zmm6,zmm3",
			"vpmadd52luq zmm2{k3},zmm6,[rax+0x40]",
			"vpmadd52luq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vpmadd52huq xmm2{k3}{z},xmm6,xmm3",
			"vpmadd52huq xmm2{k3},xmm6,[rax+0x10]",
			"vpmadd52huq xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vpmadd52huq ymm2{k3}{z},ymm6,ymm3",
			"vpmadd52huq ymm2{k3},ymm6,[rax+0x20]",
			"vpmadd52huq ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vpmadd52huq zmm2{k3}{z},zmm6,zmm3",
			"vpmadd52huq zmm2{k3},zmm6,[rax+0x40]",
			"vpmadd52huq zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmaddsub231ps xmm2,xmm6,xmm3",
			"vfmaddsub231ps xmm2,xmm6,[rax]",
			"vfmaddsub231ps ymm2,ymm6,ymm3",
			"vfmaddsub231ps ymm2,ymm6,[rax]",
			"vfmaddsub231pd xmm2,xmm6,xmm3",
			"vfmaddsub231pd xmm2,xmm6,[rax]",
			"vfmaddsub231pd ymm2,ymm6,ymm3",
			"vfmaddsub231pd ymm2,ymm6,[rax]",
			"vfmaddsub231ps xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmaddsub231ps ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmaddsub231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmaddsub231pd xmm2{k3}{z},xmm6,xmm3",
			"vfmaddsub231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmaddsub231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmaddsub231pd ymm2{k3}{z},ymm6,ymm3",
			"vfmaddsub231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmaddsub231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmaddsub231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmaddsub231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmaddsub231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmsubadd231ps xmm2,xmm6,xmm3",
			"vfmsubadd231ps xmm2,xmm6,[rax]",
			"vfmsubadd231ps ymm2,ymm6,ymm3",
			"vfmsubadd231ps ymm2,ymm6,[rax]",
			"vfmsubadd231pd xmm2,xmm6,xmm3",
			"vfmsubadd231pd xmm2,xmm6,[rax]",
			"vfmsubadd231pd ymm2,ymm6,ymm3",
			"vfmsubadd231pd ymm2,ymm6,[rax]",
			"vfmsubadd231ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsubadd231ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsubadd231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsubadd231pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsubadd231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsubadd231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsubadd231pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsubadd231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsubadd231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsubadd231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsubadd231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsubadd231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd231ps xmm2,xmm6,xmm3",
			"vfmadd231ps xmm2,xmm6,[rax]",
			"vfmadd231ps ymm2,ymm6,ymm3",
			"vfmadd231ps ymm2,ymm6,[rax]",
			"vfmadd231pd xmm2,xmm6,xmm3",
			"vfmadd231pd xmm2,xmm6,[rax]",
			"vfmadd231pd ymm2,ymm6,ymm3",
			"vfmadd231pd ymm2,ymm6,[rax]",
			"vfmadd231ps xmm2{k3}{z},xmm6,xmm3",
			"vfmadd231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmadd231ps ymm2{k3}{z},ymm6,ymm3",
			"vfmadd231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmadd231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmadd231pd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmadd231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmadd231pd ymm2{k3}{z},ymm6,ymm3",
			"vfmadd231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmadd231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmadd231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmadd231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmadd231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmadd231ss xmm2,xmm6,xmm3",
			"vfmadd231ss xmm2,xmm6,[rax]",
			"vfmadd231sd xmm2,xmm6,xmm3",
			"vfmadd231sd xmm2,xmm6,[rax]",
			"vfmadd231ss xmm2{k3}{z},xmm6,xmm3",
			"vfmadd231ss xmm2{k3},xmm6,[rax+4]",
			"vfmadd231sd xmm2{k3}{z},xmm6,xmm3",
			"vfmadd231sd xmm2{k3},xmm6,[rax+8]",
			"vfmsub231ps xmm2,xmm6,xmm3",
			"vfmsub231ps xmm2,xmm6,[rax]",
			"vfmsub231ps ymm2,ymm6,ymm3",
			"vfmsub231ps ymm2,ymm6,[rax]",
			"vfmsub231pd xmm2,xmm6,xmm3",
			"vfmsub231pd xmm2,xmm6,[rax]",
			"vfmsub231pd ymm2,ymm6,ymm3",
			"vfmsub231pd ymm2,ymm6,[rax]",
			"vfmsub231ps xmm2{k3}{z},xmm6,xmm3",
			"vfmsub231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfmsub231ps ymm2{k3}{z},ymm6,ymm3",
			"vfmsub231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfmsub231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfmsub231pd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfmsub231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfmsub231pd ymm2{k3}{z},ymm6,ymm3",
			"vfmsub231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfmsub231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfmsub231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfmsub231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfmsub231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfmsub231ss xmm2,xmm6,xmm3",
			"vfmsub231ss xmm2,xmm6,[rax]",
			"vfmsub231sd xmm2,xmm6,xmm3",
			"vfmsub231sd xmm2,xmm6,[rax]",
			"vfmsub231ss xmm2{k3}{z},xmm6,xmm3",
			"vfmsub231ss xmm2{k3},xmm6,[rax+4]",
			"vfmsub231sd xmm2{k3}{z},xmm6,xmm3",
			"vfmsub231sd xmm2{k3},xmm6,[rax+8]",
			"vfnmadd231ps xmm2,xmm6,xmm3",
			"vfnmadd231ps xmm2,xmm6,[rax]",
			"vfnmadd231ps ymm2,ymm6,ymm3",
			"vfnmadd231ps ymm2,ymm6,[rax]",
			"vfnmadd231pd xmm2,xmm6,xmm3",
			"vfnmadd231pd xmm2,xmm6,[rax]",
			"vfnmadd231pd ymm2,ymm6,ymm3",
			"vfnmadd231pd ymm2,ymm6,[rax]",
			"vfnmadd231ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmadd231ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmadd231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmadd231pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmadd231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmadd231pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmadd231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmadd231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmadd231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmadd231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmadd231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmadd231ss xmm2,xmm6,xmm3",
			"vfnmadd231ss xmm2,xmm6,[rax]",
			"vfnmadd231sd xmm2,xmm6,xmm3",
			"vfnmadd231sd xmm2,xmm6,[rax]",
			"vfnmadd231ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd231ss xmm2{k3},xmm6,[rax+4]",
			"vfnmadd231sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmadd231sd xmm2{k3},xmm6,[rax+8]",
			"vfnmsub231ps xmm2,xmm6,xmm3",
			"vfnmsub231ps xmm2,xmm6,[rax]",
			"vfnmsub231ps ymm2,ymm6,ymm3",
			"vfnmsub231ps ymm2,ymm6,[rax]",
			"vfnmsub231pd xmm2,xmm6,xmm3",
			"vfnmsub231pd xmm2,xmm6,[rax]",
			"vfnmsub231pd ymm2,ymm6,ymm3",
			"vfnmsub231pd ymm2,ymm6,[rax]",
			"vfnmsub231ps xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub231ps xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub231ps xmm2{k5}{z},xmm6,[rax+4]{1to4}",
			"vfnmsub231ps ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub231ps ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub231ps ymm2{k5}{z},ymm6,[rax+4]{1to8}",
			"vfnmsub231ps zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub231ps zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub231ps zmm2{k5}{z},zmm6,[rax+4]{1to16}",
			"vfnmsub231pd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub231pd xmm2{k3},xmm6,[rax+0x10]",
			"vfnmsub231pd xmm2{k5}{z},xmm6,[rax+8]{1to2}",
			"vfnmsub231pd ymm2{k3}{z},ymm6,ymm3",
			"vfnmsub231pd ymm2{k3},ymm6,[rax+0x20]",
			"vfnmsub231pd ymm2{k5}{z},ymm6,[rax+8]{1to4}",
			"vfnmsub231pd zmm2{k3}{z},zmm6,zmm3,{ru-sae}",
			"vfnmsub231pd zmm2{k3},zmm6,[rax+0x40]",
			"vfnmsub231pd zmm2{k5}{z},zmm6,[rax+8]{1to8}",
			"vfnmsub231ss xmm2,xmm6,xmm3",
			"vfnmsub231ss xmm2,xmm6,[rax]",
			"vfnmsub231sd xmm2,xmm6,xmm3",
			"vfnmsub231sd xmm2,xmm6,[rax]",
			"vfnmsub231ss xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub231ss xmm2{k3},xmm6,[rax+4]",
			"vfnmsub231sd xmm2{k3}{z},xmm6,xmm3",
			"vfnmsub231sd xmm2{k3},xmm6,[rax+8]",
			"vpconflictd xmm2{k3}{z},xmm3",
			"vpconflictd xmm2{k3},[rax+0x10]",
			"vpconflictd xmm2{k5}{z},[rax+4]{1to4}",
			"vpconflictd ymm2{k3}{z},ymm3",
			"vpconflictd ymm2{k3},[rax+0x20]",
			"vpconflictd ymm2{k5}{z},[rax+4]{1to8}",
			"vpconflictd zmm2{k3}{z},zmm3",
			"vpconflictd zmm2{k3},[rax+0x40]",
			"vpconflictd zmm2{k5}{z},[rax+4]{1to16}",
			"vpconflictq xmm2{k3}{z},xmm3",
			"vpconflictq xmm2{k3},[rax+0x10]",
			"vpconflictq xmm2{k5}{z},[rax+8]{1to2}",
			"vpconflictq ymm2{k3}{z},ymm3",
			"vpconflictq ymm2{k3},[rax+0x20]",
			"vpconflictq ymm2{k5}{z},[rax+8]{1to4}",
			"vpconflictq zmm2{k3}{z},zmm3",
			"vpconflictq zmm2{k3},[rax+0x40]",
			"vpconflictq zmm2{k5}{z},[rax+8]{1to8}",
			"sha1nexte xmm1,xmm5",
			"sha1nexte xmm1,[rax]",
			"sha1msg1 xmm1,xmm5",
			"sha1msg1 xmm1,[rax]",
			"sha1msg2 xmm1,xmm5",
			"sha1msg2 xmm1,[rax]",
			"sha256rnds2 xmm1,xmm5,xmm0",
			"sha256rnds2 xmm1,[rax],xmm0",
			"sha256msg1 xmm1,xmm5",
			"sha256msg1 xmm1,[rax]",
			"sha256msg2 xmm1,xmm5",
			"sha256msg2 xmm1,[rax]",
			"vgatherpf0dps [rcx+zmm4*4+4]{k3}",
			"vgatherpf0dpd [rcx+ymm4*4+8]{k3}",
			"vgatherpf1dps [rcx+zmm4*4+4]{k3}",
			"vgatherpf1dpd [rcx+ymm4*4+8]{k3}",
			"vscatterpf0dps [rcx+zmm4*4+4]{k3}",
			"vscatterpf0dpd [rcx+ymm4*4+8]{k3}",
			"vscatterpf1dps [rcx+zmm4*4+4]{k3}",
			"vscatterpf1dpd [rcx+ymm4*4+8]{k3}",
			"vgatherpf0qps [rcx+zmm4*4+4]{k3}",
			"vgatherpf0qpd [rcx+zmm4*4+8]{k3}",
			"vgatherpf1qps [rcx+zmm4*4+4]{k3}",
			"vgatherpf1qpd [rcx+zmm4*4+8]{k3}",
			"vscatterpf0qps [rcx+zmm4*4+4]{k3}",
			"vscatterpf0qpd [rcx+zmm4*4+8]{k3}",
			"vscatterpf1qps [rcx+zmm4*4+4]{k3}",
			"vscatterpf1qpd [rcx+zmm4*4+8]{k3}",
			"vexp2ps zmm2{k3},zmm3",
			"vexp2ps zmm2,[rax+0x40]",
			"vexp2ps zmm2{k3}{z},[rax+4]{1to16}",
			"vexp2pd zmm2{k3},zmm3",
			"vexp2pd zmm2,[rax+0x40]",
			"vexp2pd zmm2{k3}{z},[rax+8]{1to8}",
			"vrcp28ps zmm2{k3},zmm3",
			"vrcp28ps zmm2,[rax+0x40]",
			"vrcp28ps zmm2{k3}{z},[rax+4]{1to16}",
			"vrcp28pd zmm2{k3},zmm3",
			"vrcp28pd zmm2,[rax+0x40]",
			"vrcp28pd zmm2{k3}{z},[rax+8]{1to8}",
			"vrcp28ss xmm2{k3},xmm6,xmm3",
			"vrcp28ss xmm2{k3},xmm6,[rax+4]",
			"vrcp28sd xmm2{k3}{z},xmm6,xmm3",
			"vrcp28sd xmm2{k3},xmm6,[rax+8]",
			"vrsqrt28ps zmm2{k3},zmm3",
			"vrsqrt28ps zmm2,[rax+0x40]",
			"vrsqrt28ps zmm2{k3}{z},[rax+4]{1to16}",
			"vrsqrt28pd zmm2{k3},zmm3",
			"vrsqrt28pd zmm2,[rax+0x40]",
			"vrsqrt28pd zmm2{k3}{z},[rax+8]{1to8}",
			"vrsqrt28ss xmm2{k3},xmm6,xmm3",
			"vrsqrt28ss xmm2{k3},xmm6,[rax+4]",
			"vrsqrt28sd xmm2{k3}{z},xmm6,xmm3",
			"vrsqrt28sd xmm2{k3},xmm6,[rax+8]",
			"aesimc xmm1,xmm5",
			"aesimc xmm1,[rax]",
			"vaesimc xmm2,xmm3",
			"vaesimc xmm2,[rax]",
			"aesenc xmm1,xmm5",
			"aesenc xmm1,[rax]",
			"vaesenc xmm2,xmm6,xmm3",
			"vaesenc xmm2,xmm6,[rax]",
			"aesenclast xmm1,xmm5",
			"aesenclast xmm1,[rax]",
			"vaesenclast xmm2,xmm6,xmm3",
			"vaesenclast xmm2,xmm6,[rax]",
			"aesdec xmm1,xmm5",
			"aesdec xmm1,[rax]",
			"vaesdec xmm2,xmm6,xmm3",
			"vaesdec xmm2,xmm6,[rax]",
			"aesdeclast xmm1,xmm5",
			"aesdeclast xmm1,[rax]",
			"vaesdeclast xmm2,xmm6,xmm3",
			"vaesdeclast xmm2,xmm6,[rax]",
			"movbe bx,[rax]",
			"movbe ebx,[rax]",
			"movbe rbx,[rax]",
			"movbe [rax],bx",
			"movbe [rax],ebx",
			"movbe [rax],rbx",
			"crc32 ecx,dh",
			"crc32 ebx,byte [rax]",
			"crc32 rcx,sil",
			"crc32 rbx,byte [rax]",
			"crc32 ecx,si",
			"crc32 ebx,word [rax]",
			"crc32 ecx,esi",
			"crc32 ebx,dword [rax]",
			"crc32 rcx,rsi",
			"crc32 rbx,qword [rax]",
			"andn edx,esi,ebx",
			"andn edx,esi,[rax]",
			"andn rdx,rsi,rbx",
			"andn rdx,rsi,[rax]",
			"blsr esi,ebx",
			"blsr esi,[rax]",
			"blsr rsi,rbx",
			"blsr rsi,[rax]",
			"blsmsk esi,ebx",
			"blsmsk esi,[rax]",
			"blsmsk rsi,rbx",
			"blsmsk rsi,[rax]",
			"blsi esi,ebx",
			"blsi esi,[rax]",
			"blsi rsi,rbx",
			"blsi rsi,[rax]",
			"bzhi edx,ebx,esi",
			"bzhi edx,[rax],esi",
			"bzhi rdx,rbx,rsi",
			"bzhi rdx,[rax],rsi",
			"pext edx,esi,ebx",
			"pext edx,esi,[rax]",
			"pext rdx,rsi,rbx",
			"pext rdx,rsi,[rax]",
			"pdep edx,esi,ebx",
			"pdep edx,esi,[rax]",
			"pdep rdx,rsi,rbx",
			"pdep rdx,rsi,[rax]",
			"adcx ecx,esi",
			"adcx ebx,[rax]",
			"adcx rcx,rsi",
			"adcx rbx,[rax]",
			"adox ecx,esi",
			"adox ebx,[rax]",
			"adox rcx,rsi",
			"adox rbx,[rax]",
			"mulx edx,esi,ebx",
			"mulx edx,esi,[rax]",
			"mulx rdx,rsi,rbx",
			"mulx rdx,rsi,[rax]",
			"bextr edx,ebx,esi",
			"bextr edx,[rax],esi",
			"bextr rdx,rbx,rsi",
			"bextr rdx,[rax],rsi",
			"shlx edx,ebx,esi",
			"shlx edx,[rax],esi",
			"shlx rdx,rbx,rsi",
			"shlx rdx,[rax],rsi",
			"sarx edx,ebx,esi",
			"sarx edx,[rax],esi",
			"sarx rdx,rbx,rsi",
			"sarx rdx,[rax],rsi",
			"shrx edx,ebx,esi",
			"shrx edx,[rax],esi",
			"shrx rdx,rbx,rsi",
			"shrx rdx,[rax],rsi",
			"vpermq ymm2,ymm3,0xa5",
			"vpermq ymm2,[rax],0xa5",
			"vpermq ymm2{k3}{z},ymm3,0xa5",
			"vpermq ymm2{k3}{z},[rax+0x20],0xa5",
			"vpermq ymm2{k5},[rax+8]{1to4},0xa5",
			"vpermq zmm2{k3}{z},zmm3,0xa5",
			"vpermq zmm2{k3}{z},[rax+0x40],0xa5",
			"vpermq zmm2{k5},[rax+8]{1to8},0xa5",
			"vpermpd ymm2,ymm3,0xa5",
			"vpermpd ymm2,[rax],0xa5",
			"vpermpd ymm2{k3}{z},ymm3,0xa5",
			"vpermpd ymm2{k3}{z},[rax+0x20],0xa5",
			"vpermpd ymm2{k5},[rax+8]{1to4},0xa5",
			"vpermpd zmm2{k3}{z},zmm3,0xa5",
			"vpermpd zmm2{k3}{z},[rax+0x40],0xa5",
			"vpermpd zmm2{k5},[rax+8]{1to8},0xa5",
			"vpblendd xmm2,xmm6,xmm3,0xa5",
			"vpblendd xmm2,xmm6,[rax],0xa5",
			"vpblendd ymm2,ymm6,ymm3,0xa5",
			"vpblendd ymm2,ymm6,[rax],0xa5",
			"valignd xmm2{k3},xmm6,xmm3,0xa5",
			"valignd xmm2{k3},xmm6,[rax+0x10],0xa5",
			"valignd xmm2{k5}{z},xmm6,[rax+4]{1to4},0xa5",
			"valignd ymm2{k3},ymm6,ymm3,0xa5",
			"valignd ymm2{k3},ymm6,[rax+0x20],0xa5",
			"valignd ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"valignd zmm2{k3},zmm6,zmm3,0xa5",
			"valignd zmm2{k3},zmm6,[rax+0x40],0xa5",
			"valignd zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"valignq xmm2{k3}{z},xmm6,xmm3,0xa5",
			"valignq xmm2{k3},xmm6,[rax+0x10],0xa5",
			"valignq xmm2{k5}{z},xmm6,[rax+8]{1to2},0xa5",
			"valignq ymm2{k3}{z},ymm6,ymm3,0xa5",
			"valignq ymm2{k3},ymm6,[rax+0x20],0xa5",
			"valignq ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"valignq zmm2{k3}{z},zmm6,zmm3,0xa5",
			"valignq zmm2{k3},zmm6,[rax+0x40],0xa5",
			"valignq zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"vpermilps xmm2,xmm3,0xa5",
			"vpermilps xmm2,[rax],0xa5",
			"vpermilps ymm2,ymm3,0xa5",
			"vpermilps ymm2,[rax],0xa5",
			"vpermilps xmm2{k3}{z},xmm3,0xa5",
			"vpermilps xmm2{k3}{z},[rax+0x10],0xa5",
			"vpermilps xmm2{k5},[rax+4]{1to4},0xa5",
			"vpermilps ymm2{k3}{z},ymm3,0xa5",
			"vpermilps ymm2{k3}{z},[rax+0x20],0xa5",
			"vpermilps ymm2{k5},[rax+4]{1to8},0xa5",
			"vpermilps zmm2{k3}{z},zmm3,0xa5",
			"vpermilps zmm2{k3}{z},[rax+0x40],0xa5",
			"vpermilps zmm2{k5},[rax+4]{1to16},0xa5",
			"vpermilpd xmm2,xmm3,0xa5",
			"vpermilpd xmm2,[rax],0xa5",
			"vpermilpd ymm2,ymm3,0xa5",
			"vpermilpd ymm2,[rax],0xa5",
			"vpermilpd xmm2{k3}{z},xmm3,0xa5",
			"vpermilpd xmm2{k3}{z},[rax+0x10],0xa5",
			"vpermilpd xmm2{k5},[rax+8]{1to2},0xa5",
			"vpermilpd ymm2{k3}{z},ymm3,0xa5",
			"vpermilpd ymm2{k3}{z},[rax+0x20],0xa5",
			"vpermilpd ymm2{k5},[rax+8]{1to4},0xa5",
			"vpermilpd zmm2{k3}{z},zmm3,0xa5",
			"vpermilpd zmm2{k3}{z},[rax+0x40],0xa5",
			"vpermilpd zmm2{k5},[rax+8]{1to8},0xa5",
			"vperm2f128 ymm2,ymm6,ymm3,0xa5",
			"vperm2f128 ymm2,ymm6,[rax],0xa5",
			"roundps xmm1,xmm5,0xa5",
			"roundps xmm1,[rax],0xa5",
			"vroundps xmm2,xmm3,0xa5",
			"vroundps xmm2,[rax],0xa5",
			"vroundps ymm2,ymm3,0xa5",
			"vroundps ymm2,[rax],0xa5",
			"vrndscaleps xmm2{k3},xmm3,0xa5",
			"vrndscaleps xmm2,[rax+0x10],0xa5",
			"vrndscaleps xmm2{k3}{z},[rax+4]{1to4},0xa5",
			"vrndscaleps ymm2{k3},ymm3,0xa5",
			"vrndscaleps ymm2,[rax+0x20],0xa5",
			"vrndscaleps ymm2{k3}{z},[rax+4]{1to8},0xa5",
			"vrndscaleps zmm2{k3},zmm3,0xa5",
			"vrndscaleps zmm2,[rax+0x40],0xa5",
			"vrndscaleps zmm2{k3}{z},[rax+4]{1to16},0xa5",
			"roundpd xmm1,xmm5,0xa5",
			"roundpd xmm1,[rax],0xa5",
			"vroundpd xmm2,xmm3,0xa5",
			"vroundpd xmm2,[rax],0xa5",
			"vroundpd ymm2,ymm3,0xa5",
			"vroundpd ymm2,[rax],0xa5",
			"vrndscalepd xmm2{k3},xmm3,0xa5",
			"vrndscalepd xmm2,[rax+0x10],0xa5",
			"vrndscalepd xmm2{k3}{z},[rax+8]{1to2},0xa5",
			"vrndscalepd ymm2{k3},ymm3,0xa5",
			"vrndscalepd ymm2,[rax+0x20],0xa5",
			"vrndscalepd ymm2{k3}{z},[rax+8]{1to4},0xa5",
			"vrndscalepd zmm2{k3},zmm3,0xa5",
			"vrndscalepd zmm2,[rax+0x40],0xa5",
			"vrndscalepd zmm2{k3}{z},[rax+8]{1to8},0xa5",
			"roundss xmm1,xmm5,0xa5",
			"roundss xmm1,[rax],0xa5",
			"vroundss xmm2,xmm6,xmm3,0xa5",
			"vroundss xmm2,xmm6,[rax],0xa5",
			"vrndscaless xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vrndscaless xmm2{k3},xmm6,[rax+4],0xa5",
			"roundsd xmm1,xmm5,0xa5",
			"roundsd xmm1,[rax],0xa5",
			"vroundsd xmm2,xmm6,xmm3,0xa5",
			"vroundsd xmm2,xmm6,[rax],0xa5",
			"vrndscalesd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vrndscalesd xmm2{k3},xmm6,[rax+8],0xa5",
			"blendps xmm1,xmm5,0xa5",
			"blendps xmm1,[rax],0xa5",
			"vblendps xmm2,xmm6,xmm3,0xa5",
			"vblendps xmm2,xmm6,[rax],0xa5",
			"vblendps ymm2,ymm6,ymm3,0x5a",
			"vblendps ymm2,ymm6,[rax],0x5a",
			"blendpd xmm1,xmm5,0xa5",
			"blendpd xmm1,[rax],0xa5",
			"vblendpd xmm2,xmm6,xmm3,0xa5",
			"vblendpd xmm2,xmm6,[rax],0xa5",
			"vblendpd ymm2,ymm6,ymm3,0x5a",
			"vblendpd ymm2,ymm6,[rax],0x5a",
			"pblendw xmm1,xmm5,0xa5",
			"pblendw xmm1,[rax],0xa5",
			"vpblendw xmm2,xmm6,xmm3,0xa5",
			"vpblendw xmm2,xmm6,[rax],0xa5",
			"vpblendw ymm2,ymm6,ymm3,0x5a",
			"vpblendw ymm2,ymm6,[rax],0x5a",
			"palignr mm1,mm5,0xa5",
			"palignr mm1,[rax],0xa5",
			"palignr xmm1,xmm5,0xa5",
			"palignr xmm1,[rax],0xa5",
			"vpalignr xmm2,xmm6,xmm3,0xa5",
			"vpalignr xmm2,xmm6,[rax],0xa5",
			"vpalignr ymm2,ymm6,ymm3,0xa5",
			"vpalignr ymm2,ymm6,[rax],0xa5",
			"vpalignr xmm2{k3},xmm6,xmm3,0xa5",
			"vpalignr xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vpalignr ymm2{k3},ymm6,ymm3,0xa5",
			"vpalignr ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vpalignr zmm2{k3},zmm6,zmm3,0xa5",
			"vpalignr zmm2{k3},zmm6,[rax+0x40],0xa5",
			"pextrb ebp,xmm1,0xa5",
			"pextrb [rax+1],xmm1,0xa5",
			"pextrb rbp,xmm1,0xa5",
			"pextrb [rax+1],xmm1,0xa5",
			"vpextrb ebx,xmm2,0xa5",
			"vpextrb [rax+1],xmm2,0xa5",
			"vpextrb rbx,xmm2,0xa5",
			"vpextrb [rax+1],xmm2,0xa5",
			"vpextrb ebx,xmm2,0xa5",
			"vpextrb [rax+1],xmm2,0xa5",
			"vpextrb rbx,xmm2,0xa5",
			"vpextrb [rax+1],xmm2,0xa5",
			"pextrw ebp,xmm1,0xa5",
			"pextrw [rax+1],xmm1,0xa5",
			"pextrw rbp,xmm1,0xa5",
			"pextrw [rax+1],xmm1,0xa5",
			"vpextrw ebx,xmm2,0xa5",
			"vpextrw [rax+1],xmm2,0xa5",
			"vpextrw rbx,xmm2,0xa5",
			"vpextrw [rax+1],xmm2,0xa5",
			"vpextrw ebx,xmm2,0xa5",
			"vpextrw [rax+2],xmm2,0xa5",
			"vpextrw rbx,xmm2,0xa5",
			"vpextrw [rax+2],xmm2,0xa5",
			"pextrd ebp,xmm1,0xa5",
			"pextrd [rax+1],xmm1,0xa5",
			"pextrq rbp,xmm1,0xa5",
			"pextrq [rax+1],xmm1,0xa5",
			"vpextrd ebx,xmm2,0xa5",
			"vpextrd [rax+1],xmm2,0xa5",
			"vpextrq rbx,xmm2,0xa5",
			"vpextrq [rax+1],xmm2,0xa5",
			"vpextrd ebx,xmm2,0xa5",
			"vpextrd [rax+4],xmm2,0xa5",
			"vpextrq rbx,xmm2,0xa5",
			"vpextrq [rax+8],xmm2,0xa5",
			"extractps ebp,xmm1,0xa5",
			"extractps [rax+1],xmm1,0xa5",
			"extractps rbp,xmm1,0xa5",
			"extractps [rax+1],xmm1,0xa5",
			"vextractps ebx,xmm2,0xa5",
			"vextractps [rax+1],xmm2,0xa5",
			"vextractps rbx,xmm2,0xa5",
			"vextractps [rax+1],xmm2,0xa5",
			"vextractps ebx,xmm2,0xa5",
			"vextractps [rax+4],xmm2,0xa5",
			"vextractps rbx,xmm2,0xa5",
			"vextractps [rax+4],xmm2,0xa5",
			"vinsertf128 ymm2,ymm6,xmm3,0xa5",
			"vinsertf128 ymm2,ymm6,[rax],0xa5",
			"vinsertf32x4 ymm2{k3},ymm6,xmm3,0xa5",
			"vinsertf32x4 ymm2{k3},ymm6,[rax+0x10],0xa5",
			"vinsertf32x4 zmm2{k3},zmm6,xmm3,0xa5",
			"vinsertf32x4 zmm2{k3},zmm6,[rax+0x10],0xa5",
			"vinsertf64x2 ymm2{k3},ymm6,xmm3,0xa5",
			"vinsertf64x2 ymm2{k3},ymm6,[rax+0x10],0xa5",
			"vinsertf64x2 zmm2{k3},zmm6,xmm3,0xa5",
			"vinsertf64x2 zmm2{k3},zmm6,[rax+0x10],0xa5",
			"vextractf128 xmm3,ymm2,0xa5",
			"vextractf128 [rax],ymm2,0xa5",
			"vextractf32x4 xmm3{k3},ymm2,0xa5",
			"vextractf32x4 [rax+0x10]{k3},ymm2,0xa5",
			"vextractf32x4 xmm3{k3},zmm2,0xa5",
			"vextractf32x4 [rax+0x10]{k3},zmm2,0xa5",
			"vextractf64x2 xmm3{k3},ymm2,0xa5",
			"vextractf64x2 [rax+0x10]{k3},ymm2,0xa5",
			"vextractf64x2 xmm3{k3},zmm2,0xa5",
			"vextractf64x2 [rax+0x10]{k3},zmm2,0xa5",
			"vinsertf32x8 zmm2{k3},zmm6,ymm3,0xa5",
			"vinsertf32x8 zmm2{k3},zmm6,[rax+0x20],0xa5",
			"vinsertf64x4 zmm2{k3},zmm6,ymm3,0xa5",
			"vinsertf64x4 zmm2{k3},zmm6,[rax+0x20],0xa5",
			"vextractf32x8 ymm3{k3},zmm2,0xa5",
			"vextractf32x8 [rax+0x20]{k3},zmm2,0xa5",
			"vextractf64x4 ymm3{k3},zmm2,0xa5",
			"vextractf64x4 [rax+0x20]{k3},zmm2,0xa5",
			"vcvtps2ph xmm5,xmm1,0xa5",
			"vcvtps2ph [rax],xmm2,0xa5",
			"vcvtps2ph xmm5,ymm1,0xa5",
			"vcvtps2ph [rax],ymm2,0xa5",
			"vcvtps2ph xmm3{k3}{z},xmm2,0xa5",
			"vcvtps2ph [rax+8]{k3},xmm2,0xa5",
			"vcvtps2ph xmm3{k3}{z},ymm2,0xa5",
			"vcvtps2ph [rax+0x10]{k3},ymm2,0xa5",
			"vcvtps2ph ymm3{k3}{z},zmm2,{sae},0xa5",
			"vcvtps2ph [rax+0x20]{k3},zmm2,0xa5",
			"vpcmpud k2{k3},xmm6,xmm3,0xa5",
			"vpcmpud k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpud k2{k5},xmm6,[rax+4]{1to4},0xa5",
			"vpcmpud k2{k3},ymm6,ymm3,0xa5",
			"vpcmpud k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpud k2{k5},ymm6,[rax+4]{1to8},0xa5",
			"vpcmpud k2{k3},zmm6,zmm3,0xa5",
			"vpcmpud k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpud k2{k5},zmm6,[rax+4]{1to16},0xa5",
			"vpcmpuq k2{k3},xmm6,xmm3,0xa5",
			"vpcmpuq k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpuq k2{k5},xmm6,[rax+8]{1to2},0xa5",
			"vpcmpuq k2{k3},ymm6,ymm3,0xa5",
			"vpcmpuq k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpuq k2{k5},ymm6,[rax+8]{1to4},0xa5",
			"vpcmpuq k2{k3},zmm6,zmm3,0xa5",
			"vpcmpuq k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpuq k2{k5},zmm6,[rax+8]{1to8},0xa5",
			"vpcmpd k2{k3},xmm6,xmm3,0xa5",
			"vpcmpd k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpd k2{k5},xmm6,[rax+4]{1to4},0xa5",
			"vpcmpd k2{k3},ymm6,ymm3,0xa5",
			"vpcmpd k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpd k2{k5},ymm6,[rax+4]{1to8},0xa5",
			"vpcmpd k2{k3},zmm6,zmm3,0xa5",
			"vpcmpd k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpd k2{k5},zmm6,[rax+4]{1to16},0xa5",
			"vpcmpq k2{k3},xmm6,xmm3,0xa5",
			"vpcmpq k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpq k2{k5},xmm6,[rax+8]{1to2},0xa5",
			"vpcmpq k2{k3},ymm6,ymm3,0xa5",
			"vpcmpq k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpq k2{k5},ymm6,[rax+8]{1to4},0xa5",
			"vpcmpq k2{k3},zmm6,zmm3,0xa5",
			"vpcmpq k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpq k2{k5},zmm6,[rax+8]{1to8},0xa5",
			"pinsrb xmm1,ebp,0xa5",
			"pinsrb xmm1,[rax],0xa5",
			"pinsrb xmm1,rbp,0xa5",
			"pinsrb xmm1,[rax],0xa5",
			"vpinsrb xmm2,xmm6,ebx,0xa5",
			"vpinsrb xmm2,xmm6,[rax],0xa5",
			"vpinsrb xmm2,xmm6,rbx,0xa5",
			"vpinsrb xmm2,xmm6,[rax],0xa5",
			"vpinsrb xmm2,xmm6,ebx,0xa5",
			"vpinsrb xmm2,xmm6,[rax+1],0xa5",
			"vpinsrb xmm2,xmm6,rbx,0xa5",
			"vpinsrb xmm2,xmm6,[rax+1],0xa5",
			"insertps xmm1,xmm5,0xa5",
			"insertps xmm1,[rax],0xa5",
			"vinsertps xmm2,xmm6,xmm3,0xa5",
			"vinsertps xmm2,xmm6,[rax],0xa5",
			"vinsertps xmm2,xmm6,xmm3,0xa5",
			"vinsertps xmm2,xmm6,[rax+4],0xa5",
			"pinsrd xmm1,ebp,0xa5",
			"pinsrd xmm1,[rax],0xa5",
			"pinsrq xmm1,rbp,0xa5",
			"pinsrq xmm1,[rax],0xa5",
			"vpinsrd xmm2,xmm6,ebx,0xa5",
			"vpinsrd xmm2,xmm6,[rax],0xa5",
			"vpinsrq xmm2,xmm6,rbx,0xa5",
			"vpinsrq xmm2,xmm6,[rax],0xa5",
			"vpinsrd xmm2,xmm6,ebx,0xa5",
			"vpinsrd xmm2,xmm6,[rax+4],0xa5",
			"vpinsrq xmm2,xmm6,rbx,0xa5",
			"vpinsrq xmm2,xmm6,[rax+8],0xa5",
			"vshuff32x4 ymm2{k3},ymm6,ymm3,0xa5",
			"vshuff32x4 ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vshuff32x4 ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"vshuff32x4 zmm2{k3},zmm6,zmm3,0xa5",
			"vshuff32x4 zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vshuff32x4 zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"vshuff64x2 ymm2{k3}{z},ymm6,ymm3,0xa5",
			"vshuff64x2 ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vshuff64x2 ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"vshuff64x2 zmm2{k3}{z},zmm6,zmm3,0xa5",
			"vshuff64x2 zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vshuff64x2 zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"vpternlogd xmm2{k3},xmm6,xmm3,0xa5",
			"vpternlogd xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vpternlogd xmm2{k5}{z},xmm6,[rax+4]{1to4},0xa5",
			"vpternlogd ymm2{k3},ymm6,ymm3,0xa5",
			"vpternlogd ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vpternlogd ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"vpternlogd zmm2{k3},zmm6,zmm3,0xa5",
			"vpternlogd zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vpternlogd zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"vpternlogq xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vpternlogq xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vpternlogq xmm2{k5}{z},xmm6,[rax+8]{1to2},0xa5",
			"vpternlogq ymm2{k3}{z},ymm6,ymm3,0xa5",
			"vpternlogq ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vpternlogq ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"vpternlogq zmm2{k3}{z},zmm6,zmm3,0xa5",
			"vpternlogq zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vpternlogq zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"vgetmantps xmm2{k3},xmm3,0xa5",
			"vgetmantps xmm2,[rax+0x10],0xa5",
			"vgetmantps xmm2{k3}{z},[rax+4]{1to4},0xa5",
			"vgetmantps ymm2{k3},ymm3,0xa5",
			"vgetmantps ymm2,[rax+0x20],0xa5",
			"vgetmantps ymm2{k3}{z},[rax+4]{1to8},0xa5",
			"vgetmantps zmm2{k3},zmm3,0xa5",
			"vgetmantps zmm2,[rax+0x40],0xa5",
			"vgetmantps zmm2{k3}{z},[rax+4]{1to16},0xa5",
			"vgetmantpd xmm2{k3},xmm3,0xa5",
			"vgetmantpd xmm2,[rax+0x10],0xa5",
			"vgetmantpd xmm2{k3}{z},[rax+8]{1to2},0xa5",
			"vgetmantpd ymm2{k3},ymm3,0xa5",
			"vgetmantpd ymm2,[rax+0x20],0xa5",
			"vgetmantpd ymm2{k3}{z},[rax+8]{1to4},0xa5",
			"vgetmantpd zmm2{k3},zmm3,0xa5",
			"vgetmantpd zmm2,[rax+0x40],0xa5",
			"vgetmantpd zmm2{k3}{z},[rax+8]{1to8},0xa5",
			"vgetmantss xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vgetmantss xmm2{k3},xmm6,[rax+4],0xa5",
			"vgetmantsd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vgetmantsd xmm2{k3},xmm6,[rax+8],0xa5",
			"kshiftrw k2,k3,0xa5",
			"kshiftrb k2,k3,0xa5",
			"kshiftrq k2,k3,0xa5",
			"kshiftrd k2,k3,0xa5",
			"kshiftlw k2,k3,0xa5",
			"kshiftlb k2,k3,0xa5",
			"kshiftlq k2,k3,0xa5",
			"kshiftld k2,k3,0xa5",
			"vinserti128 ymm2,ymm6,xmm3,0xa5",
			"vinserti128 ymm2,ymm6,[rax],0xa5",
			"vinserti32x4 ymm2{k3},ymm6,xmm3,0xa5",
			"vinserti32x4 ymm2{k3},ymm6,[rax+0x10],0xa5",
			"vinserti32x4 zmm2{k3},zmm6,xmm3,0xa5",
			"vinserti32x4 zmm2{k3},zmm6,[rax+0x10],0xa5",
			"vinserti64x2 ymm2{k3},ymm6,xmm3,0xa5",
			"vinserti64x2 ymm2{k3},ymm6,[rax+0x10],0xa5",
			"vinserti64x2 zmm2{k3},zmm6,xmm3,0xa5",
			"vinserti64x2 zmm2{k3},zmm6,[rax+0x10],0xa5",
			"vextracti128 xmm3,ymm2,0xa5",
			"vextracti128 [rax],ymm2,0xa5",
			"vextracti32x4 xmm3{k3},ymm2,0xa5",
			"vextracti32x4 [rax+0x10]{k3},ymm2,0xa5",
			"vextracti32x4 xmm3{k3},zmm2,0xa5",
			"vextracti32x4 [rax+0x10]{k3},zmm2,0xa5",
			"vextracti64x2 xmm3{k3},ymm2,0xa5",
			"vextracti64x2 [rax+0x10]{k3},ymm2,0xa5",
			"vextracti64x2 xmm3{k3},zmm2,0xa5",
			"vextracti64x2 [rax+0x10]{k3},zmm2,0xa5",
			"vinserti32x8 zmm2{k3},zmm6,ymm3,0xa5",
			"vinserti32x8 zmm2{k3},zmm6,[rax+0x20],0xa5",
			"vinserti64x4 zmm2{k3},zmm6,ymm3,0xa5",
			"vinserti64x4 zmm2{k3},zmm6,[rax+0x20],0xa5",
			"vextracti32x8 ymm3{k3},zmm2,0xa5",
			"vextracti32x8 [rax+0x20]{k3},zmm2,0xa5",
			"vextracti64x4 ymm3{k3},zmm2,0xa5",
			"vextracti64x4 [rax+0x20]{k3},zmm2,0xa5",
			"vpcmpub k2{k3},xmm6,xmm3,0xa5",
			"vpcmpub k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpub k2{k3},ymm6,ymm3,0xa5",
			"vpcmpub k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpub k2{k3},zmm6,zmm3,0xa5",
			"vpcmpub k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpuw k2{k3},xmm6,xmm3,0xa5",
			"vpcmpuw k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpuw k2{k3},ymm6,ymm3,0xa5",
			"vpcmpuw k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpuw k2{k3},zmm6,zmm3,0xa5",
			"vpcmpuw k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpb k2{k3},xmm6,xmm3,0xa5",
			"vpcmpb k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpb k2{k3},ymm6,ymm3,0xa5",
			"vpcmpb k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpb k2{k3},zmm6,zmm3,0xa5",
			"vpcmpb k2{k3},zmm6,[rax+0x40],0xa5",
			"vpcmpw k2{k3},xmm6,xmm3,0xa5",
			"vpcmpw k2{k3},xmm6,[rax+0x10],0xa5",
			"vpcmpw k2{k3},ymm6,ymm3,0xa5",
			"vpcmpw k2{k3},ymm6,[rax+0x20],0xa5",
			"vpcmpw k2{k3},zmm6,zmm3,0xa5",
			"vpcmpw k2{k3},zmm6,[rax+0x40],0xa5",
			"dpps xmm1,xmm5,0xa5",
			"dpps xmm1,[rax],0xa5",
			"vdpps xmm2,xmm6,xmm3,0xa5",
			"vdpps xmm2,xmm6,[rax],0xa5",
			"vdpps ymm2,ymm6,ymm3,0x5a",
			"vdpps ymm2,ymm6,[rax],0x5a",
			"dppd xmm1,xmm5,0xa5",
			"dppd xmm1,[rax],0xa5",
			"vdppd xmm2,xmm6,xmm3,0xa5",
			"vdppd xmm2,xmm6,[rax],0xa5",
			"mpsadbw xmm1,xmm5,0xa5",
			"mpsadbw xmm1,[rax],0xa5",
			"vmpsadbw xmm2,xmm6,xmm3,0xa5",
			"vmpsadbw xmm2,xmm6,[rax],0xa5",
			"vmpsadbw ymm2,ymm6,ymm3,0xa5",
			"vmpsadbw ymm2,ymm6,[rax],0xa5",
			"vdbpsadbw xmm2{k3},xmm6,xmm3,0xa5",
			"vdbpsadbw xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vdbpsadbw ymm2{k3},ymm6,ymm3,0xa5",
			"vdbpsadbw ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vdbpsadbw zmm2{k3},zmm6,zmm3,0xa5",
			"vdbpsadbw zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vshufi32x4 ymm2{k3},ymm6,ymm3,0xa5",
			"vshufi32x4 ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vshufi32x4 ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"vshufi32x4 zmm2{k3},zmm6,zmm3,0xa5",
			"vshufi32x4 zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vshufi32x4 zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"vshufi64x2 ymm2{k3}{z},ymm6,ymm3,0xa5",
			"vshufi64x2 ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vshufi64x2 ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"vshufi64x2 zmm2{k3}{z},zmm6,zmm3,0xa5",
			"vshufi64x2 zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vshufi64x2 zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"pclmulqdq xmm1,xmm5,0xa5",
			"pclmulqdq xmm1,[rax],0xa5",
			"vpclmulqdq xmm2,xmm6,xmm3,0xa5",
			"vpclmulqdq xmm2,xmm6,[rax],0xa5",
			"vperm2i128 ymm2,ymm6,ymm3,0xa5",
			"vperm2i128 ymm2,ymm6,[rax],0xa5",
			"vblendvps xmm2,xmm6,xmm3,xmm4",
			"vblendvps xmm2,xmm6,[rax],xmm4",
			"vblendvps ymm2,ymm6,ymm3,ymm5",
			"vblendvps ymm2,ymm6,[rax],ymm5",
			"vblendvpd xmm2,xmm6,xmm3,xmm4",
			"vblendvpd xmm2,xmm6,[rax],xmm4",
			"vblendvpd ymm2,ymm6,ymm3,ymm5",
			"vblendvpd ymm2,ymm6,[rax],ymm5",
			"vpblendvb xmm2,xmm6,xmm3,xmm4",
			"vpblendvb xmm2,xmm6,[rax],xmm4",
			"vpblendvb ymm2,ymm6,ymm3,ymm5",
			"vpblendvb ymm2,ymm6,[rax],ymm5",
			"vrangeps xmm2{k3},xmm6,xmm3,0xa5",
			"vrangeps xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vrangeps xmm2{k5}{z},xmm6,[rax+4]{1to4},0xa5",
			"vrangeps ymm2{k3},ymm6,ymm3,0xa5",
			"vrangeps ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vrangeps ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"vrangeps zmm2{k3}{z},zmm6,zmm3,{sae},0xa5",
			"vrangeps zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vrangeps zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"vrangepd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vrangepd xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vrangepd xmm2{k5}{z},xmm6,[rax+8]{1to2},0xa5",
			"vrangepd ymm2{k3}{z},ymm6,ymm3,0xa5",
			"vrangepd ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vrangepd ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"vrangepd zmm2{k3}{z},zmm6,zmm3,{sae},0xa5",
			"vrangepd zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vrangepd zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"vrangess xmm2{k3},xmm6,xmm3,0xa5",
			"vrangess xmm2{k3},xmm6,[rax+4],0xa5",
			"vrangesd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vrangesd xmm2{k3},xmm6,[rax+8],0xa5",
			"vfixupimmps xmm2{k3},xmm6,xmm3,0xa5",
			"vfixupimmps xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vfixupimmps xmm2{k5}{z},xmm6,[rax+4]{1to4},0xa5",
			"vfixupimmps ymm2{k3},ymm6,ymm3,0xa5",
			"vfixupimmps ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vfixupimmps ymm2{k5}{z},ymm6,[rax+4]{1to8},0xa5",
			"vfixupimmps zmm2{k3}{z},zmm6,zmm3,{sae},0xa5",
			"vfixupimmps zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vfixupimmps zmm2{k5}{z},zmm6,[rax+4]{1to16},0xa5",
			"vfixupimmpd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vfixupimmpd xmm2{k3},xmm6,[rax+0x10],0xa5",
			"vfixupimmpd xmm2{k5}{z},xmm6,[rax+8]{1to2},0xa5",
			"vfixupimmpd ymm2{k3}{z},ymm6,ymm3,0xa5",
			"vfixupimmpd ymm2{k3},ymm6,[rax+0x20],0xa5",
			"vfixupimmpd ymm2{k5}{z},ymm6,[rax+8]{1to4},0xa5",
			"vfixupimmpd zmm2{k3}{z},zmm6,zmm3,{sae},0xa5",
			"vfixupimmpd zmm2{k3},zmm6,[rax+0x40],0xa5",
			"vfixupimmpd zmm2{k5}{z},zmm6,[rax+8]{1to8},0xa5",
			"vfixupimmss xmm2{k3},xmm6,xmm3,0xa5",
			"vfixupimmss xmm2{k3},xmm6,[rax+4],0xa5",
			"vfixupimmsd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vfixupimmsd xmm2{k3},xmm6,[rax+8],0xa5",
			"vreduceps xmm2{k3},xmm3,0xa5",
			"vreduceps xmm2,[rax+0x10],0xa5",
			"vreduceps xmm2{k3}{z},[rax+4]{1to4},0xa5",
			"vreduceps ymm2{k3},ymm3,0xa5",
			"vreduceps ymm2,[rax+0x20],0xa5",
			"vreduceps ymm2{k3}{z},[rax+4]{1to8},0xa5",
			"vreduceps zmm2{k3},zmm3,0xa5",
			"vreduceps zmm2,[rax+0x40],0xa5",
			"vreduceps zmm2{k3}{z},[rax+4]{1to16},0xa5",
			"vreducepd xmm2{k3},xmm3,0xa5",
			"vreducepd xmm2,[rax+0x10],0xa5",
			"vreducepd xmm2{k3}{z},[rax+8]{1to2},0xa5",
			"vreducepd ymm2{k3},ymm3,0xa5",
			"vreducepd ymm2,[rax+0x20],0xa5",
			"vreducepd ymm2{k3}{z},[rax+8]{1to4},0xa5",
			"vreducepd zmm2{k3},zmm3,0xa5",
			"vreducepd zmm2,[rax+0x40],0xa5",
			"vreducepd zmm2{k3}{z},[rax+8]{1to8},0xa5",
			"vreducess xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vreducess xmm2{k3},xmm6,[rax+4],0xa5",
			"vreducesd xmm2{k3}{z},xmm6,xmm3,0xa5",
			"vreducesd xmm2{k3},xmm6,[rax+8],0xa5",
			"pcmpestrm xmm1,xmm5,0xa5",
			"pcmpestrm xmm1,[rax],0xa5",
			"pcmpestrm64 xmm1,xmm5,0xa5",
			"pcmpestrm64 xmm1,[rax],0xa5",
			"vpcmpestrm xmm2,xmm3,0xa5",
			"vpcmpestrm xmm2,[rax],0xa5",
			"vpcmpestrm64 xmm2,xmm3,0xa5",
			"vpcmpestrm64 xmm2,[rax],0xa5",
			"pcmpestri xmm1,xmm5,0xa5",
			"pcmpestri xmm1,[rax],0xa5",
			"pcmpestri64 xmm1,xmm5,0xa5",
			"pcmpestri64 xmm1,[rax],0xa5",
			"vpcmpestri xmm2,xmm3,0xa5",
			"vpcmpestri xmm2,[rax],0xa5",
			"vpcmpestri64 xmm2,xmm3,0xa5",
			"vpcmpestri64 xmm2,[rax],0xa5",
			"pcmpistrm xmm1,xmm5,0xa5",
			"pcmpistrm xmm1,[rax],0xa5",
			"vpcmpistrm xmm2,xmm3,0xa5",
			"vpcmpistrm xmm2,[rax],0xa5",
			"pcmpistri xmm1,xmm5,0xa5",
			"pcmpistri xmm1,[rax],0xa5",
			"vpcmpistri xmm2,xmm3,0xa5",
			"vpcmpistri xmm2,[rax],0xa5",
			"vfpclassps k2{k3},xmm3,0xa5",
			"vfpclassps k2{k3},oword [rax+0x10],0xa5",
			"vfpclassps k2{k5},[rax+4]{1to4},0xa5",
			"vfpclassps k2{k3},ymm3,0xa5",
			"vfpclassps k2{k3},yword [rax+0x20],0xa5",
			"vfpclassps k2{k5},[rax+4]{1to8},0xa5",
			"vfpclassps k2{k3},zmm3,0xa5",
			"vfpclassps k2{k3},zword [rax+0x40],0xa5",
			"vfpclassps k2{k5},[rax+4]{1to16},0xa5",
			"vfpclasspd k2{k3},xmm3,0xa5",
			"vfpclasspd k2{k3},oword [rax+0x10],0xa5",
			"vfpclasspd k2{k5},[rax+8]{1to2},0xa5",
			"vfpclasspd k2{k3},ymm3,0xa5",
			"vfpclasspd k2{k3},yword [rax+0x20],0xa5",
			"vfpclasspd k2{k5},[rax+8]{1to4},0xa5",
			"vfpclasspd k2{k3},zmm3,0xa5",
			"vfpclasspd k2{k3},zword [rax+0x40],0xa5",
			"vfpclasspd k2{k5},[rax+8]{1to8},0xa5",
			"vfpclassss k2{k3},xmm3,0xa5",
			"vfpclassss k2{k3},[rax+4],0xa5",
			"vfpclasssd k2{k3},xmm3,0xa5",
			"vfpclasssd k2{k3},[rax+8],0xa5",
			"sha1rnds4 xmm1,xmm5,0xa5",
			"sha1rnds4 xmm1,[rax],0xa5",
			"aeskeygenassist xmm1,xmm5,0xa5",
			"aeskeygenassist xmm1,[rax],0x5a",
			"vaeskeygenassist xmm2,xmm3,0xa5",
			"vaeskeygenassist xmm2,[rax],0x5a",
			"rorx edx,ebx,0xa5",
			"rorx edx,[rax],0x5a",
			"rorx rdx,rbx,0xa5",
			"rorx rdx,[rax],0xa5",
			"fs outsb",
			"fs outsw",
			"fs outsd",
			"fs movsb",
			"fs movsw",
			"fs movsd",
			"fs movsq",
			"fs cmpsb",
			"fs cmpsw",
			"fs cmpsd",
			"fs cmpsq",
			"fs lodsb",
			"fs lodsw",
			"fs lodsd",
			"fs lodsq",
			"a32 xlatb",
			"fs xlatb",
			"fs maskmovq mm2,mm3",
			"fs maskmovdqu xmm2,xmm3",
			"fs vmaskmovdqu xmm2,xmm3",
			"a32 monitor",
			"(bad)",
			"mov al,[qword fs:0xf0debc9a78563412]",
			"a32 mov al,[fs:0x78563412]",
			"mov ax,[qword fs:0xf0debc9a78563412]",
			"a32 mov ax,[fs:0x78563412]",
			"mov eax,[qword fs:0xf0debc9a78563412]",
			"a32 mov eax,[fs:0x78563412]",
			"mov rax,[qword fs:0xf0debc9a78563412]",
			"a32 mov rax,[fs:0x78563412]",
			"mov [qword fs:0xf0debc9a78563412],al",
		};
	}
}
#endif
