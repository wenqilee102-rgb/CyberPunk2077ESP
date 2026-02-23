using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaticPlatform : InteractiveDevice
	{
		private CArray<CName> _componentsToToggleNames;
		private CName _meshName;
		private CName _sfxOnEnable;
		private CArray<CHandle<entIComponent>> _componentsToToggle;

		[Ordinal(98)] 
		[RED("componentsToToggleNames")] 
		public CArray<CName> ComponentsToToggleNames
		{
			get => GetProperty(ref _componentsToToggleNames);
			set => SetProperty(ref _componentsToToggleNames, value);
		}

		[Ordinal(99)] 
		[RED("meshName")] 
		public CName MeshName
		{
			get => GetProperty(ref _meshName);
			set => SetProperty(ref _meshName, value);
		}

		[Ordinal(100)] 
		[RED("sfxOnEnable")] 
		public CName SfxOnEnable
		{
			get => GetProperty(ref _sfxOnEnable);
			set => SetProperty(ref _sfxOnEnable, value);
		}

		[Ordinal(101)] 
		[RED("componentsToToggle")] 
		public CArray<CHandle<entIComponent>> ComponentsToToggle
		{
			get => GetProperty(ref _componentsToToggle);
			set => SetProperty(ref _componentsToToggle, value);
		}

		public StaticPlatform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
