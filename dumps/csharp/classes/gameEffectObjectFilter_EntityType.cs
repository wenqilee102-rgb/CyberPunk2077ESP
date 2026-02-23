using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_EntityType : gameEffectObjectGroupFilter
	{
		private CEnum<gameEffectObjectFilter_EntityTypeEntityTypeFilter> _typeFilter;

		[Ordinal(0)] 
		[RED("typeFilter")] 
		public CEnum<gameEffectObjectFilter_EntityTypeEntityTypeFilter> TypeFilter
		{
			get => GetProperty(ref _typeFilter);
			set => SetProperty(ref _typeFilter, value);
		}

		public gameEffectObjectFilter_EntityType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
