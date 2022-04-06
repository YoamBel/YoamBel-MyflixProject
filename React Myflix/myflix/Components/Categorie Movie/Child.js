import React, { useState,useEffect } from 'react';
import { View,Text ,StyleSheet} from 'react-native';

const Child = () =>{

    return (
        <View style={styles.container}>
          <Text>Child</Text>
        </View>
    );
  }
  
  const styles = StyleSheet.create({
    container: {},
  });
  
  export default  Child;