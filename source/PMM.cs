namespace Kernel
{
    public unsafe class PMM
    {
        /*public ulong mem_size;
        public ulong used_blocks;
        public ulong max_blocks;
        public ulong* pmmap;
        public ulong pmmap_size;

        public readonly uint BLOCK_SIZE = 1024;
        public readonly uint BLOCKS_PER_DWORD = 32;

        public long KBToBlocks(ulong kb)
        {
            return (((x) * 1024) / BLOCK_SIZE);
        }

        public unsafe void bitmap_set(ulong *bitmap, int bit) 
        {
            bitmap[bit / 32] |= (1 << (bit % 32));
        }

        public unsafe void bitmap_unset(ulong *bitmap, int bit) 
        {
            bitmap[bit / 32] &= ~(1 << (bit % 32));
        }

        public void pmm_init_region(ulong _base, ulong size) 
        {
            uint blocks  = size / BLOCK_SIZE;
            ulong align = _base / BLOCK_SIZE;

            for (ulong i = 0; i < blocks; i++) {

                bitmap_unset(pmmap, align++);
                used_blocks--;

            }

            bitmap_set(pmmap, 0);
        }       

        void pmm_deinit_region(ulong _base, ulong size) {

            ulong blocks = size / BLOCK_SIZE;
            uint align = _base / BLOCK_SIZE;

            for (uint i = 0; i < blocks; i++) {

                bitmap_set(pmmap, align++);
                used_blocks++;
            }

        }

        public unsafe void InitPMM(ulong addr, ulong size)
        {
            mem_size = size;
            max_blocks = KbToBlocks(mem_size);
            used_blocks = max_blocks;
            pmmap = (uint *) pmmap_addr;

            pmmap_size = max_blocks / BLOCKS_PER_DWORD;
            if (max_blocks % BLOCKS_PER_DWORD)
                pmmap_size++;

            MemMM.memset(pmmap, 0xFF, pmmap_size);
        }*/
    }
}