public class Crc32{
    // The CRC-32 polynomial
    private const uint Polynomial = 0xedb88320;
    private const uint DefaultSeed = 0xffffffff;

    private static uint[] _table;

    public static uint Compute(byte[] bytes) {
        return Compute(DefaultSeed, bytes);
    }

    public static uint Compute(uint seed, byte[] bytes) {
        uint crc = seed;
        for (int i = 0; i < bytes.Length; i++) {
            unchecked {
                crc = _table[(crc ^ bytes[i]) & 0xff] ^ (crc >> 8);
            }
        }
        return crc ^ 0xffffffff;
    }

    static Crc32() {
        _table = new uint[256];
        uint temp = 0;
        for (uint i = 0; i < _table.Length; i++) {
            temp = i;
            for (int j = 8; j > 0; j--) {
                if ((temp & 1) == 1) {
                    temp = (temp >> 1) ^ Polynomial;
                } else {
                    temp >>= 1;
                }
            }
            _table[i] = temp;
        }
    }

}