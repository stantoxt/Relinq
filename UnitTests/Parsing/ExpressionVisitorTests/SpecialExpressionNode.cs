// Copyright (c) rubicon IT GmbH, www.rubicon.eu
//
// See the NOTICE file distributed with this work for additional information
// regarding copyright ownership.  rubicon licenses this file to you under 
// the Apache License, Version 2.0 (the "License"); you may not use this 
// file except in compliance with the License.  You may obtain a copy of the 
// License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT 
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  See the 
// License for the specific language governing permissions and limitations
// under the License.
// 

using System;
using System.Linq.Expressions;

namespace Remotion.Linq.UnitTests.Parsing.ExpressionVisitorTests
{
  public class SpecialExpressionNode : Expression
  {
#if !NET_3_5
    private readonly ExpressionType _nodeType;
    private readonly Type _type;

    public SpecialExpressionNode (ExpressionType nodeType, Type type)
    {
      _nodeType = nodeType;
      _type = type;
    }

    public override ExpressionType NodeType
    {
      get { return _nodeType; }
    }

    public override Type Type
    {
      get { return _type; }
    }
#else
    public SpecialExpressionNode (ExpressionType nodeType, Type type)
        : base (nodeType, type)
    {
    }
#endif
  }
}