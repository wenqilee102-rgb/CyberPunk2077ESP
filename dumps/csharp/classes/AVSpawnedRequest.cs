using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AVSpawnedRequest : gameScriptableSystemRequest
	{
		private CArray<wCHandle<gameObject>> _spawnedObjects;

		[Ordinal(0)] 
		[RED("spawnedObjects")] 
		public CArray<wCHandle<gameObject>> SpawnedObjects
		{
			get => GetProperty(ref _spawnedObjects);
			set => SetProperty(ref _spawnedObjects, value);
		}

		public AVSpawnedRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
