using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FireFXEvent : redEvent
	{
		private CName _sFX;
		private CName _vFX;

		[Ordinal(0)] 
		[RED("sFX")] 
		public CName SFX
		{
			get => GetProperty(ref _sFX);
			set => SetProperty(ref _sFX, value);
		}

		[Ordinal(1)] 
		[RED("vFX")] 
		public CName VFX
		{
			get => GetProperty(ref _vFX);
			set => SetProperty(ref _vFX, value);
		}

		public FireFXEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
