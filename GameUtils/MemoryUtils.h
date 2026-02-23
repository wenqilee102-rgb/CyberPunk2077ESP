#pragma once

#include <RED4ext/Scripting/IScriptable.hpp>
#include <RED4ext/Memory/Allocators.hpp>

namespace GameUtils
{
    namespace MemoryUtils
    {
        struct ScopedJobMemory
        {
            RED4ext::Memory::IAllocator* allocator;
            void* memory;

            ScopedJobMemory(RED4ext::Memory::IAllocator* alloc, uint64_t size)
                : allocator(alloc), memory(nullptr)
            {
                if (allocator)
                {
                    auto result = allocator->Alloc(size);
                    memory = result.memory;
                }
            }

            ~ScopedJobMemory()
            {
                if (allocator && memory)
                {
                    allocator->Free(memory);
                }
            }

            void* Get() const { return memory; }

            ScopedJobMemory(const ScopedJobMemory&) = delete;
            ScopedJobMemory& operator=(const ScopedJobMemory&) = delete;
        };

        inline RED4ext::Memory::IAllocator* GetScriptAllocator()
        {
            auto rtti = RED4ext::CRTTISystem::Get();
            if (!rtti)
                return nullptr;

            auto scriptAllocatorClass = rtti->GetClass("Memory::ScriptAllocator");
            if (!scriptAllocatorClass)
                return nullptr;

            auto allocatorProp = scriptAllocatorClass->GetProperty(RED4ext::CName("instance"));
            if (!allocatorProp)
                return nullptr;

            static RED4ext::Memory::IAllocator* cachedAllocator = nullptr;
            if (!cachedAllocator)
            {
                auto allocatorPtr = reinterpret_cast<RED4ext::Memory::IAllocator**>(
                    reinterpret_cast<uintptr_t>(scriptAllocatorClass) + allocatorProp->valueOffset
                );
                if (allocatorPtr && *allocatorPtr)
                {
                    cachedAllocator = *allocatorPtr;
                }
            }
            return cachedAllocator;
        }
    }
}
