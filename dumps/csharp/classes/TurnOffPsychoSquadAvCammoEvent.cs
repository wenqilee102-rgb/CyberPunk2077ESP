using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TurnOffPsychoSquadAvCammoEvent : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _go;

		[Ordinal(0)] 
		[RED("go")] 
		public wCHandle<gameObject> Go
		{
			get => GetProperty(ref _go);
			set => SetProperty(ref _go, value);
		}

		public TurnOffPsychoSquadAvCammoEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
