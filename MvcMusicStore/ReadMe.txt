
========== DEBUG MODE ==========
========== Pulling Images ==========
Pulling missing Docker images. To cancel this download, close the command prompt window. To disable image auto-pull, see Tools > Options > Container Tools.
docker pull microsoft/aspnet:4.7.2-windowsservercore-1803
docker pull completed

========== Preparing Containers ==========
Getting Docker containers ready...
docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi config
networks:
  default:
    external:
      name: nat
services:
  mvcmusicstore:
    build:
      args:
        source: obj/Docker/empty/
      context: D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with
        Visual Sudio 2017\mvcmusicstore\MvcMusicStore
      dockerfile: Dockerfile
    entrypoint: cmd /c "start /B C:\\ServiceMonitor.exe w3svc & C:\\remote_debugger\\x64\\msvsmon.exe
      /noauth /anyuser /silent /nostatus /noclrwarn /nosecuritywarn /nofirewallwarn
      /nowowwarn /timeout:2147483646"
    image: mvcmusicstore:dev
    ports:
    - target: 80
    volumes:
    - D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual
      Sudio 2017\mvcmusicstore\MvcMusicStore:C:\inetpub\wwwroot:rw
    - C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\Remote
      Debugger:C:\remote_debugger:ro
version: '3.4'

docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi build 
Building mvcmusicstore
Step 1/4 : FROM microsoft/aspnet:4.7.2-windowsservercore-1803
 ---> 5ed43890565d
Step 2/4 : ARG source
 ---> Running in 47b22dc58545
Removing intermediate container 47b22dc58545
 ---> 8759f1112686
Step 3/4 : WORKDIR /inetpub/wwwroot
 ---> Running in ad74d454588c
Removing intermediate container ad74d454588c
 ---> e6b18c82610c
Step 4/4 : COPY ${source:-obj/Docker/publish} .
 ---> d86116a575ed
Successfully built d86116a575ed
Successfully tagged mvcmusicstore:dev

docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi up -d --no-build --force-recreate --remove-orphans
Creating dockercompose8949727369142943128_mvcmusicstore_1 ... 
Creating dockercompose8949727369142943128_mvcmusicstore_1 ... done
Done!  Docker containers are ready.
==========================================

========== RELEASE MODE ==========
1>------ Rebuild All started: Project: MvcMusicStore, Configuration: Release Any CPU ------
1>  MvcMusicStore -> D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\MvcMusicStore\bin\MvcMusicStore.dll
2>------ Rebuild All started: Project: docker-compose, Configuration: Release Any CPU ------

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -p dockercompose8949727369142943128 --no-ansi config
2>networks:
2>  default:
2>    external:
2>      name: nat
2>services:
2>  mvcmusicstore:
2>    build:
2>      context: D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with
2>        Visual Sudio 2017\mvcmusicstore\MvcMusicStore
2>      dockerfile: Dockerfile
2>    image: mvcmusicstore
2>    ports:
2>    - target: 80
2>version: '3.4'

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.release.partial.g.yml" -p dockercompose8949727369142943128 --no-ansi kill
2>Killing dockercompose8949727369142943128_mvcmusicstore_1 ...
2>Killing dockercompose8949727369142943128_mvcmusicstore_1 ... done

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.release.partial.g.yml" -p dockercompose8949727369142943128 --no-ansi down --rmi local --remove-orphans
2>Removing dockercompose8949727369142943128_mvcmusicstore_1 ...
2>Removing dockercompose8949727369142943128_mvcmusicstore_1 ... done
2>Network nat is external, skipping

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.partial.g.yml" -p dockercompose8949727369142943128 --no-ansi kill

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.partial.g.yml" -p dockercompose8949727369142943128 --no-ansi down --rmi local --remove-orphans
2>Network nat is external, skipping
2>docker images --filter dangling=true --format {{.ID}}
2>MvcMusicStore -> D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\MvcMusicStore\bin\MvcMusicStore.dll
2>Transformed Web.config using D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\MvcMusicStore\Web.Release.config into obj\Release\TransformWebConfig\transformed\Web.config.
2>Copying all files to temporary location below for package/publish:
2>obj\Release\Package\PackageTmp.
2>Auto ConnectionString Transformed obj\Release\Package\PackageTmp\Views\Web.config into obj\Release\CSAutoParameterize\transformed\Views\Web.config.
2>Auto ConnectionString Transformed obj\Release\Package\PackageTmp\Web.config into obj\Release\CSAutoParameterize\transformed\Web.config.

2>docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -p dockercompose8949727369142943128 --no-ansi build --no-cache
2>Building mvcmusicstore
2>Step 1/4 : FROM microsoft/aspnet:4.7.2-windowsservercore-1803
2> ---> 5ed43890565d
2>Step 2/4 : ARG source
2> ---> Running in e57e15a688c9
2>Removing intermediate container e57e15a688c9
2> ---> 846c521a2ed3
2>Step 3/4 : WORKDIR /inetpub/wwwroot
2> ---> Running in bcf75e07a3e9
2>Removing intermediate container bcf75e07a3e9
2> ---> f5fd8c563d8c
2>Step 4/4 : COPY ${source:-obj/Docker/publish} .
2> ---> e766d3da492c
2>Successfully built e766d3da492c
2>Successfully tagged mvcmusicstore:latest
========== Rebuild All: 2 succeeded, 0 failed, 0 skipped =========
