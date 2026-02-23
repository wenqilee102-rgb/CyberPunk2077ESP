using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlockStimProcessingCooldownEvent : redEvent
	{
		private StimIdentificationData _stimData;

		[Ordinal(0)] 
		[RED("stimData")] 
		public StimIdentificationData StimData
		{
			get => GetProperty(ref _stimData);
			set => SetProperty(ref _stimData, value);
		}

		public BlockStimProcessingCooldownEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
