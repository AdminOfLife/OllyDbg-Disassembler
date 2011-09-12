﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Disassembler
{
	class Program
	{

		static byte[] sample1 = new byte[] {
			0x81,0x05,0xE0,0x5A,0x47,0x00,0x01,0x00,0x00,0x00,0x11,0x22,0x33,0x44,0x55,0x66
		};

		static byte[] add1 = new byte[] {
			0x81,0x05,0xE0,0x5A,0x47,0x00,0x01,0x00,0x00,0x00
		};

		static byte[] call1 = new byte[] {
			0xE8,0x1F,0x14,0x00,0x00
		};

		static void Main(string[] args)
		{
			Disassemble.t_disasm asm = new Disassemble.t_disasm();

			Disassemble disam = new Disassemble();

			disam.Disasm(new ByteStream(call1), 0x450458, asm, Disassemble.DISASM_FILE);

			return;

		}
	}
}
