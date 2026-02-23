using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NormalizeAndSaveSwayEvent : redEvent
	{
		private Vector2 _sway;

		[Ordinal(0)] 
		[RED("sway")] 
		public Vector2 Sway
		{
			get => GetProperty(ref _sway);
			set => SetProperty(ref _sway, value);
		}

		public NormalizeAndSaveSwayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
