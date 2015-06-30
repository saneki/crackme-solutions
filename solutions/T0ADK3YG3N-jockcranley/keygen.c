/**
 * keygen for T0ADK3YG3N
 *  ~ saneki
 *
 * keygenme by jockcranley: http://crackmes.de/users/jockcranley/t0ad_k3yg3n/
 *
 * cl.exe keygen.c
**/

#include <stdio.h>

// Areas of interest: @004014C5, @004014ED (win32 program)
// -> @004014C5 generates the starting xor byte from username[1]
// -------------------------------------------------------------
// 004014C5 | 0F B6 44 24 24   | movzx eax,byte ptr ss:[esp+24]| ; eax: usernameStr[1]
// 004014CA | 66 0F BE D0      | movsx dx,al                   |
// 004014CE | 6B D2 56         | imul edx,edx,56               |
// 004014D1 | 66 C1 EA 08      | shr dx,8                      |
// 004014D5 | C0 F8 07         | sar al,7                      |
// 004014D8 | 89 D3            | mov ebx,edx                   |
// 004014DA | 29 C3            | sub ebx,eax                   |
// 004014DC | 89 D8            | mov eax,ebx                   |
// 004014DE | 0F BE C0         | movsx eax,al                  |
// 004014E1 | 89 44 24 3C      | mov dword ptr ss:[esp+3C],eax |
// -------------------------------------------------------------
// ...
// -> @004014ED generates the good password
// -------------------------------------------------------------
// 004014ED | EB 41            | jmp toadkey32.401530          |
// 004014EF | 8D 54 24 23      | lea edx,dword ptr ss:[esp+23] | ; edx: Username string
// 004014F3 | 8B 44 24 34      | mov eax,dword ptr ss:[esp+34] | ; Index
// 004014F7 | 01 D0            | add eax,edx                   |
// 004014F9 | 0F B6 00         | movzx eax,byte ptr ds:[eax]   | ; eax: usernameStr[i]
// 004014FC | 0F BE C0         | movsx eax,al                  |
// 004014FF | 33 44 24 3C      | xor eax,dword ptr ss:[esp+3C] |
// 00401503 | 83 E0 3C         | and eax,3C                    |
// 00401506 | 89 44 24 2C      | mov dword ptr ss:[esp+2C],eax |
// 0040150A | 8B 44 24 2C      | mov eax,dword ptr ss:[esp+2C] |
// 0040150E | 83 C0 30         | add eax,30                    |
// 00401511 | 8D 4C 24 11      | lea ecx,dword ptr ss:[esp+11] |
// 00401515 | 8B 54 24 34      | mov edx,dword ptr ss:[esp+34] |
// 00401519 | 01 CA            | add edx,ecx                   |
// 0040151B | 88 02            | mov byte ptr ds:[edx],al      |
// 0040151D | 8B 54 24 2C      | mov edx,dword ptr ss:[esp+2C] |
// 00401521 | 89 D0            | mov eax,edx                   |
// 00401523 | 01 C0            | add eax,eax                   |
// 00401525 | 01 D0            | add eax,edx                   |
// 00401527 | 89 44 24 3C      | mov dword ptr ss:[esp+3C],eax |
// 0040152B | 83 44 24 34 01   | add dword ptr ss:[esp+34],1   |
// 00401530 | 83 7C 24 34 08   | cmp dword ptr ss:[esp+34],8   |
// 00401535 | 7E B8            | jle toadkey32.4014EF          |
// -------------------------------------------------------------
void keygen(const char *username, char *key)
{
	int temp;
	char c;

	// Starting xor byte
	char xorc = ((unsigned short)(username[1] * 0x56)) >> 8;

	for(int i = 0; i < 8; i++)
	{
		c = username[i];

		c ^= xorc;
		c &= 0x3C;
		temp = c;
		c += 0x30;

		key[i] = c;

		xorc = temp * 3;
	}
}

int main(int argc, char *argv[])
{
	if(argc < 2)
	{
		printf("keygen for T0ADK3YG3N\n");
		printf("usage: keygen [username]\n");
		printf("  ~ saneki\n");
		return 0;
	}

	char *username = argv[1];

	if(strlen(username) < 8)
	{
		printf("Username must be at least 8 characters\n");
		return 1;
	}

	// Generate the key
	char key[9];
	key[8] = '\0';
	keygen(username, key);

	printf("Key: %s\n", key);

	return 0;
}