#include <stdint.h>

const char *exception_str[] = {
    "Divide By Zero",
    "Debug",
    "Non-maskable Interrupt",
    "Breakpoint",
    "Overflow",
    "Bound Range Exceeded",
    "Invalid Opcode",
    "Device Not Available",
    "Double Fault",
    "Coprocessor Segment Overrun",
    "Invalid TSS",
    "Segment Not Present",
    "Stack-Segment Fault",
    "General Protection Fault",
    "Page Fault",
    "RESERVED",
    "x87 Floating-Point",
    "Alignment Check",
    "Machine Check",
    "SIMD Floating-Point",
    "Virtualization",
    "Security Exception"
};

struct IDTDescr {
   uint16_t offset_1; // offset bits 0..15
   uint16_t selector; // a code segment selector in GDT or LDT
   uint8_t zero;      // unused, set to 0
   uint8_t type_attr; // type and attributes, see below
   uint16_t offset_2; // offset bits 16..31
}; __attribute__((packed));

struct IDTPointer
{
	uint16_t size;
	uint64_t addr;
} __attribute__((packed));

static struct IDTDescr idt_entries[256] = { 0 };
static struct IDTPointer idt_pointer = { 0 };

extern "C" void _ZN6kernel6Kernel3IDTM_0_7LoadIDT_Rv_P0()
{
    asm volatile("lidt %0" ::"m"(idt_pointer));
}
