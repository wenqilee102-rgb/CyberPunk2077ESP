using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSuggestedDefenseValues : CVariable
	{
		private CFloat _minArmor;
		private CFloat _maxArmor;
		private CFloat _minProtection;
		private CFloat _maxProtection;

		[Ordinal(0)] 
		[RED("minArmor")] 
		public CFloat MinArmor
		{
			get => GetProperty(ref _minArmor);
			set => SetProperty(ref _minArmor, value);
		}

		[Ordinal(1)] 
		[RED("maxArmor")] 
		public CFloat MaxArmor
		{
			get => GetProperty(ref _maxArmor);
			set => SetProperty(ref _maxArmor, value);
		}

		[Ordinal(2)] 
		[RED("minProtection")] 
		public CFloat MinProtection
		{
			get => GetProperty(ref _minProtection);
			set => SetProperty(ref _minProtection, value);
		}

		[Ordinal(3)] 
		[RED("maxProtection")] 
		public CFloat MaxProtection
		{
			get => GetProperty(ref _maxProtection);
			set => SetProperty(ref _maxProtection, value);
		}

		public gameSuggestedDefenseValues(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
