#include <ntifs.h>

void debug_print(PCSTR text)
{
#ifndef DEBUG
	UNREFERENCED_PARAMETER(text);
#endif

	KdPrintEx((DPFLTR_IHVDRIVER_ID, DPFLTR_INFO_LEVEL, text));
}

NTSTATUS DriverEntry()
{
	debug_print("[+] Entry to kernel.\n");

	return STATUS_SUCCESS;
}