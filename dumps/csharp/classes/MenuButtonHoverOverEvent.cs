using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuButtonHoverOverEvent : redEvent
	{
		private CInt32 _buttonId;

		[Ordinal(0)] 
		[RED("buttonId")] 
		public CInt32 ButtonId
		{
			get => GetProperty(ref _buttonId);
			set => SetProperty(ref _buttonId, value);
		}

		public MenuButtonHoverOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
