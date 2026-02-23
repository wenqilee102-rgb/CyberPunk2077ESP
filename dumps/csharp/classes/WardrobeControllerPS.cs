using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<CHandle<gameClothingSet>> _clothingSets;
		private CBool _hasInteraction;

		[Ordinal(107)] 
		[RED("clothingSets")] 
		public CArray<CHandle<gameClothingSet>> ClothingSets
		{
			get => GetProperty(ref _clothingSets);
			set => SetProperty(ref _clothingSets, value);
		}

		[Ordinal(108)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetProperty(ref _hasInteraction);
			set => SetProperty(ref _hasInteraction, value);
		}

		public WardrobeControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
