using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCameraManagerComponent : gameComponent
	{
		private raRef<entEntityTemplate> _cinematicCameraEntityTemplate;

		[Ordinal(4)] 
		[RED("cinematicCameraEntityTemplate")] 
		public raRef<entEntityTemplate> CinematicCameraEntityTemplate
		{
			get => GetProperty(ref _cinematicCameraEntityTemplate);
			set => SetProperty(ref _cinematicCameraEntityTemplate, value);
		}

		public vehicleCameraManagerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
