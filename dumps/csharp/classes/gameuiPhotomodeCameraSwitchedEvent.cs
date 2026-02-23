using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotomodeCameraSwitchedEvent : redEvent
	{
		private wCHandle<entEntity> _camera;

		[Ordinal(0)] 
		[RED("camera")] 
		public wCHandle<entEntity> Camera
		{
			get => GetProperty(ref _camera);
			set => SetProperty(ref _camera, value);
		}

		public gameuiPhotomodeCameraSwitchedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
