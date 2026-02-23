using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotomodeLightInitializedEvent : redEvent
	{
		private wCHandle<entEntity> _light;

		[Ordinal(0)] 
		[RED("light")] 
		public wCHandle<entEntity> Light
		{
			get => GetProperty(ref _light);
			set => SetProperty(ref _light, value);
		}

		public gameuiPhotomodeLightInitializedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
