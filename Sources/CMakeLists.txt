include(CMakeSources.cmake)
#project(Editor)

set(EDITOR_INCLUDES "${PROJECT_SOURCE_DIR}/Sources/")

#if(ACID_CONFIG_RELEASE AND WIN32)
#add_executable(Editor WIN32 ${EDITOR_SOURCES})
#else()
add_executable(Editor ${EDITOR_SOURCES})
#endif()

set_target_properties(Editor PROPERTIES
		POSITION_INDEPENDENT_CODE ON
		FOLDER "Editor")

add_dependencies(Editor Acid)

target_include_directories(Editor PUBLIC ${ACID_INCLUDES} ${EDITOR_INCLUDES})
target_link_libraries(Editor PRIVATE Acid)

# Install
if (EDITOR_INSTALL)
	install(
			DIRECTORY .
			DESTINATION include
			FILES_MATCHING PATTERN "*.h"
			PATTERN "Private" EXCLUDE
	)

	install(
			TARGETS Editor
			RUNTIME DESTINATION bin
			LIBRARY DESTINATION lib
			ARCHIVE DESTINATION lib
	)
endif()
