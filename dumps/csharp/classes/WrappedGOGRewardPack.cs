using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WrappedGOGRewardPack : IScriptable
	{
		private CUInt64 _index;
		private gameRewardPack _data;

		[Ordinal(0)] 
		[RED("index")] 
		public CUInt64 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameRewardPack Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public WrappedGOGRewardPack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
