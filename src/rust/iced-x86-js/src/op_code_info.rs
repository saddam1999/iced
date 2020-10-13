/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

use super::code::{iced_to_code, Code};
use super::encoding_kind::{iced_to_encoding_kind, EncodingKind};
use super::mandatory_prefix::{iced_to_mandatory_prefix, MandatoryPrefix};
use super::op_code_operand_kind::{iced_to_op_code_operand_kind, OpCodeOperandKind};
use super::op_code_table_kind::{iced_to_op_code_table_kind, OpCodeTableKind};
use super::tuple_type::{iced_to_tuple_type, TupleType};
use wasm_bindgen::prelude::*;

/// Opcode info, returned by [`Instruction.opCode`]
///
/// [`Instruction.opCode`]: struct.Instruction.html#method.op_code
#[wasm_bindgen]
pub struct OpCodeInfo(pub(crate) &'static iced_x86_rust::OpCodeInfo);

#[wasm_bindgen]
impl OpCodeInfo {
	/// Gets the code (a [`Code`] enum value)
	///
	/// [`Code`]: enum.Code.html
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode = CodeExt.opCode(Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	/// assert.equal(opCode.code, Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	///
	/// // Free wasm memory
	/// opCode.free();
	/// ```
	#[wasm_bindgen(getter)]
	pub fn code(&self) -> Code {
		iced_to_code(self.0.code())
	}

	/// Gets the encoding (a [`EncodingKind`] enum value)
	///
	/// [`EncodingKind`]: enum.EncodingKind.html
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt, EncodingKind } = require("iced-x86");
	///
	/// const opCode = CodeExt.opCode(Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	/// assert.equal(opCode.encoding, EncodingKind.EVEX);
	///
	/// // Free wasm memory
	/// opCode.free();
	/// ```
	#[wasm_bindgen(getter)]
	pub fn encoding(&self) -> EncodingKind {
		iced_to_encoding_kind(self.0.encoding())
	}

	/// `true` if it's an instruction, `false` if it's eg. [`Code.INVALID`], [`db`], [`dw`], [`dd`], [`dq`]
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode1 = CodeExt.opCode(Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	/// assert.ok(opCode1.isInstruction);
	/// const opCode2 = CodeExt.opCode(Code.INVALID);
	/// assert.ok(!opCode2.isInstruction);
	/// const opCode3 = CodeExt.opCode(Code.DeclareByte);
	/// assert.ok(!opCode3.isInstruction);
	///
	/// // Free wasm memory
	/// opCode1.free();
	/// opCode2.free();
	/// opCode3.free();
	/// ```
	///
	/// [`Code.INVALID`]: enum.Code.html#variant.INVALID
	/// [`db`]: enum.Code.html#variant.DeclareByte
	/// [`dw`]: enum.Code.html#variant.DeclareWord
	/// [`dd`]: enum.Code.html#variant.DeclareDword
	/// [`dq`]: enum.Code.html#variant.DeclareQword
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isInstruction")]
	pub fn is_instruction(&self) -> bool {
		self.0.is_instruction()
	}

	/// `true` if it's an instruction available in 16-bit mode
	#[wasm_bindgen(getter)]
	pub fn mode16(&self) -> bool {
		self.0.mode16()
	}

	/// `true` if it's an instruction available in 32-bit mode
	#[wasm_bindgen(getter)]
	pub fn mode32(&self) -> bool {
		self.0.mode32()
	}

	/// `true` if it's an instruction available in 64-bit mode
	#[wasm_bindgen(getter)]
	pub fn mode64(&self) -> bool {
		self.0.mode64()
	}

	/// `true` if an `FWAIT` (`9B`) instruction is added before the instruction
	#[wasm_bindgen(getter)]
	pub fn fwait(&self) -> bool {
		self.0.fwait()
	}

	/// (Legacy encoding) Gets the required operand size (16,32,64) or 0
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "operandSize")]
	pub fn operand_size(&self) -> u32 {
		self.0.operand_size()
	}

	/// (Legacy encoding) Gets the required address size (16,32,64) or 0
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "addressSize")]
	pub fn address_size(&self) -> u32 {
		self.0.address_size()
	}

	/// (VEX/XOP/EVEX) `L` / `L'L` value or default value if [`isLIG`] is `true`
	///
	/// [`isLIG`]: #method.is_lig
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "L")]
	pub fn l(&self) -> u32 {
		self.0.l()
	}

	/// (VEX/XOP/EVEX) `W` value or default value if [`isWIG`] or [`isWIG32`] is `true`
	///
	/// [`isWIG`]: #method.is_wig
	/// [`isWIG32`]: #method.is_wig32
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "W")]
	pub fn w(&self) -> u32 {
		self.0.w()
	}

	/// (VEX/XOP/EVEX) `true` if the `L` / `L'L` fields are ignored.
	///
	/// EVEX: if reg-only ops and `{er}` (`EVEX.b` is set), `L'L` is the rounding control and not ignored.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isLIG")]
	pub fn is_lig(&self) -> bool {
		self.0.is_lig()
	}

	/// (VEX/XOP/EVEX) `true` if the `W` field is ignored in 16/32/64-bit modes
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isWIG")]
	pub fn is_wig(&self) -> bool {
		self.0.is_wig()
	}

	/// (VEX/XOP/EVEX) `true` if the `W` field is ignored in 16/32-bit modes (but not 64-bit mode)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isWIG32")]
	pub fn is_wig32(&self) -> bool {
		self.0.is_wig32()
	}

	/// (EVEX) Gets the tuple type (a [`TupleType`] enum value)
	///
	/// [`TupleType`]: enum.TupleType.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tupleType")]
	pub fn tuple_type(&self) -> TupleType {
		iced_to_tuple_type(self.0.tuple_type())
	}

	/// (EVEX) `true` if the instruction supports broadcasting (`EVEX.b` bit) (if it has a memory operand)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canBroadcast")]
	pub fn can_broadcast(&self) -> bool {
		self.0.can_broadcast()
	}

	/// (EVEX) `true` if the instruction supports rounding control
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseRoundingControl")]
	pub fn can_use_rounding_control(&self) -> bool {
		self.0.can_use_rounding_control()
	}

	/// (EVEX) `true` if the instruction supports suppress all exceptions
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canSuppressAllExceptions")]
	pub fn can_suppress_all_exceptions(&self) -> bool {
		self.0.can_suppress_all_exceptions()
	}

	/// (EVEX) `true` if an op mask register can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseOpMaskRegister")]
	pub fn can_use_op_mask_register(&self) -> bool {
		self.0.can_use_op_mask_register()
	}

	/// (EVEX) `true` if a non-zero op mask register must be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "requireOpMaskRegister")]
	pub fn require_op_mask_register(&self) -> bool {
		self.0.require_op_mask_register()
	}

	/// (EVEX) `true` if the instruction supports zeroing masking (if one of the op mask registers `K1`-`K7` is used and destination operand is not a memory operand)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseZeroingMasking")]
	pub fn can_use_zeroing_masking(&self) -> bool {
		self.0.can_use_zeroing_masking()
	}

	/// `true` if the `LOCK` (`F0`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseLockPrefix")]
	pub fn can_use_lock_prefix(&self) -> bool {
		self.0.can_use_lock_prefix()
	}

	/// `true` if the `XACQUIRE` (`F2`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseXacquirePrefix")]
	pub fn can_use_xacquire_prefix(&self) -> bool {
		self.0.can_use_xacquire_prefix()
	}

	/// `true` if the `XRELEASE` (`F3`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseXreleasePrefix")]
	pub fn can_use_xrelease_prefix(&self) -> bool {
		self.0.can_use_xrelease_prefix()
	}

	/// `true` if the `REP` / `REPE` (`F3`) prefixes can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseRepPrefix")]
	pub fn can_use_rep_prefix(&self) -> bool {
		self.0.can_use_rep_prefix()
	}

	/// `true` if the `REPNE` (`F2`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseRepnePrefix")]
	pub fn can_use_repne_prefix(&self) -> bool {
		self.0.can_use_repne_prefix()
	}

	/// `true` if the `BND` (`F2`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseBndPrefix")]
	pub fn can_use_bnd_prefix(&self) -> bool {
		self.0.can_use_bnd_prefix()
	}

	/// `true` if the `HINT-TAKEN` (`3E`) and `HINT-NOT-TAKEN` (`2E`) prefixes can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseHintTakenPrefix")]
	pub fn can_use_hint_taken_prefix(&self) -> bool {
		self.0.can_use_hint_taken_prefix()
	}

	/// `true` if the `NOTRACK` (`3E`) prefix can be used
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "canUseNotrackPrefix")]
	pub fn can_use_notrack_prefix(&self) -> bool {
		self.0.can_use_notrack_prefix()
	}

	/// `true` if rounding control is ignored (#UD is not generated)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "ignoresRoundingControl")]
	pub fn ignores_rounding_control(&self) -> bool {
		self.0.ignores_rounding_control()
	}

	/// `true` if the `LOCK` prefix can be used as an extra register bit (bit 3) to access registers 8-15 without a `REX` prefix (eg. in 32-bit mode)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdLockRegBit")]
	pub fn amd_lock_reg_bit(&self) -> bool {
		self.0.amd_lock_reg_bit()
	}

	/// `true` if the default operand size is 64 in 64-bit mode. A `66` prefix can switch to 16-bit operand size.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "defaultOpSize64")]
	pub fn default_op_size64(&self) -> bool {
		self.0.default_op_size64()
	}

	/// `true` if the operand size is always 64 in 64-bit mode. A `66` prefix is ignored.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "forceOpSize64")]
	pub fn force_op_size64(&self) -> bool {
		self.0.force_op_size64()
	}

	/// `true` if the Intel decoder forces 64-bit operand size. A `66` prefix is ignored.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelForceOpSize64")]
	pub fn intel_force_op_size64(&self) -> bool {
		self.0.intel_force_op_size64()
	}

	/// `true` if it can only be executed when CPL=0
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "mustBeCpl0")]
	pub fn must_be_cpl0(&self) -> bool {
		self.0.must_be_cpl0()
	}

	/// `true` if it can be executed when CPL=0
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "cpl0")]
	pub fn cpl0(&self) -> bool {
		self.0.cpl0()
	}

	/// `true` if it can be executed when CPL=1
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "cpl1")]
	pub fn cpl1(&self) -> bool {
		self.0.cpl1()
	}

	/// `true` if it can be executed when CPL=2
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "cpl2")]
	pub fn cpl2(&self) -> bool {
		self.0.cpl2()
	}

	/// `true` if it can be executed when CPL=3
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "cpl3")]
	pub fn cpl3(&self) -> bool {
		self.0.cpl3()
	}

	/// `true` if the instruction accesses the I/O address space (eg. `IN`, `OUT`, `INS`, `OUTS`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isInputOutput")]
	pub fn is_input_output(&self) -> bool {
		self.0.is_input_output()
	}

	/// `true` if it's one of the many nop instructions (does not include FPU nop instructions, eg. `FNOP`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isNop")]
	pub fn is_nop(&self) -> bool {
		self.0.is_nop()
	}

	/// `true` if it's one of the many reserved nop instructions (eg. `0F0D`, `0F18-0F1F`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isReservedNop")]
	pub fn is_reserved_nop(&self) -> bool {
		self.0.is_reserved_nop()
	}

	/// `true` if it's a serializing instruction (Intel CPUs)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isSerializingIntel")]
	pub fn is_serializing_intel(&self) -> bool {
		self.0.is_serializing_intel()
	}

	/// `true` if it's a serializing instruction (AMD CPUs)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isSerializingAmd")]
	pub fn is_serializing_amd(&self) -> bool {
		self.0.is_serializing_amd()
	}

	/// `true` if the instruction requires either CPL=0 or CPL<=3 depending on some CPU option (eg. `CR4.TSD`, `CR4.PCE`, `CR4.UMIP`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "mayRequireCpl0")]
	pub fn may_require_cpl0(&self) -> bool {
		self.0.may_require_cpl0()
	}

	/// `true` if it's a tracked `JMP`/`CALL` indirect instruction (CET)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isCetTracked")]
	pub fn is_cet_tracked(&self) -> bool {
		self.0.is_cet_tracked()
	}

	/// `true` if it's a non-temporal hint memory access (eg. `MOVNTDQ`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isNonTemporal")]
	pub fn is_non_temporal(&self) -> bool {
		self.0.is_non_temporal()
	}

	/// `true` if it's a no-wait FPU instruction, eg. `FNINIT`
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isFpuNoWait")]
	pub fn is_fpu_no_wait(&self) -> bool {
		self.0.is_fpu_no_wait()
	}

	/// `true` if the mod bits are ignored and it's assumed `modrm[7:6] == 11b`
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "ignoresModBits")]
	pub fn ignores_mod_bits(&self) -> bool {
		self.0.ignores_mod_bits()
	}

	/// `true` if the `66` prefix is not allowed (it will #UD)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "no66")]
	pub fn no66(&self) -> bool {
		self.0.no66()
	}

	/// `true` if the `F2`/`F3` prefixes aren't allowed
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "nfx")]
	pub fn nfx(&self) -> bool {
		self.0.nfx()
	}

	/// `true` if the index reg's reg-num (vsib op) (if any) and register ops' reg-nums must be unique,
	/// eg. `MNEMONIC XMM1,YMM1,[RAX+ZMM1*2]` is invalid. Registers = `XMM`/`YMM`/`ZMM`/`TMM`.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "requiresUniqueRegNums")]
	pub fn requires_unique_reg_nums(&self) -> bool {
		self.0.requires_unique_reg_nums()
	}

	/// `true` if it's a privileged instruction (all CPL=0 instructions (except `VMCALL`) and IOPL instructions `IN`, `INS`, `OUT`, `OUTS`, `CLI`, `STI`)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isPrivileged")]
	pub fn is_privileged(&self) -> bool {
		self.0.is_privileged()
	}

	/// `true` if it reads/writes too many registers
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isSaveRestore")]
	pub fn is_save_restore(&self) -> bool {
		self.0.is_save_restore()
	}

	/// `true` if it's an instruction that implicitly uses the stack register, eg. `CALL`, `POP`, etc
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isStackInstruction")]
	pub fn is_stack_instruction(&self) -> bool {
		self.0.is_stack_instruction()
	}

	/// `true` if the instruction doesn't read the segment register if it uses a memory operand
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "ignoresSegment")]
	pub fn ignores_segment(&self) -> bool {
		self.0.ignores_segment()
	}

	/// `true` if the op mask register is read and written (instead of just read). This also implies that it can't be `K0`.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isOpMaskReadWrite")]
	pub fn is_op_mask_read_write(&self) -> bool {
		self.0.is_op_mask_read_write()
	}

	/// `true` if it can be executed in real mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "realMode")]
	pub fn real_mode(&self) -> bool {
		self.0.real_mode()
	}

	/// `true` if it can be executed in protected mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "protectedMode")]
	pub fn protected_mode(&self) -> bool {
		self.0.protected_mode()
	}

	/// `true` if it can be executed in virtual 8086 mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "virtual8086Mode")]
	pub fn virtual8086_mode(&self) -> bool {
		self.0.virtual8086_mode()
	}

	/// `true` if it can be executed in compatibility mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "compatibilityMode")]
	pub fn compatibility_mode(&self) -> bool {
		self.0.compatibility_mode()
	}

	/// `true` if it can be executed in 64-bit mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "longMode")]
	pub fn long_mode(&self) -> bool {
		self.0.long_mode()
	}

	/// `true` if it can be used outside SMM
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useOutsideSmm")]
	pub fn use_outside_smm(&self) -> bool {
		self.0.use_outside_smm()
	}

	/// `true` if it can be used in SMM
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInSmm")]
	pub fn use_in_smm(&self) -> bool {
		self.0.use_in_smm()
	}

	/// `true` if it can be used outside an enclave (SGX)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useOutsideEnclaveSgx")]
	pub fn use_outside_enclave_sgx(&self) -> bool {
		self.0.use_outside_enclave_sgx()
	}

	/// `true` if it can be used inside an enclave (SGX1)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInEnclaveSgx1")]
	pub fn use_in_enclave_sgx1(&self) -> bool {
		self.0.use_in_enclave_sgx1()
	}

	/// `true` if it can be used inside an enclave (SGX2)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInEnclaveSgx2")]
	pub fn use_in_enclave_sgx2(&self) -> bool {
		self.0.use_in_enclave_sgx2()
	}

	/// `true` if it can be used outside VMX operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useOutsideVmxOp")]
	pub fn use_outside_vmx_op(&self) -> bool {
		self.0.use_outside_vmx_op()
	}

	/// `true` if it can be used in VMX root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInVmxRootOp")]
	pub fn use_in_vmx_root_op(&self) -> bool {
		self.0.use_in_vmx_root_op()
	}

	/// `true` if it can be used in VMX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInVmxNonRootOp")]
	pub fn use_in_vmx_non_root_op(&self) -> bool {
		self.0.use_in_vmx_non_root_op()
	}

	/// `true` if it can be used outside SEAM
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useOutsideSeam")]
	pub fn use_outside_seam(&self) -> bool {
		self.0.use_outside_seam()
	}

	/// `true` if it can be used in SEAM
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "useInSeam")]
	pub fn use_in_seam(&self) -> bool {
		self.0.use_in_seam()
	}

	/// `true` if #UD is generated in TDX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tdxNonRootGenUd")]
	pub fn tdx_non_root_gen_ud(&self) -> bool {
		self.0.tdx_non_root_gen_ud()
	}

	/// `true` if #VE is generated in TDX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tdxNonRootGenVe")]
	pub fn tdx_non_root_gen_ve(&self) -> bool {
		self.0.tdx_non_root_gen_ve()
	}

	/// `true` if an exception (eg. #GP(0), #VE) may be generated in TDX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tdxNonRootMayGenEx")]
	pub fn tdx_non_root_may_gen_ex(&self) -> bool {
		self.0.tdx_non_root_may_gen_ex()
	}

	/// (Intel VMX) `true` if it causes a VM exit in VMX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelVmExit")]
	pub fn intel_vm_exit(&self) -> bool {
		self.0.intel_vm_exit()
	}

	/// (Intel VMX) `true` if it may cause a VM exit in VMX non-root operation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelMayVmExit")]
	pub fn intel_may_vm_exit(&self) -> bool {
		self.0.intel_may_vm_exit()
	}

	/// (Intel VMX) `true` if it causes an SMM VM exit in VMX root operation (if dual-monitor treatment is activated)
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelSmmVmExit")]
	pub fn intel_smm_vm_exit(&self) -> bool {
		self.0.intel_smm_vm_exit()
	}

	/// (AMD SVM) `true` if it causes a #VMEXIT in guest mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdVmExit")]
	pub fn amd_vm_exit(&self) -> bool {
		self.0.amd_vm_exit()
	}

	/// (AMD SVM) `true` if it may cause a #VMEXIT in guest mode
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdMayVmExit")]
	pub fn amd_may_vm_exit(&self) -> bool {
		self.0.amd_may_vm_exit()
	}

	/// `true` if it causes a TSX abort inside a TSX transaction
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tsxAbort")]
	pub fn tsx_abort(&self) -> bool {
		self.0.tsx_abort()
	}

	/// `true` if it causes a TSX abort inside a TSX transaction depending on the implementation
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tsxImplAbort")]
	pub fn tsx_impl_abort(&self) -> bool {
		self.0.tsx_impl_abort()
	}

	/// `true` if it may cause a TSX abort inside a TSX transaction depending on some condition
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "tsxMayAbort")]
	pub fn tsx_may_abort(&self) -> bool {
		self.0.tsx_may_abort()
	}

	/// `true` if it's decoded by iced's 16-bit Intel decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelDecoder16")]
	pub fn intel_decoder16(&self) -> bool {
		self.0.intel_decoder16()
	}

	/// `true` if it's decoded by iced's 32-bit Intel decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelDecoder32")]
	pub fn intel_decoder32(&self) -> bool {
		self.0.intel_decoder32()
	}

	/// `true` if it's decoded by iced's 64-bit Intel decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "intelDecoder64")]
	pub fn intel_decoder64(&self) -> bool {
		self.0.intel_decoder64()
	}

	/// `true` if it's decoded by iced's 16-bit AMD decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdDecoder16")]
	pub fn amd_decoder16(&self) -> bool {
		self.0.amd_decoder16()
	}

	/// `true` if it's decoded by iced's 32-bit AMD decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdDecoder32")]
	pub fn amd_decoder32(&self) -> bool {
		self.0.amd_decoder32()
	}

	/// `true` if it's decoded by iced's 64-bit AMD decoder
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "amdDecoder64")]
	pub fn amd_decoder64(&self) -> bool {
		self.0.amd_decoder64()
	}

	/// Gets the decoder option that's needed to decode the instruction or [`DecoderOptions::None`].
	/// The return value is a [`DecoderOptions`] value.
	///
	/// [`DecoderOptions::None`]: struct.DecoderOptions.html#associatedconstant.NONE
	/// [`DecoderOptions`]: struct.DecoderOptions.html
	#[cfg(feature = "decoder")]
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "decoderOption")]
	pub fn decoder_option(&self) -> u32 {
		self.0.decoder_option()
	}

	/// Gets the opcode table (a [`OpCodeTableKind`] enum value)
	///
	/// [`OpCodeTableKind`]: enum.OpCodeTableKind.html
	#[wasm_bindgen(getter)]
	pub fn table(&self) -> OpCodeTableKind {
		iced_to_op_code_table_kind(self.0.table())
	}

	/// Gets the mandatory prefix (a [`MandatoryPrefix`] enum value)
	///
	/// [`MandatoryPrefix`]: enum.MandatoryPrefix.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "mandatoryPrefix")]
	pub fn mandatory_prefix(&self) -> MandatoryPrefix {
		iced_to_mandatory_prefix(self.0.mandatory_prefix())
	}

	/// Gets the opcode byte(s). The low byte(s) of this value is the opcode. The length is in [`opCodeLength`].
	/// It doesn't include the table value, see [`table`].
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode1 = CodeExt.opCode(Code.Ffreep_sti);
	/// assert.equal(opCode1.opCode, 0xDFC0);
	/// const opCode2 = CodeExt.opCode(Code.Vmrunw);
	/// assert.equal(opCode2.opCode, 0x01D8);
	/// const opCode3 = CodeExt.opCode(Code.Sub_r8_rm8);
	/// assert.equal(opCode3.opCode, 0x2A);
	/// const opCode4 = CodeExt.opCode(Code.Cvtpi2ps_xmm_mmm64);
	/// assert.equal(opCode4.opCode, 0x2A);
	///
	/// // Free wasm memory
	/// opCode1.free();
	/// opCode2.free();
	/// opCode3.free();
	/// opCode4.free();
	/// ```
	///
	/// [`opCodeLength`]: #method.op_code_len
	/// [`table`]: #method.table
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "opCode")]
	pub fn op_code(&self) -> u32 {
		self.0.op_code()
	}

	/// Gets the length of the opcode bytes ([`opCode`]). The low bytes is the opcode value.
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode1 = CodeExt.opCode(Code.Ffreep_sti);
	/// assert.equal(opCode1.opCodeLength, 2);
	/// const opCode2 = CodeExt.opCode(Code.Vmrunw);
	/// assert.equal(opCode2.opCodeLength, 2);
	/// const opCode3 = CodeExt.opCode(Code.Sub_r8_rm8);
	/// assert.equal(opCode3.opCodeLength, 1);
	/// const opCode4 = CodeExt.opCode(Code.Cvtpi2ps_xmm_mmm64);
	/// assert.equal(opCode4.opCodeLength, 1);
	///
	/// // Free wasm memory
	/// opCode1.free();
	/// opCode2.free();
	/// opCode3.free();
	/// opCode4.free();
	/// ```
	///
	/// [`opCode`]: #method.op_code
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "opCodeLength")]
	pub fn op_code_len(&self) -> u32 {
		self.0.op_code_len()
	}

	/// `true` if it's part of a group
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isGroup")]
	pub fn is_group(&self) -> bool {
		self.0.is_group()
	}

	/// Group index (0-7) or -1. If it's 0-7, it's stored in the `reg` field of the `modrm` byte.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "groupIndex")]
	pub fn group_index(&self) -> i32 {
		self.0.group_index()
	}

	/// `true` if it's part of a modrm.rm group
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "isRmGroup")]
	pub fn is_rm_group(&self) -> bool {
		self.0.is_rm_group()
	}

	/// Group index (0-7) or -1. If it's 0-7, it's stored in the `rm` field of the `modrm` byte.
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "rmGroupIndex")]
	pub fn rm_group_index(&self) -> i32 {
		self.0.rm_group_index()
	}

	/// Gets the number of operands
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "opCount")]
	pub fn op_count(&self) -> u32 {
		self.0.op_count()
	}

	/// Gets operand #0's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "op0Kind")]
	pub fn op0_kind(&self) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op0_kind())
	}

	/// Gets operand #1's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "op1Kind")]
	pub fn op1_kind(&self) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op1_kind())
	}

	/// Gets operand #2's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "op2Kind")]
	pub fn op2_kind(&self) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op2_kind())
	}

	/// Gets operand #3's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "op3Kind")]
	pub fn op3_kind(&self) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op3_kind())
	}

	/// Gets operand #4's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "op4Kind")]
	pub fn op4_kind(&self) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op4_kind())
	}

	/// Gets an operand's opkind (a [`OpCodeOperandKind`] enum value)
	///
	/// [`OpCodeOperandKind`]: enum.OpCodeOperandKind.html
	///
	/// # Throws
	///
	/// Throws if `operand` is invalid
	///
	/// # Arguments
	///
	/// * `operand`: Operand number, 0-4
	#[wasm_bindgen(js_name = "opKind")]
	pub fn op_kind(&self, operand: u32) -> OpCodeOperandKind {
		iced_to_op_code_operand_kind(self.0.op_kind(operand))
	}

	/// Checks if the instruction is available in 16-bit mode, 32-bit mode or 64-bit mode
	///
	/// # Throws
	///
	/// Throws if `bitness` is not one of 16, 32, 64.
	///
	/// # Arguments
	///
	/// * `bitness`: 16, 32 or 64
	#[wasm_bindgen(js_name = "isAvailableInMode")]
	pub fn is_available_in_mode(&self, bitness: u32) -> bool {
		self.0.is_available_in_mode(bitness)
	}

	/// Gets the opcode string, eg. `VEX.128.66.0F38.W0 78 /r`, see also [`instructionString`]
	///
	/// [`instructionString`]: #method.instruction_string
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode = CodeExt.opCode(Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	/// assert.equal(opCode.opCodeString, "EVEX.256.66.0F.W1 28 /r");
	///
	/// // Free wasm memory
	/// opCode.free();
	/// ```
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "opCodeString")]
	pub fn op_code_string(&self) -> String {
		self.0.op_code_string().to_owned()
	}

	/// Gets the instruction string, eg. `VPBROADCASTB xmm1, xmm2/m8`, see also [`opCodeString`]
	///
	/// [`opCodeString`]: #method.op_code_string
	///
	/// # Examples
	///
	/// ```js
	/// const assert = require("assert").strict;
	/// const { Code, CodeExt } = require("iced-x86");
	///
	/// const opCode = CodeExt.opCode(Code.EVEX_Vmovapd_ymm_k1z_ymmm256);
	/// assert.equal("VMOVAPD ymm1 {k1}{z}, ymm2/m256", opCode.instructionString);
	///
	/// // Free wasm memory
	/// opCode.free();
	/// ```
	#[wasm_bindgen(getter)]
	#[wasm_bindgen(js_name = "instructionString")]
	pub fn instruction_string(&self) -> String {
		self.0.instruction_string().to_owned()
	}
}
