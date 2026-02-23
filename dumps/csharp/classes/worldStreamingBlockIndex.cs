using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingBlockIndex : CVariable
	{
		private CUInt32 _rldGridCell;
		private CEnum<worldStreamingDataGroup> _oup;

		[Ordinal(0)] 
		[RED("rldGridCell")] 
		public CUInt32 RldGridCell
		{
			get => GetProperty(ref _rldGridCell);
			set => SetProperty(ref _rldGridCell, value);
		}

		[Ordinal(1)] 
		[RED("oup")] 
		public CEnum<worldStreamingDataGroup> Oup
		{
			get => GetProperty(ref _oup);
			set => SetProperty(ref _oup, value);
		}

		public worldStreamingBlockIndex(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
