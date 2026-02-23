using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimChangeTexturePartEvent : inkanimEvent
	{
		private CName _imageTexturePartName;

		[Ordinal(1)] 
		[RED("imageTexturePartName")] 
		public CName ImageTexturePartName
		{
			get => GetProperty(ref _imageTexturePartName);
			set => SetProperty(ref _imageTexturePartName, value);
		}

		public inkanimChangeTexturePartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
