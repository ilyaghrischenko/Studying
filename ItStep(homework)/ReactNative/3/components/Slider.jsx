import {FlatList, StyleSheet} from 'react-native';
import {Slide} from "./Slide";

const slidesData = [
    {
        id: 1,
        photo: '../assets/daily_dash/Frame1.svg',
        title: 'Track your ride',
        description: 'Know your driver in advanced and be\n' +
            'able to view current location in real time \n' +
            'on the map'
    },
    {
        id: 2,
        photo: '../assets/daily_dash/Frame2.svg',
        title: 'Choose location',
        description: 'Pick the EXACT location\n' +
            'and create an order'
    },
    {
        id: 3,
        photo: '../assets/daily_dash/Frame3.svg',
        title: 'The fastest delivery',
        description: 'The maximum waiting time \n' +
            'of the car is 10 minutes'
    }
];

const Slider = () => {
    return (
        <FlatList
            // style={styles.list}
            contentContainerStyle={styles.list}
            data={slidesData}
            keyExtractor={item => item.id.toString()}
            horizontal
            pagingEnabled
            // showsHorizontalScrollIndicator={false}
            renderItem={({item}) => (
                <Slide {...item} />
            )}
        />
    );
};

const styles = StyleSheet.create({
    list: {
        display: 'flex',
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'center',
    }
});

export { Slider };