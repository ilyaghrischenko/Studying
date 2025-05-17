import {View, Text, Button, Image} from "react-native";

import tw from 'twrnc';

const Annotation = () => {
    return (
        <View style={tw`p-4 bg-white rounded-lg shadow-md`}>
            {/*не розумію чого фото не відображається*/}
            <Image
                source={require('./assets/favicon.png')}
                style={tw`w-full h-48 rounded-md mb-4`}
                resizeMode="cover"
            />
            <Text style={tw`text-xl font-bold mb-2`}>Заголовок</Text>
            <Text style={tw`text-base text-gray-700 mb-4`}>
                Невеликий текст
            </Text>
            <View style={tw`self-start`}>
                <Button title="button" onPress={() => {}} />
            </View>
        </View>
    );
};

export {Annotation};