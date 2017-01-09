/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 * @flow
 */

import React, { Component } from 'react';
import {
  AppRegistry,
  TextInput,
} from 'react-native';

export default class SampleReactNativeApp extends Component {
  constructor(props) {
    super(props);
    this.state = { text: 'Enter Text' };
  }

  render() {
    return (
      <TextInput style={{
        flex: 1,
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
      }}>
        <TextInput
          style={{height: 40, borderColor: 'steelblue', borderWidth: 1}}
          onChangeText={(text) => this.setState({text})}
          value={this.state.text}
          accessibilityLabel="TextInputAccessibilityId"
        />
      </TextInput>
    );
  }
}

AppRegistry.registerComponent('SampleReactNativeApp', () => SampleReactNativeApp);
