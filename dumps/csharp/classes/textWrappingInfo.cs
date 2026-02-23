using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textWrappingInfo : CVariable
	{
		private CBool _autoWrappingEnabled;
		private CFloat _wrappingAtPosition;
		private CEnum<textWrappingPolicy> _wrappingPolicy;
		private CBool _forceMinimumWidthToWrappingAtPosition;

		[Ordinal(0)] 
		[RED("autoWrappingEnabled")] 
		public CBool AutoWrappingEnabled
		{
			get => GetProperty(ref _autoWrappingEnabled);
			set => SetProperty(ref _autoWrappingEnabled, value);
		}

		[Ordinal(1)] 
		[RED("wrappingAtPosition")] 
		public CFloat WrappingAtPosition
		{
			get => GetProperty(ref _wrappingAtPosition);
			set => SetProperty(ref _wrappingAtPosition, value);
		}

		[Ordinal(2)] 
		[RED("wrappingPolicy")] 
		public CEnum<textWrappingPolicy> WrappingPolicy
		{
			get => GetProperty(ref _wrappingPolicy);
			set => SetProperty(ref _wrappingPolicy, value);
		}

		[Ordinal(3)] 
		[RED("forceMinimumWidthToWrappingAtPosition")] 
		public CBool ForceMinimumWidthToWrappingAtPosition
		{
			get => GetProperty(ref _forceMinimumWidthToWrappingAtPosition);
			set => SetProperty(ref _forceMinimumWidthToWrappingAtPosition, value);
		}

		public textWrappingInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
