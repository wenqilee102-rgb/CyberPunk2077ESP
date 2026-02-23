using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureCompensationOffsetAreaSettings : IAreaSettings
	{
		private CFloat _exposureCompensationOffset;

		[Ordinal(2)] 
		[RED("exposureCompensationOffset")] 
		public CFloat ExposureCompensationOffset
		{
			get => GetProperty(ref _exposureCompensationOffset);
			set => SetProperty(ref _exposureCompensationOffset, value);
		}

		public ExposureCompensationOffsetAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
