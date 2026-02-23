using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioBlip : CVariable
	{
		private CName _blipEventName;

		[Ordinal(0)] 
		[RED("blipEventName")] 
		public CName BlipEventName
		{
			get => GetProperty(ref _blipEventName);
			set => SetProperty(ref _blipEventName, value);
		}

		public audioRadioBlip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
