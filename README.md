# BS1192 
[![Build Status](https://travis-ci.org/radumg/BS1192.svg?branch=master)](https://travis-ci.org/radumg/BS1192) [![GitHub version](https://badge.fury.io/gh/radumg%2FBS1192.svg)](https://badge.fury.io/gh/radumg%2FBS1192) [![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/radumg/BS1192/blob/master/docs/CONTRIBUTING.md)
---

**BS1192** is a package providing tools to better handle BS1192 workflows.
It can be used 
- as a package in other apps
- use as a [Dynamo](http://www.dynamobim.org) package, without needing Revit

## Status

This is an experimental package and should not be relied upon until a stable release version is reached (1.0).

## Built with

The `BS1192` project relies on a few community-published NuGet packages as listed below :
* [Newtonsoft](https://www.nuget.org/packages/newtonsoft.json/) - handles serializing and deserializing to JSON
* [DynamoServices](https://www.nuget.org/packages/DynamoVisualProgramming.DynamoServices/2.0.0-beta4066) - an official Dynamo package providing support for better mapping of C# code to Dynamo nodes

## Contributing

Please read [CONTRIBUTING.md](https://github.com/radumg/BS1192/blob/master/docs/CONTRIBUTING.md) for details on how to contribute to this package. Please also read the [CODE OF CONDUCT.md](https://github.com/radumg/BS1192/blob/master/docs/CODE_OF_CONDUCT.md).

## Versioning & Releases

BS1192 useS the [SemVer](http://semver.org/) semantic versioning standard.
For the versions available, see the versions listed in the Dynamo package manager or [releases on this repository](https://github.com/radumg/DynAsana/releases).
The versioning for this project is `X.Y.Z` where
- `X` is a major release, which may not be fully compatible with prior major releases
- `Y` is a minor release, which adds both new features and bug fixes
- `Z` is a patch release, which adds just bug fixes

## Authors

* **Radu Gidei** : [Github profile](https://github.com/radumg), [Twitter profile](https://twitter.com/radugidei)

## License

This project is licensed under the GNU AGPL 3.0 License - see the [LICENSE FILE](https://github.com/radumg/BS1192/blob/master/docs/LICENSE) for details.

## Acknowledgments

* Other than me needing the functionality, hat tip to the #ukbimcrew for all the BS1192 debates on Twitter that inspired me to release this.

* The codebase is in no way striving for efficiency, but instead simplicity & legibility for the community's benefit - hence the many comments left throughout the code. Any suggestions or help improving it is warmly welcomed.