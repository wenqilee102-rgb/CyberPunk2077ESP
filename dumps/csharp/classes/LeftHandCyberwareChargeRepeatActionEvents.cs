using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareChargeRepeatActionEvents : LeftHandCyberwareActionAbstractEvents
	{
		private CFloat _maxSpread;
		private CInt32 _maxProjectiles;

		[Ordinal(3)] 
		[RED("maxSpread")] 
		public CFloat MaxSpread
		{
			get => GetProperty(ref _maxSpread);
			set => SetProperty(ref _maxSpread, value);
		}

		[Ordinal(4)] 
		[RED("maxProjectiles")] 
		public CInt32 MaxProjectiles
		{
			get => GetProperty(ref _maxProjectiles);
			set => SetProperty(ref _maxProjectiles, value);
		}

		public LeftHandCyberwareChargeRepeatActionEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
