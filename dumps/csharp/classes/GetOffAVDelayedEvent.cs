using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetOffAVDelayedEvent : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _go;
		private CBool _checkForHazards;

		[Ordinal(0)] 
		[RED("go")] 
		public wCHandle<gameObject> Go
		{
			get => GetProperty(ref _go);
			set => SetProperty(ref _go, value);
		}

		[Ordinal(1)] 
		[RED("checkForHazards")] 
		public CBool CheckForHazards
		{
			get => GetProperty(ref _checkForHazards);
			set => SetProperty(ref _checkForHazards, value);
		}

		public GetOffAVDelayedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
