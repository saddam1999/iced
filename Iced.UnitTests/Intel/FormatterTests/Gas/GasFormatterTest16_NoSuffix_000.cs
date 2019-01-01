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
	public sealed class GasFormatterTest16_NoSuffix_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_NoSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos16_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos16_000.AllInfos_Length] {
			"push %es",
			"pushl %es",
			"pop %es",
			"popl %es",
			"push %cs",
			"pushl %cs",
			"push %ss",
			"pushl %ss",
			"pop %ss",
			"popl %ss",
			"push %ds",
			"pushl %ds",
			"pop %ds",
			"popl %ds",
			"pusha",
			"pushal",
			"popa",
			"popal",
			"pushl $0x3412a55a",
			"pushl $0xffffffa5",
			"jo 0x804c",
			"data32 jo 0x0000804d",
			"jno 0x804c",
			"data32 jno 0x0000804d",
			"jb 0x804c",
			"data32 jb 0x0000804d",
			"jae 0x804c",
			"data32 jae 0x0000804d",
			"je 0x804c",
			"data32 je 0x0000804d",
			"jne 0x804c",
			"data32 jne 0x0000804d",
			"jbe 0x804c",
			"data32 jbe 0x0000804d",
			"ja 0x804c",
			"data32 ja 0x0000804d",
			"js 0x804c",
			"data32 js 0x0000804d",
			"jns 0x804c",
			"data32 jns 0x0000804d",
			"jp 0x804c",
			"data32 jp 0x0000804d",
			"jnp 0x804c",
			"data32 jnp 0x0000804d",
			"jl 0x804c",
			"data32 jl 0x0000804d",
			"jge 0x804c",
			"data32 jge 0x0000804d",
			"jle 0x804c",
			"data32 jle 0x0000804d",
			"jg 0x804c",
			"data32 jg 0x0000804d",
			"pop %esi",
			"popl (%bx,%si)",
			"lcall $0x7856,$0x3412",
			"lcalll $0xbc9a,$0x78563412",
			"pushfl",
			"popfl",
			"ret $0xa55a",
			"retl $0xa55a",
			"ret",
			"retl",
			"les (%bx,%si),%bx",
			"les (%bx,%si),%ebx",
			"lds (%bx,%si),%bx",
			"lds (%bx,%si),%ebx",
			"enterl $0xa55a,$0xa6",
			"leavel",
			"loopne 0x804c",
			".byte 0x66; loopne 0x0000804d",
			"loopnel 0x804d",
			".byte 0x66; loopnel 0x0000804e",
			"loope 0x804c",
			".byte 0x66; loope 0x0000804d",
			"loopel 0x804d",
			".byte 0x66; loopel 0x0000804e",
			"loop 0x804c",
			".byte 0x66; loop 0x0000804d",
			"loopl 0x804d",
			".byte 0x66; loopl 0x0000804e",
			"jcxz 0x804c",
			".byte 0x66; jcxz 0x0000804d",
			"jecxz 0x804d",
			".byte 0x66; jecxz 0x0000804e",
			"call 0x254d",
			"calll 0xa55ab408",
			"jmp 0x254d",
			"data32 jmp 0xa55ab408",
			"ljmp $0x7856,$0x3412",
			"ljmpl $0xbcea,$0x78563412",
			"jmp 0x804c",
			"data32 jmp 0x0000804d",
			"call *%cx",
			"callw *(%bx,%si)",
			"call *%ecx",
			"calll *(%bx,%si)",
			"jmp *%dx",
			"jmpw *(%bx,%si)",
			"jmp *%edx",
			"jmpl *(%bx,%si)",
			"push %esi",
			"pushl (%bx,%si)",
			"bndmov %bnd2,%bnd1",
			"bndmov (%eax),%bnd1",
			"bndcl %edx,%bnd1",
			"bndcl (%eax),%bnd1",
			"bndcu %edx,%bnd1",
			"bndcu (%eax),%bnd1",
			"bndmov %bnd1,%bnd2",
			"bndmov %bnd1,(%eax)",
			"bndmk (%eax),%bnd1",
			"bndcn %edx,%bnd1",
			"bndcn (%eax),%bnd1",
			"vmread %ecx,%esi",
			"vmread %ebx,(%bx,%si)",
			"vmwrite %esi,%ecx",
			"vmwrite (%bx,%si),%ebx",
			"jo 0x254e",
			"data32 jo 0x34132551",
			"jno 0x254e",
			"data32 jno 0x34132551",
			"jb 0x254e",
			"data32 jb 0x34132551",
			"jae 0x254e",
			"data32 jae 0x34132551",
			"je 0x254e",
			"data32 je 0x34132551",
			"jne 0x254e",
			"data32 jne 0x34132551",
			"jbe 0x254e",
			"data32 jbe 0x34132551",
			"ja 0x254e",
			"data32 ja 0x34132551",
			"js 0x254e",
			"data32 js 0x34132551",
			"jns 0x254e",
			"data32 jns 0x34132551",
			"jp 0x254e",
			"data32 jp 0x34132551",
			"jnp 0x254e",
			"data32 jnp 0x34132551",
			"jl 0x254e",
			"data32 jl 0x34132551",
			"jge 0x254e",
			"data32 jge 0x34132551",
			"jle 0x254e",
			"data32 jle 0x34132551",
			"jg 0x254e",
			"data32 jg 0x34132551",
			"pushl %fs",
			"popl %fs",
			"pushl %gs",
			"popl %gs",
			"invept (%bx,%si),%edx",
			"invvpid (%bx,%si),%edx",
			"invpcid (%bx,%si),%edx",
			"push $0xa55a",
			"push $0xffa5",
			"insb %dx,(%edi)",
			"insb %dx,(%di)",
			"insw %dx,(%edi)",
			"insw %dx,(%di)",
			"insl %dx,(%edi)",
			"insl %dx,(%di)",
			"outsb (%esi),%dx",
			"outsb (%si),%dx",
			"outsw (%esi),%dx",
			"outsw (%si),%dx",
			"outsl (%esi),%dx",
			"outsl (%si),%dx",
			"mov %si,%fs",
			"mov (%bx,%si),%ds",
			"mov %esi,%fs",
			"data32 mov (%bx,%si),%ds",
			"pop %si",
			"popw (%bx,%si)",
			"nop",
			"xchg %eax,%eax",
			"pushf",
			"popf",
			"mov 0xf0de,%al",
			"addr32 mov 0x78563412,%al",
			"mov 0xf0de,%ax",
			"addr32 mov 0x78563412,%ax",
			"mov 0xf0de,%eax",
			"addr32 mov 0x78563412,%eax",
			"mov %al,0xf0de",
			"addr32 mov %al,0x78563412",
			"mov %ax,0xf0de",
			"addr32 mov %ax,0x78563412",
			"mov %eax,0xf0de",
			"addr32 mov %eax,0x78563412",
			"movsb (%esi),(%edi)",
			"movsb (%si),(%di)",
			"movsw (%esi),(%edi)",
			"movsw (%si),(%di)",
			"movsl (%esi),(%edi)",
			"movsl (%si),(%di)",
			"cmpsb (%edi),(%esi)",
			"cmpsb (%di),(%si)",
			"cmpsw (%edi),(%esi)",
			"cmpsw (%di),(%si)",
			"cmpsl (%edi),(%esi)",
			"cmpsl (%di),(%si)",
			"stos %al,(%edi)",
			"stos %al,(%di)",
			"stos %ax,(%edi)",
			"stos %ax,(%di)",
			"stos %eax,(%edi)",
			"stos %eax,(%di)",
			"lods (%esi),%al",
			"lods (%si),%al",
			"lods (%esi),%ax",
			"lods (%si),%ax",
			"lods (%esi),%eax",
			"lods (%si),%eax",
			"scas (%edi),%al",
			"scas (%di),%al",
			"scas (%edi),%ax",
			"scas (%di),%ax",
			"scas (%edi),%eax",
			"scas (%di),%eax",
			"xbegin 0x254e",
			"data32 xbegin 0x2551",
			"enter $0xa55a,$0xa6",
			"leave",
			"lret $0xa55a",
			"lretl $0xa55a",
			"lret",
			"lretl",
			"iret",
			"iretl",
			"rol %cl,%cl",
			"rolb %cl,(%bx,%si)",
			"ror %cl,%dl",
			"rorb %cl,(%bx,%si)",
			"rcl %cl,%bl",
			"rclb %cl,(%bx,%si)",
			"rcr %cl,%ah",
			"rcrb %cl,(%bx,%si)",
			"shl %cl,%ch",
			"shlb %cl,(%bx,%si)",
			"shr %cl,%dh",
			"shrb %cl,(%bx,%si)",
			"sar %cl,%al",
			"sarb %cl,(%bx,%si)",
			"rol %cl,%cx",
			"rolw %cl,(%bx,%si)",
			"rol %cl,%ecx",
			"roll %cl,(%bx,%si)",
			"ror %cl,%dx",
			"rorw %cl,(%bx,%si)",
			"ror %cl,%edx",
			"rorl %cl,(%bx,%si)",
			"rcl %cl,%bx",
			"rclw %cl,(%bx,%si)",
			"rcl %cl,%ebx",
			"rcll %cl,(%bx,%si)",
			"rcr %cl,%sp",
			"rcrw %cl,(%bx,%si)",
			"rcr %cl,%esp",
			"rcrl %cl,(%bx,%si)",
			"shl %cl,%bp",
			"shlw %cl,(%bx,%si)",
			"shl %cl,%ebp",
			"shll %cl,(%bx,%si)",
			"shr %cl,%si",
			"shrw %cl,(%bx,%si)",
			"shr %cl,%esi",
			"shrl %cl,(%bx,%si)",
			"sar %cl,%ax",
			"sarw %cl,(%bx,%si)",
			"sar %cl,%eax",
			"sarl %cl,(%bx,%si)",
			"fldcw (%bx,%si)",
			"fnstcw (%bx,%si)",
			"fnstsw (%bx,%si)",
			"lcall *(%bx,%si)",
			"lcalll *(%bx,%si)",
			"ljmp *(%bx,%si)",
			"ljmpl *(%bx,%si)",
			"push %si",
			"pushw (%bx,%si)",
			"sgdt (%bx,%si)",
			"sgdtl (%bx,%si)",
			"sidt (%bx,%si)",
			"sidtl (%bx,%si)",
			"lgdt (%bx,%si)",
			"lgdtl (%bx,%si)",
			"lidt (%bx,%si)",
			"lidtl (%bx,%si)",
			"lar %si,%cx",
			"lar (%bx,%si),%bx",
			"lar %esi,%ecx",
			"lar (%bx,%si),%ebx",
			"lsl %si,%cx",
			"lsl (%bx,%si),%bx",
			"lsl %esi,%ecx",
			"lsl (%bx,%si),%ebx",
			"bndldx (%eax),%bnd1",
			"bndstx %bnd1,(%eax)",
			"kmovw %k3,%k2",
			"kmovw (%bx,%si),%k1",
			"kmovb %k3,%k2",
			"kmovb (%bx,%si),%k1",
			"kmovd %k3,%k2",
			"kmovd (%bx,%si),%k1",
			"kmovw %k1,(%bx,%si)",
			"kmovb %k1,(%bx,%si)",
			"kmovd %k1,(%bx,%si)",
			"kmovw %ebx,%k2",
			"kmovb %ebx,%k2",
			"kmovd %ebx,%k2",
			"kmovw %k3,%edx",
			"kmovb %k3,%edx",
			"kmovd %k3,%edx",
			"kortestw %k3,%k2",
			"kortestq %k3,%k2",
			"kortestb %k3,%k2",
			"kortestd %k3,%k2",
			"ktestw %k3,%k2",
			"ktestq %k3,%k2",
			"ktestb %k3,%k2",
			"ktestd %k3,%k2",
			"push %fs",
			"pop %fs",
			"shld %cl,%cx,%si",
			"shld %cl,%bx,(%bx,%si)",
			"shld %cl,%ecx,%esi",
			"shld %cl,%ebx,(%bx,%si)",
			"push %gs",
			"pop %gs",
			"shrd %cl,%cx,%si",
			"shrd %cl,%bx,(%bx,%si)",
			"shrd %cl,%ecx,%esi",
			"shrd %cl,%ebx,(%bx,%si)",
			"lss (%bx,%si),%bx",
			"lss (%bx,%si),%ebx",
			"lfs (%bx,%si),%bx",
			"lfs (%bx,%si),%ebx",
			"lgs (%bx,%si),%bx",
			"lgs (%bx,%si),%ebx",
			"movzbw %dh,%cx",
			"movzbw (%bx,%si),%bx",
			"movzbl %dh,%ecx",
			"movzbl (%bx,%si),%ebx",
			"movzww %si,%cx",
			"movzww (%bx,%si),%bx",
			"movzwl %si,%ecx",
			"movzwl (%bx,%si),%ebx",
			"movsbw %dh,%cx",
			"movsbw (%bx,%si),%bx",
			"movsbl %dh,%ecx",
			"movsbl (%bx,%si),%ebx",
			"movsww %si,%cx",
			"movsww (%bx,%si),%bx",
			"movswl %si,%ecx",
			"movswl (%bx,%si),%ebx",
			"cmpxchg8b (%bx,%si)",
			"crc32 %dh,%ecx",
			"crc32b (%bx,%si),%ebx",
			"crc32 %si,%ecx",
			"crc32w (%bx,%si),%ebx",
			"crc32 %esi,%ecx",
			"crc32l (%bx,%si),%ebx",
			"addr32 maskmovq %mm3,%mm2",
			"maskmovq %mm3,%mm2",
			"addr32 maskmovdqu %xmm3,%xmm2",
			"maskmovdqu %xmm3,%xmm2",
			"addr32 vmaskmovdqu %xmm3,%xmm2",
			"vmaskmovdqu %xmm3,%xmm2",
			"outsb %fs:(%si),%dx",
			"outsw %fs:(%si),%dx",
			"outsl %fs:(%si),%dx",
			"movsb %fs:(%si),%es:(%di)",
			"movsw %fs:(%si),%es:(%di)",
			"movsl %fs:(%si),%es:(%di)",
			"cmpsb %es:(%di),%fs:(%si)",
			"cmpsw %es:(%di),%fs:(%si)",
			"cmpsl %es:(%di),%fs:(%si)",
			"lods %fs:(%si),%al",
			"lods %fs:(%si),%ax",
			"lods %fs:(%si),%eax",
			"xlat (%ebx)",
			"xlat %fs:(%bx)",
			"fs maskmovq %mm3,%mm2",
			"fs maskmovdqu %xmm3,%xmm2",
			"fs vmaskmovdqu %xmm3,%xmm2",
			"xlat (%bx)",
			"aam",
			"aad",
			"aam $0xfa",
			"aad $0xfa",
			"fldenv (%bx,%si)",
			"fldenvs (%bx,%si)",
			"fnstenv (%bx,%si)",
			"fnstenvs (%bx,%si)",
			"frstor (%bx,%si)",
			"frstors (%bx,%si)",
			"fnsave (%bx,%si)",
			"fnsaves (%bx,%si)",
			"monitor",
			"addr32 monitor",
			"mwait",
			"mov %fs:0xf0de,%al",
			"addr32 mov %fs:0x78563412,%al",
			"mov %fs:0xf0de,%ax",
			"addr32 mov %fs:0x78563412,%ax",
			"mov %fs:0xf0de,%eax",
			"addr32 mov %fs:0x78563412,%eax",
			"mov %al,%fs:0xf0de",
			"addr32 mov %al,%fs:0x78563412",
			"mov %ax,%fs:0xf0de",
			"addr32 mov %ax,%fs:0x78563412",
			"mov %eax,%fs:0xf0de",
			"addr32 mov %eax,%fs:0x78563412",
			"mov (%bx,%si),%cl",
			"mov (%bx,%di),%cl",
			"mov (%bp,%si),%cl",
			"mov (%bp,%di),%cl",
			"mov (%si),%cl",
			"mov (%di),%cl",
			"mov 0xedcc,%cl",
			"mov 0x1234,%cl",
			"mov (%bx),%cl",
			"mov -0x12(%bx,%si),%cl",
			"mov -0x12(%bx,%di),%cl",
			"mov -0x12(%bp,%si),%cl",
			"mov -0x12(%bp,%di),%cl",
			"mov -0x12(%si),%cl",
			"mov -0x12(%di),%cl",
			"mov -0x12(%bp),%cl",
			"mov -0x12(%bx),%cl",
			"mov 0x12(%bx,%si),%cl",
			"mov 0x12(%bx,%di),%cl",
			"mov 0x12(%bp,%si),%cl",
			"mov 0x12(%bp,%di),%cl",
			"mov 0x12(%si),%cl",
			"mov 0x12(%di),%cl",
			"mov 0x12(%bp),%cl",
			"mov 0x12(%bx),%cl",
			"mov -0x1234(%bx,%si),%cl",
			"mov -0x1234(%bx,%di),%cl",
			"mov -0x1234(%bp,%si),%cl",
			"mov -0x1234(%bp,%di),%cl",
			"mov -0x1234(%si),%cl",
			"mov -0x1234(%di),%cl",
			"mov -0x1234(%bp),%cl",
			"mov -0x1234(%bx),%cl",
			"mov 0x1234(%bx,%si),%cl",
			"mov 0x1234(%bx,%di),%cl",
			"mov 0x1234(%bp,%si),%cl",
			"mov 0x1234(%bp,%di),%cl",
			"mov 0x1234(%si),%cl",
			"mov 0x1234(%di),%cl",
			"mov 0x1234(%bp),%cl",
			"mov 0x1234(%bx),%cl",
			"mov %fs:(%bx,%si),%cl",
			"mov %fs:(%bx,%di),%cl",
			"mov %fs:(%bp,%si),%cl",
			"mov %fs:(%bp,%di),%cl",
			"mov %fs:(%si),%cl",
			"mov %fs:(%di),%cl",
			"mov %fs:0xedcc,%cl",
			"mov %fs:0x1234,%cl",
			"mov %fs:(%bx),%cl",
			"mov %fs:-0x12(%bx,%si),%cl",
			"mov %fs:-0x12(%bx,%di),%cl",
			"mov %fs:-0x12(%bp,%si),%cl",
			"mov %fs:-0x12(%bp,%di),%cl",
			"mov %fs:-0x12(%si),%cl",
			"mov %fs:-0x12(%di),%cl",
			"mov %fs:-0x12(%bp),%cl",
			"mov %fs:-0x12(%bx),%cl",
			"mov %fs:0x12(%bx,%si),%cl",
			"mov %fs:0x12(%bx,%di),%cl",
			"mov %fs:0x12(%bp,%si),%cl",
			"mov %fs:0x12(%bp,%di),%cl",
			"mov %fs:0x12(%si),%cl",
			"mov %fs:0x12(%di),%cl",
			"mov %fs:0x12(%bp),%cl",
			"mov %fs:0x12(%bx),%cl",
			"mov %fs:-0x1234(%bx,%si),%cl",
			"mov %fs:-0x1234(%bx,%di),%cl",
			"mov %fs:-0x1234(%bp,%si),%cl",
			"mov %fs:-0x1234(%bp,%di),%cl",
			"mov %fs:-0x1234(%si),%cl",
			"mov %fs:-0x1234(%di),%cl",
			"mov %fs:-0x1234(%bp),%cl",
			"mov %fs:-0x1234(%bx),%cl",
			"mov %fs:0x1234(%bx,%si),%cl",
			"mov %fs:0x1234(%bx,%di),%cl",
			"mov %fs:0x1234(%bp,%si),%cl",
			"mov %fs:0x1234(%bp,%di),%cl",
			"mov %fs:0x1234(%si),%cl",
			"mov %fs:0x1234(%di),%cl",
			"mov %fs:0x1234(%bp),%cl",
			"mov %fs:0x1234(%bx),%cl",
			"arpl %si,%dx",
			"arpl %bx,(%bx,%si)",
			"vmrun",
			"addr32 vmrun",
			"vmload",
			"addr32 vmload",
			"vmsave",
			"addr32 vmsave",
			"invlpga",
			"addr32 invlpga",
			"monitorx",
			"addr32 monitorx",
			"clzero",
			"addr32 clzero",
		};
	}
}
#endif
